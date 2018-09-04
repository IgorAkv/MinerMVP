using System;
using System.Collections.Generic;
using System.Linq;

namespace Akimov.MinerMVP.Models {
    class MinerModel : IMinerModel {
        public event EventHandler<GameOverArgs> GameOver = delegate { };
        public event EventHandler<ModelUpdatedArgs> ModelUpdated = delegate { };
        Dictionary<Position, Cell> mineField;        
        HashSet<Position> bombs;        
        Random random;
        HashSet<Cell> quereForOpen;
        bool isStarted;

        public MinerModel(MineFieldSettings setting) {
            Setting = setting;
            Initialize();
        }
        
        MineFieldSettings Setting { get; }

        public void Start() {
            CreateMineField();
            isStarted = true;
        }
                
        public void CellAction(int row, int col, CellActionType action) {
            Cell cell;
            if (isStarted && mineField.TryGetValue(new Position(row, col), out cell)) {
                if (action == CellActionType.Open && cell.CellType == CellType.Closed) {
                    OpenCell(cell);
                }
                if (action == CellActionType.NextMarker) {
                    NextMarker(cell);
                }
                OnModelUpdated();
            }
        }

        public void OnModelUpdated() {
            List<Cell> cells = new List<Cell>(mineField.Values);
            ModelUpdated(this, new ModelUpdatedArgs(cells));
            CheckGameOver();
        }

        public void OnGameOver(GameOverType type) {
            GameOver(this, new GameOverArgs(type));
        }

        void Initialize() {
            mineField = new Dictionary<Position, Cell>();
            bombs = new HashSet<Position>();            
            random = new Random();
            isStarted = false;
        }

        void CreateMineField() {
            for (int row = 0; row < Setting.Rows; row++) {
                for (int col = 0; col < Setting.Columns; col++) {
                    Position position = new Position(row, col);
                    mineField.Add(position, new Cell(position, CellType.Closed));
                    if (random.Next(MineFieldConstant.PERCENT_MAX) < Setting.BombRatio) {
                        bombs.Add(position);
                    }
                }
            }
            OnModelUpdated();
        }         

        void CheckGameOver() {            
            if (!Setting.CommanderMode && mineField.Values.Any(c => c.CellType == CellType.Bomb)) {
                OnGameOver(GameOverType.Defeat);
            }
            if (mineField.Values.All(c => c.CellType != CellType.Closed) &&
                bombs.Count() == mineField.Values.Where(c => c.CellType == CellType.Flagged || 
                c.CellType == CellType.Bomb).Count()) {
                if (Setting.CommanderMode) {
                    OnGameOver(GameOverType.VictoryCommander);
                }
                else {
                    OnGameOver(GameOverType.Victory);
                }
            }
        }
        
        void NextMarker(Cell cell) {
            CellType nextMarker;
            switch (cell.CellType) {
            case CellType.Closed:
                nextMarker = CellType.Flagged;
                break;
            case CellType.Flagged:
                nextMarker = CellType.Closed;
                break;
            default:
                return;
            }
            cell.CellType = nextMarker;
        }
     
        void OpenCell(Cell cellForOpen) {
            quereForOpen = new HashSet<Cell>() { cellForOpen };            
            while (quereForOpen.Count > 0) {
                Cell cell = quereForOpen.Last();
                quereForOpen.Remove(cell);
                if (bombs.Contains(cellForOpen.Position)) {
                    cell.CellType = CellType.Bomb;
                }
                else {
                    HashSet<Cell> neighbors = GetCellsNeighbors(cell);
                    int bombCount = neighbors.Where(c => bombs.Contains(c.Position)).Count();
                    cell.CellType = (CellType)bombCount;
                    if (bombCount == 0) {
                        quereForOpen.UnionWith(neighbors
                            .Where(c => c.CellType == CellType.Closed));
                    }
                }
            }
        }

        HashSet<Cell> GetCellsNeighbors(Cell cell) {
            HashSet<Position> positions = new HashSet<Position>();
            int row = cell.Position.Row;
            int column = cell.Position.Column;
            for (int r = row - 1; r <= row + 1; r++) {
                positions.Add(new Position(r, column - 1));
                if (r != row) {
                    positions.Add(new Position(r, column));
                }
                positions.Add(new Position(r, column + 1));
            }
            HashSet<Cell> cells = new HashSet<Cell>();
            foreach (Position pos in positions) {
                Cell candidateCell;
                if (mineField.TryGetValue(pos, out candidateCell)) {
                    cells.Add(candidateCell);
                }
            }
            return cells;
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Akimov.MinerMVP.Models {
    class MinerModel : IMinerModel {
        public event EventHandler<GameOverArgs> GameOver = delegate { };
        public event EventHandler<ModelUpdatedArgs> ModelUpdated = delegate { };
        Dictionary<Coordinates, Cell> mineField;        
        HashSet<Coordinates> bombs;        
        HashSet<Cell> queueCellForOpen;
        MineFieldSettings settings;
        Random random;        

        public MinerModel() {            
            random = new Random();
        }
        
        public void Start(MineFieldSettings setting) {
            this.settings = setting;
            Initialize();
            CreateMineField();            
        }
                
        public void CellAction(int row, int col, CellActionType action) {
            Cell cell;
            if (mineField.TryGetValue(new Coordinates(row, col), out cell)) {
                if (action == CellActionType.Open && cell.CellType == CellType.Closed) {
                    OpenCell(cell);
                }
                else {
                    if (action == CellActionType.NextMarker) {
                        NextMarker(cell);
                    }
                    else {
                        return;
                    }
                }
                OnModelUpdated();
                CheckGameOver();
            }
        }

        void OnModelUpdated() {
            List<Cell> cells = new List<Cell>(mineField.Values);
            ModelUpdated(this, new ModelUpdatedArgs(cells));
        }

        void OnGameOver(GameOverType type) {
            GameOver(this, new GameOverArgs(type));
        }

        void Initialize() {
            mineField = new Dictionary<Coordinates, Cell>();
            bombs = new HashSet<Coordinates>();
        }

        void CreateMineField() {
            for (int row = 0; row < settings.Rows; row++) {
                for (int col = 0; col < settings.Columns; col++) {
                    Coordinates position = new Coordinates(row, col);
                    mineField.Add(position, new Cell(position, CellType.Closed));                    
                }
            }
            GenerateBombs();
            OnModelUpdated();
        }

        void GenerateBombs() {            
            int bombCount = (int) Math.Round(settings.Rows * settings.Columns * MineFieldConstants.PERCENT_FACTOR * settings.BombRatio);
            List<Coordinates> coordinates = new List<Coordinates>(mineField.Keys);
            while (bombCount > 0) {
                int index = random.Next(coordinates.Count - 1);
                bombs.Add(coordinates.ElementAt(index));
                coordinates.RemoveAt(index);
                bombCount--;
            }
        }

        void CheckGameOver() {            
            if (!settings.CommanderMode && mineField.Values.Any(c => c.CellType == CellType.Bomb)) {
                OnGameOver(GameOverType.Defeat);
            }
            if (mineField.Values.All(c => c.CellType != CellType.Closed) &&
                bombs.Count() == mineField.Values.Where(c => c.CellType == CellType.Flagged || 
                c.CellType == CellType.Bomb).Count()) {
                if (settings.CommanderMode) {
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
     
        void OpenCell(Cell cell) {
            if (bombs.Contains(cell.Coordinates)) {
                cell.CellType = CellType.Bomb;
                return;
            }
            queueCellForOpen = new HashSet<Cell>() { cell };
            while (queueCellForOpen.Count > 0) {
                Cell currentCell = queueCellForOpen.Last();
                queueCellForOpen.Remove(currentCell);
                HashSet<Cell> neighbors = GetCellsNeighbors(currentCell);                
                currentCell.CellType = (CellType)GetBombCount(neighbors); 
                if (currentCell.CellType == CellType.None_Bomb_Around) {
                    queueCellForOpen.UnionWith(GetClosedCell(neighbors));
                }
            }
        }

        int GetBombCount(HashSet<Cell> cells) {
            return cells.Where(c => bombs.Contains(c.Coordinates)).Count();
        }

        IEnumerable<Cell> GetClosedCell(HashSet<Cell> cells) {
            return cells.Where(c => c.CellType == CellType.Closed);
        }

        HashSet<Cell> GetCellsNeighbors(Cell cell) {            
            HashSet<Cell> cells = new HashSet<Cell>();
            foreach (Coordinates pos in GenerateNeighborsLocations(cell.Coordinates)) {
                Cell candidateCell;
                if (mineField.TryGetValue(pos, out candidateCell)) {
                    cells.Add(candidateCell);
                }
            }
            return cells;
        }

        HashSet<Coordinates> GenerateNeighborsLocations(Coordinates coordinates) {
            HashSet<Coordinates> neighborsLocations = new HashSet<Coordinates>();
            int row = coordinates.Row;
            int column = coordinates.Column;
            for (int r = row - 1; r <= row + 1; r++) {
                neighborsLocations.Add(new Coordinates(r, column - 1));
                if (r != row) {
                    neighborsLocations.Add(new Coordinates(r, column));
                }
                neighborsLocations.Add(new Coordinates(r, column + 1));
            }
            return neighborsLocations;
        }
    }
}

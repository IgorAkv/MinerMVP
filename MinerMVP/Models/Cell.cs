
namespace Akimov.MinerMVP.Models {
    public class Cell {        
        public Cell(int row, int col, CellType cellType) : 
            this(new Position(row, col), cellType) {            
        }
        public Cell(Position position, CellType cellType) {
            Position = position;
            CellType = cellType;
        }
        public Position Position { get; }
        public CellType CellType { get; set; }        
        public Cell Copy() => new Cell(Position, CellType);
        public override bool Equals(object obj) {
            Cell cell = obj as Cell;
            if (cell != null) {
                return Equals(cell);
            }
            return false;
        }
        public bool Equals(Cell cell) {
            return Position.Row == cell.Position.Row && 
                Position.Column == cell.Position.Column;
        }
        public override int GetHashCode() {
            return (Position.Row + 1) << 8 + Position.Column;
        }
    }
}

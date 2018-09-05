
namespace Akimov.MinerMVP.Models {
    public class Cell {        
        public Cell(int row, int col, CellType cellType) : 
            this(new Сoordinates(row, col), cellType) {            
        }
        public Cell(Сoordinates position, CellType cellType) {
            Position = position;
            CellType = cellType;
        }
        public Сoordinates Position { get; }
        public CellType CellType { get; set; }        
  
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

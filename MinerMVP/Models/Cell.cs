
namespace Akimov.MinerMVP.Models {
    public class Cell {        
        public Cell(int row, int col, CellType cellType) : 
            this(new Coordinates(row, col), cellType) {            
        }
        public Cell(Coordinates coordinates, CellType cellType) {
            Coordinates = coordinates;
            CellType = cellType;
        }
        public Coordinates Coordinates { get; }
        public CellType CellType { get; set; }        
  
        public override bool Equals(object obj) {
            Cell cell = obj as Cell;
            if (cell != null) {
                return Equals(cell);
            }
            return false;
        }
        public bool Equals(Cell cell) {
            return Coordinates.Row == cell.Coordinates.Row && 
                Coordinates.Column == cell.Coordinates.Column;
        }
        public override int GetHashCode() {
            return (Coordinates.Row + 1) << 8 + Coordinates.Column;
        }
    }
}

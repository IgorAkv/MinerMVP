using System;

namespace Akimov.MinerMVP.Models {
    public struct Position : IEquatable<Position> {
        public Position(int row, int column) {
            Row = row;
            Column = column;
        }
        public int Row { get; }
        public int Column { get; }

        public override bool Equals(object obj) {
            if (obj is Position) {
                return this.Equals((Position)obj);
            }
            return false;
        }
        public bool Equals(Position obj) {
            return Row == obj.Row && Column == obj.Column;
        }
        public override int GetHashCode() {
            return (Row + 1) << 8 + Column;
        }
        public static bool operator ==(Position lhs, Position rhs) {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Position lhs, Position rhs) {
            return !(lhs.Equals(rhs));
        }
    }
}

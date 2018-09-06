using System;

namespace Akimov.MinerMVP.Models {
    public struct Coordinates : IEquatable<Coordinates> {
        public Coordinates(int row, int column) {
            Row = row;
            Column = column;
        }
        public int Row { get; }
        public int Column { get; }

        public override bool Equals(object obj) {
            if (obj is Coordinates) {
                return this.Equals((Coordinates)obj);
            }
            return false;
        }
        public bool Equals(Coordinates obj) {
            return Row == obj.Row && Column == obj.Column;
        }
        public override int GetHashCode() {
            return (Row + 1) << 8 + Column;
        }
        public static bool operator ==(Coordinates lhs, Coordinates rhs) {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Coordinates lhs, Coordinates rhs) {
            return !(lhs.Equals(rhs));
        }
    }
}

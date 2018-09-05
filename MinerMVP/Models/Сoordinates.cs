using System;

namespace Akimov.MinerMVP.Models {
    public struct Сoordinates : IEquatable<Сoordinates> {
        public Сoordinates(int row, int column) {
            Row = row;
            Column = column;
        }
        public int Row { get; }
        public int Column { get; }

        public override bool Equals(object obj) {
            if (obj is Сoordinates) {
                return this.Equals((Сoordinates)obj);
            }
            return false;
        }
        public bool Equals(Сoordinates obj) {
            return Row == obj.Row && Column == obj.Column;
        }
        public override int GetHashCode() {
            return (Row + 1) << 8 + Column;
        }
        public static bool operator ==(Сoordinates lhs, Сoordinates rhs) {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Сoordinates lhs, Сoordinates rhs) {
            return !(lhs.Equals(rhs));
        }
    }
}

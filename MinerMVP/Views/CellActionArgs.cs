using Akimov.MinerMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akimov.MinerMVP.Views {
    public class CellActionArgs : EventArgs {
        public CellActionArgs(int row, int col, CellActionType cellActionType) {
            Row = row;
            Col = col;
            CellActionType = cellActionType;
        }
        public int Row { get; }
        public int Col { get; }
        public CellActionType CellActionType { get; }
    }
}

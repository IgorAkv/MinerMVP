using Akimov.MinerMVP.Models;
using System;
using System.Collections.Generic;

namespace Akimov.MinerMVP.Views {
    public interface IMinerView {
        event EventHandler<CellActionArgs> CellAction;
        void MineFieldUpdate(List<Cell> updatedCell);
        void GameOver();
    }
}

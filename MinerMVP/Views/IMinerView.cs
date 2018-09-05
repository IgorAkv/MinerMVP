using Akimov.MinerMVP.Models;
using System;
using System.Collections.Generic;

namespace Akimov.MinerMVP.Views {
    public interface IMinerView {
        event EventHandler NewGame;
        event EventHandler Settings;
        event EventHandler Exit;
        event EventHandler<CellActionArgs> CellAction;
        void StartNewGame(MineFieldSettings setting);
        void MineFieldUpdate(List<Cell> updatedCell);
        void GameOver();
    }
}

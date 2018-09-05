using Akimov.MinerMVP.Models;
using System;
using System.Collections.Generic;

namespace Akimov.MinerMVP.Views {
    public interface IMinerView {
        event EventHandler NewGameStart;
        event EventHandler SettingsOpen;
        event EventHandler Exit;
        event EventHandler<CellActionArgs> CellAction;
        void NewGame(MineFieldSettings setting);
        void MineFieldUpdate(List<Cell> updatedCell);
        void GameOver();
    }
}

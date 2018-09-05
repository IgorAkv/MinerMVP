using System;

namespace Akimov.MinerMVP.Models {

    public interface IMinerModel {
        void Start(MineFieldSettings setting);
        void CellAction(int row, int col, CellActionType cellActionType);        
        event EventHandler<ModelUpdatedArgs> ModelUpdated;
        event EventHandler<GameOverArgs> GameOver;        
    }
}

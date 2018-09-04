using System;

namespace Akimov.MinerMVP.Models {
    public class GameOverArgs : EventArgs {
        public GameOverArgs(GameOverType type) {
            GameOverType = type;
        }
        public GameOverType GameOverType { get; }
    }
    
}


namespace Akimov.MinerMVP.Models {
    public class MineFieldSettings {

        public MineFieldSettings() : this(
            MineFieldConstants.HEIGHT_EASY, 
            MineFieldConstants.WIDTH_EASY, 
            MineFieldConstants.BOMB_RATIO_EASY,
            false) {
        }

        public MineFieldSettings(int rows, int columns, int bombRatio, bool commanderMode) {
            Rows = rows;
            Columns = columns;
            BombRatio = bombRatio;
            CommanderMode = commanderMode;
        }

        public int Rows { get; }
        public int Columns { get; }
        public int BombRatio { get; }
        public bool CommanderMode { get; }
    }
}


namespace Akimov.MinerMVP.Models {
    public class MineFieldSettings {

        public MineFieldSettings() : this(
            MineFieldConstant.HEIGHT_EASY, 
            MineFieldConstant.WIDTH_EASY, 
            MineFieldConstant.BOMB_RATIO_EASY,
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

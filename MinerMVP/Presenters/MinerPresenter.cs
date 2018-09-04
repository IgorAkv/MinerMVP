using Akimov.MinerMVP.Models;
using Akimov.MinerMVP.Views;

namespace Akimov.MinerMVP.Presenters {
    class MinerPresenter : IMinerPresenter {
        IMinerView view;
        IGameOverView gameOverView;
        IMinerModel model;        

        public MinerPresenter(IMinerView minerView, IGameOverView gameOverView, IMinerModel model) {
            this.view = minerView;
            this.gameOverView = gameOverView;
            this.model = model;
        }

        public void Start() {            
            SubscribeEvent();
            model.Start();            
        }

        void View_CellAction(object sender, CellActionArgs e) {
            model.CellAction(e.Row, e.Col, e.CellActionType);
        }

        void SubscribeEvent() {            
            view.CellAction += View_CellAction;            
            model.ModelUpdated += Model_ModelUpdated;
            model.GameOver += Model_GameOver;
        }

        void UnSubscribeEvent() {
            view.CellAction -= View_CellAction;
            model.ModelUpdated -= Model_ModelUpdated;
            model.GameOver -= Model_GameOver;
        }

        void Model_GameOver(object sender, GameOverArgs e) {
            UnSubscribeEvent();
            gameOverView.ShowGameOver(e.GameOverType);
            view.GameOver();
        }

        void Model_ModelUpdated(object sender, ModelUpdatedArgs e) {
            view.MineFieldUpdate(e.UpdatedCells);
        }
    }
}

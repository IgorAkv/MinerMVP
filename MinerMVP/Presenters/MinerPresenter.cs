using Akimov.MinerMVP.Models;
using Akimov.MinerMVP.Views;

namespace Akimov.MinerMVP.Presenters {
    class MinerPresenter : IMinerPresenter {
        IMinerView view;
        IGameOverView gameOverView;
        IMinerModel model;
        MineFieldSettings settings;

        public MinerPresenter(IMinerView minerView) {
            this.view = minerView;
            this.gameOverView = new GameOverView();
            this.model = new MinerModel();
            settings = new MineFieldSettings();
            SubscribeMenuEvent();
        }

        public void Start() {
            UnSubscribeCurrentGameEvent();
            SubscribeCurrentGameEvent();
            view.StartNewGame(settings);
            model.Start(settings);            
        }

        void View_CellAction(object sender, CellActionArgs e) {
            model.CellAction(e.Row, e.Col, e.CellActionType);
        }

        void SubscribeMenuEvent() {
            view.NewGame += View_NewGameStart;
            view.Settings += View_SettingsOpen;
            view.Exit += View_Exit;
        }

        void View_Exit(object sender, System.EventArgs e) {
            UnSubscribeCurrentGameEvent();
            UnSubscribeMenuEvent();
        }

        void SubscribeCurrentGameEvent() {
            view.CellAction += View_CellAction;            
            model.ModelUpdated += Model_ModelUpdated;
            model.GameOver += Model_GameOver;
        }
        void UnSubscribeCurrentGameEvent() {
            view.CellAction -= View_CellAction;            
            model.ModelUpdated -= Model_ModelUpdated;
            model.GameOver -= Model_GameOver;
        }

        void View_NewGameStart(object sender, System.EventArgs e) {
            Start();
        }

        void View_SettingsOpen(object sender, System.EventArgs e) {
            SettingView settingView = new SettingView(settings, SetSettings);
            settingView.ShowDialog();
        }

        void UnSubscribeMenuEvent() {            
            view.Settings -= View_SettingsOpen;
            view.NewGame -= View_NewGameStart;            
        }

        void Model_GameOver(object sender, GameOverArgs e) {
            UnSubscribeCurrentGameEvent();
            gameOverView.ShowGameOver(e.GameOverType);
            view.GameOver();
        }

        void Model_ModelUpdated(object sender, ModelUpdatedArgs e) {
            view.MineFieldUpdate(e.UpdatedCells);
        }

        void SetSettings(MineFieldSettings settings) {
            this.settings = settings;
        }        
    }
}

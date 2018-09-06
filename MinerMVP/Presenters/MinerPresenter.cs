using System;
using Akimov.MinerMVP.Models;
using Akimov.MinerMVP.Views;

namespace Akimov.MinerMVP.Presenters {
    class MinerPresenter : IMinerPresenter {
        IMinerForm mineFieldForm;
        IGameOverForm gameOverForm;
        IMinerModel model;
        MineFieldSettings gameSettings;

        public MinerPresenter(IMinerForm minerForm) {
            mineFieldForm = minerForm;
            gameOverForm = new GameOverForm(); 
            model = new MinerModel();
            gameSettings = new MineFieldSettings();
            SubscribeMenuEvent();
        }

        public void Start() {            
            SubscribeCurrentGameEvent();
            mineFieldForm.StartNewGame(gameSettings);
            model.Start(gameSettings);            
        }

        void CellAction(object sender, CellActionArgs e) {
            model.CellAction(e.Row, e.Col, e.CellActionType);
        }

        void SubscribeMenuEvent() {
            mineFieldForm.NewGame += NewGame;
            mineFieldForm.Settings += Settings;
            mineFieldForm.Exit += Exit;
        }
                        
        void NewGame(object sender, System.EventArgs e) {
            Start();
        }

        void Settings(object sender, System.EventArgs e) {
            Action<MineFieldSettings> callback = SetSettings;
            SettingForm settingForm = new SettingForm(gameSettings, callback);
            settingForm.ShowDialog();
        }

        void Exit(object sender, System.EventArgs e) {            
            UnSubscribeAllEvent();
        }

        void GameOver(object sender, GameOverArgs e) {
            UnSubscribeCurrentGameEvent();
            mineFieldForm.GameOver();
            gameOverForm.ShowGameOver(e.GameOverType);                    
        }

        void ModelUpdated(object sender, ModelUpdatedArgs e) {
            mineFieldForm.MineFieldUpdate(e.UpdatedCells);
        }

        void SetSettings(MineFieldSettings settings) {
            this.gameSettings = settings;
        }

        void SubscribeCurrentGameEvent() {
            UnSubscribeCurrentGameEvent();
            mineFieldForm.CellAction += CellAction;         
            model.ModelUpdated += ModelUpdated;         
            model.GameOver += GameOver;
        }

        void UnSubscribeCurrentGameEvent() {
            mineFieldForm.CellAction -= CellAction;
            model.ModelUpdated -= ModelUpdated;
            model.GameOver -= GameOver;
        }

        void UnSubscribeAllEvent() {            
            mineFieldForm.NewGame -= NewGame;
            mineFieldForm.Settings -= Settings;
            mineFieldForm.Exit -= Exit;
            UnSubscribeCurrentGameEvent();
        }
    }
}

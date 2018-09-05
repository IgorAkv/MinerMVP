using Akimov.MinerMVP.Models;
using Akimov.MinerMVP.Presenters;
using Akimov.MinerMVP.Views;
using System;
using System.Windows.Forms;

namespace Akimov.MinerMVP {
    class Launcher {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MinerForm minerView = new MinerForm();           
            MinerPresenter presenter = new MinerPresenter(minerView);            
            presenter.Start();
            Application.Run(minerView);
        }
    }
}

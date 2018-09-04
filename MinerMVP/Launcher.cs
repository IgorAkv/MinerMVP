using System.Windows.Forms;

namespace Akimov.MinerMVP {
    class Launcher {
        //[STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LauncherForm());
        }
    }
}

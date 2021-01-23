using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Person SeterSignalPerson = new Person();
            SeterSignalPerson.SeterSignal("RenewDisplayname");
            var SeterSignalPersonJson = SeterSignalPerson.IntoJson(SeterSignalPerson);
            Client FirtstC = new Client();
            FirtstC.Connect();
            FirtstC.Send(SeterSignalPersonJson);
            System.Threading.Thread.Sleep(3000);
            Application.Run(new Form1());
        }
    }
}

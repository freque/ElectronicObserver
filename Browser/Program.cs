using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser {
	static class Program {
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main( string[] args ) {
			// FormBrowserHostから起動された時は引数に通信用URLが渡される
			if ( args.Length == 0 ) {
				MessageBox.Show("이 프로그램은 74식전자관측의의 서브 프로그램으로\r\n독립실행이 불가능합니다.\r\n본 프로그램에서 실행해주시기 바랍니다.", 
					"정보", MessageBoxButtons.OK, MessageBoxIcon.Information );
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new FormBrowser( args[0] ) );
		}
	}
}

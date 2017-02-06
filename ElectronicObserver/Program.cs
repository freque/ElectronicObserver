using ElectronicObserver.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicObserver {
	static class Program {
		/// <summary>
		/// 응용 프로그램 주 진입점
		/// </summary>
		[STAThread]
		static void Main() {

			var mutex = new System.Threading.Mutex( false, Application.ExecutablePath.Replace( '\\', '/' ) );

			if ( !mutex.WaitOne( 0, false ) ) {
				// 多重起動禁止
				MessageBox.Show( "접속기가 이미 실행중입니다.。\r\n동시 실행은 할 수 없습니다.", "74식전자관측의", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new FormMain() );

			mutex.ReleaseMutex();
		}
	}
}

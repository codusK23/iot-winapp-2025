using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // async 비동기로 동작하는 메서드라고 선언
        // async, await는 항상 같이 사용
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            // * : UI스레드가 관리
            LblCurrState.Text = "현재상태 : 진행";      // *
            BtnStart.Text = "진행중";                       // *
            BtnStart.Enabled = false;   // 못 쓰게 함   // *

            // 엄청난 시간이 걸리는 연산을 수행
            long MaxVal = 200;
            long total = 0;

            PrgProcess.Minimum = 0;       // *
            PrgProcess.Maximum = 100;   // *

            // await로 비동기 대기
            await Task.Run(() =>
            {
                // UI와 전혀 관계없는 작업
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;

                    int progress = (int)((i * 100) / MaxVal) + 1;
                    Console.WriteLine(progress.ToString());
                    this.Invoke(new Action(() =>
                    {
                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart += TxtLog.Text.Length;
                        TxtLog.ScrollToCaret();     // 스크롤을 제일 밑으로
                        PrgProcess.Value = progress;             // *
                    }));

                    Thread.Sleep(50);
                    // 스레드를 개발자가 사용한 게 아님
                    // 50ms동안 대기 (대량의 일을 처리하는 것 처럼 보이게)

                    //Application.DoEvents();       // 권장X, 사용하지 말 것
                }
            });

            LblCurrState.Text = "현재상태 : 중지";    // *
            BtnStart.Text = "시작";                       // *
            BtnStart.Enabled = true;

        }
    }
}

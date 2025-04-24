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

        // async �񵿱�� �����ϴ� �޼����� ����
        // async, await�� �׻� ���� ���
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            // * : UI�����尡 ����
            LblCurrState.Text = "������� : ����";      // *
            BtnStart.Text = "������";                       // *
            BtnStart.Enabled = false;   // �� ���� ��   // *

            // ��û�� �ð��� �ɸ��� ������ ����
            long MaxVal = 200;
            long total = 0;

            PrgProcess.Minimum = 0;       // *
            PrgProcess.Maximum = 100;   // *

            // await�� �񵿱� ���
            await Task.Run(() =>
            {
                // UI�� ���� ������� �۾�
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;

                    int progress = (int)((i * 100) / MaxVal) + 1;
                    Console.WriteLine(progress.ToString());
                    this.Invoke(new Action(() =>
                    {
                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart += TxtLog.Text.Length;
                        TxtLog.ScrollToCaret();     // ��ũ���� ���� ������
                        PrgProcess.Value = progress;             // *
                    }));

                    Thread.Sleep(50);
                    // �����带 �����ڰ� ����� �� �ƴ�
                    // 50ms���� ��� (�뷮�� ���� ó���ϴ� �� ó�� ���̰�)

                    //Application.DoEvents();       // ����X, ������� �� ��
                }
            });

            LblCurrState.Text = "������� : ����";    // *
            BtnStart.Text = "����";                       // *
            BtnStart.Enabled = true;

        }
    }
}

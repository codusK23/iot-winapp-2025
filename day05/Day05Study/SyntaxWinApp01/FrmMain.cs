namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // 대리자(delegate) 선언
        delegate void MyDelegate(string msg);

        // 이벤트 핸들러 대리자 선언
        delegate void MyEventHandler(object sender, EventArgs e);

        // 이벤트를 선언
        public event EventHandler SomthingHappened;

        // 대리자에서 호출할 메서드 - 대리자와 파라미터가 일치
        void SayHello(string msg)
        {
            MessageBox.Show($"안녕, {msg}", "메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void SayGoodbye(string msg)
        {
            MessageBox.Show($"내일봐~ {msg}", "메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public FrmMain()
        {
            InitializeComponent();
            Console.WriteLine("1. Form 생성자 실행");
            TxtLog.Text += ("1. Form 생성자 실행");
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            Console.WriteLine("2. Form_Load 이벤트 실행");
            TxtLog.Text += ("2. Form_Load 이벤트 실행");
        }
        private void FrmMain_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("3. Form_Activated 이벤트 실행");
            TxtLog.Text += ("3. Form_Activated 이벤트 실행");
        }
        private void FrmMain_Shown(object sender, EventArgs e) { 
            Console.WriteLine("4. Form_Shown 이벤트 실행");
            TxtLog.Text += ("4. Form_Shown 이벤트 실행");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("5. FormClosing 이벤트 실행");
            TxtLog.Text += ("5. FormClosing 이벤트 실행");
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) { 
            Console.WriteLine("6. FormClosed 이벤트 실행");
            TxtLog.Text += ("6. FormClosed 이벤트 실행");
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 1. 직접 호출
            SayHello("차연");
            SayGoodbye("차연");

            // 2. 대리자(delegate) 호출 (윈앱 개발 핵심!!)
            MyDelegate del = SayHello;  // 대리자에 호출할 메서드를 묶어줌
            del += SayGoodbye;   // 추가도 가능(대리자 체인 추가)
            del -= SayHello;    // (대리자 체인 삭제)
            del("예삐");

            // 3. 반환값 없는 대리자 - Action(보기만)
            Action<string> act = SayHello;
            act("금동");

            // 4. 반환값 있는 대리자 - Func(보기만)
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(7, 8);
            Console.WriteLine(result);

            // 이벤트 실행
            if (SomthingHappened != null)
            {
                SomthingHappened(this, new EventArgs());    // 이벤트 실행
            }
        }
    }
}

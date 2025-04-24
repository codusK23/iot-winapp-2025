namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // �븮��(delegate) ����
        delegate void MyDelegate(string msg);

        // �̺�Ʈ �ڵ鷯 �븮�� ����
        delegate void MyEventHandler(object sender, EventArgs e);

        // �̺�Ʈ�� ����
        public event EventHandler SomthingHappened;

        // �븮�ڿ��� ȣ���� �޼��� - �븮�ڿ� �Ķ���Ͱ� ��ġ
        void SayHello(string msg)
        {
            MessageBox.Show($"�ȳ�, {msg}", "�޽���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void SayGoodbye(string msg)
        {
            MessageBox.Show($"���Ϻ�~ {msg}", "�޽���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public FrmMain()
        {
            InitializeComponent();
            Console.WriteLine("1. Form ������ ����");
            TxtLog.Text += ("1. Form ������ ����");
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            Console.WriteLine("2. Form_Load �̺�Ʈ ����");
            TxtLog.Text += ("2. Form_Load �̺�Ʈ ����");
        }
        private void FrmMain_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("3. Form_Activated �̺�Ʈ ����");
            TxtLog.Text += ("3. Form_Activated �̺�Ʈ ����");
        }
        private void FrmMain_Shown(object sender, EventArgs e) { 
            Console.WriteLine("4. Form_Shown �̺�Ʈ ����");
            TxtLog.Text += ("4. Form_Shown �̺�Ʈ ����");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("5. FormClosing �̺�Ʈ ����");
            TxtLog.Text += ("5. FormClosing �̺�Ʈ ����");
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) { 
            Console.WriteLine("6. FormClosed �̺�Ʈ ����");
            TxtLog.Text += ("6. FormClosed �̺�Ʈ ����");
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 1. ���� ȣ��
            SayHello("����");
            SayGoodbye("����");

            // 2. �븮��(delegate) ȣ�� (���� ���� �ٽ�!!)
            MyDelegate del = SayHello;  // �븮�ڿ� ȣ���� �޼��带 ������
            del += SayGoodbye;   // �߰��� ����(�븮�� ü�� �߰�)
            del -= SayHello;    // (�븮�� ü�� ����)
            del("����");

            // 3. ��ȯ�� ���� �븮�� - Action(���⸸)
            Action<string> act = SayHello;
            act("�ݵ�");

            // 4. ��ȯ�� �ִ� �븮�� - Func(���⸸)
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(7, 8);
            Console.WriteLine(result);

            // �̺�Ʈ ����
            if (SomthingHappened != null)
            {
                SomthingHappened(this, new EventArgs());    // �̺�Ʈ ����
            }
        }
    }
}

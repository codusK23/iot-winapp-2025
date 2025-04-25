namespace WinApppractice
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // DS ��ü ��Ʈ ��������
            var Fonts = FontFamily.Families;
            foreach (var Font in Fonts)
            {
                CboFonts.Items.Add(Font.Name);
            }
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            ClbResult.Items.Add(TxtInput.Text + "\r\n");
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0) return;  // ��Ʈ�� �������� ���� ���

            FontStyle style = FontStyle.Regular;    // 0 ��ſ� Regular

            if (ChkBold.Checked) style |= FontStyle.Bold;   // FontStyle.Regualr | FontStyle.Bold => 0000 | 0001 = 0001

            // CboFonts���� ���õ� ���ڷ�, ����ũ�� 12, ����ü ��Ÿ�� ����
            TxtInput.Font = new Font((string)CboFonts.SelectedItem, 9, style);
            ClbResult.Font = new Font((string)CboFonts.SelectedItem, 12, style);
        }
    }
}

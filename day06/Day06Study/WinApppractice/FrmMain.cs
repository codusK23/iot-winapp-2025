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
            // DS 전체 폰트 가져오기
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
            if (CboFonts.SelectedIndex < 0) return;  // 폰트를 선택하지 않을 경우

            FontStyle style = FontStyle.Regular;    // 0 대신에 Regular

            if (ChkBold.Checked) style |= FontStyle.Bold;   // FontStyle.Regualr | FontStyle.Bold => 0000 | 0001 = 0001

            // CboFonts에서 선택된 글자로, 글자크기 12, 글자체 스타일 적용
            TxtInput.Font = new Font((string)CboFonts.SelectedItem, 9, style);
            ClbResult.Font = new Font((string)CboFonts.SelectedItem, 12, style);
        }
    }
}

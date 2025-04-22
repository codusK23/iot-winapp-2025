namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 기본 생성자
            Person yeppi = new Person();
            yeppi.Name = TxtName.Text.Trim();
            yeppi.Age = int.Parse(TxtAge.Text.Trim());
            yeppi.Gender = char.Parse(TxtGender.Text.Trim());
            yeppi.Phone = TxtPhone.Text.Trim();

            // 매개변수 생성자
            Person gold = new Person("강금동", 8, 'M', "010-8888-3333");

            TxtResult.Text = yeppi.ToString();
            yeppi.GetUp();
            yeppi.GoToSchool();
        }
    }
}

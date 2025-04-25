namespace WinApppractice
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            timer1 = new System.Windows.Forms.Timer(components);
            fontDialog1 = new FontDialog();
            TxtInput = new TextBox();
            BtnInput = new Button();
            ClbResult = new CheckedListBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            CboFonts = new ComboBox();
            ChkBold = new CheckBox();
            Pbxlucky = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pbxlucky).BeginInit();
            SuspendLayout();
            // 
            // TxtInput
            // 
            TxtInput.Location = new Point(17, 467);
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(252, 23);
            TxtInput.TabIndex = 0;
            // 
            // BtnInput
            // 
            BtnInput.Location = new Point(275, 462);
            BtnInput.Name = "BtnInput";
            BtnInput.Size = new Size(50, 30);
            BtnInput.TabIndex = 1;
            BtnInput.Text = "입력";
            BtnInput.UseVisualStyleBackColor = true;
            BtnInput.Click += BtnInput_Click;
            // 
            // ClbResult
            // 
            ClbResult.Font = new Font("맑은 고딕", 10F);
            ClbResult.FormattingEnabled = true;
            ClbResult.Location = new Point(17, 84);
            ClbResult.Name = "ClbResult";
            ClbResult.Size = new Size(301, 364);
            ClbResult.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(17, 48);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 3;
            label1.Text = "To Do List";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(124, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 23);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "글꼴 선택";
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(122, 20);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(138, 23);
            CboFonts.TabIndex = 6;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ChkBold.Location = new Point(268, 22);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(50, 19);
            ChkBold.TabIndex = 7;
            ChkBold.Text = "볼드";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // Pbxlucky
            // 
            Pbxlucky.Image = (Image)resources.GetObject("Pbxlucky.Image");
            Pbxlucky.Location = new Point(17, 12);
            Pbxlucky.Name = "Pbxlucky";
            Pbxlucky.Size = new Size(34, 33);
            Pbxlucky.SizeMode = PictureBoxSizeMode.StretchImage;
            Pbxlucky.TabIndex = 8;
            Pbxlucky.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(337, 502);
            Controls.Add(Pbxlucky);
            Controls.Add(ChkBold);
            Controls.Add(CboFonts);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(ClbResult);
            Controls.Add(BtnInput);
            Controls.Add(TxtInput);
            Name = "FrmMain";
            Text = "To Do List";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)Pbxlucky).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private FontDialog fontDialog1;
        private TextBox TxtInput;
        private Button BtnInput;
        private CheckedListBox ClbResult;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox CboFonts;
        private CheckBox ChkBold;
        private PictureBox Pbxlucky;
    }
}

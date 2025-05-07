namespace WindowsFormsApp1
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            BtnDelTap1 = new Button();
            BtnEditTap1 = new Button();
            BtnReset = new Button();
            imageList1 = new ImageList(components);
            BtnSaveTap1 = new Button();
            dataGridView1 = new DataGridView();
            ItemName = new DataGridViewTextBoxColumn();
            ItemCode = new DataGridViewTextBoxColumn();
            ItemNum = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            NudItemNum_Tab1 = new NumericUpDown();
            TxtItemCode_Tap1 = new TextBox();
            TxtItemName_Tap1 = new TextBox();
            BtnRegisterTap1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            BtnSaveTap2 = new Button();
            BtnEditTap2 = new Button();
            BtnDelTap2 = new Button();
            dataGridView2 = new DataGridView();
            itemInOut = new DataGridViewTextBoxColumn();
            ItemDate = new DataGridViewTextBoxColumn();
            ItemTime = new DataGridViewTextBoxColumn();
            ItemName2 = new DataGridViewTextBoxColumn();
            ItemCode2 = new DataGridViewTextBoxColumn();
            ItemNum2 = new DataGridViewTextBoxColumn();
            ItemManager = new DataGridViewTextBoxColumn();
            ManagerPhone = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            CboItemName = new ComboBox();
            BtnSearch = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            CboMinute = new ComboBox();
            label12 = new Label();
            CboHour = new ComboBox();
            label11 = new Label();
            DptDate = new DateTimePicker();
            RdoOutput = new RadioButton();
            RdoInput = new RadioButton();
            TxtPhone = new MaskedTextBox();
            NudItemNum_Tap2 = new NumericUpDown();
            TxtManager = new TextBox();
            TxtItemCode_Tap2 = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            BtnRegisterTap2 = new Button();
            label10 = new Label();
            label5 = new Label();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudItemNum_Tab1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudItemNum_Tap2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 13);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(360, 535);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(352, 507);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "재고관리";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnDelTap1);
            groupBox2.Controls.Add(BtnEditTap1);
            groupBox2.Controls.Add(BtnReset);
            groupBox2.Controls.Add(BtnSaveTap1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(6, 157);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(340, 342);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "재고목록";
            // 
            // BtnDelTap1
            // 
            BtnDelTap1.Location = new Point(264, 304);
            BtnDelTap1.Margin = new Padding(3, 4, 3, 4);
            BtnDelTap1.Name = "BtnDelTap1";
            BtnDelTap1.Size = new Size(70, 30);
            BtnDelTap1.TabIndex = 5;
            BtnDelTap1.Text = "삭제";
            BtnDelTap1.UseVisualStyleBackColor = true;
            BtnDelTap1.Click += BtnDelTap1_Click;
            // 
            // BtnEditTap1
            // 
            BtnEditTap1.Location = new Point(188, 304);
            BtnEditTap1.Margin = new Padding(3, 4, 3, 4);
            BtnEditTap1.Name = "BtnEditTap1";
            BtnEditTap1.Size = new Size(70, 30);
            BtnEditTap1.TabIndex = 5;
            BtnEditTap1.Text = "수정";
            BtnEditTap1.UseVisualStyleBackColor = true;
            BtnEditTap1.Click += BtnEditTap1_Click;
            // 
            // BtnReset
            // 
            BtnReset.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReset.ImageIndex = 0;
            BtnReset.ImageList = imageList1;
            BtnReset.Location = new Point(9, 304);
            BtnReset.Margin = new Padding(3, 4, 3, 4);
            BtnReset.Name = "BtnReset";
            BtnReset.Padding = new Padding(2, 0, 0, 0);
            BtnReset.Size = new Size(29, 30);
            BtnReset.TabIndex = 5;
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Reset.png");
            // 
            // BtnSaveTap1
            // 
            BtnSaveTap1.Location = new Point(112, 304);
            BtnSaveTap1.Margin = new Padding(3, 4, 3, 4);
            BtnSaveTap1.Name = "BtnSaveTap1";
            BtnSaveTap1.Size = new Size(70, 30);
            BtnSaveTap1.TabIndex = 5;
            BtnSaveTap1.Text = "저장";
            BtnSaveTap1.UseVisualStyleBackColor = true;
            BtnSaveTap1.Click += BtnSaveTap1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ItemName, ItemCode, ItemNum });
            dataGridView1.Location = new Point(9, 24);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.Size = new Size(324, 272);
            dataGridView1.TabIndex = 0;
            // 
            // ItemName
            // 
            ItemName.HeaderText = "재고명";
            ItemName.Name = "ItemName";
            // 
            // ItemCode
            // 
            ItemCode.HeaderText = "재고코드";
            ItemCode.Name = "ItemCode";
            ItemCode.Width = 91;
            // 
            // ItemNum
            // 
            ItemNum.HeaderText = "재고수량";
            ItemNum.Name = "ItemNum";
            ItemNum.Width = 90;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NudItemNum_Tab1);
            groupBox1.Controls.Add(TxtItemCode_Tap1);
            groupBox1.Controls.Add(TxtItemName_Tap1);
            groupBox1.Controls.Add(BtnRegisterTap1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, 8);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(340, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "재고등록";
            // 
            // NudItemNum_Tab1
            // 
            NudItemNum_Tab1.Location = new Point(78, 86);
            NudItemNum_Tab1.Margin = new Padding(3, 4, 3, 4);
            NudItemNum_Tab1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NudItemNum_Tab1.Name = "NudItemNum_Tab1";
            NudItemNum_Tab1.Size = new Size(100, 23);
            NudItemNum_Tab1.TabIndex = 3;
            // 
            // TxtItemCode_Tap1
            // 
            TxtItemCode_Tap1.Location = new Point(78, 55);
            TxtItemCode_Tap1.Margin = new Padding(3, 4, 3, 4);
            TxtItemCode_Tap1.Name = "TxtItemCode_Tap1";
            TxtItemCode_Tap1.Size = new Size(100, 23);
            TxtItemCode_Tap1.TabIndex = 2;
            // 
            // TxtItemName_Tap1
            // 
            TxtItemName_Tap1.Location = new Point(78, 24);
            TxtItemName_Tap1.Margin = new Padding(3, 4, 3, 4);
            TxtItemName_Tap1.Name = "TxtItemName_Tap1";
            TxtItemName_Tap1.Size = new Size(100, 23);
            TxtItemName_Tap1.TabIndex = 1;
            // 
            // BtnRegisterTap1
            // 
            BtnRegisterTap1.Location = new Point(264, 103);
            BtnRegisterTap1.Margin = new Padding(3, 4, 3, 4);
            BtnRegisterTap1.Name = "BtnRegisterTap1";
            BtnRegisterTap1.Size = new Size(70, 30);
            BtnRegisterTap1.TabIndex = 4;
            BtnRegisterTap1.Text = "등록";
            BtnRegisterTap1.UseVisualStyleBackColor = true;
            BtnRegisterTap1.Click += BtnRegisterTap1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 88);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "재고수량 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 58);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "재고코드 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "재고명 :";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(352, 507);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "입출고관리";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnSaveTap2);
            groupBox3.Controls.Add(BtnEditTap2);
            groupBox3.Controls.Add(BtnDelTap2);
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(6, 325);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(340, 174);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "입출고기록";
            // 
            // BtnSaveTap2
            // 
            BtnSaveTap2.Location = new Point(112, 136);
            BtnSaveTap2.Margin = new Padding(3, 4, 3, 4);
            BtnSaveTap2.Name = "BtnSaveTap2";
            BtnSaveTap2.Size = new Size(70, 30);
            BtnSaveTap2.TabIndex = 17;
            BtnSaveTap2.Text = "저장";
            BtnSaveTap2.UseVisualStyleBackColor = true;
            BtnSaveTap2.Click += BtnSaveTap2_Click;
            // 
            // BtnEditTap2
            // 
            BtnEditTap2.Location = new Point(188, 136);
            BtnEditTap2.Margin = new Padding(3, 4, 3, 4);
            BtnEditTap2.Name = "BtnEditTap2";
            BtnEditTap2.Size = new Size(70, 30);
            BtnEditTap2.TabIndex = 17;
            BtnEditTap2.Text = "수정";
            BtnEditTap2.UseVisualStyleBackColor = true;
            BtnEditTap2.Click += BtnEditTap2_Click;
            // 
            // BtnDelTap2
            // 
            BtnDelTap2.Location = new Point(264, 136);
            BtnDelTap2.Margin = new Padding(3, 4, 3, 4);
            BtnDelTap2.Name = "BtnDelTap2";
            BtnDelTap2.Size = new Size(70, 30);
            BtnDelTap2.TabIndex = 17;
            BtnDelTap2.Text = "삭제";
            BtnDelTap2.UseVisualStyleBackColor = true;
            BtnDelTap2.Click += BtnDelTap2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { itemInOut, ItemDate, ItemTime, ItemName2, ItemCode2, ItemNum2, ItemManager, ManagerPhone });
            dataGridView2.Location = new Point(6, 25);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 23;
            dataGridView2.Size = new Size(327, 103);
            dataGridView2.TabIndex = 0;
            // 
            // itemInOut
            // 
            itemInOut.HeaderText = "입출고";
            itemInOut.Name = "itemInOut";
            itemInOut.Width = 80;
            // 
            // ItemDate
            // 
            ItemDate.HeaderText = "입출고날짜";
            ItemDate.Name = "ItemDate";
            ItemDate.Width = 90;
            // 
            // ItemTime
            // 
            ItemTime.HeaderText = "입출고시간";
            ItemTime.Name = "ItemTime";
            ItemTime.Width = 90;
            // 
            // ItemName2
            // 
            ItemName2.HeaderText = "재고명";
            ItemName2.Name = "ItemName2";
            ItemName2.Width = 90;
            // 
            // ItemCode2
            // 
            ItemCode2.HeaderText = "재고코드";
            ItemCode2.Name = "ItemCode2";
            ItemCode2.Width = 80;
            // 
            // ItemNum2
            // 
            ItemNum2.HeaderText = "재고수량";
            ItemNum2.Name = "ItemNum2";
            ItemNum2.Width = 80;
            // 
            // ItemManager
            // 
            ItemManager.HeaderText = "담당자명";
            ItemManager.Name = "ItemManager";
            ItemManager.Width = 90;
            // 
            // ManagerPhone
            // 
            ManagerPhone.HeaderText = "연락망";
            ManagerPhone.Name = "ManagerPhone";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(CboItemName);
            groupBox4.Controls.Add(BtnSearch);
            groupBox4.Controls.Add(panel2);
            groupBox4.Controls.Add(panel1);
            groupBox4.Controls.Add(CboMinute);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(CboHour);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(DptDate);
            groupBox4.Controls.Add(RdoOutput);
            groupBox4.Controls.Add(RdoInput);
            groupBox4.Controls.Add(TxtPhone);
            groupBox4.Controls.Add(NudItemNum_Tap2);
            groupBox4.Controls.Add(TxtManager);
            groupBox4.Controls.Add(TxtItemCode_Tap2);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(BtnRegisterTap2);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(5, 8);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(340, 309);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "입출고등록";
            // 
            // CboItemName
            // 
            CboItemName.FormattingEnabled = true;
            CboItemName.Location = new Point(80, 173);
            CboItemName.Name = "CboItemName";
            CboItemName.Size = new Size(82, 23);
            CboItemName.TabIndex = 18;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(169, 142);
            BtnSearch.Margin = new Padding(3, 4, 3, 4);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(49, 23);
            BtnSearch.TabIndex = 17;
            BtnSearch.Text = "조회";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(20, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(20, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 15;
            // 
            // CboMinute
            // 
            CboMinute.FormattingEnabled = true;
            CboMinute.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            CboMinute.Location = new Point(168, 79);
            CboMinute.Name = "CboMinute";
            CboMinute.Size = new Size(49, 23);
            CboMinute.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(152, 82);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 13;
            label12.Text = ":";
            // 
            // CboHour
            // 
            CboHour.FormattingEnabled = true;
            CboHour.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            CboHour.Location = new Point(97, 79);
            CboHour.Name = "CboHour";
            CboHour.Size = new Size(49, 23);
            CboHour.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 84);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 11;
            label11.Text = "입출고 시간 :";
            // 
            // DptDate
            // 
            DptDate.Location = new Point(97, 49);
            DptDate.Margin = new Padding(3, 4, 3, 4);
            DptDate.Name = "DptDate";
            DptDate.Size = new Size(200, 23);
            DptDate.TabIndex = 2;
            // 
            // RdoOutput
            // 
            RdoOutput.AutoSize = true;
            RdoOutput.Location = new Point(152, 23);
            RdoOutput.Name = "RdoOutput";
            RdoOutput.Size = new Size(49, 19);
            RdoOutput.TabIndex = 1;
            RdoOutput.TabStop = true;
            RdoOutput.Text = "출고";
            RdoOutput.UseVisualStyleBackColor = true;
            // 
            // RdoInput
            // 
            RdoInput.AutoSize = true;
            RdoInput.Location = new Point(97, 23);
            RdoInput.Name = "RdoInput";
            RdoInput.Size = new Size(49, 19);
            RdoInput.TabIndex = 1;
            RdoInput.TabStop = true;
            RdoInput.Text = "입고";
            RdoInput.UseVisualStyleBackColor = true;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(224, 238);
            TxtPhone.Mask = "000-9000-0000";
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(100, 23);
            TxtPhone.TabIndex = 9;
            // 
            // NudItemNum_Tap2
            // 
            NudItemNum_Tap2.Location = new Point(248, 173);
            NudItemNum_Tap2.Margin = new Padding(3, 4, 3, 4);
            NudItemNum_Tap2.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NudItemNum_Tap2.Name = "NudItemNum_Tap2";
            NudItemNum_Tap2.Size = new Size(76, 23);
            NudItemNum_Tap2.TabIndex = 7;
            // 
            // TxtManager
            // 
            TxtManager.Location = new Point(81, 238);
            TxtManager.Margin = new Padding(3, 4, 3, 4);
            TxtManager.Name = "TxtManager";
            TxtManager.Size = new Size(81, 23);
            TxtManager.TabIndex = 8;
            // 
            // TxtItemCode_Tap2
            // 
            TxtItemCode_Tap2.Location = new Point(81, 142);
            TxtItemCode_Tap2.Margin = new Padding(3, 4, 3, 4);
            TxtItemCode_Tap2.Name = "TxtItemCode_Tap2";
            TxtItemCode_Tap2.Size = new Size(81, 23);
            TxtItemCode_Tap2.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(168, 241);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 1;
            label9.Text = "연락망 :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(168, 176);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 1;
            label7.Text = "입출고수량 :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 241);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 1;
            label8.Text = "담당자명 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 145);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 1;
            label4.Text = "재고코드 :";
            // 
            // BtnRegisterTap2
            // 
            BtnRegisterTap2.Location = new Point(264, 271);
            BtnRegisterTap2.Margin = new Padding(3, 4, 3, 4);
            BtnRegisterTap2.Name = "BtnRegisterTap2";
            BtnRegisterTap2.Size = new Size(70, 30);
            BtnRegisterTap2.TabIndex = 10;
            BtnRegisterTap2.Text = "등록";
            BtnRegisterTap2.UseVisualStyleBackColor = true;
            BtnRegisterTap2.Click += BtnRegisterTap2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 57);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 1;
            label10.Text = "입출고 날짜 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 176);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 1;
            label5.Text = "재고명 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 27);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 0;
            label6.Text = "입출고 :";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(384, 561);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "재고 입출고관리 시스템";
            Load += FrmMain_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudItemNum_Tab1).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudItemNum_Tap2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown NudItemNum_Tab1;
        private System.Windows.Forms.TextBox TxtItemCode_Tap1;
        private System.Windows.Forms.TextBox TxtItemName_Tap1;
        private System.Windows.Forms.Button BtnRegisterTap1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown NudItemNum_Tap2;
        private System.Windows.Forms.TextBox TxtManager;
        private System.Windows.Forms.TextBox TxtItemCode_Tap2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRegisterTap2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DptDate;
        private System.Windows.Forms.Label label10;
        private Label label2;
        private RadioButton RdoOutput;
        private RadioButton RdoInput;
        private MaskedTextBox TxtPhone;
        private Label label11;
        private ComboBox CboMinute;
        private Label label12;
        private ComboBox CboHour;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn itemInOut;
        private DataGridViewTextBoxColumn ItemDate;
        private DataGridViewTextBoxColumn ItemTime;
        private DataGridViewTextBoxColumn ItemName2;
        private DataGridViewTextBoxColumn ItemCode2;
        private DataGridViewTextBoxColumn ItemNum2;
        private DataGridViewTextBoxColumn ItemManager;
        private DataGridViewTextBoxColumn ManagerPhone;
        private Button BtnSaveTap1;
        private Button BtnDelTap2;
        private Button BtnSearch;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn ItemCode;
        private DataGridViewTextBoxColumn ItemNum;
        private Button BtnSaveTap2;
        private Button BtnEditTap2;
        private Button BtnDelTap1;
        private Button BtnEditTap1;
        private ComboBox CboItemName;
        private Button BtnReset;
        private ImageList imageList1;
    }
}


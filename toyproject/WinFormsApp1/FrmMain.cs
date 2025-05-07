using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadCsv("재고관리.csv", dataGridView1);
            LoadCsv("입출고관리.csv", dataGridView2);
        }

        private void BtnRegisterTap1_Click(object sender, EventArgs e)
        {
            string itemName_Tap1 = TxtItemName_Tap1.Text;
            string itemCode_Tap1 = TxtItemCode_Tap1.Text;
            int itemNum_Tap1 = (int)NudItemNum_Tab1.Value;

            if (editingRowIndex >= 0)
            {
                // 수정 중인 행 업데이트
                var row = dataGridView1.Rows[editingRowIndex];
                row.SetValues(itemName_Tap1, itemCode_Tap1, itemNum_Tap1);

                editingRowIndex = -1; // 수정 상태 해제
                MessageBox.Show("수정되었습니다.", "수정완료", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                // 새 행 추가
                dataGridView1.Rows.Add(itemName_Tap1, itemCode_Tap1, itemNum_Tap1);
                MessageBox.Show("등록되었습니다.", "등록완료", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSaveTap1_Click(object sender, EventArgs e)
        {
            SaveCsv("재고관리.csv", dataGridView1);
            MessageBox.Show("저장되었습니다.", "저장완료", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnRegisterTap2_Click(object sender, EventArgs e)
        {
            string type = RdoInput.Checked ? "입고" : "출고";
            string date = DptDate.Value.ToString("yyyy-MM-dd (ddd)");
            string time = CboHour.Text + ":" + CboMinute.Text;
            string itemName_Tap2 = CboItemName.Text;
            string itemCode_Tap2 = TxtItemCode_Tap2.Text;
            int itemNum_Tap2 = (int)NudItemNum_Tap2.Value;
            string manager = TxtManager.Text;
            string phone = TxtPhone.Text;

            // 입출고에 따른 수량 변화
            int updateItemNum = RdoInput.Checked ? itemNum_Tap2 : -itemNum_Tap2;

            // 재고 수량 업데이트
            UpdateItemNum(itemCode_Tap2, updateItemNum);

            if (editingRowIndex >= 0)
            {
                // 수정 중인 행 업데이트
                var row = dataGridView2.Rows[editingRowIndex];
                row.SetValues(type, date, time, itemName_Tap2, itemCode_Tap2, itemNum_Tap2, manager, phone);

                editingRowIndex = -1; // 수정 상태 해제
                MessageBox.Show("수정되었습니다.", "수정완료", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                // 새 행 추가
                dataGridView2.Rows.Add(type, date, time, itemName_Tap2, itemCode_Tap2, itemNum_Tap2, manager, phone);
                MessageBox.Show("등록되었습니다.", "등록완료", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSaveTap2_Click(object sender, EventArgs e)
        {
            SaveCsv("입출고관리.csv", dataGridView2);
            MessageBox.Show("저장되었습니다.", "저장완료", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        Dictionary<string, List<string>> stockDict = new Dictionary<string, List<string>>(); // 재고코드, 재고명

        private void LoadCsv(string filePath, DataGridView grid)    // 파일 불러오기 함수
        {
            if (!File.Exists(filePath)) return;

            grid.Rows.Clear();
            grid.Columns.Clear();
            if (filePath == "재고관리.csv")
                stockDict.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                bool isFirstLine = true;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (isFirstLine)
                    {
                        foreach (var header in values)
                            grid.Columns.Add(header, header); // 첫 줄을 컬럼명으로 사용
                        isFirstLine = false;
                    }
                    else
                    {
                        grid.Rows.Add(values);
                        if (values.Length >= 2)
                        {
                            string itemName = values[0];
                            string itemCode = values[1];

                            if (!stockDict.ContainsKey(itemCode))
                            {
                                stockDict[itemCode] = new List<string>(); // 리스트 생성
                            }
                            stockDict[itemCode].Add(itemName); // 재고명 리스트에 추가
                        }
                    }
                }
            }
        }
        private void SaveCsv(string filePath, DataGridView grid)  // 파일 저장하는 함수
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // 컬럼 헤더 저장
                var headers = grid.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText.Replace(",", ""));
                writer.WriteLine(string.Join(",", headers));

                // 데이터 행 저장
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()?.Replace(",", ""));
                        writer.WriteLine(string.Join(",", values));
                    }
                }
            }
        }

        private void BtnDelTap1_Click(object sender, EventArgs e)
        {
            DeleteData(dataGridView1);
        }

        private void BtnDelTap2_Click(object sender, EventArgs e)
        {
            DeleteData(dataGridView2);
        }

        private void DeleteData(DataGridView grid)  // 데이터 삭제 함수
        {
            if (grid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("선택한 데이터를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in grid.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            grid.Rows.Remove(row);
                            MessageBox.Show("삭제되었습니다.", "삭제완료", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제할 데이터를 선택하세요.", "삭제오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int editingRowIndex = -1; // -1이면 새로 추가, 0 이상이면 수정 중

        private void BtnEditTap1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                editingRowIndex = row.Index;

                // 예시: 입력창에 데이터 채워 넣기
                TxtItemName_Tap1.Text = row.Cells[0].Value.ToString();
                TxtItemCode_Tap1.Text = row.Cells[1].Value.ToString();
                NudItemNum_Tab1.Value = int.Parse(row.Cells[2].Value.ToString());
            }
            else
            {
                MessageBox.Show("수정할 행을 선택하세요.");
            }
        }

        private void BtnEditTap2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];
                editingRowIndex = row.Index;

                // 예시: 입력창에 데이터 채워 넣기
                RdoInput.Checked = row.Cells[0].Value.ToString() == "입고";
                DptDate.Value = DateTime.Parse(row.Cells[1].Value.ToString());

                string[] timeParts = row.Cells[2].Value.ToString().Split(':');
                CboHour.SelectedItem = timeParts[0];
                CboMinute.SelectedItem = timeParts[1];

                CboItemName.Text = row.Cells[3].Value.ToString();
                TxtItemCode_Tap2.Text = row.Cells[4].Value.ToString();
                NudItemNum_Tap2.Value = int.Parse(row.Cells[5].Value.ToString());
                TxtManager.Text = row.Cells[6].Value.ToString();
                TxtPhone.Text = row.Cells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("수정할 행을 선택하세요.");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string inputCode = TxtItemCode_Tap2.Text.Trim();

            if (stockDict.ContainsKey(inputCode))
            {
                CboItemName.Items.Clear();
                foreach (var itemName in stockDict[inputCode])
                {
                    CboItemName.Items.Add(itemName); // 해당 재고코드에 해당하는 모든 재고명을 콤보박스에 추가
                }
                if (CboItemName.Items.Count > 0)
                {
                    CboItemName.SelectedIndex = 0; // 첫 번째 항목 선택
                }
            }
            else
            {
                MessageBox.Show("해당 재고코드는 등록되어 있지 않습니다.", "조회 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboItemName.Items.Clear();
            }
        }
        void UpdateItemNum(string itemCode, int quantityChange)
        {
            string csvPath = "재고관리.csv";
            var lines = File.ReadAllLines(csvPath).ToList();

            for (int i = 1; i < lines.Count; i++)
            {
                var parts = lines[i].Split(',');

                if (parts[1] == itemCode)
                {
                    int currentQty = int.Parse(parts[2]);
                    int newQty = currentQty + quantityChange;

                    if (newQty < 0)
                    {
                        MessageBox.Show("재고가 부족하여 출고할 수 없습니다.", "출고 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    parts[2] = newQty.ToString();
                    lines[i] = string.Join(",", parts);
                    File.WriteAllLines(csvPath, lines);
                    return;
                }
            }

            MessageBox.Show("해당 재고코드가 재고관리.csv에 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LoadCsv("재고관리.csv", dataGridView1);
        }
    }
}
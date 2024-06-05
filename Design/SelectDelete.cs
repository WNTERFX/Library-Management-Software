namespace Test1
{
    public partial class SelectDelete : Form
    {
        public SelectDelete()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Select" });
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Section", "Section");
            dataGridView1.Columns.Add("StudentNumber", "Student Number");

            
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(textBoxName.Text) &&
                !string.IsNullOrWhiteSpace(textBoxSection.Text) &&
                !string.IsNullOrWhiteSpace(textBoxStudentNumber.Text))
            {
                dataGridView1.Rows.Add(false, textBoxName.Text, textBoxSection.Text, textBoxStudentNumber.Text);
                textBoxName.Clear();
                textBoxSection.Clear();
                textBoxStudentNumber.Clear();
            }
            else
            {
                MessageBox.Show("Fill all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Delete rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    var result = MessageBox.Show($"Delete Number: {row.Cells[3].Value}?",
                                                  "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                // checkbox click message
                bool isChecked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                MessageBox.Show(isChecked ? "Checkbox unchecked" : "Checkbox checked", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
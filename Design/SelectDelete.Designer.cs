namespace Test1
{
    partial class SelectDelete
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private TextBox textBoxName;
        private TextBox textBoxSection;
        private TextBox textBoxStudentNumber;
        private Button buttonCreate;
        private Button buttonDelete;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBoxName = new TextBox();
            textBoxSection = new TextBox();
            textBoxStudentNumber = new TextBox();
            buttonCreate = new Button();
            buttonDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(221, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(403, 160);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(339, 109);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSection
            // 
            textBoxSection.Location = new Point(339, 60);
            textBoxSection.Name = "textBoxSection";
            textBoxSection.Size = new Size(150, 23);
            textBoxSection.TabIndex = 2;
            // 
            // textBoxStudentNumber
            // 
            textBoxStudentNumber.Location = new Point(339, 157);
            textBoxStudentNumber.Name = "textBoxStudentNumber";
            textBoxStudentNumber.Size = new Size(150, 23);
            textBoxStudentNumber.TabIndex = 3;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(230, 200);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(150, 30);
            buttonCreate.TabIndex = 4;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(424, 200);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 30);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 60);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 112);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 7;
            label2.Text = "Section";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 160);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 8;
            label3.Text = "Student Number";
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSection);
            Controls.Add(textBoxStudentNumber);
            Controls.Add(buttonCreate);
            Controls.Add(buttonDelete);
            Name = "Form1";
            Text = "Select/Delete";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
    }
}
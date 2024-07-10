namespace Galaxy
{
    partial class StockCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockCode));
            stock_code = new Label();
            label1 = new Label();
            save_code = new Button();
            dataGridView1 = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            code_short = new DataGridViewTextBoxColumn();
            pprice = new DataGridViewTextBoxColumn();
            sprice = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            DeleteCode = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // stock_code
            // 
            stock_code.AutoSize = true;
            stock_code.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stock_code.ForeColor = Color.FromArgb(249, 115, 0);
            stock_code.Location = new Point(153, 10);
            stock_code.Name = "stock_code";
            stock_code.Size = new Size(131, 17);
            stock_code.TabIndex = 1;
            stock_code.Text = "Stock Input Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(8, 3, 8, 3);
            label1.Size = new Size(42, 24);
            label1.TabIndex = 2;
            label1.Text = "<<";
            label1.Click += label1_Click;
            // 
            // save_code
            // 
            save_code.BackColor = Color.FromArgb(249, 115, 0);
            save_code.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_code.ForeColor = Color.White;
            save_code.Location = new Point(292, 497);
            save_code.Name = "save_code";
            save_code.Padding = new Padding(5);
            save_code.Size = new Size(120, 40);
            save_code.TabIndex = 3;
            save_code.Text = "Save";
            save_code.UseVisualStyleBackColor = false;
            save_code.Click += save_code_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { code, description, code_short, pprice, sprice });
            dataGridView1.Location = new Point(23, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(388, 400);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += CodeEnterData;
            dataGridView1.CellEnter += CodeEnter;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // code
            // 
            code.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.BackColor = Color.White;
            code.DefaultCellStyle = dataGridViewCellStyle1;
            code.FillWeight = 1000F;
            code.HeaderText = "Code";
            code.Name = "code";
            code.Width = 60;
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            description.HeaderText = "Description";
            description.Name = "description";
            description.Width = 92;
            // 
            // code_short
            // 
            code_short.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            code_short.HeaderText = "Short";
            code_short.Name = "code_short";
            code_short.Width = 60;
            // 
            // pprice
            // 
            pprice.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Format = "N0";
            pprice.DefaultCellStyle = dataGridViewCellStyle2;
            pprice.HeaderText = "PPrice";
            pprice.Name = "pprice";
            pprice.Width = 65;
            // 
            // sprice
            // 
            sprice.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Format = "N0";
            sprice.DefaultCellStyle = dataGridViewCellStyle3;
            sprice.HeaderText = "SPrice";
            sprice.Name = "sprice";
            sprice.Width = 64;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(433, 84);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(545, 400);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 115, 0);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 497);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 5;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(249, 115, 0);
            label2.Location = new Point(674, 12);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 6;
            label2.Text = "Stock List";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 115, 0);
            panel1.Location = new Point(410, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(23, 42);
            panel1.TabIndex = 7;
            // 
            // DeleteCode
            // 
            DeleteCode.BackColor = Color.FromArgb(249, 115, 0);
            DeleteCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteCode.ForeColor = Color.White;
            DeleteCode.Location = new Point(860, 497);
            DeleteCode.Name = "DeleteCode";
            DeleteCode.Size = new Size(120, 40);
            DeleteCode.TabIndex = 8;
            DeleteCode.Text = "Code Delete";
            DeleteCode.UseVisualStyleBackColor = false;
            DeleteCode.Click += DeleteCode_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(226, 223, 208);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(stock_code);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 42);
            panel2.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(249, 115, 0);
            panel4.Location = new Point(976, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(23, 42);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(249, 115, 0);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(23, 42);
            panel3.TabIndex = 8;
            // 
            // StockCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 76, 66);
            ClientSize = new Size(1000, 550);
            Controls.Add(panel1);
            Controls.Add(DeleteCode);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(save_code);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StockCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockCode";
            Load += StockCode_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label stock_code;
        private Label label1;
        private Button save_code;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private Label label2;
        private Panel panel1;
        private Button DeleteCode;
        private Panel panel2;
        private Panel panel3;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn code_short;
        private DataGridViewTextBoxColumn pprice;
        private DataGridViewTextBoxColumn sprice;
        private Panel panel4;
    }
}
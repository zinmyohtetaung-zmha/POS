namespace Galaxy
{
    partial class SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            customer = new TextBox();
            pay_type = new ComboBox();
            inv_date = new DateTimePicker();
            doc_id = new TextBox();
            panel2 = new Panel();
            hideField = new Label();
            sale = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            quenty = new DataGridViewTextBoxColumn();
            sprice = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            net_amt = new TextBox();
            inv_total = new Label();
            total_qty = new Label();
            qty = new Label();
            label5 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            code_fine = new TextBox();
            codeFindLvl = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(customer);
            panel1.Controls.Add(pay_type);
            panel1.Controls.Add(inv_date);
            panel1.Controls.Add(doc_id);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 108);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(82, 76, 66);
            label4.Location = new Point(619, 56);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 8;
            label4.Text = "Payment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(82, 76, 66);
            label3.Location = new Point(422, 56);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 7;
            label3.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(82, 76, 66);
            label2.Location = new Point(225, 56);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 6;
            label2.Text = "Invoice No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(82, 76, 66);
            label1.Location = new Point(31, 56);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 5;
            label1.Text = "Date";
            // 
            // customer
            // 
            customer.Location = new Point(422, 76);
            customer.Name = "customer";
            customer.Size = new Size(150, 23);
            customer.TabIndex = 4;
            // 
            // pay_type
            // 
            pay_type.FormattingEnabled = true;
            pay_type.Items.AddRange(new object[] { "Cash Down", "Credit" });
            pay_type.Location = new Point(619, 76);
            pay_type.Name = "pay_type";
            pay_type.Size = new Size(150, 23);
            pay_type.TabIndex = 3;
            // 
            // inv_date
            // 
            inv_date.Location = new Point(31, 76);
            inv_date.Name = "inv_date";
            inv_date.Size = new Size(150, 23);
            inv_date.TabIndex = 2;
            // 
            // doc_id
            // 
            doc_id.Location = new Point(225, 76);
            doc_id.Name = "doc_id";
            doc_id.ReadOnly = true;
            doc_id.Size = new Size(150, 23);
            doc_id.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 76, 66);
            panel2.Controls.Add(hideField);
            panel2.Controls.Add(sale);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 42);
            panel2.TabIndex = 0;
            // 
            // hideField
            // 
            hideField.AutoSize = true;
            hideField.ForeColor = Color.White;
            hideField.Location = new Point(316, 10);
            hideField.Name = "hideField";
            hideField.Size = new Size(57, 15);
            hideField.TabIndex = 3;
            hideField.Text = "HideField";
            hideField.Visible = false;
            // 
            // sale
            // 
            sale.AutoSize = true;
            sale.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sale.ForeColor = Color.FromArgb(249, 115, 0);
            sale.Location = new Point(31, 9);
            sale.Name = "sale";
            sale.Size = new Size(152, 27);
            sale.TabIndex = 2;
            sale.Text = "Sale Voucher";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(751, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(249, 115, 0);
            panel3.Location = new Point(0, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 67);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(249, 115, 0);
            panel4.Location = new Point(786, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(14, 67);
            panel4.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 115, 0);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(621, 381);
            button1.Name = "button1";
            button1.Size = new Size(150, 44);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { code, description, quenty, sprice, amount });
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(572, 311);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // code
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            code.DefaultCellStyle = dataGridViewCellStyle1;
            code.HeaderText = "Code";
            code.Name = "code";
            code.ReadOnly = true;
            code.Width = 110;
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.Name = "description";
            description.ReadOnly = true;
            description.Width = 170;
            // 
            // quenty
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            quenty.DefaultCellStyle = dataGridViewCellStyle2;
            quenty.HeaderText = "Qty";
            quenty.Name = "quenty";
            quenty.Width = 50;
            // 
            // sprice
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            sprice.DefaultCellStyle = dataGridViewCellStyle3;
            sprice.HeaderText = "Sale Price";
            sprice.Name = "sprice";
            sprice.ReadOnly = true;
            sprice.Width = 90;
            // 
            // amount
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            amount.DefaultCellStyle = dataGridViewCellStyle4;
            amount.HeaderText = "Amount";
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Width = 110;
            // 
            // net_amt
            // 
            net_amt.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            net_amt.ForeColor = Color.FromArgb(249, 115, 0);
            net_amt.Location = new Point(619, 341);
            net_amt.Name = "net_amt";
            net_amt.ReadOnly = true;
            net_amt.Size = new Size(152, 27);
            net_amt.TabIndex = 2;
            net_amt.Text = "0";
            net_amt.TextAlign = HorizontalAlignment.Center;
            net_amt.TextChanged += textBox3_TextChanged;
            // 
            // inv_total
            // 
            inv_total.AutoSize = true;
            inv_total.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inv_total.ForeColor = Color.FromArgb(249, 115, 0);
            inv_total.Location = new Point(645, 309);
            inv_total.Name = "inv_total";
            inv_total.Size = new Size(87, 17);
            inv_total.TabIndex = 3;
            inv_total.Text = "Invoice Total";
            // 
            // total_qty
            // 
            total_qty.AutoSize = true;
            total_qty.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_qty.ForeColor = Color.FromArgb(249, 115, 0);
            total_qty.Location = new Point(658, 228);
            total_qty.Name = "total_qty";
            total_qty.Size = new Size(65, 17);
            total_qty.TabIndex = 4;
            total_qty.Text = "Total Qty";
            // 
            // qty
            // 
            qty.AutoSize = true;
            qty.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qty.ForeColor = Color.White;
            qty.Location = new Point(675, 260);
            qty.Name = "qty";
            qty.Size = new Size(15, 17);
            qty.TabIndex = 5;
            qty.Text = "0";
            qty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(249, 115, 0);
            label5.Location = new Point(619, 187);
            label5.Name = "label5";
            label5.Size = new Size(148, 21);
            label5.TabIndex = 6;
            label5.Text = "       SUMMARY       ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(619, 201);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 165);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(761, 187);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 167);
            panel6.TabIndex = 8;
            // 
            // code_fine
            // 
            code_fine.Location = new Point(619, 149);
            code_fine.Name = "code_fine";
            code_fine.Size = new Size(152, 23);
            code_fine.TabIndex = 9;
            code_fine.KeyDown += CodeFineEnter;
            // 
            // codeFindLvl
            // 
            codeFindLvl.AutoSize = true;
            codeFindLvl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            codeFindLvl.ForeColor = Color.FromArgb(249, 115, 0);
            codeFindLvl.Location = new Point(619, 125);
            codeFindLvl.Name = "codeFindLvl";
            codeFindLvl.Size = new Size(86, 21);
            codeFindLvl.TabIndex = 10;
            codeFindLvl.Text = "Code Find";
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 76, 66);
            ClientSize = new Size(800, 450);
            Controls.Add(codeFindLvl);
            Controls.Add(code_fine);
            Controls.Add(label5);
            Controls.Add(qty);
            Controls.Add(total_qty);
            Controls.Add(inv_total);
            Controls.Add(button1);
            Controls.Add(net_amt);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SaleForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        public TextBox doc_id;
        private PictureBox pictureBox1;
        private Button button1;
        public TextBox customer;
        public ComboBox pay_type;
        public DateTimePicker inv_date;
        public DataGridView dataGridView1;
        public TextBox net_amt;
        public Label inv_total;
        public Label total_qty;
        public Label qty;
        private Label sale;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private Panel panel3;
        private Label label5;
        private Panel panel5;
        private Panel panel6;
        public TextBox code_fine;
        public Label codeFindLvl;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn quenty;
        private DataGridViewTextBoxColumn sprice;
        private DataGridViewTextBoxColumn amount;
        public Label hideField;
    }
}
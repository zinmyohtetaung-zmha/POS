namespace Galaxy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            sale = new Button();
            purchase = new Button();
            stock_status = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            totalSaleAmount = new Label();
            totalSaleQty = new Label();
            Update_Sale = new Button();
            SH_Delete = new Button();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            sale_data = new DataGridView();
            purchase_data = new DataGridView();
            sale_lavel = new Label();
            pur_lavel = new Label();
            add_sale = new Label();
            add_purchase = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sale_data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)purchase_data).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(82, 76, 66);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(sale);
            flowLayoutPanel1.Controls.Add(purchase);
            flowLayoutPanel1.Controls.Add(stock_status);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Font = new Font("Britannic Bold", 14.25F);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(174, 700);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 84);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // sale
            // 
            sale.BackColor = Color.FromArgb(226, 223, 208);
            sale.FlatStyle = FlatStyle.Flat;
            sale.Location = new Point(3, 93);
            sale.Name = "sale";
            sale.Size = new Size(196, 47);
            sale.TabIndex = 1;
            sale.Text = "     Sale";
            sale.TextAlign = ContentAlignment.MiddleLeft;
            sale.UseVisualStyleBackColor = false;
            sale.Click += sale_Click_1;
            // 
            // purchase
            // 
            purchase.BackColor = Color.FromArgb(226, 223, 208);
            purchase.FlatStyle = FlatStyle.Flat;
            purchase.Location = new Point(3, 146);
            purchase.Name = "purchase";
            purchase.Size = new Size(196, 47);
            purchase.TabIndex = 2;
            purchase.Text = "     Purchase";
            purchase.TextAlign = ContentAlignment.MiddleLeft;
            purchase.UseVisualStyleBackColor = false;
            purchase.Click += purchase_Click;
            // 
            // stock_status
            // 
            stock_status.BackColor = Color.FromArgb(226, 223, 208);
            stock_status.FlatStyle = FlatStyle.Flat;
            stock_status.Location = new Point(3, 199);
            stock_status.Name = "stock_status";
            stock_status.Size = new Size(196, 47);
            stock_status.TabIndex = 3;
            stock_status.Text = "     Adjustment";
            stock_status.TextAlign = ContentAlignment.MiddleLeft;
            stock_status.UseVisualStyleBackColor = false;
            stock_status.Click += stock_status_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(226, 223, 208);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 252);
            button1.Name = "button1";
            button1.Size = new Size(196, 47);
            button1.TabIndex = 4;
            button1.Text = "     Stock Status";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(226, 223, 208);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(3, 305);
            button2.Name = "button2";
            button2.Size = new Size(196, 47);
            button2.TabIndex = 5;
            button2.Text = "     Price Change";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(226, 223, 208);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(3, 358);
            button3.Name = "button3";
            button3.Size = new Size(196, 47);
            button3.TabIndex = 6;
            button3.Text = "     Outstanding";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(226, 223, 208);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(3, 411);
            button4.Name = "button4";
            button4.Size = new Size(196, 47);
            button4.TabIndex = 7;
            button4.Text = "     Cash / Bank";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(226, 223, 208);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(3, 464);
            button5.Name = "button5";
            button5.Size = new Size(196, 47);
            button5.TabIndex = 8;
            button5.Text = "     Gledger";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(226, 223, 208);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 511);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 39);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(226, 223, 208);
            panel3.Controls.Add(totalSaleAmount);
            panel3.Controls.Add(totalSaleQty);
            panel3.Controls.Add(Update_Sale);
            panel3.Controls.Add(SH_Delete);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 39);
            panel3.TabIndex = 2;
            // 
            // totalSaleAmount
            // 
            totalSaleAmount.BorderStyle = BorderStyle.FixedSingle;
            totalSaleAmount.FlatStyle = FlatStyle.Flat;
            totalSaleAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalSaleAmount.ForeColor = Color.FromArgb(249, 115, 0);
            totalSaleAmount.Location = new Point(873, 4);
            totalSaleAmount.Name = "totalSaleAmount";
            totalSaleAmount.Padding = new Padding(0, 5, 0, 5);
            totalSaleAmount.Size = new Size(115, 29);
            totalSaleAmount.TabIndex = 3;
            totalSaleAmount.Text = "label2";
            totalSaleAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalSaleQty
            // 
            totalSaleQty.BorderStyle = BorderStyle.FixedSingle;
            totalSaleQty.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalSaleQty.ForeColor = Color.FromArgb(249, 115, 0);
            totalSaleQty.Location = new Point(754, 4);
            totalSaleQty.Name = "totalSaleQty";
            totalSaleQty.Padding = new Padding(30, 5, 30, 5);
            totalSaleQty.Size = new Size(115, 29);
            totalSaleQty.TabIndex = 2;
            totalSaleQty.Text = "label2";
            totalSaleQty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Update_Sale
            // 
            Update_Sale.BackColor = Color.FromArgb(249, 115, 0);
            Update_Sale.ForeColor = Color.White;
            Update_Sale.Location = new Point(261, 3);
            Update_Sale.Name = "Update_Sale";
            Update_Sale.Size = new Size(75, 33);
            Update_Sale.TabIndex = 1;
            Update_Sale.Text = "Update";
            Update_Sale.UseVisualStyleBackColor = false;
            Update_Sale.Click += button6_Click;
            // 
            // SH_Delete
            // 
            SH_Delete.BackColor = Color.FromArgb(249, 115, 0);
            SH_Delete.ForeColor = Color.White;
            SH_Delete.Location = new Point(180, 3);
            SH_Delete.Name = "SH_Delete";
            SH_Delete.Size = new Size(75, 33);
            SH_Delete.TabIndex = 0;
            SH_Delete.Text = "Delete";
            SH_Delete.UseVisualStyleBackColor = false;
            SH_Delete.Click += SH_Delete_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(226, 223, 208);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1000, 46);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(249, 115, 0);
            label1.Location = new Point(180, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 2;
            label1.Text = "Inventory Control";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(951, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(899, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 0;
            label3.Text = "Sale";
            // 
            // sale_data
            // 
            sale_data.AllowUserToAddRows = false;
            sale_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sale_data.BackgroundColor = Color.White;
            sale_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sale_data.Location = new Point(180, 79);
            sale_data.Name = "sale_data";
            sale_data.ReadOnly = true;
            sale_data.Size = new Size(808, 426);
            sale_data.TabIndex = 3;
            sale_data.Visible = false;
            sale_data.CellContentClick += dataGridView1_CellContentClick;
            // 
            // purchase_data
            // 
            purchase_data.BackgroundColor = Color.White;
            purchase_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            purchase_data.Location = new Point(180, 80);
            purchase_data.Name = "purchase_data";
            purchase_data.Size = new Size(808, 426);
            purchase_data.TabIndex = 4;
            purchase_data.Visible = false;
            purchase_data.CellContentClick += purchase_data_CellContentClick;
            // 
            // sale_lavel
            // 
            sale_lavel.AutoSize = true;
            sale_lavel.BackColor = Color.White;
            sale_lavel.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sale_lavel.Location = new Point(180, 52);
            sale_lavel.Name = "sale_lavel";
            sale_lavel.Padding = new Padding(5);
            sale_lavel.Size = new Size(115, 25);
            sale_lavel.TabIndex = 5;
            sale_lavel.Text = "Sale History       ";
            sale_lavel.Visible = false;
            // 
            // pur_lavel
            // 
            pur_lavel.AutoSize = true;
            pur_lavel.BackColor = Color.White;
            pur_lavel.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pur_lavel.Location = new Point(180, 52);
            pur_lavel.Name = "pur_lavel";
            pur_lavel.Padding = new Padding(5);
            pur_lavel.Size = new Size(116, 25);
            pur_lavel.TabIndex = 6;
            pur_lavel.Text = "Purchase History";
            pur_lavel.Visible = false;
            // 
            // add_sale
            // 
            add_sale.AutoSize = true;
            add_sale.BackColor = Color.FromArgb(82, 76, 66);
            add_sale.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_sale.ForeColor = Color.White;
            add_sale.Location = new Point(302, 51);
            add_sale.Name = "add_sale";
            add_sale.Size = new Size(27, 24);
            add_sale.TabIndex = 7;
            add_sale.Text = "+";
            add_sale.Visible = false;
            add_sale.Click += add_sale_Click;
            // 
            // add_purchase
            // 
            add_purchase.AutoSize = true;
            add_purchase.BackColor = Color.FromArgb(82, 76, 66);
            add_purchase.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_purchase.ForeColor = Color.White;
            add_purchase.Location = new Point(302, 51);
            add_purchase.Name = "add_purchase";
            add_purchase.Size = new Size(27, 24);
            add_purchase.TabIndex = 8;
            add_purchase.Text = "+";
            add_purchase.Visible = false;
            add_purchase.Click += add_purchase_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 550);
            Controls.Add(add_purchase);
            Controls.Add(add_sale);
            Controls.Add(pur_lavel);
            Controls.Add(sale_lavel);
            Controls.Add(purchase_data);
            Controls.Add(sale_data);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sale_data).EndInit();
            ((System.ComponentModel.ISupportInitialize)purchase_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button sale;
        private Button purchase;
        private Button stock_status;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Button button4;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private DataGridView sale_data;
        private DataGridView purchase_data;
        private Label sale_lavel;
        private Label pur_lavel;
        private Label add_sale;
        private Label add_purchase;
        private Button Update_Sale;
        private Button SH_Delete;
        private Label totalSaleQty;
        private Label totalSaleAmount;
    }
}

using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Galaxy
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=EIMONKYAW;Initial Catalog=galaxy;User ID=sa;Password=9@1@84;TrustServerCertificate=True");
        public Form1()
        {
            LoadMainForm();
        }

        public void LoadMainForm()
        {
            InitializeComponent();
            sale_data.Visible = true;
            sale_lavel.Visible = true;
            add_sale.Visible = true;
            purchase_data.Visible = false;
            pur_lavel.Visible = false;
            add_purchase.Visible = false;



            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT inv_date AS Date, docid AS DocId, customer AS Customer, pay_type AS PayType, total_qty AS TotalQty, net_amt AS NetAmt FROM Sale_head", con);
            DataSet ds = new DataSet();

            sda.Fill(ds, "Sale_head");

            sale_data.DataSource = ds.Tables["Sale_head"];

            // Rename the column headers
            sale_data.Columns["Date"].HeaderText = "Date";
            sale_data.Columns["DocId"].HeaderText = "DocId";
            sale_data.Columns["Customer"].HeaderText = "Customer";
            sale_data.Columns["PayType"].HeaderText = "PayType";
            sale_data.Columns["TotalQty"].HeaderText = "TotalQty";
            sale_data.Columns["NetAmt"].HeaderText = "NetAmt";

            //Total Qty in Sale History Start           
            int totalQtySum = 0;

            foreach (DataGridViewRow row in sale_data.Rows)
            {
                if (row.Cells["TotalQty"].Value != null && int.TryParse(row.Cells["TotalQty"].Value.ToString(), out int qty))
                {
                    totalQtySum += qty;
                }
            }
            totalSaleQty.Text = totalQtySum.ToString();
            //Total Qty in Sale Histoyr End

            //Total Sale Amount in Sale History Start           
            int totalSaleAmt = 0;

            foreach (DataGridViewRow row in sale_data.Rows)
            {
                if (row.Cells["NetAmt"].Value != null && int.TryParse(row.Cells["NetAmt"].Value.ToString(), out int amt))
                {
                    totalSaleAmt += amt;
                }
            }
            totalSaleAmount.Text = totalSaleAmt.ToString();
            //Total Sale Amount in Sale Histoyr End

            con.Close();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockCode stockcode = new StockCode();
            stockcode.ShowDialog();

            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void add_sale_Click(object sender, EventArgs e)
        {

            SetInvoiceNumber(con);

        }

        //set invoice number       

        public void SetInvoiceNumber(SqlConnection con)
        {
            try
            {
                con.Open();

                // Step 1: Get the latest row ID from the database table
                int latestId = GetLatestRowId(con);

                // Step 2: Calculate the invoice number
                string invoiceNumber = CalculateInvoiceNumber(latestId);

                SaleForm saleForm = new SaleForm();
                saleForm.doc_id.Text = invoiceNumber;
                saleForm.hideField.Text = 0.ToString();
                saleForm.pay_type.SelectedIndex = 0;
                saleForm.ShowDialog();

                Application.Exit();


                con.Close(); // Close the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting invoice number: " + ex.Message);
            }
        }


        private int GetLatestRowId(SqlConnection con)
        {
            int latestId = 0;

            string query = "SELECT MAX(id) FROM Sale_head";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out latestId))
                {
                    // Latest ID retrieved successfully
                }
            }

            return latestId;
        }

        private string CalculateInvoiceNumber(int latestId)
        {
            DateTime localDate = DateTime.Now;

            string invoiceNumber = string.Format("{0}{1}{2}{3}", "INV", localDate.Year % 100, localDate.Month.ToString("00"), latestId + 1000);
            return invoiceNumber;
        }

        //close set invoice number

        //sale history start
        private void SaleHistory(object sender, EventArgs e)
        {

        }
        //sale history end



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sale_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void purchase_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sale_Click_1(object sender, EventArgs e)
        {
            sale_data.Visible = true;
            sale_lavel.Visible = true;
            add_sale.Visible = true;
            purchase_data.Visible = false;
            pur_lavel.Visible = false;
            add_purchase.Visible = false;
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            sale_data.Visible = false;
            sale_lavel.Visible = false;
            add_sale.Visible = false;
            purchase_data.Visible = true;
            pur_lavel.Visible = true;
            add_purchase.Visible = true;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }




        //Delete Invoice start
        private void SH_Delete_Click(object sender, EventArgs e)
        {
            if (sale_data.SelectedRows.Count > 0)
            {
                int selected = sale_data.SelectedRows[0].Index; // Get the index of the selected row
                string selectedDoc = sale_data.Rows[selected].Cells[1].Value?.ToString();

                if (!string.IsNullOrEmpty(selectedDoc))
                {
                    con.Open();

                    // Get the tranid corresponding to the selected docid
                    SqlCommand getTranidCmd = new SqlCommand("SELECT id FROM Sale_head WHERE docid = @DocId", con);
                    getTranidCmd.Parameters.AddWithValue("@DocId", selectedDoc);
                    object tranidObj = getTranidCmd.ExecuteScalar();

                    if (tranidObj != null && int.TryParse(tranidObj.ToString(), out int tranid))
                    {
                        // Delete from Sale_det using tranid
                        SqlCommand deleteSaleDetCmd = new SqlCommand("DELETE FROM Sale_det WHERE tranid = @TranId", con);
                        deleteSaleDetCmd.Parameters.AddWithValue("@TranId", tranid);
                        deleteSaleDetCmd.ExecuteNonQuery();

                        // Delete from Sale_head using docid
                        SqlCommand deleteSaleCmd = new SqlCommand("DELETE FROM Sale_head WHERE docid = @DocId", con);
                        deleteSaleCmd.Parameters.AddWithValue("@DocId", selectedDoc);
                        deleteSaleCmd.ExecuteNonQuery();

                        MessageBox.Show("Delete Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Transaction ID not found!");
                    }

                    con.Close();

                    Form1 loadform = new Form1();
                    loadform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selected document is null or empty!");
                }
            }
            else
            {
                MessageBox.Show("No row selected!");
            }
        }
        //Delete Invoice end

        //select data for update Start

        private void button6_Click(object sender, EventArgs e)
        {
            if (sale_data.SelectedRows.Count > 0)
            {
                int selected = sale_data.SelectedRows[0].Index; // Get the index of the selected row
                string selectedDoc = sale_data.Rows[selected].Cells[1].Value?.ToString(); // Use ?. to handle possible null value

                if (!string.IsNullOrEmpty(selectedDoc))
                {

                    con.Open();

                    // Use parameterized query to prevent SQL injection
                    SqlCommand getTranidCmd = new SqlCommand("SELECT * FROM Sale_head WHERE docid = @DocId", con);
                    getTranidCmd.Parameters.AddWithValue("@DocId", selectedDoc);
                    SqlDataReader reader = getTranidCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        SaleForm updateForm = new SaleForm();
                       

                        // Fill the SaleForm controls with data from the Sale_head table
                        updateForm.inv_date.Value = Convert.ToDateTime(reader["inv_date"]);
                        updateForm.doc_id.Text = reader["docid"].ToString();
                        updateForm.customer.Text = reader["customer"].ToString();
                        updateForm.pay_type.SelectedItem = reader["pay_type"].ToString();
                        updateForm.qty.Text = reader["total_qty"].ToString();
                        updateForm.net_amt.Text = reader["net_amt"].ToString();
                        updateForm.hideField.Text = 1.ToString();

                        int docid = Convert.ToInt32(reader["id"]);

                        reader.Close();

                        // Use parameterized query for security and performance
                        SqlDataAdapter getSaleDet = new SqlDataAdapter("SELECT code, description, qty, sprice, amount FROM Sale_det WHERE tranid = @TranId", con);
                        getSaleDet.SelectCommand.Parameters.AddWithValue("@TranId", docid);

                        DataSet ds = new DataSet();
                        getSaleDet.Fill(ds, "Sale_det");

                        DataTable dt = ds.Tables["Sale_det"];

                        // Clear existing rows in the DataGridView
                        //updateForm.dataGridView1.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            // Add a new row to the DataGridView
                            updateForm.dataGridView1.Rows.Add(
                                row["code"].ToString(),
                                row["description"].ToString(),
                                row["qty"].ToString(),
                                row["sprice"].ToString(),
                                row["amount"].ToString()
                            );
                        }

                        updateForm.codeFindLvl.Visible = false;
                        updateForm.code_fine.Visible = false;

                        updateForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Document ID not found!");
                        reader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Selected document is null or empty!");
                }
            }
            else
            {
                MessageBox.Show("No row selected!");
            }
        }

        private void stock_status_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developing Stage!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developing Stage!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developing Stage!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developing Stage!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developing Stage!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developing Stage!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void add_purchase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developing Stage!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //select data for update End

    }
}

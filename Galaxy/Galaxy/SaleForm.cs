using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaxy
{
    public partial class SaleForm : Form
    {

        private string connectionString = "Data Source=EIMONKYAW;Initial Catalog=galaxy;Persist Security Info=True;User ID=sa;Password=9@1@84;Encrypt=True;TrustServerCertificate=True";

     

        public SaleForm()
        {
            InitializeComponent();
            //SetInvoiceNumber();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form = new Form1();
            form.ShowDialog();

            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private (string Code, string Description, int Quantity, decimal SalePrice, decimal Amount) FetchDataFromDatabase(string code)
        {
            string description = string.Empty;
            int quantity = 0;
            decimal salePrice = 0;
            decimal amount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Usr_code WHERE code = @code"; 
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@code", code);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                description = reader["description"].ToString();
                                quantity = 1;
                                salePrice = Convert.ToDecimal(reader["sprice"]);
                                amount = Convert.ToDecimal(reader["sprice"]) * quantity;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data from database: " + ex.Message);
            }

            return (code, description, quantity, salePrice, amount);
        }
        //qty enter calculate start
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["quenty"].Index) // Assuming "quenty" is the quantity column name
            {
                DataGridViewCell qtyCell = dataGridView1.Rows[e.RowIndex].Cells["quenty"];
                DataGridViewCell spriceCell = dataGridView1.Rows[e.RowIndex].Cells["sprice"];

                if (qtyCell.Value != null && spriceCell.Value != null &&
                    int.TryParse(qtyCell.Value.ToString(), out int qty) &&
                    decimal.TryParse(spriceCell.Value.ToString(), out decimal sprice))
                {
                    decimal amount = qty * sprice;
                    dataGridView1.Rows[e.RowIndex].Cells["amount"].Value = amount;

                    UpdateNetAmount();
                    UpdateTotalQuantity();
                }
            }
        }

        private void CodeFineEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string code = code_fine.Text.Trim();
                if (!string.IsNullOrEmpty(code))
                {
                    // Fetch data from the database based on the entered code ID
                    var data = FetchDataFromDatabase(code);

                    if (!string.IsNullOrEmpty(data.Description))
                    {
                        // Add a new row to the DataGridView and fill it with the fetched data
                        dataGridView1.Rows.Add(data.Code, data.Description, data.Quantity, data.SalePrice, data.Amount);

                        //code find text box is clear
                        code_fine.Clear();

                        // Calculate net amount and total quantity
                        UpdateNetAmount();
                        UpdateTotalQuantity();
                    }
                    else
                    {
                        MessageBox.Show("No data found for the entered code.");
                    }
                }
            }
        }

        private void UpdateNetAmount()
        {
            decimal netAmount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["amount"].Value != null && decimal.TryParse(row.Cells["amount"].Value.ToString(), out decimal amount))
                {
                    netAmount += amount;
                }
            }

            net_amt.Text = netAmount.ToString();
        }

        private void UpdateTotalQuantity()
        {
            int totalQuantity = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["quenty"].Value != null && int.TryParse(row.Cells["quenty"].Value.ToString(), out int qty))
                {
                    totalQuantity += qty;
                }
            }

            qty.Text = totalQuantity.ToString();
        }

        //qty enter calculate end

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
       
        private void button1_Click(object sender, EventArgs e)
        {

      
            SqlConnection connection = new SqlConnection(connectionString);

            //sale head insert start
            connection.Open();

            int totalQty = int.Parse(qty.Text);
            int netAmt = int.Parse(net_amt.Text);
            int hide = int.Parse(hideField.Text);

            if(hide == 0)
            {
                if (totalQty > 0)
                {
                    String insertquery = "INSERT INTO Sale_head (inv_date,docid, customer,pay_type,total_qty, net_amt) VALUES ('" + inv_date.Value + "', '" + doc_id.Text + "', '" + customer.Text + "', '" + pay_type.SelectedItem + "'," + totalQty + " , " + netAmt + ")";
                    SqlCommand saleheadcmd = new SqlCommand(insertquery, connection);

                    saleheadcmd.ExecuteNonQuery();

                    customer.Clear();

                    //sale head insert end

                    //sale det insert start
                    SqlCommand getMaxTranIdCmd = new SqlCommand("SELECT MAX(id) FROM Sale_head", connection);
                    int tranid = Convert.ToInt32(getMaxTranIdCmd.ExecuteScalar());


                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Sale_det(tranid, code, description, qty, sprice, amount) VALUES (" + tranid + ",'" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[1].Value + "', " + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + ", " + int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) + ", " + int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) + ") ", connection);

                        cmd.ExecuteNonQuery();

                    }

                    connection.Close();

                    dataGridView1.Rows.Clear();
                    this.Hide();
                    Form1 main = new Form1();
                    main.SetInvoiceNumber(connection);

                    SaleForm sf = new SaleForm();
                    sf.ShowDialog();


                    //sale det insert end
                }
                else
                {
                    MessageBox.Show("Fill Transactions!");
                }
            }
            else
            {
                String docid = doc_id.Text;
               
                String updateSaleHead = "UPDATE Sale_head SET inv_date='" + inv_date.Value + "',docid='"+doc_id.Text+"', customer='" + customer.Text + "', pay_type='" + pay_type.SelectedItem.ToString() + "', total_qty='"+totalQty+ "', net_amt='"+ netAmt + "' WHERE docid='"+docid+"'";
                SqlCommand updateHead = new SqlCommand(updateSaleHead, connection);
                updateHead.ExecuteNonQuery();

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    SqlCommand getTranId = new SqlCommand("SELECT id FROM Sale_head WHERE docid='"+docid+"'", connection);
                    int tranid = Convert.ToInt32(getTranId.ExecuteScalar());


                    string code = dataGridView1.Rows[i].Cells[0].Value.ToString();

                    String UpdateSaleDet = "UPDATE Sale_det SET qty='" + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + "', amount='"+ int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) + "' WHERE tranid='"+tranid+"' AND code='"+code+"'";
                    SqlCommand updateDet = new SqlCommand(UpdateSaleDet, connection);
                    updateDet.ExecuteNonQuery();

                    MessageBox.Show("Sale Voucher is updated!");
                    this.Hide();
                    Form1 form = new Form1();
                    form.ShowDialog();

                }

            }

            
        }    

        


    }
}

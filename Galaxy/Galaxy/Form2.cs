using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Galaxy
{
    public partial class StockCode : Form
    {
        public StockCode()
        {
            InitializeComponent();
           
        }


        SqlConnection con = new SqlConnection("Data Source=EIMONKYAW;Initial Catalog=galaxy;User ID=sa;Password=9@1@84;TrustServerCertificate=True");



        private void save_code_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView1.RowCount -2; i++)
            {
                string code = dataGridView1.Rows[i].Cells[0].Value?.ToString();

               
                if (string.IsNullOrEmpty(code))
                {
                    MessageBox.Show("Code cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                

                if (IsCodeExists(code))
                {
                    MessageBox.Show("Code '" + code + "' already exists.", "Code Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else
                {
                
                    // Insert the data into the database
                    SqlCommand cmd = new SqlCommand("INSERT INTO Usr_code(code, description, short, pprice, sprice) VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[1].Value + "', '" + dataGridView1.Rows[i].Cells[2].Value + "', '" + dataGridView1.Rows[i].Cells[3].Value + "', '" + dataGridView1.Rows[i].Cells[4].Value + "') ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Code Save Successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }


            }

            dataGridView1.Rows.Clear();

            StockCode loadStock = new StockCode();
            loadStock.ShowDialog();
        }

        private bool IsCodeExists(string code)
        {
            
            bool exists = false;

            try
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM Usr_code WHERE code = @code";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@code", code);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    exists = true;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking code existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider logging the error or handling it appropriately
            }

            return exists;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.ShowDialog();

            Application.Exit();

        }


        private void StockCode_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT code AS Code, description AS Description, short AS Short, pprice AS PurchasePrice, sprice AS SellingPrice FROM Usr_code", con);
            DataSet ds = new DataSet();

            sda.Fill(ds, "Usr_code");

            dataGridView2.DataSource = ds.Tables["Usr_code"];

            // Rename the column headers
            dataGridView2.Columns["Code"].HeaderText = "Code";
            dataGridView2.Columns["Description"].HeaderText = "Description";
            dataGridView2.Columns["Short"].HeaderText = "Short";
            dataGridView2.Columns["PurchasePrice"].HeaderText = "PPrice";
            dataGridView2.Columns["SellingPrice"].HeaderText = "SPrice";

            con.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int col = dataGridView1.CurrentCell.ColumnIndex;//5
                int row = dataGridView1.CurrentCell.RowIndex;//1

                if (col < dataGridView1.Columns.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[col + 1];
                }
                else if (col == dataGridView1.Columns.Count - 1)
                {
                    dataGridView1.Rows.Add(); // Add a new row
                    dataGridView1.CurrentCell = dataGridView1.Rows[row + 1].Cells[0]; // Move to the first cell of the new row
                }

                e.Handled = true; // Mark the event as handled to prevent the default behavior (move to next row)
                dataGridView1.BeginEdit(true);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void CodeEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CodeEnterData(object sender, DataGridViewCellEventArgs e)
        {
            // Defer the cell navigation using BeginInvoke to avoid reentrant calls
            BeginInvoke(new Action(() =>
            {
                int col = e.ColumnIndex;
                int row = e.RowIndex;

                if (col < dataGridView1.Columns.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[col + 1];
                }
                else if (col == dataGridView1.Columns.Count - 1)
                {
                    dataGridView1.Rows.Add(); // Add a new row
                    dataGridView1.CurrentCell = dataGridView1.Rows[row + 1].Cells[0]; // Move to the first cell of the new row
                }

            }));
        }

        private void DeleteCode_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedRows[0].Index; // Get the index of the selected row
                string selectedCode = dataGridView2.Rows[selectedRowIndex].Cells[0].Value?.ToString(); // Assuming code is in the second column (index 1)

                if (!string.IsNullOrEmpty(selectedCode))
                {
                    try
                    {
                        con.Open();
                        SqlCommand deleteCode = new SqlCommand("DELETE FROM Usr_code WHERE code = @Code", con);
                        deleteCode.Parameters.AddWithValue("@Code", selectedCode);
                        int rowsAffected = deleteCode.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Code deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                        }
                        else
                        {
                            MessageBox.Show("No code deleted. Code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Selected code is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

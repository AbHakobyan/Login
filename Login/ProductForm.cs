using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ProductForm : Form
    {
        DataAccess con = new DataAccess();

        public ProductForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonProductCategoryBord_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void buttonProductLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void buttonProductLogout_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void buttonProductLogout_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
        }

        private void buttonProductLogout_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Orange;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetCategory()
        {
            string selectcategory = "SELECT * FROM Category";
            SqlCommand cmd = new SqlCommand(selectcategory, con.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBoxProductCategory.DataSource = dt;
            comboBoxProductCategory.ValueMember = "CategoryName";
            comboBoxCategory.DataSource = dt;
            comboBoxCategory.ValueMember = "CategoryName";
        }

        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxProductID.Text == "" || textBoxProductName.Text == ""
                || textBoxProductPrice.Text == "" || textBoxProductQuantity.Text == "" || comboBoxProductCategory.Text == "")
                {
                    MessageBox.Show("Missing information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string addquery = "INSERT INTO Product(Prodid,ProdName,ProdPrice,ProdQuantity,ProdCategory) " +
                        "VALUES(@id,@name,@price,@qt,@cat)";
                    SqlCommand cmd = new SqlCommand(addquery, con.GetCon());
                    cmd.Parameters.AddWithValue("@id", TextBoxProductID.Text);
                    cmd.Parameters.AddWithValue("@name", textBoxProductName.Text);
                    cmd.Parameters.AddWithValue("@price", textBoxProductPrice.Text);
                    cmd.Parameters.AddWithValue("@qt", textBoxProductQuantity.Text);
                    cmd.Parameters.AddWithValue("@cat", comboBoxProductCategory.SelectedValue.ToString());
                    con.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added Succsesfuly", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.CloseCon();
                    GetTable();
                    Cleare();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Cleare()
        {
            TextBoxProductID.Clear();
            textBoxProductName.Clear();
            textBoxProductPrice.Clear();
            textBoxProductQuantity.Clear();
            comboBoxCategory.SelectedIndex = 0;
        }

        private void GetTable()
        {
            string selectcategory = "SELECT * FROM Product";
            SqlCommand cmd = new SqlCommand(selectcategory, con.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewProduct.DataSource = dt;
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                TextBoxProductID.Text = dataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString();
                textBoxProductName.Text = dataGridViewProduct.SelectedRows[0].Cells[1].Value.ToString();
                textBoxProductPrice.Text = dataGridViewProduct.SelectedRows[0].Cells[2].Value.ToString();
                textBoxProductQuantity.Text = dataGridViewProduct.SelectedRows[0].Cells[3].Value.ToString();
                comboBoxProductCategory.SelectedValue = dataGridViewProduct.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please Select Row");
            }
        }

        private void buttonProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxProductID.Text == "" || textBoxProductName.Text == ""
                || textBoxProductPrice.Text == "" || textBoxProductQuantity.Text == "" || comboBoxProductCategory.Text == "")
                {
                    MessageBox.Show("Missing information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updatequery = "UPDATE Product SET ProdName=@name,ProdPrice=@price,ProdQuantity=@qt,ProdCategory=@cat WHERE ProdId=@id";
                    SqlCommand cmd = new SqlCommand(updatequery, con.GetCon());
                    cmd.Parameters.AddWithValue("@id", TextBoxProductID.Text);
                    cmd.Parameters.AddWithValue("@name", textBoxProductName.Text);
                    cmd.Parameters.AddWithValue("@price", textBoxProductPrice.Text);
                    cmd.Parameters.AddWithValue("@qt", textBoxProductQuantity.Text);
                    cmd.Parameters.AddWithValue("@cat", comboBoxProductCategory.SelectedValue.ToString());
                    con.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Update Succsesfuly", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.CloseCon();
                    GetTable();
                    Cleare();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxProductID.Text == "")
                {
                    MessageBox.Show("Missing information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deletequery = "DELETE FROM Product WHERE ProdId=" + TextBoxProductID.Text + "";
                    SqlCommand cmd = new SqlCommand(deletequery, con.GetCon());
                    con.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Delete Succsesfuly", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.CloseCon();
                    GetTable();
                    Cleare();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProductAddbox_Click(object sender, EventArgs e)
        {
            GetTable();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectcategory = "SELECT * FROM Product WHERE ProdCategory=@cat";
            SqlCommand cmd = new SqlCommand(selectcategory, con.GetCon());
            cmd.Parameters.AddWithValue("cat", comboBoxCategory.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewProduct.DataSource = dt;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor= Color.White;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marketDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.marketDataSet.Category);
            GetTable();
            GetCategory();
        }
    }
}

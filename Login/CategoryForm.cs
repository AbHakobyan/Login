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

namespace Login
{
    public partial class CategoryForm : Form
    {
        DataAccess con = new DataAccess();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void GetTable()
        {
            string selectcategory = "SELECT * FROM Category";
            SqlCommand cmd = new SqlCommand(selectcategory,con.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewCategory.DataSource = dt;

        }

        private void buttonCategoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxCategoryID.Text == "" || textBoxCategoryName.Text == "" || textBoxCategoryDescription.Text == "")
                {
                    MessageBox.Show("Missing information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertquery =
                        "INSERT INTO Category(CategoryId,CategoryName,CategoryDescription)" +
                        "VALUES(@id,@name,@des)";
                    SqlCommand cmd = new SqlCommand(insertquery, con.GetCon());
                    cmd.Parameters.AddWithValue("@id", TextBoxCategoryID.Text);
                    cmd.Parameters.AddWithValue("@name", textBoxCategoryName.Text);
                    cmd.Parameters.AddWithValue("@des", textBoxCategoryDescription.Text);
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

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void buttonCategoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxCategoryID.Text == "" || textBoxCategoryName.Text == "" || textBoxCategoryDescription.Text == "")
                {
                    MessageBox.Show("Missing information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updatequery = "UPDATE Category SET CategoryName=@name," +
                    "CategoryDescription=@des WHERE CategoryId=@id";
                    SqlCommand cmd = new SqlCommand(updatequery, con.GetCon());
                    cmd.Parameters.AddWithValue("@name", textBoxCategoryName.Text);
                    cmd.Parameters.AddWithValue("@des", textBoxCategoryDescription.Text);
                    cmd.Parameters.AddWithValue("@id", TextBoxCategoryID.Text);
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


        private void Cleare()
        {
            TextBoxCategoryID.Clear();
            textBoxCategoryName.Clear();
            textBoxCategoryDescription.Clear();
        }

        private void buttonCategoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxCategoryID.Text == "")
                {
                    MessageBox.Show("Missing information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deletequery = "DELETE FROM Category WHERE CategoryId=" + TextBoxCategoryID.Text + "";
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

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
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

        private void buttonProductLogout_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Orange;
        }

        private void buttonProductLogout_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
        }

        private void buttonCategoryProductBord_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCategory.SelectedRows.Count > 0)
            {
                textBoxCategoryDescription.Text = dataGridViewCategory.SelectedRows[0].Cells[2].Value.ToString();
                textBoxCategoryName.Text = dataGridViewCategory.SelectedRows[0].Cells[1].Value.ToString();
                TextBoxCategoryID.Text = dataGridViewCategory.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please Select Row");
            }
        }
    }
}

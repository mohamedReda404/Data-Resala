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

namespace Data_Resala
{
    public partial class Form18 : Form
    {
        public string connectionString = "Server=desktop-6tshlsd\\sqlexpress; Database=Resala; Integrated Security=True;";

        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string status = textBox2.Text;
            string nationalID = textBox3.Text;
            string maritalStatus = textBox4.Text;
            string phone1 = textBox5.Text;
            string phone2 = textBox6.Text;
            string area = textBox7.Text;
            string address = textBox8.Text;
            string explorationDate = textBox9.Text;
            string evaluationDate = textBox10.Text;
            string evaluation = textBox11.Text;

            // Validate that required fields are not empty (you can add more validations as needed)
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nationalID) || string.IsNullOrEmpty(explorationDate))
            {
                MessageBox.Show("اكمل البيانات للحفظ");
                return;
            }

            // Call method to save data
            SaveData(name, status, nationalID, maritalStatus, phone1, phone2, area, address, explorationDate, evaluationDate, evaluation);
        }

        // Method to save data in the database
        private void SaveData(string name, string status, string nationalID, string maritalStatus, string phone1, string phone2, string area, string address, string explorationDate, string evaluationDate, string evaluation)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to insert the data into the UserData table
                    string query = "INSERT INTO t18 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) "
                        + "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters for the query
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@NationalID", nationalID);
                        cmd.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                        cmd.Parameters.AddWithValue("@Phone1", phone1);
                        cmd.Parameters.AddWithValue("@Phone2", phone2);
                        cmd.Parameters.AddWithValue("@Area", area);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                        cmd.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                        cmd.Parameters.AddWithValue("@Evaluation", evaluation);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("تم حفظ البيانات");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ :" + ex.Message);
            }
        }



        public void ConnectToDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }


        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM t18"; // Query to get all data
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Set the data source of the DataGridView
                    dataGridView22.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView22_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

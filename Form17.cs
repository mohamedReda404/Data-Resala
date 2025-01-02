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
    public partial class Form17 : Form
    {
        public string connectionString = "Server=desktop-6tshlsd\\sqlexpress; Database=Resala; Integrated Security=True;";

        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string status = comboBox1.Text;
            string nationalID = textBox3.Text;
            string maritalStatus = comboBox2.Text;
            string phone1 = textBox5.Text;
            string phone2 = textBox6.Text;
            string area = comboBox3.Text;
            string address = textBox8.Text;
            string explorationDate = textBox9.Text;
            string evaluationDate = textBox10.Text;
            string evaluation = comboBox4.Text;

            // Validate that required fields are not empty (you can add more validations as needed)
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nationalID) || string.IsNullOrEmpty(explorationDate))
            {
                MessageBox.Show("اكمل البيانات للحفظ");
                return;
            }

            // Call method to save data
          //  SaveData(name, status, nationalID, maritalStatus, phone1, phone2, area, address, explorationDate, evaluationDate, evaluation);
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
                    string query = "INSERT INTO ch_1 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) "
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
                textBox1.Text = " ";
                comboBox1.Text = " ";
                textBox3.Text = " ";
                comboBox2.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                comboBox3.Text = " ";
                textBox8.Text = " ";
                textBox9.Text = " ";
                textBox10.Text = " ";
                comboBox4.Text = " ";
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
                    string query = "SELECT * FROM ch_1"; // Query to get all data
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

        private void button4_Click(object sender, EventArgs e)
        {

            string nameToSearch = textBox1.Text;
            string statusToSearch = comboBox1.Text;
            string nationalIDToSearch = textBox3.Text;
            string maritalStatusToSearch = comboBox2.Text;
            string phone1ToSearch = textBox5.Text;
            string phone2ToSearch = textBox6.Text;
            string areaToSearch = comboBox3.Text;
            string addressToSearch = textBox8.Text;
            string explorationDateToSearch = textBox9.Text;
            string evaluationDateToSearch = textBox10.Text;
            string evaluationToSearch = comboBox4.Text;

            // استعلام SQL مرن للبحث
            SearchWithConditions(nameToSearch, statusToSearch, nationalIDToSearch, maritalStatusToSearch,
                                 phone1ToSearch, phone2ToSearch, areaToSearch, addressToSearch,
                                 explorationDateToSearch, evaluationDateToSearch, evaluationToSearch);
        }


        private void SearchWithConditions(string name, string status, string nationalID, string maritalStatus,
                                      string phone1, string phone2, string area, string address,
                                      string explorationDate, string evaluationDate, string evaluation)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // بناء استعلام SQL مرن حسب المدخلات
                    string query = "SELECT * FROM ch_1 WHERE 1 = 1"; // استخدام 1 = 1 كقاعدة ثابتة لجعل شروط البحث مرنة

                    // إضافة شروط البحث بناءً على المدخلات
                    if (!string.IsNullOrEmpty(name))
                    {
                        query += " AND الاسم LIKE @Name";
                    }
                    if (!string.IsNullOrEmpty(status))
                    {
                        query += " AND الحالة LIKE @Status";
                    }
                    if (!string.IsNullOrEmpty(nationalID))
                    {
                        query += " AND الرقم_القومي LIKE @NationalID";
                    }
                    if (!string.IsNullOrEmpty(maritalStatus))
                    {
                        query += " AND الحالة_الاجتماعية LIKE @MaritalStatus";
                    }
                    if (!string.IsNullOrEmpty(phone1))
                    {
                        query += " AND الهاتف_1 LIKE @Phone1";
                    }
                    if (!string.IsNullOrEmpty(phone2))
                    {
                        query += " AND الهاتف_2 LIKE @Phone2";
                    }
                    if (!string.IsNullOrEmpty(area))
                    {
                        query += " AND المنطقة LIKE @Area";
                    }
                    if (!string.IsNullOrEmpty(address))
                    {
                        query += " AND العنوان_بالتفصيل LIKE @Address";
                    }
                    if (!string.IsNullOrEmpty(explorationDate))
                    {
                        query += " AND تاريخ_الاستكشاف LIKE @ExplorationDate";
                    }
                    if (!string.IsNullOrEmpty(evaluationDate))
                    {
                        query += " AND تاريخ_التقييم LIKE @EvaluationDate";
                    }
                    if (!string.IsNullOrEmpty(evaluation))
                    {
                        query += " AND التقييم LIKE @Evaluation";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // إضافة المعاملات للبحث
                        if (!string.IsNullOrEmpty(name)) cmd.Parameters.AddWithValue("@Name", "%" + name + "%");
                        if (!string.IsNullOrEmpty(status)) cmd.Parameters.AddWithValue("@Status", "%" + status + "%");
                        if (!string.IsNullOrEmpty(nationalID)) cmd.Parameters.AddWithValue("@NationalID", "%" + nationalID + "%");
                        if (!string.IsNullOrEmpty(maritalStatus)) cmd.Parameters.AddWithValue("@MaritalStatus", "%" + maritalStatus + "%");
                        if (!string.IsNullOrEmpty(phone1)) cmd.Parameters.AddWithValue("@Phone1", "%" + phone1 + "%");
                        if (!string.IsNullOrEmpty(phone2)) cmd.Parameters.AddWithValue("@Phone2", "%" + phone2 + "%");
                        if (!string.IsNullOrEmpty(area)) cmd.Parameters.AddWithValue("@Area", "%" + area + "%");
                        if (!string.IsNullOrEmpty(address)) cmd.Parameters.AddWithValue("@Address", "%" + address + "%");
                        if (!string.IsNullOrEmpty(explorationDate)) cmd.Parameters.AddWithValue("@ExplorationDate", "%" + explorationDate + "%");
                        if (!string.IsNullOrEmpty(evaluationDate)) cmd.Parameters.AddWithValue("@EvaluationDate", "%" + evaluationDate + "%");
                        if (!string.IsNullOrEmpty(evaluation)) cmd.Parameters.AddWithValue("@Evaluation", "%" + evaluation + "%");

                        // تنفيذ الاستعلام
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // عرض النتائج في DataGridView
                        dataGridView22.DataSource = dt;

                        // في حال لم يتم العثور على نتائج
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("لا توجد نتائج للبحث");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في البحث: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string status = comboBox1.Text;
            string nationalID = textBox3.Text;
            string maritalStatus = comboBox2.Text;
            string phone1 = textBox5.Text;
            string phone2 = textBox6.Text;
            string area = comboBox3.Text;
            string address = textBox8.Text;
            string explorationDate = textBox9.Text;
            string evaluationDate = textBox10.Text;
            string evaluation = comboBox4.Text;

            // Validate that required fields are not empty (you can add more validations as needed)
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nationalID) || string.IsNullOrEmpty(explorationDate))
            {
                MessageBox.Show("اكمل البيانات للحفظ");
                return;
            }

            // Call method to save data
            SaveData(name, status, nationalID, maritalStatus, phone1, phone2, area, address, explorationDate, evaluationDate, evaluation);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string status = comboBox1.Text;
            string nationalID = textBox3.Text;
            string maritalStatus = comboBox2.Text;
            string phone1 = textBox5.Text;
            string phone2 = textBox6.Text;
            string area = comboBox3.Text;
            string address = textBox8.Text;
            string explorationDate = textBox9.Text;
            string evaluationDate = textBox10.Text;
            string evaluation = comboBox4.Text;

            // التحقق من أن جميع الحقول الأساسية مدخلة
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nationalID) || string.IsNullOrEmpty(explorationDate))
            {
                MessageBox.Show("يرجى إدخال جميع البيانات المطلوبة للتعديل.");
                return;
            }

            // استدعاء وظيفة لتعديل البيانات في قاعدة البيانات
            UpdateData(name, status, nationalID, maritalStatus, phone1, phone2, area, address, explorationDate, evaluationDate, evaluation);
        }

        private void UpdateData(string name, string status, string nationalID, string maritalStatus,
                             string phone1, string phone2, string area, string address,
                             string explorationDate, string evaluationDate, string evaluation)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // استعلام التحديث باستخدام الرقم القومي لتحديد السطر
                    string query = "UPDATE ch_1 SET الاسم = @Name, الحالة = @Status, الحالة_الاجتماعية = @MaritalStatus, " +
                                   "الهاتف_1 = @Phone1, الهاتف_2 = @Phone2, المنطقة = @Area, العنوان_بالتفصيل = @Address, " +
                                   "تاريخ_الاستكشاف = @ExplorationDate, تاريخ_التقييم = @EvaluationDate, التقييم = @Evaluation " +
                                   "WHERE الرقم_القومي = @NationalID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // إضافة المعاملات للبحث
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

                        // تنفيذ الاستعلام
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("تم تعديل البيانات بنجاح");
                LoadData();  // تحميل البيانات بعد التعديل لتحديث ال DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تعديل البيانات: " + ex.Message);
            }
        

    }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string NationalID = textBox3.Text;

            if (string.IsNullOrEmpty(NationalID))  // التأكد من أنه تم تحديد سطر للحذف
            {
                MessageBox.Show("يرجى اختيار شخص للحذف من الجدول.");
                return;
            }

            // تأكيد الحذف من قبل المستخدم
            DialogResult dialogResult = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا السطر؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // استدعاء وظيفة لحذف السطر من قاعدة البيانات
                DeleteData(NationalID);
                textBox1.Text = " ";
                comboBox1.Text = " ";
                textBox3.Text = " ";
                comboBox2.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                comboBox3.Text = " ";
                textBox8.Text = " ";
                textBox9.Text = " ";
                textBox10.Text = " ";
                comboBox4.Text = " ";
                // textBox12.Text = " ";

            }
        }

        private void DeleteData(string nationalID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // استعلام الحذف باستخدام الرقم القومي
                    string query = "DELETE FROM ch_1 WHERE الرقم_القومي = @NationalID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // إضافة المعامل للبحث
                        cmd.Parameters.AddWithValue("@NationalID", nationalID);

                        // تنفيذ الاستعلام
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("تم حذف البيانات بنجاح");
                LoadData();  // تحميل البيانات بعد الحذف لتحديث DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في حذف البيانات: " + ex.Message);
            }
        }

        private void dataGridView22_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // جلب البيانات من السطر المحدد
                DataGridViewRow row = dataGridView22.Rows[e.RowIndex];

                // تعبئة الحقول بالبيانات من السطر المحدد
                textBox1.Text = row.Cells["الاسم"].Value.ToString();
                comboBox1.Text = row.Cells["الحالة"].Value.ToString();
                textBox3.Text = row.Cells["الرقم_القومي"].Value.ToString();
                comboBox2.Text = row.Cells["الحالة_الاجتماعية"].Value.ToString();
                textBox5.Text = row.Cells["الهاتف_1"].Value.ToString();
                textBox6.Text = row.Cells["الهاتف_2"].Value.ToString();
                comboBox3.Text = row.Cells["المنطقة"].Value.ToString();
                textBox8.Text = row.Cells["العنوان_بالتفصيل"].Value.ToString();
                textBox9.Text = row.Cells["تاريخ_الاستكشاف"].Value.ToString();
                textBox10.Text = row.Cells["تاريخ_التقييم"].Value.ToString();
                comboBox4.Text = row.Cells["التقييم"].Value.ToString();

                // يمكنك تخزين الرقم القومي أو أي معرف آخر لاستخدامه لاحقاً
                // comboBox3.Text = row.Cells["الرقم_القومي"].Value.ToString();  // تخزين الرقم القومي لاستخدامه في التعديل أو الحذف
            }
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

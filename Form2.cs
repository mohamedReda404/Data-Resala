using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Data_Resala.ResalaDataSet;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.MonthCalendar;
namespace Data_Resala
{
    public partial class Form2 : Form
    {
        public string connectionString = "Server=desktop-6tshlsd\\sqlexpress; Database=Resala; Integrated Security=True;";
        public Form2()

        {
         

        InitializeComponent();

            comboBox1.Items.Add("مستمر");
            comboBox1.Items.Add("اعادة أستكشاف");
            comboBox1.Items.Add("أرشيف");



            comboBox2.Items.Add("أعزب");
            comboBox2.Items.Add("أنسة");
            comboBox2.Items.Add("متزوج");
            comboBox2.Items.Add("متزوجة");
            comboBox2.Items.Add("أرمل");
            comboBox2.Items.Add("أرملة");
            comboBox2.Items.Add("مسن");
            comboBox2.Items.Add("مسنة");
            comboBox2.Items.Add("مهجورة");
            comboBox2.Items.Add("أيتام");


            comboBox3.Items.Add("عرب الحارث");
            comboBox3.Items.Add("عزبه الأهالي");
            comboBox3.Items.Add("الجزيرة");
            comboBox3.Items.Add("البرداعة");
            comboBox3.Items.Add("احمد فوزي");
            comboBox3.Items.Add("شركس");
            comboBox3.Items.Add("ابو الغيط");
            comboBox3.Items.Add("دار الكتب");
            comboBox3.Items.Add("سندبيس");
            comboBox3.Items.Add("عزبه الخيمي");
            comboBox3.Items.Add("مسلم");
            comboBox3.Items.Add("الشواربي");
            comboBox3.Items.Add("شلقان");
            comboBox3.Items.Add("شارع 14");
            comboBox3.Items.Add("الجامع القديم");
            comboBox3.Items.Add("سوق الثلاثاء");
            comboBox3.Items.Add("عزبه الناموس");
            comboBox3.Items.Add("الاخميين");
            comboBox3.Items.Add("عرب ابو الغيط");
            comboBox3.Items.Add("باسوس");
            comboBox3.Items.Add("شراره");
            comboBox3.Items.Add("الرملايه");
            comboBox3.Items.Add("مساكن شلقان");
            comboBox3.Items.Add("الشقرفي");
            comboBox3.Items.Add("قرنفيل");
            comboBox3.Items.Add("عزبة علام");
            comboBox3.Items.Add("عرب ابو راضي");
            comboBox3.Items.Add("عزبه السجن");//قرنفيل//عزبة علام
            comboBox3.Items.Add("عزبه الشيمي");
            comboBox3.Items.Add("الخرس");
            comboBox3.Items.Add("أخري");




            comboBox4.Items.Add("طبي");
            comboBox4.Items.Add("بناء");
            comboBox4.Items.Add("كساء");
            comboBox4.Items.Add("سداد الدين");
            comboBox4.Items.Add("كفاله شهرية");
            comboBox4.Items.Add("عيني");
            comboBox4.Items.Add("مشاريع");
            comboBox4.Items.Add("أسقف");
            comboBox4.Items.Add("أجهزه طبية");
            comboBox4.Items.Add("عرايس");
            comboBox4.Items.Add("زيارات");
            comboBox4.Items.Add("وصلات مياة");
            comboBox4.Items.Add("أيتام");
            comboBox4.Items.Add("طلب مساعده");
            comboBox4.Items.Add("شنط موسمية");
            comboBox4.Items.Add("شنط شهرية");

            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Items.Add("الخيار 1");
            listBox1.Items.Add("الخيار 2");
            listBox1.Items.Add("الخيار 3");
            listBox1.Items.Add("الخيار 4");

            //  comboBox1.Items.Add("مستمر");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // الحصول على الاسم المدخل من الـ TextBox

            /* // ResalaDataSet vv = new ResalaDataSet();
              ResalaEntities2 db = new ResalaEntities2();
              tiby1 t1= new tiby1();
              t1.الاسم=textBox1.Text;
              db.tiby1.Add(t1);
           //   db.SaveChanges();*/

            // الحصول على القيم من TextBox
            // Read data from textboxes
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

        // Method to save data in the database
        private void SaveData(string name, string status, string nationalID, string maritalStatus, string phone1, string phone2, string area, string address, string explorationDate, string evaluationDate, string evaluation)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to insert the data into the UserData table
                    string query = "INSERT INTO tty1 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                   "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

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
                        // cmd.Parameters.AddWithValue("@ExplorationDate", DateTime.ParseExact(evaluationDate, "dd/MM/yyyy", null));
                        // Execute the query
                        cmd.ExecuteNonQuery();



                        ////مجمع البينانات =============================

                        string query20 = "INSERT INTO t20 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                  "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                        using (SqlCommand cmd20 = new SqlCommand(query20, conn))
                        {
                            // Add parameters for the query
                            cmd20.Parameters.AddWithValue("@Name", name);
                            cmd20.Parameters.AddWithValue("@Status", status);
                            cmd20.Parameters.AddWithValue("@NationalID", nationalID);
                            cmd20.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                            cmd20.Parameters.AddWithValue("@Phone1", phone1);
                            cmd20.Parameters.AddWithValue("@Phone2", phone2);
                            cmd20.Parameters.AddWithValue("@Area", area);
                            cmd20.Parameters.AddWithValue("@Address", address);
                            cmd20.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                            cmd20.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                            cmd20.Parameters.AddWithValue("@Evaluation", evaluation);

                            // Execute the query
                            cmd20.ExecuteNonQuery();
                        }

                        //بناء
                        string selectedText = comboBox4.SelectedItem?.ToString();

                        if (selectedText != null && selectedText.Contains("بناء"))
                        {
                            string query3 = "INSERT INTO tb_3 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                  "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                            using (SqlCommand cmd3 = new SqlCommand(query3, conn))
                            {
                                // Add parameters for the query
                                cmd3.Parameters.AddWithValue("@Name", name);
                                cmd3.Parameters.AddWithValue("@Status", status);
                                cmd3.Parameters.AddWithValue("@NationalID", nationalID);
                                cmd3.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                                cmd3.Parameters.AddWithValue("@Phone1", phone1);
                                cmd3.Parameters.AddWithValue("@Phone2", phone2);
                                cmd3.Parameters.AddWithValue("@Area", area);
                                cmd3.Parameters.AddWithValue("@Address", address);
                                cmd3.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                                cmd3.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                                cmd3.Parameters.AddWithValue("@Evaluation", evaluation);

                                // Execute the query
                                cmd3.ExecuteNonQuery();
                            }

                        }


                        //ارشيف=======================================
                        string selectedText_2 = comboBox1.SelectedItem?.ToString();

                        if (selectedText != null && selectedText.Contains("أرشيف"))
                        {
                            string query4 = "INSERT INTO ch_1 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                  "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                            using (SqlCommand cmd4 = new SqlCommand(query4, conn))
                            {
                                // Add parameters for the query
                                cmd4.Parameters.AddWithValue("@Name", name);
                                cmd4.Parameters.AddWithValue("@Status", status);
                                cmd4.Parameters.AddWithValue("@NationalID", nationalID);
                                cmd4.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                                cmd4.Parameters.AddWithValue("@Phone1", phone1);
                                cmd4.Parameters.AddWithValue("@Phone2", phone2);
                                cmd4.Parameters.AddWithValue("@Area", area);
                                cmd4.Parameters.AddWithValue("@Address", address);
                                cmd4.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                                cmd4.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                                cmd4.Parameters.AddWithValue("@Evaluation", evaluation);

                                // Execute the query
                                cmd4.ExecuteNonQuery();
                            }

                        }


                        //كساء========================================
                        string selectedText_3 = comboBox1.SelectedItem?.ToString();

                        if (selectedText != null && selectedText.Contains("كساء"))
                        {
                            string query5 = "INSERT INTO tb_4 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                  "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                            using (SqlCommand cmd5 = new SqlCommand(query5, conn))
                            {
                                // Add parameters for the query
                                cmd5.Parameters.AddWithValue("@Name", name);
                                cmd5.Parameters.AddWithValue("@Status", status);
                                cmd5.Parameters.AddWithValue("@NationalID", nationalID);
                                cmd5.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                                cmd5.Parameters.AddWithValue("@Phone1", phone1);
                                cmd5.Parameters.AddWithValue("@Phone2", phone2);
                                cmd5.Parameters.AddWithValue("@Area", area);
                                cmd5.Parameters.AddWithValue("@Address", address);
                                cmd5.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                                cmd5.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                                cmd5.Parameters.AddWithValue("@Evaluation", evaluation);

                                // Execute the query
                                cmd5.ExecuteNonQuery();
                            }

                        }


                        string selectedText_4 = comboBox1.SelectedItem?.ToString();

                        if (selectedText != null && selectedText.Contains("سداد الدين"))
                        {
                            string query6 = "INSERT INTO tb_5 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                  "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                            using (SqlCommand cmd6 = new SqlCommand(query6, conn))
                            {
                                // Add parameters for the query
                                cmd6.Parameters.AddWithValue("@Name", name);
                                cmd6.Parameters.AddWithValue("@Status", status);
                                cmd6.Parameters.AddWithValue("@NationalID", nationalID);
                                cmd6.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                                cmd6.Parameters.AddWithValue("@Phone1", phone1);
                                cmd6.Parameters.AddWithValue("@Phone2", phone2);
                                cmd6.Parameters.AddWithValue("@Area", area);
                                cmd6.Parameters.AddWithValue("@Address", address);
                                cmd6.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                                cmd6.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                                cmd6.Parameters.AddWithValue("@Evaluation", evaluation);

                                // Execute the query
                                cmd6.ExecuteNonQuery();
                            }

                        }



                        string selectedText_5 = comboBox1.SelectedItem?.ToString();

                        if (selectedText != null && selectedText.Contains("أسقف"))
                        {
                            string query7 = "INSERT INTO table_t6 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                  "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                            using (SqlCommand cmd7 = new SqlCommand(query7, conn))
                            {
                                // Add parameters for the query
                                cmd7.Parameters.AddWithValue("@Name", name);
                                cmd7.Parameters.AddWithValue("@Status", status);
                                cmd7.Parameters.AddWithValue("@NationalID", nationalID);
                                cmd7.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                                cmd7.Parameters.AddWithValue("@Phone1", phone1);
                                cmd7.Parameters.AddWithValue("@Phone2", phone2);
                                cmd7.Parameters.AddWithValue("@Area", area);
                                cmd7.Parameters.AddWithValue("@Address", address);
                                cmd7.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                                cmd7.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                                cmd7.Parameters.AddWithValue("@Evaluation", evaluation);

                                // Execute the query
                                cmd7.ExecuteNonQuery();
                            }

                        }




                        string selectedText_6 = comboBox1.SelectedItem?.ToString();

                        if (selectedText != null && selectedText.Contains("مشاريع"))
                        {
                            string query8 = "INSERT INTO table_7 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                  "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                            using (SqlCommand cmd8 = new SqlCommand(query8, conn))
                            {
                                // Add parameters for the query
                                cmd8.Parameters.AddWithValue("@Name", name);
                                cmd8.Parameters.AddWithValue("@Status", status);
                                cmd8.Parameters.AddWithValue("@NationalID", nationalID);
                                cmd8.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                                cmd8.Parameters.AddWithValue("@Phone1", phone1);
                                cmd8.Parameters.AddWithValue("@Phone2", phone2);
                                cmd8.Parameters.AddWithValue("@Area", area);
                                cmd8.Parameters.AddWithValue("@Address", address);
                                cmd8.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                                cmd8.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                                cmd8.Parameters.AddWithValue("@Evaluation", evaluation);

                                // Execute the query
                                cmd8.ExecuteNonQuery();
                            }

                        }



                        string selectedText_7 = comboBox1.SelectedItem?.ToString();

                        if (selectedText != null && selectedText.Contains("عيني"))
                        {
                            string query9 = "INSERT INTO table_8 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                  "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                            using (SqlCommand cmd9 = new SqlCommand(query9, conn))
                            {
                                // Add parameters for the query
                                cmd9.Parameters.AddWithValue("@Name", name);
                                cmd9.Parameters.AddWithValue("@Status", status);
                                cmd9.Parameters.AddWithValue("@NationalID", nationalID);
                                cmd9.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                                cmd9.Parameters.AddWithValue("@Phone1", phone1);
                                cmd9.Parameters.AddWithValue("@Phone2", phone2);
                                cmd9.Parameters.AddWithValue("@Area", area);
                                cmd9.Parameters.AddWithValue("@Address", address);
                                cmd9.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                                cmd9.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                                cmd9.Parameters.AddWithValue("@Evaluation", evaluation);

                                // Execute the query
                                cmd9.ExecuteNonQuery();
                            }

                        }




                        string selectedText_8 = comboBox1.SelectedItem?.ToString();

                        if (selectedText != null && selectedText.Contains("كفاله شهرية"))
                        {
                            string query10 = "INSERT INTO table_9 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                  "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                            using (SqlCommand cmd10 = new SqlCommand(query10, conn))
                            {
                                // Add parameters for the query
                                cmd10.Parameters.AddWithValue("@Name", name);
                                cmd10.Parameters.AddWithValue("@Status", status);
                                cmd10.Parameters.AddWithValue("@NationalID", nationalID);
                                cmd10.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                                cmd10.Parameters.AddWithValue("@Phone1", phone1);
                                cmd10.Parameters.AddWithValue("@Phone2", phone2);
                                cmd10.Parameters.AddWithValue("@Area", area);
                                cmd10.Parameters.AddWithValue("@Address", address);
                                cmd10.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                                cmd10.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                                cmd10.Parameters.AddWithValue("@Evaluation", evaluation);

                                // Execute the query
                                cmd10.ExecuteNonQuery();
                            }

                        }




                        string selectedText_9 = comboBox1.SelectedItem?.ToString();

                        if (selectedText != null && selectedText.Contains("وصلات مياة"))
                        {
                            string query11 = "INSERT INTO table_10 (الاسم,الحالة,الرقم_القومي,الحالة_الاجتماعية,الهاتف_1,الهاتف_2,المنطقة,العنوان_بالتفصيل,تاريخ_الاستكشاف,تاريخ_التقييم,التقييم) " +
                                  "VALUES (@Name, @Status, @NationalID, @MaritalStatus, @Phone1, @Phone2, @Area, @Address, @ExplorationDate, @EvaluationDate, @Evaluation)";

                            using (SqlCommand cmd11 = new SqlCommand(query11, conn))
                            {
                                // Add parameters for the query
                                cmd11.Parameters.AddWithValue("@Name", name);
                                cmd11.Parameters.AddWithValue("@Status", status);
                                cmd11.Parameters.AddWithValue("@NationalID", nationalID);
                                cmd11.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                                cmd11.Parameters.AddWithValue("@Phone1", phone1);
                                cmd11.Parameters.AddWithValue("@Phone2", phone2);
                                cmd11.Parameters.AddWithValue("@Area", area);
                                cmd11.Parameters.AddWithValue("@Address", address);
                                cmd11.Parameters.AddWithValue("@ExplorationDate", explorationDate);
                                cmd11.Parameters.AddWithValue("@EvaluationDate", evaluationDate);
                                cmd11.Parameters.AddWithValue("@Evaluation", evaluation);

                                // Execute the query
                                cmd11.ExecuteNonQuery();
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
                }
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
                    string query = "SELECT * FROM tty1"; // Query to get all data
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
           // textBox_PreviewKeyDown();
        }

        private void button3_Click(object sender, EventArgs e)
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


        // الطريقة لحذف البيانات من قاعدة البيانات
        private void DeleteData(string nationalID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // استعلام الحذف باستخدام الرقم القومي
                    string query = "DELETE FROM tty1 WHERE الرقم_القومي = @NationalID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // إضافة المعامل للبحث
                        cmd.Parameters.AddWithValue("@NationalID", nationalID);

                        // تنفيذ الاستعلام
                        cmd.ExecuteNonQuery();
                    }




                    // 3. تحميل البيانات بعد الحذف وإعادة ترتيب الأرقام
                    LoadData();

                }

                MessageBox.Show("تم حذف البيانات بنجاح");
                LoadData();  // تحميل البيانات بعد الحذف لتحديث DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في حذف البيانات: " + ex.Message);
            }
        }




        private void dataGridView22_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
              //  comboBox3.Text = row.Cells["الرقم_القومي"].Value.ToString();  // تخزين الرقم القومي لاستخدامه في التعديل أو الحذف
            }
        
    }

        private void button2_Click(object sender, EventArgs e)
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

        // الطريقة لتحديث البيانات في قاعدة البيانات
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
                    string query = "UPDATE tty1 SET الاسم = @Name, الحالة = @Status, الحالة_الاجتماعية = @MaritalStatus, " +
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

        // هذه هي الطريقة التي تقوم بإجراء البحث بناءً على الحقول المدخلة
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
                    string query = "SELECT * FROM tty1 WHERE 1 = 1"; // استخدام 1 = 1 كقاعدة ثابتة لجعل شروط البحث مرنة

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
        private void textBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (currentTextBox != null)
            {
                // السهم للأسفل (Down): الانتقال إلى المربع النصي التالي
                if (e.KeyCode == Keys.Down)
                {
                    if (currentTextBox.TabIndex < 10) // التأكد من أنه ليس المربع النصي الأخير
                    {
                        // الانتقال إلى المربع النصي التالي
                        this.SelectNextControl(currentTextBox, true, true, true, true);
                    }
                }
                // السهم للأعلى (Up): الانتقال إلى المربع النصي السابق
                else if (e.KeyCode == Keys.Up)
                {
                    if (currentTextBox.TabIndex > 0) // التأكد من أنه ليس المربع النصي الأول
                    {
                        // الانتقال إلى المربع النصي السابق
                        this.SelectNextControl(currentTextBox, false, true, true, true);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // التحقق مما إذا كان المستخدم قد ضغط على السهم للأسفل
            if (e.KeyCode == Keys.Down)
            {
                // نقل التركيز إلى TextBox2
               // textBox2.Focus();
            }
        }

        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // التحقق مما إذا كان المستخدم قد ضغط على السهم للأسفل
            if (e.KeyCode == Keys.Down)
            {
                // نقل التركيز إلى TextBox2
                textBox3.Focus();
            }
           
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // نقل التركيز إلى TextBox2
                textBox1.Focus();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // التحقق مما إذا كان المستخدم قد ضغط على السهم للأسفل
            if (e.KeyCode == Keys.Down)
            {
                // نقل التركيز إلى TextBox2
                //textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                // نقل التركيز إلى TextBox2
                textBox3.Focus();
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                // نقل التركيز إلى TextBox2
               // textBox4.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                // نقل التركيز إلى TextBox2
              //  textBox4.Focus();
            }

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // نقل التركيز إلى TextBox2
              //  textBox4.Focus();
            }
        }

        private void textBox3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                // نقل التركيز إلى TextBox2
               // textBox4.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // الحصول على الاسم المدخل من الـ TextBox

            /* // ResalaDataSet vv = new ResalaDataSet();
              ResalaEntities2 db = new ResalaEntities2();
              tiby1 t1= new tiby1();
              t1.الاسم=textBox1.Text;
              db.tiby1.Add(t1);
           //   db.SaveChanges();*/

            // الحصول على القيم من TextBox
            // Read data from textboxes
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

        private void button4_Click_1(object sender, EventArgs e)
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
              //  comboBox3.Text = row.Cells["الرقم_القومي"].Value.ToString();  // تخزين الرقم القومي لاستخدامه في التعديل أو الحذف
            }
        }

        private void resalaDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

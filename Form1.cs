using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.SqlClient;
//using Data_Resala.Data_ResalaDataSetTableAdapters;
namespace Data_Resala
{
    /// <summary>
    /// ////////////////////////////developed by=====>eng:Mohamed Reda/////////////////////////
    //////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////صادقه جاريه علي روح جدتي رحمه الله عليها//////////////////
    ////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    public partial class Form1 : Form
    {
        public string connectionString = "Server=desktop-6tshlsd\\sqlexpress; Database=Resala; Integrated Security=True;";
        private Control t1_1;

       
       
        public Form1()
        {

            


            InitializeComponent();
          





            this.WindowState = FormWindowState.Maximized;
            //  this.FormBorderStyle = FormBorderStyle.None;
          //  dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
       Form2 form2 = new Form2();

           
            form2.Show();


         
        }

        private void button13_Click(object sender, EventArgs e)
        {
          

            Form6 form6 = new Form6();


            form6.Show();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            //form وصلات مياة==============================================

            Form10 form10 = new Form10();


            form10.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
           

            Form20 form20 = new Form20();


            form20.Show();

        }

        public void back11(object sender, EventArgs e) //function المسؤله عن الرجوع للصافحه الرئيسيه في section محمع الداتا 
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
          //  button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;

            back1.Visible = false;
            show1.Visible = false;
            save1.Visible = false;
            l1_15.Visible= false;
            l2_15.Visible = false;
            l3_15.Visible = false;
            l4_15.Visible = false;
            l5_15.Visible = false;
            l6_15.Visible = false;
            l7_15.Visible = false;
            l8_15.Visible = false;
            l9_15.Visible = false;
            l10_15.Visible = false;
            l11_15.Visible = false;
            l12_15.Visible = false;
            l13_15.Visible = false;

            t1_15.Visible= false;
            t2_15.Visible = false;
            t3_15.Visible = false;
            t4_15.Visible = false;
            t5_15.Visible = false;
            t6_15.Visible = false;
            t7_15.Visible = false;
            t8_15.Visible = false;
            t9_15.Visible = false;
            t10_15.Visible = false;
            t11_15.Visible = false;
            t12_15.Visible = false;
            t13_15.Visible = false;


           



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Form3 form3 = new Form3();


            form3.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {
           

            Form7 form7 = new Form7();


            form7.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            Form11 form11 = new Form11();


            form11.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            Form4 form4 = new Form4();


            form4.Show();



        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            Form8 form8 = new Form8();


            form8.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            Form12 form12 = new Form12();


            form12.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;

            this.Controls.Add(save1); //مجمع الداتا زر الحفظ
            this.save1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save1.Location = new System.Drawing.Point(320, 740);
            this.save1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.save1.BackColor = Color.Crimson;
            this.save1.Size = new Size(80, 30);
            this.save1.Text = "حفظ";
            this.save1.Click += save;


            this.Controls.Add(show1); //مجمع الداتا زر عرض البيانات
            this.show1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show1.Location = new System.Drawing.Point(170, 740);
            this.show1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.show1.BackColor = Color.Crimson;
            this.show1.Size = new Size(120, 30);
            this.show1.Text = "عرض الكل";


            this.Controls.Add(back1); //مجمع الداتا زر الرجوع للصافحه الرئيسية
            this.back1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back1.Location = new System.Drawing.Point(280, 212);
            this.back1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.back1.BackColor = Color.Crimson;
            this.back1.Size = new Size(210, 30);
            this.back1.Text = "<==الصافحةالرئيسية";
            this.back1.Click += back11;

            this.Controls.Add(l1_15); //label1 in button مجمع الداتا
            l1_15.Visible = true;
            this.l1_15.AutoSize = true;
            this.l1_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1_15.Location = new System.Drawing.Point(1000, 208);
            //  this.l1_15.Name = "label1";
            this.l1_15.Size = new System.Drawing.Size(79, 36);
            this.l1_15.TabIndex = 19;
            this.l1_15.Text = "الأسم";



            this.Controls.Add(l2_15); //label2 in button مجمع الداتا
            l2_15.Visible = true;
            this.l2_15.AutoSize = true;
            this.l2_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2_15.Location = new System.Drawing.Point(1000, 266);
            //  this.l2_15.Name = "label1";
            this.l2_15.Size = new System.Drawing.Size(79, 36);
            this.l2_15.TabIndex = 19;
            this.l2_15.Text = "الحالة";


            this.Controls.Add(l3_15); //label3 in button مجمع الداتا
            l3_15.Visible = true;
            this.l3_15.AutoSize = true;
            this.l3_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3_15.Location = new System.Drawing.Point(1000, 324);
            //  this.l3_15.Name = "label1";
            this.l3_15.Size = new System.Drawing.Size(79, 36);
            this.l3_15.TabIndex = 19;
            this.l3_15.Text = "الرقم القومي";



            this.Controls.Add(l4_15); //label4 in button مجمع الداتا
            l4_15.Visible = true;
            this.l4_15.AutoSize = true;
            this.l4_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4_15.Location = new System.Drawing.Point(1000, 382);
            //  this.l4_15.Name = "label1";
            this.l4_15.Size = new System.Drawing.Size(100, 36);
            this.l4_15.TabIndex = 19;
            this.l4_15.Text = "الحالة الأجتماعية";



            this.Controls.Add(l5_15); //label5 in button مجمع الداتا
            l5_15.Visible = true;
            this.l5_15.AutoSize = true;
            this.l5_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5_15.Location = new System.Drawing.Point(1000, 440);
            //  this.l4_15.Name = "label1";
            this.l5_15.Size = new System.Drawing.Size(100, 36);
            this.l5_15.TabIndex = 19;
            this.l5_15.Text = "رقم الموبايل1";



            this.Controls.Add(l6_15); //label6 in button مجمع الداتا
            l6_15.Visible = true;
            this.l6_15.AutoSize = true;
            this.l6_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6_15.Location = new System.Drawing.Point(1000, 498);
            //  this.l4_15.Name = "label1";
            this.l6_15.Size = new System.Drawing.Size(100, 36);
            this.l6_15.TabIndex = 19;
            this.l6_15.Text = "رقم الموبايل2";



            this.Controls.Add(l7_15); //label7 in button مجمع الداتا
            l7_15.Visible = true;
            this.l7_15.AutoSize = true;
            this.l7_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7_15.Location = new System.Drawing.Point(1000, 556);
            //  this.l4_15.Name = "label1";
            this.l7_15.Size = new System.Drawing.Size(100, 36);
            this.l7_15.TabIndex = 19;
            this.l7_15.Text = "المنطقة";


            this.Controls.Add(l8_15); //label8 in button مجمع الداتا
            l8_15.Visible = true;
            this.l8_15.AutoSize = true;
            this.l8_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8_15.Location = new System.Drawing.Point(1000, 614);
            //  this.l4_15.Name = "label1";
            this.l8_15.Size = new System.Drawing.Size(100, 36);
            this.l8_15.TabIndex = 19;
            this.l8_15.Text = "العنوان بالتفصيل";




            this.Controls.Add(l9_15); //label9 in button مجمع الداتا
            l9_15.Visible = true;
            this.l9_15.AutoSize = true;
            this.l9_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9_15.Location = new System.Drawing.Point(1000, 672);
            //  this.l4_15.Name = "label1";
            this.l9_15.Size = new System.Drawing.Size(100, 36);
            this.l9_15.TabIndex = 19;
            this.l9_15.Text = "تاريخ الأستكشاف";



            this.Controls.Add(l10_15); //label10 in button مجمع الداتا
            l10_15.Visible = true;
            this.l10_15.AutoSize = true;
            this.l10_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l10_15.Location = new System.Drawing.Point(1000, 730);
            //  this.l4_15.Name = "label1";
            this.l10_15.Size = new System.Drawing.Size(100, 36);
            this.l10_15.TabIndex = 19;
            this.l10_15.Text = "تاريخ التقييم";


            this.Controls.Add(t1_15);//مجمع الداتا textbox1
            this.t1_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1_15.Location = new System.Drawing.Point(500, 266);
            this.t1_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t1_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t1_15.Multiline = true;
            this.t1_15.Name = "textBox1";
            this.t1_15.Size = new System.Drawing.Size(500, 36);
            this.t1_15.TabIndex = 19;
            this.t1_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t1_15.BackColor = System.Drawing.Color.MidnightBlue;



            this.Controls.Add(t2_15);//مجمع الداتا textbox2
            this.t2_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2_15.Location = new System.Drawing.Point(500, 210);
            this.t2_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t2_15.Multiline = true;
            this.t2_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t2_15.Name = "textBox1";
            this.t2_15.Size = new System.Drawing.Size(500, 36);
            this.t2_15.TabIndex = 19;
            this.t2_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t2_15.BackColor = System.Drawing.Color.MidnightBlue;



            this.Controls.Add(t3_15);//مجمع الداتا textbox3
            this.t3_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3_15.Location = new System.Drawing.Point(500, 322);
            this.t3_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t3_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t3_15.Multiline = true;
            this.t3_15.Name = "textBox1";
            this.t3_15.Size = new System.Drawing.Size(500, 36);
            this.t3_15.TabIndex = 19;
            this.t3_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t3_15.BackColor = System.Drawing.Color.MidnightBlue;


            this.Controls.Add(t4_15);//مجمع الداتا textbox4
            this.t4_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4_15.Location = new System.Drawing.Point(500, 378);
            this.t4_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t4_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t4_15.Multiline = true;
            this.t4_15.Name = "textBox1";
            this.t4_15.Size = new System.Drawing.Size(500, 36);
            this.t4_15.TabIndex = 19;
            this.t4_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t4_15.BackColor = System.Drawing.Color.MidnightBlue;



            this.Controls.Add(t5_15);//مجمع الداتا textbox5
            this.t5_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t5_15.Location = new System.Drawing.Point(500, 378);
            this.t5_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t5_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t5_15.Multiline = true;
            this.t5_15.Name = "textBox1";
            this.t5_15.Size = new System.Drawing.Size(500, 36);
            this.t5_15.TabIndex = 19;
            this.t5_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t5_15.BackColor = System.Drawing.Color.MidnightBlue;



            this.Controls.Add(t6_15);//مجمع الداتا textbox6
            this.t6_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t6_15.Location = new System.Drawing.Point(500, 434);
            this.t6_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t6_15.Multiline = true;
            this.t6_15.Name = "textBox1";
            this.t6_15.Size = new System.Drawing.Size(500, 36);
            this.t6_15.TabIndex = 19;
            this.t6_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t6_15.BackColor = System.Drawing.Color.MidnightBlue;




            this.Controls.Add(t7_15);//مجمع الداتا textbox7
            this.t7_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t7_15.Location = new System.Drawing.Point(500, 490);
            this.t7_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t7_15.Multiline = true;
            this.t7_15.Name = "textBox1";
            this.t7_15.Size = new System.Drawing.Size(500, 36);
            this.t7_15.TabIndex = 19;
            this.t7_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t7_15.BackColor = System.Drawing.Color.MidnightBlue;




            //   this.Controls.Add(t8_15);//مجمع الداتا textbox8
            this.t8_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t8_15.Location = new System.Drawing.Point(500, 500);
            this.t8_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t8_15.Multiline = true;
            this.t8_15.Name = "textBox1";
            this.t8_15.Size = new System.Drawing.Size(500, 36);
            this.t8_15.TabIndex = 19;
            this.t8_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t8_15.BackColor = System.Drawing.Color.MidnightBlue;


            this.Controls.Add(t9_15);//مجمع الداتا textbox9
            this.t9_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t9_15.Location = new System.Drawing.Point(500, 552);
            this.t9_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t9_15.Multiline = true;
            this.t9_15.Name = "textBox1";
            this.t9_15.Size = new System.Drawing.Size(500, 36);
            this.t9_15.TabIndex = 19;
            this.t9_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t9_15.BackColor = System.Drawing.Color.MidnightBlue;



            this.Controls.Add(t10_15);//مجمع الداتا textbox10
            this.t10_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t10_15.Location = new System.Drawing.Point(500, 618);
            this.t10_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t10_15.Multiline = true;
            this.t10_15.Name = "textBox1";
            this.t10_15.Size = new System.Drawing.Size(500, 36);
            this.t10_15.TabIndex = 19;
            this.t10_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t10_15.BackColor = System.Drawing.Color.MidnightBlue;



            this.Controls.Add(t11_15);//مجمع الداتا textbox11
            this.t11_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t11_15.Location = new System.Drawing.Point(500, 670);
            this.t11_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t11_15.Multiline = true;
            this.t11_15.Name = "textBox1";
            this.t11_15.Size = new System.Drawing.Size(500, 36);
            this.t11_15.TabIndex = 19;
            this.t11_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t11_15.BackColor = System.Drawing.Color.MidnightBlue;




            this.Controls.Add(t12_15);//مجمع الداتا textbox12
            this.t12_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t12_15.Location = new System.Drawing.Point(500, 730);
            this.t12_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t12_15.Multiline = true;
            this.t12_15.Name = "textBox1";
            this.t12_15.Size = new System.Drawing.Size(500, 36);
            this.t12_15.TabIndex = 19;
            this.t12_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t12_15.BackColor = System.Drawing.Color.MidnightBlue;

            back1.Visible = true;
            show1.Visible = true;
            save1.Visible = true;
            l1_15.Visible = true;
            l2_15.Visible = true;
            l3_15.Visible = true;
            l5_15.Visible = true;
            l6_15.Visible = true;
            l7_15.Visible = true;
            l8_15.Visible = true;
            l9_15.Visible = true;
            l10_15.Visible = true;
            l11_15.Visible = true;
            l12_15.Visible = true;
            l13_15.Visible = true;

            t1_15.Visible = true;
            t2_15.Visible = true;
            t3_15.Visible = true;
            t4_15.Visible = true;
            t5_15.Visible = true;
            t6_15.Visible = true;
            t7_15.Visible = true;
            t8_15.Visible = true;
            t9_15.Visible = true;
            t10_15.Visible = true;
            t11_15.Visible = true;
            t12_15.Visible = true;
            t13_15.Visible = true;

            this.t5_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t6_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t7_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t8_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t9_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t10_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t11_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t12_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t13_15.ForeColor = System.Drawing.SystemColors.Window;
            */


            Form16 form16 = new Form16();


            form16.Show();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            Form5 form5 = new Form5();


            form5.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
           

            Form9 form9 = new Form9();


            form9.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
          

            Form13 form13 = new Form13();


            form13.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;


            this.Controls.Add(save1); //مجمع الداتا زر الحفظ
            this.save1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save1.Location = new System.Drawing.Point(320, 740);
            this.save1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.save1.BackColor = Color.Crimson;
            this.save1.Size = new Size(80, 30);
            this.save1.Text = "حفظ";
            this.save1.Click += save;


            this.Controls.Add(show1); //مجمع الداتا زر عرض البيانات
            this.show1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show1.Location = new System.Drawing.Point(170, 740);
            this.show1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.show1.BackColor = Color.Crimson;
            this.show1.Size = new Size(120, 30);
            this.show1.Text = "عرض الكل";


            this.Controls.Add(back1); //مجمع الداتا زر الرجوع للصافحه الرئيسية
            this.back1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back1.Location = new System.Drawing.Point(280, 212);
            this.back1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.back1.BackColor = Color.Crimson;
            this.back1.Size = new Size(210, 30);
            this.back1.Text = "<==الصافحةالرئيسية";
            this.back1.Click += back11;

            this.Controls.Add(l1_15); //label1 in button مجمع الداتا
            l1_15.Visible = true;
            this.l1_15.AutoSize = true;
            this.l1_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1_15.Location = new System.Drawing.Point(1000, 208);
            //  this.l1_15.Name = "label1";
            this.l1_15.Size = new System.Drawing.Size(79, 36);
            this.l1_15.TabIndex = 19;
            this.l1_15.Text = "الأسم";



            this.Controls.Add(l2_15); //label2 in button مجمع الداتا
            l2_15.Visible = true;
            this.l2_15.AutoSize = true;
            this.l2_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2_15.Location = new System.Drawing.Point(1000, 266);
            //  this.l2_15.Name = "label1";
            this.l2_15.Size = new System.Drawing.Size(79, 36);
            this.l2_15.TabIndex = 19;
            this.l2_15.Text = "الحالة";


            this.Controls.Add(l3_15); //label3 in button مجمع الداتا
            l3_15.Visible = true;
            this.l3_15.AutoSize = true;
            this.l3_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3_15.Location = new System.Drawing.Point(1000, 324);
            //  this.l3_15.Name = "label1";
            this.l3_15.Size = new System.Drawing.Size(79, 36);
            this.l3_15.TabIndex = 19;
            this.l3_15.Text = "الرقم القومي";



            this.Controls.Add(l4_15); //label4 in button مجمع الداتا
            l4_15.Visible = true;
            this.l4_15.AutoSize = true;
            this.l4_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4_15.Location = new System.Drawing.Point(1000, 382);
            //  this.l4_15.Name = "label1";
            this.l4_15.Size = new System.Drawing.Size(100, 36);
            this.l4_15.TabIndex = 19;
            this.l4_15.Text = "الحالة الأجتماعية";



            this.Controls.Add(l5_15); //label5 in button مجمع الداتا
            l5_15.Visible = true;
            this.l5_15.AutoSize = true;
            this.l5_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5_15.Location = new System.Drawing.Point(1000, 440);
            //  this.l4_15.Name = "label1";
            this.l5_15.Size = new System.Drawing.Size(100, 36);
            this.l5_15.TabIndex = 19;
            this.l5_15.Text = "رقم الموبايل1";



            this.Controls.Add(l6_15); //label6 in button مجمع الداتا
            l6_15.Visible = true;
            this.l6_15.AutoSize = true;
            this.l6_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6_15.Location = new System.Drawing.Point(1000, 498);
            //  this.l4_15.Name = "label1";
            this.l6_15.Size = new System.Drawing.Size(100, 36);
            this.l6_15.TabIndex = 19;
            this.l6_15.Text = "رقم الموبايل2";



            this.Controls.Add(l7_15); //label7 in button مجمع الداتا
            l7_15.Visible = true;
            this.l7_15.AutoSize = true;
            this.l7_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7_15.Location = new System.Drawing.Point(1000, 556);
            //  this.l4_15.Name = "label1";
            this.l7_15.Size = new System.Drawing.Size(100, 36);
            this.l7_15.TabIndex = 19;
            this.l7_15.Text = "المنطقة";


            this.Controls.Add(l8_15); //label8 in button مجمع الداتا
            l8_15.Visible = true;
            this.l8_15.AutoSize = true;
            this.l8_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8_15.Location = new System.Drawing.Point(1000, 614);
            //  this.l4_15.Name = "label1";
            this.l8_15.Size = new System.Drawing.Size(100, 36);
            this.l8_15.TabIndex = 19;
            this.l8_15.Text = "العنوان بالتفصيل";




            this.Controls.Add(l9_15); //label9 in button مجمع الداتا
            l9_15.Visible = true;
            this.l9_15.AutoSize = true;
            this.l9_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9_15.Location = new System.Drawing.Point(1000, 672);
            //  this.l4_15.Name = "label1";
            this.l9_15.Size = new System.Drawing.Size(100, 36);
            this.l9_15.TabIndex = 19;
            this.l9_15.Text = "تاريخ الأستكشاف";



            this.Controls.Add(l10_15); //label10 in button مجمع الداتا
            l10_15.Visible = true;
            this.l10_15.AutoSize = true;
            this.l10_15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l10_15.Location = new System.Drawing.Point(1000, 730);
            //  this.l4_15.Name = "label1";
            this.l10_15.Size = new System.Drawing.Size(100, 36);
            this.l10_15.TabIndex = 19;
            this.l10_15.Text = "تاريخ التقييم";


            this.Controls.Add(t1_15);//مجمع الداتا textbox1
            this.t1_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1_15.Location = new System.Drawing.Point(500, 266);
            this.t1_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t1_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t1_15.Multiline = true;
            this.t1_15.Name = "textBox1";
            this.t1_15.Size = new System.Drawing.Size(500, 36);
            this.t1_15.TabIndex = 19;
            this.t1_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t1_15.BackColor = System.Drawing.Color.MidnightBlue;



            this.Controls.Add(t2_15);//مجمع الداتا textbox2
            this.t2_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2_15.Location = new System.Drawing.Point(500, 210);
            this.t2_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t2_15.Multiline = true;
            this.t2_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t2_15.Name = "textBox1";
            this.t2_15.Size = new System.Drawing.Size(500, 36);
            this.t2_15.TabIndex = 19;
            this.t2_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t2_15.BackColor = System.Drawing.Color.MidnightBlue;



            this.Controls.Add(t3_15);//مجمع الداتا textbox3
            this.t3_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3_15.Location = new System.Drawing.Point(500, 322);
            this.t3_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t3_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t3_15.Multiline = true;
            this.t3_15.Name = "textBox1";
            this.t3_15.Size = new System.Drawing.Size(500, 36);
            this.t3_15.TabIndex = 19;
            this.t3_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t3_15.BackColor = System.Drawing.Color.MidnightBlue;


            this.Controls.Add(t4_15);//مجمع الداتا textbox4
            this.t4_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4_15.Location = new System.Drawing.Point(500, 378);
            this.t4_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t4_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t4_15.Multiline = true;
            this.t4_15.Name = "textBox1";
            this.t4_15.Size = new System.Drawing.Size(500, 36);
            this.t4_15.TabIndex = 19;
            this.t4_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t4_15.BackColor = System.Drawing.Color.MidnightBlue;



            this.Controls.Add(t5_15);//مجمع الداتا textbox5
            this.t5_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t5_15.Location = new System.Drawing.Point(500, 378);
            this.t5_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t5_15.ForeColor = System.Drawing.SystemColors.Window;
            this.t5_15.Multiline = true;
            this.t5_15.Name = "textBox1";
            this.t5_15.Size = new System.Drawing.Size(500, 36);
            this.t5_15.TabIndex = 19;
            this.t5_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t5_15.BackColor = System.Drawing.Color.MidnightBlue;



            this.Controls.Add(t6_15);//مجمع الداتا textbox6
            this.t6_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t6_15.Location = new System.Drawing.Point(500, 434);
            this.t6_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t6_15.Multiline = true;
            this.t6_15.Name = "textBox1";
            this.t6_15.Size = new System.Drawing.Size(500, 36);
            this.t6_15.TabIndex = 19;
            this.t6_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t6_15.BackColor = System.Drawing.Color.MidnightBlue;
            this.t6_15.ForeColor = System.Drawing.SystemColors.Window;




            this.Controls.Add(t7_15);//مجمع الداتا textbox7
            this.t7_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t7_15.Location = new System.Drawing.Point(500, 490);
            this.t7_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t7_15.Multiline = true;
            this.t7_15.Name = "textBox1";
            this.t7_15.Size = new System.Drawing.Size(500, 36);
            this.t7_15.TabIndex = 19;
            this.t7_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t7_15.BackColor = System.Drawing.Color.MidnightBlue;
            this.t7_15.ForeColor = System.Drawing.SystemColors.Window;




            //   this.Controls.Add(t8_15);//مجمع الداتا textbox8
            this.t8_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t8_15.Location = new System.Drawing.Point(500, 500);
            this.t8_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t8_15.Multiline = true;
            this.t8_15.Name = "textBox1";
            this.t8_15.Size = new System.Drawing.Size(500, 36);
            this.t8_15.TabIndex = 19;
            this.t8_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t8_15.BackColor = System.Drawing.Color.MidnightBlue;
            this.t8_15.ForeColor = System.Drawing.SystemColors.Window;


            this.Controls.Add(t9_15);//مجمع الداتا textbox9
            this.t9_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t9_15.Location = new System.Drawing.Point(500, 552);
            this.t9_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t9_15.Multiline = true;
            this.t9_15.Name = "textBox1";
            this.t9_15.Size = new System.Drawing.Size(500, 36);
            this.t9_15.TabIndex = 19;
            this.t9_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t9_15.BackColor = System.Drawing.Color.MidnightBlue;
            this.t9_15.ForeColor = System.Drawing.SystemColors.Window;



            this.Controls.Add(t10_15);//مجمع الداتا textbox10
            this.t10_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t10_15.Location = new System.Drawing.Point(500, 618);
            this.t10_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t10_15.Multiline = true;
            this.t10_15.Name = "textBox1";
            this.t10_15.Size = new System.Drawing.Size(500, 36);
            this.t10_15.TabIndex = 19;
            this.t10_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t10_15.BackColor = System.Drawing.Color.MidnightBlue;
            this.t10_15.ForeColor = System.Drawing.SystemColors.Window;



            this.Controls.Add(t11_15);//مجمع الداتا textbox11
            this.t11_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t11_15.Location = new System.Drawing.Point(500, 670);
            this.t11_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t11_15.Multiline = true;
            this.t11_15.Name = "textBox1";
            this.t11_15.Size = new System.Drawing.Size(500, 36);
            this.t11_15.TabIndex = 19;
            this.t11_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t11_15.BackColor = System.Drawing.Color.MidnightBlue;
            this.t11_15.ForeColor = System.Drawing.SystemColors.Window;




            this.Controls.Add(t12_15);//مجمع الداتا textbox12
            this.t12_15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t12_15.Location = new System.Drawing.Point(500, 730);
            this.t12_15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.t12_15.Multiline = true;
            this.t12_15.Name = "textBox1";
            this.t12_15.Size = new System.Drawing.Size(500, 36);
            this.t12_15.TabIndex = 19;
            this.t12_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t12_15.BackColor = System.Drawing.Color.MidnightBlue;
            this.t12_15.ForeColor = System.Drawing.SystemColors.Window;


            back1.Visible = true;
            show1.Visible = true;
            save1.Visible = true;
            l1_15.Visible = true;
            l2_15.Visible = true;
            l3_15.Visible = true;
            l5_15.Visible = true;
            l6_15.Visible = true;
            l7_15.Visible = true;
            l8_15.Visible = true;
            l9_15.Visible = true;
            l10_15.Visible = true;
            l11_15.Visible = true;
            l12_15.Visible = true;
            l13_15.Visible = true;

            t1_15.Visible = true;
            t2_15.Visible = true;
            t3_15.Visible = true;
            t4_15.Visible = true;
            t5_15.Visible = true;
            t6_15.Visible = true;
            t7_15.Visible = true;
            t8_15.Visible = true;
            t9_15.Visible = true;
            t10_15.Visible = true;
            t11_15.Visible = true;
            t12_15.Visible = true;
            t13_15.Visible = true;*/

            Form17 form17 = new Form17();


            form17.Show();


        }
        private void save(object sender, EventArgs e)
        {
           this. t1_15.Text = " ";
           this. t2_15.Text = " ";
           this. t3_15.Text = " ";
           this. t4_15.Text = " ";
           this. t5_15.Text = " ";
           this. t6_15.Text = " ";
           this. t7_15.Text = " ";
           this. t8_15.Text = " ";
           this. t9_15.Text = " ";
           this. t10_15.Text = " ";
           this. t11_15.Text = " ";
           this. t12_15.Text = " ";
           this. t13_15.Text = " ";

          //  dataGridView1.Visible = true;
            back1.Visible = false;
            show1.Visible = false;
            save1.Visible = false;
            l1_15.Visible = false;
            l2_15.Visible = false;
            l3_15.Visible = false;
            l4_15.Visible = false;
            l5_15.Visible = false;
            l6_15.Visible = false;
            l7_15.Visible = false;
            l8_15.Visible = false;
            l9_15.Visible = false;
            l10_15.Visible = false;
            l11_15.Visible = false;
            l12_15.Visible = false;
            l13_15.Visible = false;

            t1_15.Visible = false;
            t2_15.Visible = false;
            t3_15.Visible = false;
            t4_15.Visible = false;
            t5_15.Visible = false;
            t6_15.Visible = false;
            t7_15.Visible = false;
            t8_15.Visible = false;
            t9_15.Visible = false;
            t10_15.Visible = false;
            t11_15.Visible = false;
            t12_15.Visible = false;
            t13_15.Visible = false;


          
            

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_ResalaDataSet.Table_1' table. You can move, or remove it, as needed.
            //   this.table_1TableAdapter.Fill(this.data_ResalaDataSet.Table_1);
            int recordCount = GetRecordCount();
            int recordCount2 = GetRecordCount2();
           // int recordCount3 = GetRecordCount3();
          //  int recordCount4 = GetRecordCount4();
           // int recordCount5 = GetRecordCount5();


            //tb_3
            // عرض العدد في الـ Label1
            label1.Text =  recordCount.ToString();
            label2.Text = recordCount2.ToString();
           // label3.Text = recordCount3.ToString();
           // label4.Text = recordCount4.ToString();
           // label5.Text = recordCount5.ToString();

        }

        private int GetRecordCount()
        {
            int count = 0;
            try
            {
                // سلسلة الاتصال بقاعدة البيانات
                  // استبدلها بسلسلة الاتصال الخاصة بك

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // استعلام SQL لعد السجلات في جدول tyy1
                    string query = "SELECT COUNT(*) FROM tty1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // تنفيذ الاستعلام وإرجاع النتيجة
                        count = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الاتصال بقاعدة البيانات: " + ex.Message);
            }

            return count;
        }

        private int GetRecordCount2()
        {
            int count = 0;
            try
            {
                // سلسلة الاتصال بقاعدة البيانات
                // استبدلها بسلسلة الاتصال الخاصة بك

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // استعلام SQL لعد السجلات في جدول tyy1
                    string query = "SELECT COUNT(*) FROM tb_3";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // تنفيذ الاستعلام وإرجاع النتيجة
                        count = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الاتصال بقاعدة البيانات: " + ex.Message);
            }

            return count;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();


            form14.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();


            form15.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();


            form16.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           /* button1.Width = this.ClientSize.Width / 6+6/5;
            button1.Height = this.ClientSize.Height / 11;

            button2.Width = this.ClientSize.Width / 6 + 6 / 5;
            button2.Height = this.ClientSize.Height / 11;


            button3.Width = this.ClientSize.Width / 6 + 6 / 5;
            button3.Height = this.ClientSize.Height / 11;


            button4.Width = this.ClientSize.Width / 6 + 6 / 5;
            button4.Height = this.ClientSize.Height / 11;


            button6.Width = this.ClientSize.Width / 6 + 6 / 5;
            button6.Height = this.ClientSize.Height / 11;


            button7.Width = this.ClientSize.Width / 6 + 6 / 5;
            button7.Height = this.ClientSize.Height / 11;


            button8.Width = this.ClientSize.Width / 6 + 6 / 5;
            button8.Height = this.ClientSize.Height / 11;


            button9.Width = this.ClientSize.Width / 6 + 6 / 5;
            button9.Height = this.ClientSize.Height / 11;


            button11.Width = this.ClientSize.Width / 6 + 6 / 5;
            button11.Height = this.ClientSize.Height / 11;

            button10.Width = this.ClientSize.Width / 6 + 6 / 5;
            button10.Height = this.ClientSize.Height / 11;

            button12.Width = this.ClientSize.Width / 6 + 6 / 5;
            button12.Height = this.ClientSize.Height / 11;

            button13.Width = this.ClientSize.Width / 6 + 6 / 5;
            button13.Height = this.ClientSize.Height / 11;


            button14.Width = this.ClientSize.Width / 6 + 6 / 5;
            button14.Height = this.ClientSize.Height / 11;
            button15.Width = this.ClientSize.Width / 6 + 6 / 5;
            button15.Height = this.ClientSize.Height / 11;

            button16.Width = this.ClientSize.Width / 6 + 6 / 5;
            button16.Height = this.ClientSize.Height / 11;
            button17.Width = this.ClientSize.Width / 6 + 6 / 5;
            button17.Height = this.ClientSize.Height / 11;

            button18.Width = this.ClientSize.Width / 6 + 6 / 5;
            button18.Height = this.ClientSize.Height / 11;*/
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }
    }
}

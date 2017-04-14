using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int countupseconds = 0, minute = 0, second = 0,hour = 0;
        String strmin, strsecond, strdisplay,strhr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user, pass, myFilePath;
            user = textBox1.Text;
            pass = textBox2.Text;

            myFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "BrainTeaser.txt");


            if (pass == "prerna8.0" && user != "")
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(myFilePath))
                {
                    sw.WriteLine("Username: " + user);
                }
                this.Hide();
                aar2 ss = new aar2(0);
                // ss._timer = _timer1;
                ss.ShowDialog();
            }
            else
            {
                if (pass != "prerna8.0")
                {
                    MessageBox.Show("OOPS!!....incorrect password.." + Environment.NewLine + "The password is : - prerna8.0");
                }
                else
                {
                    MessageBox.Show("Enter Username!");
                }
                
            }

                
        }
        /*public string _timer1
        {
            get { return strdisplay; }
        }*/ 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            countupseconds++;

            hour = countupseconds / 3600;
            second = countupseconds % 3600;
            minute = second / 60;
            second = second % 60;

            strmin = minute.ToString("00");
            strsecond = second.ToString("00");
            strhr = hour.ToString("00");
            strdisplay = strhr + ":" + strmin + ":" + strsecond;
           // label3.Text = strdisplay;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
      }
     
    }

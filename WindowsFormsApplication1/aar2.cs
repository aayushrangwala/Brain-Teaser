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
    public partial class aar2 : Form
    {
        int countupseconds,minute,second,hour;
        String strmin, strsecond, strdisplay,strhr;

        public aar2(int countupseconds)
        {
            InitializeComponent();
            this.countupseconds = countupseconds;
        }

        public string _timer
        {
            set { label3.Text = value; }
        }

        private void aar2_Load(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ans, myFilePath;
            ans = textBox1.Text;

            myFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "BrainTeaser.txt");

            if (strdisplay == "02:00:00")
            {
                timer1.Stop();
                MessageBox.Show("OOPS...Time's Up!!!");
                this.Close();
            }
            else
            {
                if (ans == "franklin")
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(myFilePath, true))
                    {
                        sw.WriteLine(Environment.NewLine + "1." + strdisplay);
                    }
                    this.Hide();
                    aar3 ss = new aar3(countupseconds);
                    ss._timer = _timer1;
                    ss.ShowDialog();
                }
                else
                {
                    if (ans == "BTclose")
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Answer in Incorrect! Try Again");
                    }
                }
                timer1.Start();  //clock starts here
            }
        }

        public string _timer1
        {
            get { return strdisplay; }
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
            label3.Text = strdisplay;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
    }
}

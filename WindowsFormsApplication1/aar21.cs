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
    public partial class aar21 : Form
    {
        int countupseconds, minute, second,hour;
        String strmin, strsecond,strhr, strdisplay;

        public aar21(int countupseconds)
        {
            InitializeComponent();
            this.countupseconds = countupseconds;
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
                if (ans == "never")
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(myFilePath, true))
                    {
                        sw.WriteLine(Environment.NewLine +"20. "+ strdisplay);
                        MessageBox.Show("Congratulations!!! You have completed all the Levels of Brain Teaser");
                        timer1.Stop();
                        this.Close();
                    }
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
            }
        }
        public string _timer
        {
            set { label3.Text = value; }
        }
        public string _timer1
        {
            get { return strdisplay; }
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

        private void aar21_Load(object sender, EventArgs e)
        {

        }
    }
}

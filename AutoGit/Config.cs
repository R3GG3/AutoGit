using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGit
{
    public partial class Config : Form
    {
        public string username, email;

        public Config()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("info.txt");
            if ((untb.TextLength > 3) && (etb.TextLength > 3))
            {
                username = untb.Text;
                email = etb.Text;

                writer.WriteLine(username);
                writer.WriteLine(email);
            }
            writer.Close();
            Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {

            try
            {
                StreamReader reader = new StreamReader("info.txt");
                username = reader.ReadLine();
                email = reader.ReadLine();
                reader.Close();

                untb.Text = username;
                etb.Text = email;
            }

            catch (FileNotFoundException)
            {

            }
        }
    }
}

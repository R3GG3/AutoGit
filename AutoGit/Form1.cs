using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGit
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
            main.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main.Visible = false;
            menu.Visible = true;

            if (!File.Exists("info.txt"))
            {
                MessageBox.Show("Before doing anything, you have to write to me what is your git username and e-mail!", "Info");
                Config config = new Config();
                config.Show();
            }
        }

        private void Configbutton_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.Show();
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            string username, email;
            try
            {
                StreamReader reader = new StreamReader("info.txt");
                username = reader.ReadLine();
                email = reader.ReadLine();
                reader.Close();

                if ((reposnametextbox.TextLength > 3) && (reposloctextbox.TextLength > 3))
                {
                    Commands(username, email);
                    reposnametextbox.Text = "";
                    reposloctextbox.Text = "";
                    main.Visible = false;
                    menu.Visible = true;
                }

                else
                {
                    MessageBox.Show("Fill all text boxes!", "Info");
                }
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Before doing anything, you have to write to me what is your git username and e-mail!", "Info");
                Config config = new Config();
                config.Show();
            }
        }

        private void Folderbutton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            reposloctextbox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Commands(string username, string email)
        {
            string reposname = reposnametextbox.Text;
            string fullpath = reposloctextbox.Text;
            string discname = fullpath.Substring(0, 2);

            //------------------------------PROCESS----------------------------------------------------------------------------
            if(!File.Exists("commands.bat"))
            {
                StreamWriter writer = new StreamWriter("commands.bat");
                writer.WriteLine("@echo off");
                writer.WriteLine("timeout 1");
                writer.WriteLine(discname);
                writer.WriteLine("timeout 1");
                writer.WriteLine("cd " + fullpath);
                writer.WriteLine("timeout 1");
                writer.WriteLine("echo \"# AutoGit\" >> README.md");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git config --global user.name " + "\"" + username + "\"");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git config --global user.email " + "\"" + email + "\"");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git init");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git add .");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git commit -m \"First Commit\"");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git remote add origin " + "https://github.com/" + username + "/" + reposname + ".git");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git push -u origin master");
                writer.WriteLine("exit");
                writer.Close();
            }

            if(File.Exists("commands.bat"))
            {
                StreamWriter writer = new StreamWriter("commands.bat");
                writer.WriteLine("@echo off");
                writer.WriteLine("title AutoGit");
                writer.WriteLine("timeout 1");
                writer.WriteLine(discname);
                writer.WriteLine("timeout 1");
                writer.WriteLine("cd " + fullpath);
                writer.WriteLine("timeout 1");
                writer.WriteLine("echo \"# AutoGit\" >> README.md");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git config --global user.name " + "\"" + username + "\"");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git config --global user.email " + "\"" + email + "\"");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git init");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git add .");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git commit -m \"Commit Made By Auto Git from R3GG3 and HiGh_SkUlL!\"");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git remote add origin " + "https://github.com/" + username + "/" + reposname + ".git");
                writer.WriteLine("timeout 1");
                writer.WriteLine("git push -u origin master");
                writer.WriteLine("timeout 1");
                writer.WriteLine("exit");
                writer.Close();
            }

            Thread.Sleep(500);
            ExecuteAsAdmin("commands.bat");
            //-----------------------------------------------------------------------------------------------------------------
        }

        public void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }
    }
}

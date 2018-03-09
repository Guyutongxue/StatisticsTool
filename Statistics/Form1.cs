using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Statistics
{
    public partial class Form1 : Form
    {
        public string path;
        public string[] list;
        public string[] indx;
        public bool[] isFind;
        public Form1()
        {
            path = System.Environment.CurrentDirectory;
            InitializeComponent();
        }

        private void refresh()
        {
            listShow.Items.Clear();
            for (int i = 0; i < list.Length; i++)
            {

                //MessageBox.Show(ele);
                listShow.Items.Add((isFind[i] ? "X " : "O ") + list[i]);
            }
            btnSwitch.Visible = false;
            rtbLog.Text += "Refresh Listbox.\n";

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                rtbLog.Text += "Reading text...";
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Choose file of Name List.";
                ofd.Filter = "文本文件(*.txt)|*.txt|所有文件|*.*";
                ofd.InitialDirectory = path;
                ofd.ValidateNames = true;
                ofd.CheckPathExists = true;
                ofd.CheckFileExists = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string listPath = ofd.FileName;
                    ofd.ShowDialog();
                    ofd.Title = "Choose file of Index List.";
                    ofd.Filter = "文本文件(*.txt)|*.txt|所有文件|*.*";
                    ofd.InitialDirectory = path;
                    ofd.ValidateNames = true;
                    ofd.CheckPathExists = true;
                    ofd.CheckFileExists = true;
                    readText(listPath, ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
                rtbLog.Text += ("Error:\n" + ex.Message + "\n");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    //MessageBox.Show(tbInput.Text);
                    int found = Array.IndexOf(indx, tbInput.Text);
                    if (found == -1)
                    {
                        MessageBox.Show("Not Found.");
                        rtbLog.Text += ("Index \"" + tbInput.Text + "\" not found.\n");
                    }
                    else
                    {
                        isFind[found] = true;
                        rtbLog.Text += ("\"" + tbInput.Text + "\" found in No." + Convert.ToString(found) + " .\n");
                        refresh();

                    }
                    tbInput.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
                rtbLog.Text += ("Error:\n" + ex.Message + "\n");
            }
        }

        void readText(string listPath, string indxPath)
        {
            list = File.ReadAllLines(listPath);
            indx = File.ReadAllLines(indxPath);
            rtbLog.Text += "Read success.\n";
            isFind = new bool[list.Length];
            refresh();
            for (int i = 0; i < isFind.Length; i++)
            {
                isFind[i] = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSwitch.Visible = false;
            try
            {
                rtbLog.Text += "Reading list.txt & index.txt from directory...\n";
                readText(path + @"\list.txt", path + @"\index.txt");
                rtbLog.Text += "Initialized success.\n";
            }
            catch (Exception ex)
            {
                //who cares??
                rtbLog.Text += ("Auto-init failed: " + ex.Message + "\n");
            }
        }

        private void btnSlc_Click(object sender, EventArgs e)
        {
            string msg = "";
            for (int i = 0; i < list.Length; i++)
            {
                if (isFind[i]) msg += (list[i] + "\n");
            }
            rtbLog.Text += ("MessageBox:\n" + msg);
            MessageBox.Show(msg);
        }

        private void btnUSLC_Click(object sender, EventArgs e)
        {
            string msg = "";
            for (int i = 0; i < list.Length; i++)
            {
                if (!isFind[i]) msg += (list[i] + "\n");
            }
            rtbLog.Text += ("MessageBox:\n" + msg);
            MessageBox.Show(msg);
        }

        private void rtbLog_TextChanged(object sender, EventArgs e)
        {
            rtbLog.SelectionStart = rtbLog.Text.Length; //Set the current caret position at the end
            rtbLog.ScrollToCaret(); //Now scroll it automatically
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    String cmd = tbCmd.Text;
                    String[] argv = cmd.Split(' ');
                    switch (argv[0])
                    {
                        case "del":
                            {
                                for (int i = 1; i < argv.Length; i++)
                                {
                                    int found = Array.IndexOf(indx, argv[i]);
                                    if (found == -1)
                                    {
                                        MessageBox.Show("Not Found.");
                                        rtbLog.Text += ("Index \"" + argv[i] + "\" not found.\n");
                                    }
                                    else
                                    {
                                        isFind[found] = false;
                                        rtbLog.Text += ("\"" + argv[i] + "\" found in No." + Convert.ToString(found) + " .\n");
                                        refresh();

                                    }
                                }
                                break;
                            }
                        case "add":
                            {
                                for (int i = 1; i < argv.Length; i++)
                                {
                                    int found = Array.IndexOf(indx, argv[i]);
                                    if (found == -1)
                                    {
                                        MessageBox.Show("Not Found.");
                                        rtbLog.Text += ("Index \"" + argv[i] + "\" not found.\n");
                                    }
                                    else
                                    {
                                        isFind[found] = true;
                                        rtbLog.Text += ("\"" + argv[i] + "\" found in No." + Convert.ToString(found) + " .\n");
                                        refresh();

                                    }
                                }
                                break;
                            }
                        case "show":
                            {
                                if (argv.Length == 2 && argv[1] == "-u")
                                {
                                    string msg = "";
                                    for (int i = 0; i < list.Length; i++)
                                    {
                                        if (!isFind[i]) msg += (list[i] + "\n");
                                    }
                                    rtbLog.Text += ("MessageBox:\n" + msg);
                                    MessageBox.Show(msg);
                                }
                                else
                                {
                                    string msg = "";
                                    for (int i = 0; i < list.Length; i++)
                                    {
                                        if (isFind[i]) msg += (list[i] + "\n");
                                    }
                                    rtbLog.Text += ("MessageBox:\n" + msg);
                                    MessageBox.Show(msg);
                                }
                                break;
                            }
                        case "help":
                            {
                                rtbLog.Text += @"Statistics Tool Command Line
by Guyutongxue
Usage: command [options]
Command:
    add [name1] [name2] ... (make index(s) marked)
    del [name1] [name2] ... (make index(s) unmarked)
    show [-u] (show (un)selected messagebox)
    help (show this page)
    
For more, contact me.
";
                                break;
                            }
                        default:
                            {
                                rtbLog.Text += ("Command \"" + argv[0] + "\" not found.\n");

                                break;
                            }
                    }
                    tbCmd.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
                rtbLog.Text += ("Error:\n" + ex.Message + "\n");
                tbCmd.Text = "";
            }

        }

        private void listShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listShow.SelectedIndex != -1)
            {
                btnSwitch.Visible = true;
                if (isFind[listShow.SelectedIndex])
                {
                    btnSwitch.Text = "Unselect";
                }
                else
                {
                    btnSwitch.Text = "Select";
                }
            }
            else
            {
                btnSwitch.Visible = false;
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listShow.SelectedIndex;
                isFind[index] = !isFind[index];
                refresh();
                rtbLog.Text += ("Switched index " + index.ToString() + " .\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
                rtbLog.Text += ("Error:\n" + ex.Message + "\n");
            }
        }
    }
}

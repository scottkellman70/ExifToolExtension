using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ExifToolExtension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGPSData_Click(object sender, EventArgs e)
        {
            //gps
            listBoxTopResults.Items.Clear();
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\exiftool.exe",
                    Arguments = string.Format(@"-a  ""-gps*"" -ee {0}", textBoxFile.Text),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                listBoxTopResults.Items.Add(proc.StandardOutput.ReadLine().Replace("  ", ""));
            }
        }

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            listBoxTopResults.Items.Clear();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxFile.Text = ofd.FileName;
            }
        }

        private void ButtonAllEXIF_Click(object sender, EventArgs e)
        {
            //all exif
            listBoxTopResults.Items.Clear();
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\exiftool.exe",
                    Arguments = string.Format(@"-g2 {0}", textBoxFile.Text),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                listBoxTopResults.Items.Add(proc.StandardOutput.ReadLine().Replace("  ", ""));
            }
        }

        private void ButtonSerialNumber_Click(object sender, EventArgs e)
        {
            listBoxTopResults.Items.Clear();
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\exiftool.exe",
                    Arguments = string.Format(@"-SerialNumber {0}", textBoxFile.Text),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                listBoxTopResults.Items.Add(proc.StandardOutput.ReadLine().Replace("  ", ""));
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchTerm.Text.Trim();
            DirectoryInfo di = new DirectoryInfo(textBoxFolder.Text);
            listBoxTopResults.Items.Clear();

            foreach (FileInfo fi in di.GetFiles("*.*", SearchOption.AllDirectories))
            {
                try
                {
                    listBoxTopResults.Items.Clear();
                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = @"C:\Windows\exiftool.exe",
                            Arguments = string.Format(@"-g2 {0}", fi.FullName),
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        }
                    };

                    proc.Start();
                    while (!proc.StandardOutput.EndOfStream)
                    {
                        string result = proc.StandardOutput.ReadLine();
                        if (result.ToUpper().Contains(searchTerm.ToUpper()))
                        {
                            listBoxBottomResults.Items.Add(fi.FullName);
                            listBoxBottomResults.Refresh();
                        }
                    }
                }
                catch (Exception ex) { }
            }
        }

        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxFolder.Text = fbd.SelectedPath;
            }
        }

        private void ButtonByTag_Click(object sender, EventArgs e)
        {
            listBoxTopResults.Items.Clear();
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\exiftool.exe",
                    Arguments = string.Format(@"-a ""-{0}"" -ee {1}", textBoxTag.Text, textBoxFile.Text),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                listBoxTopResults.Items.Add(proc.StandardOutput.ReadLine().Replace("  ", ""));
            }
        }
    }
}

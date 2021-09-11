using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LinkedListStruct
{
    public partial class Form1 : Form
    {
        private string fileContent = string.Empty;
        private char[] delimiterChars = { ' ', ',', '.', '\t' };
        private string[] strArray = { };
        private string sorttext = string.Empty;
        private int[] array;
        private static Stopwatch stopwatch = new Stopwatch();
        private LinkedList<double> linkedlist = new LinkedList<double>();
        public BackgroundWorker worker;
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void btSortArray(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(fileContent))
            {
                rtbOpenArray.Text = "Помилка, файл пустий";
                return;
            }

            strArray = fileContent.Split(delimiterChars);
            tbTime.Text = "";
            Array.Resize(ref strArray, strArray.Length - 1);
            try
            {
                array = Array.ConvertAll(strArray, s => int.TryParse(s, out var x) ? x : -1);
                foreach (var arr in array)
                {
                    linkedlist.Add(arr);
                }
            }
            catch
            {
                rtbOpenArray.Text = "Невірний формат чисел";
                return;
            }
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btreadfromfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                rtbSortArray.Text = "";
                tbTime.Text = "";
                fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.RestoreDirectory = true;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = fileDialog.OpenFile();
                    using (StreamReader sr = new StreamReader(fileStream))
                    {
                        fileContent = sr.ReadToEnd();
                        rtbOpenArray.Text = fileContent;
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             worker = sender as BackgroundWorker;
            stopwatch.Start();
            linkedlist.Sort();
            worker.ReportProgress(100);
            stopwatch.Stop();
        }
        private void backgroundWorker1_RunWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                foreach (double i in linkedlist)
                {
                    sorttext += i.ToString() + " ";
                }
                rtbSortArray.Text = sorttext;

                TimeSpan timeSpan = stopwatch.Elapsed;
                if (timeSpan.TotalSeconds < 0.01)
                    tbTime.Text = System.Math.Round(timeSpan.TotalMilliseconds, 2).ToString() + "ms";
                else
                    tbTime.Text = System.Math.Round(timeSpan.TotalSeconds, 2).ToString() + "s";
            }

            stopwatch.Reset();
        }
        private void backgroundWorker1_ProgressChangedReported(object sender, ProgressChangedEventArgs e)
        {
            pbsort.Value = e.ProgressPercentage;
        }

        private void btsavetofile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = fileDialog.OpenFile();
                    using (StreamWriter sr = new StreamWriter(fileStream))
                    {
                        sr.WriteLine(sorttext);

                    }
                }
            }
        }
    }
}

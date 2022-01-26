using System.Diagnostics;

namespace Counter
{
    public partial class frmCounter : Form
    {
        private const string Starting_Time = "0:00:00"; //hour, minutes, seconds
        private readonly int FullWidth;
        private readonly int SmallWidth;

        private readonly int FullHeight;
        private readonly int SmallHeight;

        //private Thread timeThread;
        //private ManualResetEvent mre;
        //private Stopwatch stopWatch;

        //bool isThreadRunning;
        public frmCounter()
        {
            InitializeComponent();
            //numericUpDown.Value = numericUpDown.Maximum; //testing, remove when done
            FullWidth = 587;
            SmallWidth = 303;

            //set size on form start up
            FullHeight = 374;
            SmallHeight = 331;

            Width = SmallWidth;
            Height = SmallHeight;

            DisableControls();
            //Gonna scrap the timer feature. Instead, I'll use the system timer as a way to annotate the times
            DisableFeaturesUntilFurtherNotice();
            //Temporaily disabling the Timer feature, I don't see a need to have this in my program
            //stopWatch = new Stopwatch();
            //isThreadRunning = false;

            //mre = new ManualResetEvent(false);
            //timeThread = new Thread(new ThreadStart(HandleStopWatchThread));
        }

        private void DisableFeaturesUntilFurtherNotice()
        {
            groupBox2.Enabled = false;
            chkAnnotateTime.Enabled = false;
            btnResetAll.Enabled = false;
            fileToolStripMenuItem.Enabled = false;
        }

        //private void ResetTime()
        //{
        //    //stop timer as well
        //    if(stopWatch.IsRunning)
        //    {
        //        stopWatch.Reset();
               
        //        //mre.Reset();
        //        //mre.Close();
        //    }
        //    lblTimer.Text = Starting_Time;
        //}

        //private void HandleStopWatchThread()
        //{
        //    mre.WaitOne(); //hmm...

        //    TimeSpan timeSpan;            
        //    stopWatch.Start();
        //    while(isThreadRunning)
        //    {
        //        timeSpan = stopWatch.Elapsed;
        //        if (InvokeRequired)
        //        {
        //            Invoke(new MethodInvoker(() =>
        //                lblTimer.Text = String.Format("{0:0}:{1:00}:{2:00}",
        //                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds)));
        //        }
        //        else
        //            lblTimer.Text = String.Format("{0:0}:{1:00}:{2:00}",
        //                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

        //        //mre.WaitOne(); //https://stackoverflow.com/questions/10469687/how-to-pause-resume-a-thread
        //    }
        //}

        private void EnableControls()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btnResetAll.Enabled = true;

            DisableTimerButtons();
        }
        private void DisableTimerButtons()
        {
            btnPause.Enabled = false;
            btnResetTimer.Enabled = false;
        }

        private void EnableTimerButtons()
        {
            btnPause.Enabled = true;
            btnResetTimer.Enabled = true;
        }
        private void DisableControls()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            btnResetAll.Enabled = false;
        }

        private void ClearFields(bool resetAll = false, 
            bool resetCount = false, bool resetTime = false)
        {
            if(resetAll)
            {
                txtReason.Text = "";                
                txtAnnotate.Text = "";
                txtSetCount.Text = "";

                listAnnotations.Items.Clear();
                numericUpDown.Value = numericUpDown.Minimum;

                //ResetTime();
                btnStartTime.Enabled = true;
                DisableTimerButtons();
            }
            else
            {
                if(resetCount)
                    numericUpDown.Value = numericUpDown.Minimum;
                if(resetTime)
                {
                    //ResetTime();
                }
                                 
            }            
        }

        private void btnResetCount_Click(object sender, EventArgs e)
        {
            ClearFields(false, true, false);
        }

        private void btnSetCount_Click(object sender, EventArgs e)
        {          
            if(Validator.IsInteger(txtSetCount))
                if (Validator.IsWithinRange(txtSetCount, 
                    (int)numericUpDown.Minimum, (int)numericUpDown.Maximum))
                {
                    numericUpDown.Value = Convert.ToInt32(txtSetCount.Text);
                    txtSetCount.Text = "";
                }        
        }

        private void btnAnnotate_Click(object sender, EventArgs e)
        {
            string text = chkAnnotateTime.Checked ? 
                $"{numericUpDown.Value} - {lblTimer.Text} | {txtAnnotate.Text}"
                : $"{numericUpDown.Value} - {txtAnnotate.Text}";

            listAnnotations.Items.Add(text);
            txtAnnotate.Text = "";
            if(numericUpDown.Value != numericUpDown.Maximum)
                numericUpDown.Value++;

            AutoScrollListBox();
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            ClearFields(true);
        }

        private void btnRemoveAnnotation_Click(object sender, EventArgs e)
        {
            if(Validator.IsSelected(listAnnotations))
            {                
                if (listAnnotations.SelectedItems.Count != 0)   
                    while (listAnnotations.SelectedIndex != -1)                      
                        listAnnotations.Items.RemoveAt(listAnnotations.SelectedIndex);

                if (chkDecrement.Checked)
                    if(numericUpDown.Value != numericUpDown.Minimum)
                        numericUpDown.Value--;
            }
        }

        private void chkMoreTools_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMoreTools.Checked)
            {
                EnableControls();
                Width = FullWidth;
                Height = FullHeight;
            }
            else 
            {
                Width = SmallWidth;
                Height = SmallHeight;
                DisableControls();
            }
            DisableFeaturesUntilFurtherNotice();
        }

        //btnStartTime
        private void button1_Click(object sender, EventArgs e)
        {
            btnStartTime.Enabled = false;
            EnableTimerButtons();
            //isThreadRunning = true;
            ////begin thread
            
            //timeThread.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //Pause
            //if(isThreadRunning)
            //{
            //    stopWatch.Stop();
            //    //mre.Reset();
            //    btnPause.Text = "Continue";
            //    //stop timer
            //    isThreadRunning = false;
                
            //}
            //else
            //{
            //    btnPause.Text = "Pause";
            //    //resume timer
            //    //mre.Set();
            //    isThreadRunning = true;
            //    stopWatch.Start();

            //    timeThread.Start();
            //}

        }

        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            
            DisableTimerButtons();
            //end thread
                //stopWatch.Reset();
            //mre.Reset();
            //mre.Close();
                //isThreadRunning = false;
            btnStartTime.Enabled = true;
        }

        private void SaveAsTextFile()
        {
            string fileName = $"{numericUpDown.Value}-{txtReason.Text}";
            save.FileName = fileName;

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream S = File.Open(save.FileName, FileMode.Create))
                {
                    using (StreamWriter st = new StreamWriter(S))
                    {
                        st.WriteLine(fileName);
                        if(chkMoreTools.Checked)
                        {
                            //st.WriteLine(lblTimer.Text);
                            foreach (var aa in listAnnotations.Items)
                                st.WriteLine(aa);
                        }
                        
                        st.Close();
                    }
                    S.Close();
                }
                save.FileName = "";
            }
        }

        private void LoadTextFile()
        {
            string line = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader r = new StreamReader(openFileDialog1.FileName))
                {
                    if(r.ReadLine() != null)
                    {
                        line = r.ReadLine();
                        //It's not getting the first line of the file...
                        string counter = line.Trim('-');
                        counter = counter.Remove(counter.Length - 1);
                        numericUpDown.Value = Convert.ToDecimal(counter);
                        txtReason.Text = line;
                        if (chkMoreTools.Checked)
                        {

                            //I don't think there's a way for me to put the exact time
                            //from the label into the Stopwatch instance
                           // r.ReadLine(); //skipping the label
                          
                            while (line != null)
                            {
                                line = r.ReadLine();
                                if (line != null)
                                    listAnnotations.Items.Add(line);
                            }
                        }
                        
                    }
                    r.Close();
                }
                openFileDialog1.FileName = "";
            }
        }


        private void saveAsTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsTextFile();
        }

        private void loadTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTextFile();
        }

        private void AutoScrollListBox()
        {
            int nItems = listAnnotations.Height / listAnnotations.ItemHeight;
            listAnnotations.TopIndex = listAnnotations.Items.Count - nItems;
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listAnnotations.Items.Clear();
        }
    }
}
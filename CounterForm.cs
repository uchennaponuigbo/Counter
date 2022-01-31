using System.Diagnostics;

namespace Counter
{
    public partial class CounterForm : Form
    {
        //private const string Starting_Time = "0:00:00"; //hour, minutes, seconds
        private readonly int FullWidth;
        private readonly int SmallWidth;

        private readonly int FullHeight;
        private readonly int SmallHeight;

        public CounterForm()
        {
            InitializeComponent();
            //numericUpDown.Value = numericUpDown.Maximum; //testing, remove when done

            FullWidth = 623; //587
            SmallWidth = 290; //303

            //set size on form start up
            FullHeight = 375;
            SmallHeight = 331;

            Width = SmallWidth;
            Height = SmallHeight;

            DisableControls();
            //Gonna scrap the timer feature. Instead, I'll use the system timer as a way to annotate the times

            //disabling the Timer feature, I don't see a need to have this in my program
            //stopWatch = new Stopwatch();
            //isThreadRunning = false;

            //mre = new ManualResetEvent(false);
            //timeThread = new Thread(new ThreadStart(HandleStopWatchThread));
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
            txtListIndex.Enabled = true;
            btnEditList.Enabled = true;
            //groupBox2.Enabled = true;

            //DisableTimerButtons();
        }
        //private void DisableTimerButtons()
        //{
        //    btnPause.Enabled = false;
        //    btnResetTimer.Enabled = false;
        //}

        //private void EnableTimerButtons()
        //{
        //    btnPause.Enabled = true;
        //    btnResetTimer.Enabled = true;
        //}
        private void DisableControls()
        {
            groupBox1.Enabled = false;
            //groupBox2.Enabled = false;
            txtListIndex.Enabled = false;
            btnEditList.Enabled = false;
        }

        private void ClearFields(bool resetAll = false, 
            bool resetCount = false, bool resetTime = false)
        {
            if(resetAll)
            {
                txtReason.Text = "";                
                txtAnnotate.Text = "";
                txtSetCount.Text = "";
                txtListIndex.Text = "";

                listAnnotations.Items.Clear();
                numericUpDown.Value = numericUpDown.Minimum;

                //ResetTime();
                //btnStartTime.Enabled = true;
                //DisableTimerButtons();
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
                $"{numericUpDown.Value} - {DateTime.Now} | {txtAnnotate.Text}"
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
        }

        ////btnStartTime
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    btnStartTime.Enabled = false;
        //    EnableTimerButtons();
        //    //isThreadRunning = true;
        //    ////begin thread
            
        //    //timeThread.Start();
        //}

        //private void btnPause_Click(object sender, EventArgs e)
        //{
        //    //Pause
        //    //if(isThreadRunning)
        //    //{
        //    //    stopWatch.Stop();
        //    //    //mre.Reset();
        //    //    btnPause.Text = "Continue";
        //    //    //stop timer
        //    //    isThreadRunning = false;

        //    //}
        //    //else
        //    //{
        //    //    btnPause.Text = "Pause";
        //    //    //resume timer
        //    //    //mre.Set();
        //    //    isThreadRunning = true;
        //    //    stopWatch.Start();

        //    //    timeThread.Start();
        //    //}

        //}

        //private void btnResetTimer_Click(object sender, EventArgs e)
        //{

        //    DisableTimerButtons();
        //    //end thread
        //    //stopWatch.Reset();
        //    //mre.Reset();
        //    //mre.Close();
        //    //isThreadRunning = false;
        //    btnStartTime.Enabled = true;
        //}

        private void SaveAsTextFile()
        {           
            save.FileName = $"{numericUpDown.Value} - {txtReason.Text}";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream S = File.Open(save.FileName, FileMode.Create))
                {
                    using (StreamWriter st = new StreamWriter(S))
                    {
                        st.WriteLine(numericUpDown.Value);
                        st.WriteLine(txtReason.Text);
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
                    line = r.ReadLine();
                    if(line != null)
                    {                       
                        if (!decimal.TryParse(line, out decimal x))
                        {
                            MessageBox.Show("Invalid file to read from!", "Error");
                            return;
                        }
                            

                        numericUpDown.Value = Convert.ToDecimal(line);

                        line = r.ReadLine();

                        txtReason.Text = line;
                        if (chkMoreTools.Checked)
                        {                         
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
            int items = listAnnotations.Height / listAnnotations.ItemHeight;
            listAnnotations.TopIndex = listAnnotations.Items.Count - items;
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listAnnotations.Items.Clear();
        }

        private void listAnnotations_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listAnnotations, txtListIndex);
        }

        private void btnEditList_Click(object sender, EventArgs e)
        {
            FormatListBox.ChangeValue(listAnnotations, txtListIndex);
        }
    }
}
namespace Counter
{
    public partial class frmCounter : Form
    {
        private const string Starting_Time = "0:00:00"; //hour, minutes, seconds
        public frmCounter()
        {
            InitializeComponent();
            numericUpDown.Value = numericUpDown.Maximum; //testing, remove when done
        }

        private void ResetTime()
        {
            //stop timer as well
            lblTimer.Text = Starting_Time;
        }

        private void ClearFields(bool resetAll = false, 
            bool resetCount = false, bool resetTime = false)
        {
            if(resetAll)
            {
                txtReason.Text = "";
                ResetTime();
                txtAnnotate.Text = "";
                txtSetCount.Text = "";
                listAnnotations.Items.Clear();
                numericUpDown.Value = numericUpDown.Minimum;
            }
            else
            {
                if(resetCount)
                    numericUpDown.Value = numericUpDown.Minimum;
                if(resetTime)
                {
                    ResetTime();
                }
            }
            
        }

        private void frmCounter_Load(object sender, EventArgs e)
        {

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
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnRemoveAnnotation_Click(object sender, EventArgs e)
        {
            if(Validator.IsSelected(listAnnotations))
            {                
                if (listAnnotations.SelectedItems.Count != 0)   
                    while (listAnnotations.SelectedIndex != -1)                      
                        listAnnotations.Items.RemoveAt(listAnnotations.SelectedIndex);                                   
            }
        }

        private void chkMoreTools_CheckedChanged(object sender, EventArgs e)
        {
            //562, 325
        }

        private void txtSetCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
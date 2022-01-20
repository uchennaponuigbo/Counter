namespace Counter
{
    partial class frmCounter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnAnnotate = new System.Windows.Forms.Button();
            this.txtAnnotate = new System.Windows.Forms.TextBox();
            this.listAnnotations = new System.Windows.Forms.ListBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnResetCount = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnSetCount = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.txtSetCount = new System.Windows.Forms.TextBox();
            this.btnResetTimer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRemoveAnnotation = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkAnnotateTime = new System.Windows.Forms.CheckBox();
            this.chkMoreTools = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reason for Counting";
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(441, 21);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(105, 39);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "0:00:00";
            // 
            // btnAnnotate
            // 
            this.btnAnnotate.Location = new System.Drawing.Point(6, 42);
            this.btnAnnotate.Name = "btnAnnotate";
            this.btnAnnotate.Size = new System.Drawing.Size(75, 25);
            this.btnAnnotate.TabIndex = 2;
            this.btnAnnotate.Text = "Annotate";
            this.btnAnnotate.UseVisualStyleBackColor = true;
            this.btnAnnotate.Click += new System.EventHandler(this.btnAnnotate_Click);
            // 
            // txtAnnotate
            // 
            this.txtAnnotate.Location = new System.Drawing.Point(91, 42);
            this.txtAnnotate.Name = "txtAnnotate";
            this.txtAnnotate.Size = new System.Drawing.Size(112, 23);
            this.txtAnnotate.TabIndex = 3;
            // 
            // listAnnotations
            // 
            this.listAnnotations.FormattingEnabled = true;
            this.listAnnotations.ItemHeight = 15;
            this.listAnnotations.Location = new System.Drawing.Point(6, 73);
            this.listAnnotations.Name = "listAnnotations";
            this.listAnnotations.Size = new System.Drawing.Size(206, 94);
            this.listAnnotations.TabIndex = 4;
            this.listAnnotations.Tag = "Annotation List";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(12, 51);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(256, 23);
            this.txtReason.TabIndex = 5;
            // 
            // btnResetCount
            // 
            this.btnResetCount.Location = new System.Drawing.Point(173, 88);
            this.btnResetCount.Name = "btnResetCount";
            this.btnResetCount.Size = new System.Drawing.Size(90, 38);
            this.btnResetCount.TabIndex = 6;
            this.btnResetCount.Text = "Reset Counter";
            this.btnResetCount.UseVisualStyleBackColor = true;
            this.btnResetCount.Click += new System.EventHandler(this.btnResetCount_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown.Location = new System.Drawing.Point(12, 80);
            this.numericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.ReadOnly = true;
            this.numericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown.Size = new System.Drawing.Size(155, 61);
            this.numericUpDown.TabIndex = 7;
            // 
            // btnSetCount
            // 
            this.btnSetCount.Location = new System.Drawing.Point(12, 153);
            this.btnSetCount.Name = "btnSetCount";
            this.btnSetCount.Size = new System.Drawing.Size(104, 32);
            this.btnSetCount.TabIndex = 8;
            this.btnSetCount.Text = "Set Count Value";
            this.btnSetCount.UseVisualStyleBackColor = true;
            this.btnSetCount.Click += new System.EventHandler(this.btnSetCount_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(242, 259);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(86, 45);
            this.btnResetAll.TabIndex = 9;
            this.btnResetAll.Text = "Reset and Clear All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // txtSetCount
            // 
            this.txtSetCount.Location = new System.Drawing.Point(122, 162);
            this.txtSetCount.MaxLength = 6;
            this.txtSetCount.Name = "txtSetCount";
            this.txtSetCount.Size = new System.Drawing.Size(45, 23);
            this.txtSetCount.TabIndex = 10;
            this.txtSetCount.Tag = "Set Count Text Box";
            this.txtSetCount.TextChanged += new System.EventHandler(this.txtSetCount_TextChanged);
            // 
            // btnResetTimer
            // 
            this.btnResetTimer.Location = new System.Drawing.Point(454, 63);
            this.btnResetTimer.Name = "btnResetTimer";
            this.btnResetTimer.Size = new System.Drawing.Size(83, 28);
            this.btnResetTimer.TabIndex = 11;
            this.btnResetTimer.Text = "Reset Time";
            this.btnResetTimer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearList);
            this.groupBox1.Controls.Add(this.listAnnotations);
            this.groupBox1.Controls.Add(this.chkAnnotateTime);
            this.groupBox1.Controls.Add(this.btnAnnotate);
            this.groupBox1.Controls.Add(this.btnRemoveAnnotation);
            this.groupBox1.Controls.Add(this.txtAnnotate);
            this.groupBox1.Location = new System.Drawing.Point(334, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 200);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(137, 173);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 25);
            this.btnClearList.TabIndex = 18;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start Time";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(352, 63);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(83, 28);
            this.btnPause.TabIndex = 14;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAnnotation
            // 
            this.btnRemoveAnnotation.Location = new System.Drawing.Point(8, 173);
            this.btnRemoveAnnotation.Name = "btnRemoveAnnotation";
            this.btnRemoveAnnotation.Size = new System.Drawing.Size(123, 25);
            this.btnRemoveAnnotation.TabIndex = 15;
            this.btnRemoveAnnotation.Text = "Remove Annotation";
            this.btnRemoveAnnotation.UseVisualStyleBackColor = true;
            this.btnRemoveAnnotation.Click += new System.EventHandler(this.btnRemoveAnnotation_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsTextFileToolStripMenuItem,
            this.loadTextFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsTextFileToolStripMenuItem
            // 
            this.saveAsTextFileToolStripMenuItem.Name = "saveAsTextFileToolStripMenuItem";
            this.saveAsTextFileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveAsTextFileToolStripMenuItem.Text = "Save As Text File...";
            // 
            // loadTextFileToolStripMenuItem
            // 
            this.loadTextFileToolStripMenuItem.Name = "loadTextFileToolStripMenuItem";
            this.loadTextFileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadTextFileToolStripMenuItem.Text = "Load Text File...";
            // 
            // chkAnnotateTime
            // 
            this.chkAnnotateTime.AutoSize = true;
            this.chkAnnotateTime.Location = new System.Drawing.Point(8, 17);
            this.chkAnnotateTime.Name = "chkAnnotateTime";
            this.chkAnnotateTime.Size = new System.Drawing.Size(104, 19);
            this.chkAnnotateTime.TabIndex = 17;
            this.chkAnnotateTime.Text = "Annotate Time";
            this.chkAnnotateTime.UseVisualStyleBackColor = true;
            // 
            // chkMoreTools
            // 
            this.chkMoreTools.AutoSize = true;
            this.chkMoreTools.Location = new System.Drawing.Point(173, 151);
            this.chkMoreTools.Name = "chkMoreTools";
            this.chkMoreTools.Size = new System.Drawing.Size(78, 34);
            this.chkMoreTools.TabIndex = 18;
            this.chkMoreTools.Text = "See More \r\nTools";
            this.chkMoreTools.UseVisualStyleBackColor = true;
            this.chkMoreTools.CheckedChanged += new System.EventHandler(this.chkMoreTools_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 72);
            this.label2.TabIndex = 19;
            this.label2.Text = "Clicking on the numeric textbox allows you to control the values \r\nwith your keyb" +
    "oard Up and Down Arrows respectively";
            // 
            // frmCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkMoreTools);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetTimer);
            this.Controls.Add(this.txtSetCount);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnSetCount);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.btnResetCount);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCounter";
            this.Text = "Incrementer";
            this.Load += new System.EventHandler(this.frmCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblTimer;
        private Button btnAnnotate;
        private TextBox txtAnnotate;
        private ListBox listAnnotations;
        private TextBox txtReason;
        private Button btnResetCount;
        private NumericUpDown numericUpDown;
        private Button btnSetCount;
        private Button btnResetAll;
        private TextBox txtSetCount;
        private Button btnResetTimer;
        private GroupBox groupBox1;
        private Button button1;
        private Button btnPause;
        private Button btnRemoveAnnotation;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsTextFileToolStripMenuItem;
        private ToolStripMenuItem loadTextFileToolStripMenuItem;
        private CheckBox chkAnnotateTime;
        private Button btnClearList;
        private CheckBox chkMoreTools;
        private Label label2;
    }
}
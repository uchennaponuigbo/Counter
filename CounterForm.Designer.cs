namespace Counter
{
    partial class CounterForm
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
            this.btnAnnotate = new System.Windows.Forms.Button();
            this.txtAnnotate = new System.Windows.Forms.TextBox();
            this.listAnnotations = new System.Windows.Forms.ListBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnResetCount = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnSetCount = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.txtSetCount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDecrement = new System.Windows.Forms.CheckBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.chkAnnotateTime = new System.Windows.Forms.CheckBox();
            this.btnRemoveAnnotation = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkMoreTools = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtListIndex = new System.Windows.Forms.TextBox();
            this.btnEditList = new System.Windows.Forms.Button();
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
            this.txtAnnotate.Size = new System.Drawing.Size(224, 23);
            this.txtAnnotate.TabIndex = 3;
            // 
            // listAnnotations
            // 
            this.listAnnotations.FormattingEnabled = true;
            this.listAnnotations.ItemHeight = 15;
            this.listAnnotations.Location = new System.Drawing.Point(6, 73);
            this.listAnnotations.Name = "listAnnotations";
            this.listAnnotations.Size = new System.Drawing.Size(309, 154);
            this.listAnnotations.TabIndex = 4;
            this.listAnnotations.Tag = "Annotation List";
            this.listAnnotations.SelectedIndexChanged += new System.EventHandler(this.listAnnotations_SelectedIndexChanged);
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
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSetCount
            // 
            this.btnSetCount.Location = new System.Drawing.Point(12, 162);
            this.btnSetCount.Name = "btnSetCount";
            this.btnSetCount.Size = new System.Drawing.Size(104, 32);
            this.btnSetCount.TabIndex = 8;
            this.btnSetCount.Text = "Set Count Value";
            this.btnSetCount.UseVisualStyleBackColor = true;
            this.btnSetCount.Click += new System.EventHandler(this.btnSetCount_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(228, 235);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(83, 25);
            this.btnResetAll.TabIndex = 9;
            this.btnResetAll.Text = "Clear All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // txtSetCount
            // 
            this.txtSetCount.Location = new System.Drawing.Point(122, 167);
            this.txtSetCount.MaxLength = 6;
            this.txtSetCount.Name = "txtSetCount";
            this.txtSetCount.Size = new System.Drawing.Size(45, 23);
            this.txtSetCount.TabIndex = 10;
            this.txtSetCount.Tag = "Set Count Text Box";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDecrement);
            this.groupBox1.Controls.Add(this.btnClearList);
            this.groupBox1.Controls.Add(this.listAnnotations);
            this.groupBox1.Controls.Add(this.chkAnnotateTime);
            this.groupBox1.Controls.Add(this.btnAnnotate);
            this.groupBox1.Controls.Add(this.btnRemoveAnnotation);
            this.groupBox1.Controls.Add(this.btnResetAll);
            this.groupBox1.Controls.Add(this.txtAnnotate);
            this.groupBox1.Location = new System.Drawing.Point(274, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 264);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // chkDecrement
            // 
            this.chkDecrement.AutoSize = true;
            this.chkDecrement.Location = new System.Drawing.Point(165, 17);
            this.chkDecrement.Name = "chkDecrement";
            this.chkDecrement.Size = new System.Drawing.Size(150, 19);
            this.chkDecrement.TabIndex = 19;
            this.chkDecrement.Text = "Decrement on Removal";
            this.chkDecrement.UseVisualStyleBackColor = true;
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(135, 235);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(83, 25);
            this.btnClearList.TabIndex = 18;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // chkAnnotateTime
            // 
            this.chkAnnotateTime.AutoSize = true;
            this.chkAnnotateTime.Location = new System.Drawing.Point(8, 17);
            this.chkAnnotateTime.Name = "chkAnnotateTime";
            this.chkAnnotateTime.Size = new System.Drawing.Size(154, 19);
            this.chkAnnotateTime.TabIndex = 17;
            this.chkAnnotateTime.Text = "Annotate Time and Date";
            this.chkAnnotateTime.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAnnotation
            // 
            this.btnRemoveAnnotation.Location = new System.Drawing.Point(6, 235);
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
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
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
            this.saveAsTextFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsTextFileToolStripMenuItem_Click);
            // 
            // loadTextFileToolStripMenuItem
            // 
            this.loadTextFileToolStripMenuItem.Name = "loadTextFileToolStripMenuItem";
            this.loadTextFileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadTextFileToolStripMenuItem.Text = "Load Text File...";
            this.loadTextFileToolStripMenuItem.Click += new System.EventHandler(this.loadTextFileToolStripMenuItem_Click);
            // 
            // chkMoreTools
            // 
            this.chkMoreTools.AutoSize = true;
            this.chkMoreTools.Location = new System.Drawing.Point(179, 140);
            this.chkMoreTools.Name = "chkMoreTools";
            this.chkMoreTools.Size = new System.Drawing.Size(84, 19);
            this.chkMoreTools.TabIndex = 18;
            this.chkMoreTools.Text = "More Tools";
            this.chkMoreTools.UseVisualStyleBackColor = true;
            this.chkMoreTools.CheckedChanged += new System.EventHandler(this.chkMoreTools_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 72);
            this.label2.TabIndex = 19;
            this.label2.Text = "Clicking on the numeric textbox allows you to control the values \r\nwith your keyb" +
    "oard Up and Down Arrows respectively";
            // 
            // save
            // 
            this.save.Filter = "Text files (*.txt)|*.txt";
            this.save.Title = "Save as Text File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Text files (*.txt)|*.txt";
            // 
            // txtListIndex
            // 
            this.txtListIndex.Location = new System.Drawing.Point(12, 304);
            this.txtListIndex.Name = "txtListIndex";
            this.txtListIndex.Size = new System.Drawing.Size(496, 23);
            this.txtListIndex.TabIndex = 20;
            // 
            // btnEditList
            // 
            this.btnEditList.Location = new System.Drawing.Point(516, 303);
            this.btnEditList.Name = "btnEditList";
            this.btnEditList.Size = new System.Drawing.Size(75, 25);
            this.btnEditList.TabIndex = 21;
            this.btnEditList.Text = "Edit";
            this.btnEditList.UseVisualStyleBackColor = true;
            this.btnEditList.Click += new System.EventHandler(this.btnEditList_Click);
            // 
            // CounterForm
            // 
            this.AcceptButton = this.btnAnnotate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 340);
            this.Controls.Add(this.btnEditList);
            this.Controls.Add(this.txtListIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkMoreTools);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSetCount);
            this.Controls.Add(this.btnSetCount);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.btnResetCount);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CounterForm";
            this.Text = "Incrementer";
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
        private Button btnAnnotate;
        private TextBox txtAnnotate;
        private ListBox listAnnotations;
        private TextBox txtReason;
        private Button btnResetCount;
        private NumericUpDown numericUpDown;
        private Button btnSetCount;
        private Button btnResetAll;
        private TextBox txtSetCount;
        private GroupBox groupBox1;
        private Button btnRemoveAnnotation;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsTextFileToolStripMenuItem;
        private ToolStripMenuItem loadTextFileToolStripMenuItem;
        private CheckBox chkAnnotateTime;
        private Button btnClearList;
        private CheckBox chkMoreTools;
        private Label label2;
        private CheckBox chkDecrement;
        private SaveFileDialog save;
        private OpenFileDialog openFileDialog1;
        private TextBox txtListIndex;
        private Button btnEditList;
    }
}
namespace MassEffect3Extractor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupFileType = new System.Windows.Forms.GroupBox();
            this.radioTypeAny = new System.Windows.Forms.RadioButton();
            this.radioTypeSfar = new System.Windows.Forms.RadioButton();
            this.radioTypePcc = new System.Windows.Forms.RadioButton();
            this.radioTypeAfc = new System.Windows.Forms.RadioButton();
            this.groupMethod = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioMethodDir = new System.Windows.Forms.RadioButton();
            this.radioMethodFiles = new System.Windows.Forms.RadioButton();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.radioOutputStructure = new System.Windows.Forms.RadioButton();
            this.radioOutputFolder = new System.Windows.Forms.RadioButton();
            this.radioOutputAll = new System.Windows.Forms.RadioButton();
            this.textFileCount = new System.Windows.Forms.TextBox();
            this.labelFileCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelOpenFiles = new System.Windows.Forms.Label();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.buttonOpenOutput = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.buttonOpenInput = new System.Windows.Forms.Button();
            this.openFiles = new System.Windows.Forms.OpenFileDialog();
            this.folderSave = new System.Windows.Forms.FolderBrowserDialog();
            this.folderOpen = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUnpack = new System.Windows.Forms.Button();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.labelExtractedCount = new System.Windows.Forms.Label();
            this.labelFileProgress = new System.Windows.Forms.Label();
            this.labelOverallPercent = new System.Windows.Forms.Label();
            this.labelOverallProgress = new System.Windows.Forms.Label();
            this.progressOverall = new System.Windows.Forms.ProgressBar();
            this.labelCurrentPercent = new System.Windows.Forms.Label();
            this.labelCurrentAction = new System.Windows.Forms.Label();
            this.progressCurrent = new System.Windows.Forms.ProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupFileType.SuspendLayout();
            this.groupMethod.SuspendLayout();
            this.groupOutput.SuspendLayout();
            this.groupStatus.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFileType
            // 
            this.groupFileType.Controls.Add(this.radioTypeAny);
            this.groupFileType.Controls.Add(this.radioTypeSfar);
            this.groupFileType.Controls.Add(this.radioTypePcc);
            this.groupFileType.Controls.Add(this.radioTypeAfc);
            this.groupFileType.Location = new System.Drawing.Point(12, 27);
            this.groupFileType.Name = "groupFileType";
            this.groupFileType.Size = new System.Drawing.Size(420, 70);
            this.groupFileType.TabIndex = 1;
            this.groupFileType.TabStop = false;
            this.groupFileType.Text = "File type";
            // 
            // radioTypeAny
            // 
            this.radioTypeAny.AutoSize = true;
            this.radioTypeAny.Location = new System.Drawing.Point(213, 43);
            this.radioTypeAny.Name = "radioTypeAny";
            this.radioTypeAny.Size = new System.Drawing.Size(79, 17);
            this.radioTypeAny.TabIndex = 3;
            this.radioTypeAny.Text = ".* (any files)";
            this.radioTypeAny.UseVisualStyleBackColor = true;
            this.radioTypeAny.CheckedChanged += new System.EventHandler(this.radioTypeAny_CheckedChanged);
            // 
            // radioTypeSfar
            // 
            this.radioTypeSfar.AutoSize = true;
            this.radioTypeSfar.Location = new System.Drawing.Point(213, 20);
            this.radioTypeSfar.Name = "radioTypeSfar";
            this.radioTypeSfar.Size = new System.Drawing.Size(190, 17);
            this.radioTypeSfar.TabIndex = 2;
            this.radioTypeSfar.Text = ".sfar (DLC content) - slow scanning";
            this.radioTypeSfar.UseVisualStyleBackColor = true;
            this.radioTypeSfar.CheckedChanged += new System.EventHandler(this.radioTypeSfar_CheckedChanged);
            // 
            // radioTypePcc
            // 
            this.radioTypePcc.AutoSize = true;
            this.radioTypePcc.Location = new System.Drawing.Point(7, 43);
            this.radioTypePcc.Name = "radioTypePcc";
            this.radioTypePcc.Size = new System.Drawing.Size(151, 17);
            this.radioTypePcc.TabIndex = 1;
            this.radioTypePcc.Text = ".pcc (SFX) - slow scanning";
            this.radioTypePcc.UseVisualStyleBackColor = true;
            this.radioTypePcc.CheckedChanged += new System.EventHandler(this.radioTypePcc_CheckedChanged);
            // 
            // radioTypeAfc
            // 
            this.radioTypeAfc.AutoSize = true;
            this.radioTypeAfc.Checked = true;
            this.radioTypeAfc.Location = new System.Drawing.Point(7, 20);
            this.radioTypeAfc.Name = "radioTypeAfc";
            this.radioTypeAfc.Size = new System.Drawing.Size(197, 17);
            this.radioTypeAfc.TabIndex = 0;
            this.radioTypeAfc.TabStop = true;
            this.radioTypeAfc.Text = ".afc (voices, music) - quick scanning";
            this.radioTypeAfc.UseVisualStyleBackColor = true;
            this.radioTypeAfc.CheckedChanged += new System.EventHandler(this.radioTypeAfc_CheckedChanged);
            // 
            // groupMethod
            // 
            this.groupMethod.Controls.Add(this.button1);
            this.groupMethod.Controls.Add(this.radioMethodDir);
            this.groupMethod.Controls.Add(this.radioMethodFiles);
            this.groupMethod.Location = new System.Drawing.Point(12, 103);
            this.groupMethod.Name = "groupMethod";
            this.groupMethod.Size = new System.Drawing.Size(457, 38);
            this.groupMethod.TabIndex = 19;
            this.groupMethod.TabStop = false;
            this.groupMethod.Text = "Extraction method";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Get ME3 install dir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioMethodDir
            // 
            this.radioMethodDir.AutoSize = true;
            this.radioMethodDir.Location = new System.Drawing.Point(123, 15);
            this.radioMethodDir.Name = "radioMethodDir";
            this.radioMethodDir.Size = new System.Drawing.Size(192, 17);
            this.radioMethodDir.TabIndex = 20;
            this.radioMethodDir.Text = "Select directory containing .afc files";
            this.radioMethodDir.UseVisualStyleBackColor = true;
            this.radioMethodDir.CheckedChanged += new System.EventHandler(this.radioMethodDir_CheckedChanged);
            // 
            // radioMethodFiles
            // 
            this.radioMethodFiles.AutoSize = true;
            this.radioMethodFiles.Checked = true;
            this.radioMethodFiles.Location = new System.Drawing.Point(6, 15);
            this.radioMethodFiles.Name = "radioMethodFiles";
            this.radioMethodFiles.Size = new System.Drawing.Size(97, 17);
            this.radioMethodFiles.TabIndex = 19;
            this.radioMethodFiles.TabStop = true;
            this.radioMethodFiles.Text = "Select .afc files";
            this.radioMethodFiles.UseVisualStyleBackColor = true;
            this.radioMethodFiles.CheckedChanged += new System.EventHandler(this.radioMethodFiles_CheckedChanged);
            // 
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.radioOutputStructure);
            this.groupOutput.Controls.Add(this.radioOutputFolder);
            this.groupOutput.Controls.Add(this.radioOutputAll);
            this.groupOutput.Location = new System.Drawing.Point(15, 261);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(454, 66);
            this.groupOutput.TabIndex = 28;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "Output directories:";
            // 
            // radioOutputStructure
            // 
            this.radioOutputStructure.AutoSize = true;
            this.radioOutputStructure.Location = new System.Drawing.Point(219, 19);
            this.radioOutputStructure.Name = "radioOutputStructure";
            this.radioOutputStructure.Size = new System.Drawing.Size(229, 17);
            this.radioOutputStructure.TabIndex = 2;
            this.radioOutputStructure.Text = "Extract according to original folder structure";
            this.radioOutputStructure.UseVisualStyleBackColor = true;
            this.radioOutputStructure.Visible = false;
            this.radioOutputStructure.CheckedChanged += new System.EventHandler(this.radioOutputStructure_CheckedChanged);
            // 
            // radioOutputFolder
            // 
            this.radioOutputFolder.AutoSize = true;
            this.radioOutputFolder.Checked = true;
            this.radioOutputFolder.Location = new System.Drawing.Point(6, 42);
            this.radioOutputFolder.Name = "radioOutputFolder";
            this.radioOutputFolder.Size = new System.Drawing.Size(319, 17);
            this.radioOutputFolder.TabIndex = 1;
            this.radioOutputFolder.TabStop = true;
            this.radioOutputFolder.Text = "Extract each .afc file to separate folder named as .afc filename";
            this.radioOutputFolder.UseVisualStyleBackColor = true;
            this.radioOutputFolder.CheckedChanged += new System.EventHandler(this.radioOutputFolder_CheckedChanged);
            // 
            // radioOutputAll
            // 
            this.radioOutputAll.AutoSize = true;
            this.radioOutputAll.Location = new System.Drawing.Point(6, 19);
            this.radioOutputAll.Name = "radioOutputAll";
            this.radioOutputAll.Size = new System.Drawing.Size(154, 17);
            this.radioOutputAll.TabIndex = 0;
            this.radioOutputAll.Text = "Extract all files to one folder";
            this.radioOutputAll.UseVisualStyleBackColor = true;
            this.radioOutputAll.CheckedChanged += new System.EventHandler(this.radioOutputAll_CheckedChanged);
            // 
            // textFileCount
            // 
            this.textFileCount.Enabled = false;
            this.textFileCount.Location = new System.Drawing.Point(350, 198);
            this.textFileCount.Name = "textFileCount";
            this.textFileCount.Size = new System.Drawing.Size(39, 20);
            this.textFileCount.TabIndex = 27;
            this.textFileCount.Text = "0";
            // 
            // labelFileCount
            // 
            this.labelFileCount.AutoSize = true;
            this.labelFileCount.Location = new System.Drawing.Point(252, 201);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(92, 13);
            this.labelFileCount.TabIndex = 26;
            this.labelFileCount.Text = ".afc files selected:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Set directory for processed files:";
            // 
            // labelOpenFiles
            // 
            this.labelOpenFiles.AutoSize = true;
            this.labelOpenFiles.Location = new System.Drawing.Point(12, 155);
            this.labelOpenFiles.Name = "labelOpenFiles";
            this.labelOpenFiles.Size = new System.Drawing.Size(84, 13);
            this.labelOpenFiles.TabIndex = 24;
            this.labelOpenFiles.Text = "Open .afc file(s):";
            // 
            // textOutput
            // 
            this.textOutput.Enabled = false;
            this.textOutput.Location = new System.Drawing.Point(13, 235);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(376, 20);
            this.textOutput.TabIndex = 23;
            // 
            // buttonOpenOutput
            // 
            this.buttonOpenOutput.Location = new System.Drawing.Point(395, 235);
            this.buttonOpenOutput.Name = "buttonOpenOutput";
            this.buttonOpenOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenOutput.TabIndex = 22;
            this.buttonOpenOutput.Text = "Open";
            this.buttonOpenOutput.UseVisualStyleBackColor = true;
            this.buttonOpenOutput.Click += new System.EventHandler(this.buttonOpenOutput_Click);
            // 
            // textInput
            // 
            this.textInput.Enabled = false;
            this.textInput.Location = new System.Drawing.Point(13, 171);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(376, 20);
            this.textInput.TabIndex = 21;
            // 
            // buttonOpenInput
            // 
            this.buttonOpenInput.Location = new System.Drawing.Point(395, 171);
            this.buttonOpenInput.Name = "buttonOpenInput";
            this.buttonOpenInput.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenInput.TabIndex = 20;
            this.buttonOpenInput.Text = "Open";
            this.buttonOpenInput.UseVisualStyleBackColor = true;
            this.buttonOpenInput.Click += new System.EventHandler(this.buttonOpenInput_Click);
            // 
            // openFiles
            // 
            this.openFiles.Filter = "AFC files (*.afc)|*.afc|PCC files (*.pcc)|*.pcc|SFAR files (*.sfar)|*.sfar|All fi" +
                "les (*.*)|*.*";
            this.openFiles.Multiselect = true;
            this.openFiles.FileOk += new System.ComponentModel.CancelEventHandler(this.openFiles_FileOk);
            // 
            // folderOpen
            // 
            this.folderOpen.ShowNewFolderButton = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Updated for\r\nMass Effect 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Created by Kyp";
            // 
            // buttonUnpack
            // 
            this.buttonUnpack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUnpack.Location = new System.Drawing.Point(136, 487);
            this.buttonUnpack.Name = "buttonUnpack";
            this.buttonUnpack.Size = new System.Drawing.Size(214, 38);
            this.buttonUnpack.TabIndex = 29;
            this.buttonUnpack.Text = "UNPACK!";
            this.buttonUnpack.UseVisualStyleBackColor = true;
            this.buttonUnpack.Click += new System.EventHandler(this.button3_Click);
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.labelExtractedCount);
            this.groupStatus.Controls.Add(this.labelFileProgress);
            this.groupStatus.Controls.Add(this.labelOverallPercent);
            this.groupStatus.Controls.Add(this.labelOverallProgress);
            this.groupStatus.Controls.Add(this.progressOverall);
            this.groupStatus.Controls.Add(this.labelCurrentPercent);
            this.groupStatus.Controls.Add(this.labelCurrentAction);
            this.groupStatus.Controls.Add(this.progressCurrent);
            this.groupStatus.Location = new System.Drawing.Point(15, 334);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(448, 147);
            this.groupStatus.TabIndex = 32;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "Extraction progress";
            // 
            // labelExtractedCount
            // 
            this.labelExtractedCount.AutoSize = true;
            this.labelExtractedCount.Location = new System.Drawing.Point(175, 73);
            this.labelExtractedCount.Name = "labelExtractedCount";
            this.labelExtractedCount.Size = new System.Drawing.Size(81, 13);
            this.labelExtractedCount.TabIndex = 7;
            this.labelExtractedCount.Text = "0 files extracted";
            // 
            // labelFileProgress
            // 
            this.labelFileProgress.AutoSize = true;
            this.labelFileProgress.Location = new System.Drawing.Point(196, 126);
            this.labelFileProgress.Name = "labelFileProgress";
            this.labelFileProgress.Size = new System.Drawing.Size(33, 13);
            this.labelFileProgress.TabIndex = 6;
            this.labelFileProgress.Text = "None";
            this.labelFileProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOverallPercent
            // 
            this.labelOverallPercent.AutoSize = true;
            this.labelOverallPercent.Location = new System.Drawing.Point(405, 73);
            this.labelOverallPercent.Name = "labelOverallPercent";
            this.labelOverallPercent.Size = new System.Drawing.Size(21, 13);
            this.labelOverallPercent.TabIndex = 5;
            this.labelOverallPercent.Text = "0%";
            // 
            // labelOverallProgress
            // 
            this.labelOverallProgress.AutoSize = true;
            this.labelOverallProgress.Location = new System.Drawing.Point(7, 73);
            this.labelOverallProgress.Name = "labelOverallProgress";
            this.labelOverallProgress.Size = new System.Drawing.Size(86, 13);
            this.labelOverallProgress.TabIndex = 4;
            this.labelOverallProgress.Text = "Overall progress:";
            // 
            // progressOverall
            // 
            this.progressOverall.Location = new System.Drawing.Point(6, 89);
            this.progressOverall.Name = "progressOverall";
            this.progressOverall.Size = new System.Drawing.Size(435, 23);
            this.progressOverall.TabIndex = 3;
            // 
            // labelCurrentPercent
            // 
            this.labelCurrentPercent.AutoSize = true;
            this.labelCurrentPercent.Location = new System.Drawing.Point(405, 20);
            this.labelCurrentPercent.Name = "labelCurrentPercent";
            this.labelCurrentPercent.Size = new System.Drawing.Size(21, 13);
            this.labelCurrentPercent.TabIndex = 2;
            this.labelCurrentPercent.Text = "0%";
            // 
            // labelCurrentAction
            // 
            this.labelCurrentAction.AutoSize = true;
            this.labelCurrentAction.Location = new System.Drawing.Point(7, 20);
            this.labelCurrentAction.Name = "labelCurrentAction";
            this.labelCurrentAction.Size = new System.Drawing.Size(94, 13);
            this.labelCurrentAction.TabIndex = 1;
            this.labelCurrentAction.Text = "Current status: idle";
            // 
            // progressCurrent
            // 
            this.progressCurrent.Location = new System.Drawing.Point(6, 36);
            this.progressCurrent.Name = "progressCurrent";
            this.progressCurrent.Size = new System.Drawing.Size(435, 23);
            this.progressCurrent.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(482, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(318, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(152, 13);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://kypapps.co.cc/afc2ogg";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 535);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUnpack);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.textFileCount);
            this.Controls.Add(this.labelFileCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOpenFiles);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.buttonOpenOutput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.buttonOpenInput);
            this.Controls.Add(this.groupMethod);
            this.Controls.Add(this.groupFileType);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = ".afc/.pcc to .ogg multi unpacker - afc2ogg - 1.4.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupFileType.ResumeLayout(false);
            this.groupFileType.PerformLayout();
            this.groupMethod.ResumeLayout(false);
            this.groupMethod.PerformLayout();
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFileType;
        private System.Windows.Forms.RadioButton radioTypeAny;
        private System.Windows.Forms.RadioButton radioTypeSfar;
        private System.Windows.Forms.RadioButton radioTypePcc;
        private System.Windows.Forms.RadioButton radioTypeAfc;
        private System.Windows.Forms.GroupBox groupMethod;
        private System.Windows.Forms.RadioButton radioMethodDir;
        private System.Windows.Forms.RadioButton radioMethodFiles;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.RadioButton radioOutputStructure;
        private System.Windows.Forms.RadioButton radioOutputFolder;
        private System.Windows.Forms.RadioButton radioOutputAll;
        private System.Windows.Forms.TextBox textFileCount;
        private System.Windows.Forms.Label labelFileCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOpenFiles;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button buttonOpenOutput;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button buttonOpenInput;
        private System.Windows.Forms.OpenFileDialog openFiles;
        private System.Windows.Forms.FolderBrowserDialog folderSave;
        private System.Windows.Forms.FolderBrowserDialog folderOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUnpack;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.Label labelFileProgress;
        private System.Windows.Forms.Label labelOverallPercent;
        private System.Windows.Forms.Label labelOverallProgress;
        private System.Windows.Forms.ProgressBar progressOverall;
        private System.Windows.Forms.Label labelCurrentPercent;
        private System.Windows.Forms.Label labelCurrentAction;
        private System.Windows.Forms.ProgressBar progressCurrent;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelExtractedCount;
        private System.Windows.Forms.Button button1;
    }
}


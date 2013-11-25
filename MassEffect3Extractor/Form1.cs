using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MassEffect3Tools;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;

namespace MassEffect3Extractor
{
    public partial class Form1 : Form
    {
        private string filetype;
        private bool exmethod;
        private List<string> files;
        private string inputDirectory;
        private string outputDirectory;
        private int convState;
        private ProcessingMode processingMode;
        ProcessingMode.OutputMode outputMode;
        Thread thread;

        public Form1()
        {
            if (!FilesInPlace())
            {
                MessageBox.Show("Some of the required applications are not in place. Make sure there is a folder 'data' containing tools for extraction. The program will now close.");
                Environment.Exit(0);
            }

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            InitializeComponent();
            filetype = ".afc";
            exmethod = true;
            Lockdown(true);
            files = new List<string>();
            outputMode = ProcessingMode.OutputMode.SeparateDirectory;
            Progress.Reset(1);
            convState = 0;
            updateNames();            
        }

        private void updateNames()
        {
            radioMethodFiles.Text = "Select " + filetype + " files";
            radioMethodDir.Text = "Select directory containing " + filetype + " files";
            labelOpenFiles.Text = "Open " + (exmethod ? filetype + " file(s):" : "directory:");
            labelFileCount.Text = filetype + " files selected:";
            radioOutputFolder.Text = "Extract each " + filetype + " file to separate folder named as " + filetype + " filename";
            textFileCount.Text = files.Count.ToString();
            textOutput.Text = outputDirectory;
            switch (exmethod)
            {
                case true:
                    textInput.Lines = files.ToArray();
                    radioOutputStructure.Hide();
                    if (radioOutputStructure.Checked)
                    {
                        radioOutputFolder.Select();
                    }
                    break;
                case false:
                    textInput.Text = inputDirectory;
                    radioOutputStructure.Show();
                    break;
            }
            switch (filetype)
            {
                case ".afc":
                    openFiles.FilterIndex = 1;
                    break;
                case ".pcc":
                    openFiles.FilterIndex = 2;
                    break;
                case ".sfar":
                    openFiles.FilterIndex = 3;
                    break;
                case ".*":
                    openFiles.FilterIndex = 4;
                    break;
                default:
                    break;
            }
        }

        private void clearChoice()
        {
            files.Clear();
            inputDirectory = "";
        }

        private void AddFiles(string path, IList<string> files)
        {
            try
            {
                foreach (string s in Directory.GetFiles(path).ToList())
                {
                    if (filetype==".*" || s.EndsWith(filetype)) files.Add(s);
                }

                Directory.GetDirectories(path)
                    .ToList()
                    .ForEach(s => AddFiles(s, files));
            }
            catch (UnauthorizedAccessException)
            {
                // ok, so we are not allowed to dig into that directory. Move on.
            }
        }

        private void radioTypeSfar_CheckedChanged(object sender, EventArgs e)
        {
            filetype = ".sfar";
            clearChoice();
            updateNames();
        }
        private void radioTypePcc_CheckedChanged(object sender, EventArgs e)
        {
            filetype = ".pcc";
            clearChoice();
            updateNames();
        }
        private void radioTypeAny_CheckedChanged(object sender, EventArgs e)
        {
            filetype = ".*";
            clearChoice();
            updateNames();
        }
        private void radioTypeAfc_CheckedChanged(object sender, EventArgs e)
        {
            filetype = ".afc";
            clearChoice();
            updateNames();
        }
        private void radioMethodFiles_CheckedChanged(object sender, EventArgs e)
        {
            exmethod = true;
            clearChoice();
            updateNames();
        }
        private void radioMethodDir_CheckedChanged(object sender, EventArgs e)
        {
            exmethod = false;
            clearChoice();
            updateNames();
        }

        private void buttonOpenInput_Click(object sender, EventArgs e)
        {
            switch (exmethod)
            {
                case true:
                    openFiles.ShowDialog();
                    break;
                case false:
                    folderOpen.ShowDialog();
                    if (folderOpen.SelectedPath != "")
                    {
                        inputDirectory = folderOpen.SelectedPath;
                        files.Clear();
                        AddFiles(inputDirectory, files);
                    }
                    break;
            }
            updateNames();
        }

        private void openFiles_FileOk(object sender, CancelEventArgs e)
        {
            switch (openFiles.FilterIndex)
            {
                case 1:
                    filetype = ".afc";
                    radioTypeAfc.Select();
                    break;
                case 2:
                    filetype = ".pcc";
                    radioTypePcc.Select();
                    break;
                case 3:
                    filetype = ".sfar";
                    radioTypeSfar.Select();
                    break;
                case 4:
                    filetype = ".*";
                    radioTypeAny.Select();
                    break;
                default:
                    break;
            }
            files.Clear();
            files.AddRange(openFiles.FileNames);
            updateNames();
        }

        private void buttonOpenOutput_Click(object sender, EventArgs e)
        {
            folderSave.ShowDialog();
            outputDirectory = folderSave.SelectedPath;
            updateNames();
        }

        public void BackgroundConvert()
        {
            Processor.ProcessRange(files, processingMode);
            convState = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textInput.Text != "" && textOutput.Text != "")
            {
                processingMode = new ProcessingMode(outputMode, inputDirectory, outputDirectory);
                thread = new Thread(new ThreadStart(BackgroundConvert));
                Lockdown(false);
                convState = 1;
                thread.Start();
            }
            else
            {
                MessageBox.Show("Please specify input/output files/directories.");
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (Progress.current_state != "idle")
                labelCurrentAction.Text = "Status: " + Progress.current_state + " " + Progress.current_file + "...";
            else
                labelCurrentAction.Text = "Status: idle";
            if (Progress.current_state == "scanning")
                labelCurrentAction.Text += " " + Progress.current_filecount.ToString() + " waves found";
            labelCurrentPercent.Text = Progress.current_percentage.ToString() + "%";
            labelOverallPercent.Text = Progress.overall_percentage().ToString() + "%";
            progressCurrent.Value = Progress.current_percentage;
            progressOverall.Value = Progress.overall_percentage();
            labelExtractedCount.Text = Progress.wavecount.ToString() + " audio files extracted";
            labelFileProgress.Text = "File " + Progress.files_processed.ToString() + " of " + Progress.filecount.ToString();

            if (convState == 2)
            {
                convState = 0;
                if (Progress.wavecount == 0) MessageBox.Show("The program was unable to extract any waves from the files provided.");
                else
                {
                    Process.Start(outputDirectory);
                    clearChoice();
                    MessageBox.Show("The program have successfully extracted and converted " + Progress.wavecount.ToString() + " audio pieces from the provided files.");
                    Progress.Reset(1);
                }
                Lockdown(true);
            }
        }

        private void Lockdown(bool b)
        {
            labelExtractedCount.Visible = !b;
            labelFileProgress.Visible = !b;
            groupStatus.Enabled = !b;

            groupFileType.Enabled = b;
            groupMethod.Enabled = b;
            groupOutput.Enabled = b;
            buttonOpenInput.Enabled = b;
            buttonOpenOutput.Enabled = b;
            buttonUnpack.Enabled = b;
        }

        private void radioOutputAll_CheckedChanged(object sender, EventArgs e)
        {
            outputMode = ProcessingMode.OutputMode.SameDirectory;
        }

        private void radioOutputFolder_CheckedChanged(object sender, EventArgs e)
        {
            outputMode = ProcessingMode.OutputMode.SeparateDirectory;
        }

        private void radioOutputStructure_CheckedChanged(object sender, EventArgs e)
        {
            outputMode = ProcessingMode.OutputMode.OriginalStructure;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://kypapps.co.cc/afc2ogg");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Afc2ogg - version 1.4\n\nThis program analyzes multiple files in search of RIFF waves, extracts single waves to .wav files, converts .wav files to .ogg using 'ww2ogg', and fixes them with 'revorb'. If the given file is an .pcc file, it first extracts it with 'decompress'.\n\nThese files are used by games Mass Effect 2 and 3 for sound/voices/SFX storage. Probably also by some other games.\n\nIncluded conversion app of 'ww2ogg' is from hcs64.com\n\nDecompress, by Gildor is from http://gildor.org \n\nRevorb, made by Yirkha, taken from here: http://www.hydrogenaudio.org/forums/lofiversion/index.php/t64328.html \n\nContact: kyppro@gmail.com\nSite: http://kypapps.co.cc/afc2ogg", "About");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread != null && thread.IsAlive) thread.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string me3path = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\BioWare\Mass Effect 3", "Install Dir", null);
            if (me3path == null) me3path = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\BioWare\Mass Effect 3", "Install Dir", null);
            if (me3path == null) MessageBox.Show("Mass Effect 3 installation not found, please navigate manually.");
            else
            {
                radioMethodDir.PerformClick();
                inputDirectory = me3path;
                textInput.Text = me3path;
                files.Clear();
                AddFiles(inputDirectory, files);
                updateNames();
            }
        }

        private bool FilesInPlace()
        {
            bool b = true;
            b &= File.Exists("data\\ww2ogg.exe");
            b &= File.Exists("MassEffect3Tools.dll");
            b &= File.Exists("data\\decompress.exe");
            b &= File.Exists("data\\packed_codebooks.bin");
            b &= File.Exists("data\\revorb.exe");
            return b;
        }

    }
}

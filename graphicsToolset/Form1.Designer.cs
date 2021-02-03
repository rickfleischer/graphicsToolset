
namespace graphicsToolset
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
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultBox01 = new System.Windows.Forms.PictureBox();
            this.resultBox02 = new System.Windows.Forms.PictureBox();
            this.resultBox03 = new System.Windows.Forms.PictureBox();
            this.toolStatus = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox03)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPictureBox.Location = new System.Drawing.Point(12, 121);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(199, 182);
            this.inputPictureBox.TabIndex = 0;
            this.inputPictureBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 93);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "I want to show both the input image and the results from several tools.  I also w" +
    "ant to be able to indicate tool progression on the input..  The first experiment" +
    " is to copy the input to the output.";
            // 
            // resultBox01
            // 
            this.resultBox01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox01.Location = new System.Drawing.Point(233, 121);
            this.resultBox01.Name = "resultBox01";
            this.resultBox01.Size = new System.Drawing.Size(132, 125);
            this.resultBox01.TabIndex = 2;
            this.resultBox01.TabStop = false;
            // 
            // resultBox02
            // 
            this.resultBox02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox02.Location = new System.Drawing.Point(382, 121);
            this.resultBox02.Name = "resultBox02";
            this.resultBox02.Size = new System.Drawing.Size(132, 125);
            this.resultBox02.TabIndex = 3;
            this.resultBox02.TabStop = false;
            // 
            // resultBox03
            // 
            this.resultBox03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox03.Location = new System.Drawing.Point(530, 121);
            this.resultBox03.Name = "resultBox03";
            this.resultBox03.Size = new System.Drawing.Size(132, 125);
            this.resultBox03.TabIndex = 4;
            this.resultBox03.TabStop = false;
            // 
            // toolStatus
            // 
            this.toolStatus.Location = new System.Drawing.Point(12, 321);
            this.toolStatus.Multiline = true;
            this.toolStatus.Name = "toolStatus";
            this.toolStatus.Size = new System.Drawing.Size(199, 107);
            this.toolStatus.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = "c:\\";
            this.openFileDialog.Tag = "whumEyeGoinDo";
            this.openFileDialog.Title = "Does this show up?";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(509, 43);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(68, 49);
            this.openFile.TabIndex = 7;
            this.openFile.Text = "Open File. I hope.";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.toolStatus);
            this.Controls.Add(this.resultBox03);
            this.Controls.Add(this.resultBox02);
            this.Controls.Add(this.resultBox01);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inputPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox inputPictureBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox resultBox01;
        private System.Windows.Forms.PictureBox resultBox02;
        private System.Windows.Forms.PictureBox resultBox03;
        private System.Windows.Forms.TextBox toolStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFile;
    }
}


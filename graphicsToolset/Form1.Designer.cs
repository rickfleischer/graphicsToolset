
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
            this.process01 = new System.Windows.Forms.Button();
            this.process02 = new System.Windows.Forms.Button();
            this.process03 = new System.Windows.Forms.Button();
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
            this.inputPictureBox.Size = new System.Drawing.Size(256, 256);
            this.inputPictureBox.TabIndex = 0;
            this.inputPictureBox.TabStop = false;
            this.inputPictureBox.Click += new System.EventHandler(this.inputPictureBox_Click);
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
            this.resultBox01.Location = new System.Drawing.Point(300, 121);
            this.resultBox01.Name = "resultBox01";
            this.resultBox01.Size = new System.Drawing.Size(256, 256);
            this.resultBox01.TabIndex = 2;
            this.resultBox01.TabStop = false;
            this.resultBox01.Click += new System.EventHandler(this.resultBox01_Click);
            // 
            // resultBox02
            // 
            this.resultBox02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox02.Location = new System.Drawing.Point(576, 121);
            this.resultBox02.Name = "resultBox02";
            this.resultBox02.Size = new System.Drawing.Size(256, 256);
            this.resultBox02.TabIndex = 3;
            this.resultBox02.TabStop = false;
            this.resultBox02.Click += new System.EventHandler(this.resultBox02_Click);
            // 
            // resultBox03
            // 
            this.resultBox03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox03.Location = new System.Drawing.Point(510, 445);
            this.resultBox03.Name = "resultBox03";
            this.resultBox03.Size = new System.Drawing.Size(72, 67);
            this.resultBox03.TabIndex = 4;
            this.resultBox03.TabStop = false;
            // 
            // toolStatus
            // 
            this.toolStatus.Location = new System.Drawing.Point(25, 392);
            this.toolStatus.Multiline = true;
            this.toolStatus.Name = "toolStatus";
            this.toolStatus.Size = new System.Drawing.Size(436, 107);
            this.toolStatus.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "C:\\Users\\merle\\Desktop\\icons\\big";
            this.openFileDialog.Tag = "do I need a tag?";
            this.openFileDialog.Title = "Select the file to annalyze";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(454, 1);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(68, 49);
            this.openFile.TabIndex = 7;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // process01
            // 
            this.process01.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process01.Location = new System.Drawing.Point(457, 52);
            this.process01.Name = "process01";
            this.process01.Size = new System.Drawing.Size(68, 49);
            this.process01.TabIndex = 8;
            this.process01.Text = "1";
            this.process01.UseVisualStyleBackColor = true;
            this.process01.Click += new System.EventHandler(this.straightCopy);
            // 
            // process02
            // 
            this.process02.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process02.Location = new System.Drawing.Point(531, 53);
            this.process02.Name = "process02";
            this.process02.Size = new System.Drawing.Size(68, 49);
            this.process02.TabIndex = 9;
            this.process02.Text = "2";
            this.process02.UseVisualStyleBackColor = true;
            this.process02.Click += new System.EventHandler(this.markBackslash);
            // 
            // process03
            // 
            this.process03.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process03.Location = new System.Drawing.Point(605, 53);
            this.process03.Name = "process03";
            this.process03.Size = new System.Drawing.Size(68, 49);
            this.process03.TabIndex = 10;
            this.process03.Text = "3";
            this.process03.UseVisualStyleBackColor = true;
            this.process03.Click += new System.EventHandler(this.explodeSlash);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 534);
            this.Controls.Add(this.process03);
            this.Controls.Add(this.process02);
            this.Controls.Add(this.process01);
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
        private System.Windows.Forms.Button process01;
        private System.Windows.Forms.Button process02;
        private System.Windows.Forms.Button process03;
    }
}


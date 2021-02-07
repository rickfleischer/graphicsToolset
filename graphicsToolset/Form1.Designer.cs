
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
            _imageTool = new ImageTool(this);
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.resultBox01 = new System.Windows.Forms.PictureBox();
            this.resultBox02 = new System.Windows.Forms.PictureBox();
            this.resultStrip = new System.Windows.Forms.PictureBox();
            this.toolStatus = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.process01 = new System.Windows.Forms.Button();
            this.process02 = new System.Windows.Forms.Button();
            this.process03 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            this.x2 = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.GroupBox();
            this.end = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            this.start.SuspendLayout();
            this.end.SuspendLayout();
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
            // resultStrip
            // 
            this.resultStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultStrip.Location = new System.Drawing.Point(3, 505);
            this.resultStrip.Margin = new System.Windows.Forms.Padding(0);
            this.resultStrip.Name = "resultStrip";
            this.resultStrip.Size = new System.Drawing.Size(839, 20);
            this.resultStrip.TabIndex = 4;
            this.resultStrip.TabStop = false;
            this.resultStrip.Click += new System.EventHandler(this.resultStrip_Click);
            // 
            // toolStatus
            // 
            this.toolStatus.Location = new System.Drawing.Point(9, 392);
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
            this.process01.Location = new System.Drawing.Point(457, 65);
            this.process01.Name = "process01";
            this.process01.Size = new System.Drawing.Size(68, 49);
            this.process01.TabIndex = 8;
            this.process01.Text = "1";
            this.process01.UseVisualStyleBackColor = true;
            this.process01.Click += new System.EventHandler(this.inputPictureBox_Click);
            // 
            // process02
            // 
            this.process02.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process02.Location = new System.Drawing.Point(531, 66);
            this.process02.Name = "process02";
            this.process02.Size = new System.Drawing.Size(68, 49);
            this.process02.TabIndex = 9;
            this.process02.Text = "2";
            this.process02.UseVisualStyleBackColor = true;
            this.process02.Click += new System.EventHandler(this.resultBox01_Click);
            // 
            // process03
            // 
            this.process03.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process03.Location = new System.Drawing.Point(605, 66);
            this.process03.Name = "process03";
            this.process03.Size = new System.Drawing.Size(68, 49);
            this.process03.TabIndex = 10;
            this.process03.Text = "3";
            this.process03.UseVisualStyleBackColor = true;
            this.process03.Click += new System.EventHandler(this.resultBox02_Click);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(1, 14);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(50, 20);
            this.x1.TabIndex = 11;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(1, 37);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(50, 20);
            this.y1.TabIndex = 12;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(6, 35);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(50, 20);
            this.y2.TabIndex = 14;
            this.y2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(6, 13);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(50, 20);
            this.x2.TabIndex = 13;
            // 
            // start
            // 
            this.start.Controls.Add(this.y1);
            this.start.Controls.Add(this.x1);
            this.start.Location = new System.Drawing.Point(534, 1);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(57, 63);
            this.start.TabIndex = 15;
            this.start.TabStop = false;
            this.start.Text = "start";
            // 
            // end
            // 
            this.end.Controls.Add(this.y2);
            this.end.Controls.Add(this.x2);
            this.end.Location = new System.Drawing.Point(609, 2);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(62, 61);
            this.end.TabIndex = 16;
            this.end.TabStop = false;
            this.end.Text = "end";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.process03);
            this.Controls.Add(this.process02);
            this.Controls.Add(this.process01);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.toolStatus);
            this.Controls.Add(this.resultStrip);
            this.Controls.Add(this.resultBox02);
            this.Controls.Add(this.resultBox01);
            this.Controls.Add(this.inputPictureBox);
            this.Name = "Form1";
            this.Text = "Pixel Diddler";
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            this.start.ResumeLayout(false);
            this.end.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox inputPictureBox;
        private System.Windows.Forms.PictureBox resultBox01;
        private System.Windows.Forms.PictureBox resultBox02;
        private System.Windows.Forms.PictureBox resultStrip;
        private System.Windows.Forms.TextBox toolStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button process01;
        private System.Windows.Forms.Button process02;
        private System.Windows.Forms.Button process03;
        private System.Windows.Forms.NumericUpDown x1;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.NumericUpDown y2;
        private System.Windows.Forms.NumericUpDown x2;
        private System.Windows.Forms.GroupBox start;
        private System.Windows.Forms.GroupBox end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

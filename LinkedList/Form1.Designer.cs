
namespace LinkedListStruct
{
    partial class Form1
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
            this.btsort = new System.Windows.Forms.Button();
            this.btreadfromfile = new System.Windows.Forms.Button();
            this.btsavetofile = new System.Windows.Forms.Button();
            this.pbsort = new System.Windows.Forms.ProgressBar();
            this.rtbSortArray = new System.Windows.Forms.RichTextBox();
            this.rtbOpenArray = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btsort
            // 
            this.btsort.Location = new System.Drawing.Point(29, 161);
            this.btsort.Name = "btsort";
            this.btsort.Size = new System.Drawing.Size(130, 33);
            this.btsort.TabIndex = 0;
            this.btsort.Text = "Sort Array";
            this.btsort.UseVisualStyleBackColor = true;
            this.btsort.Click += new System.EventHandler(this.btSortArray);
            // 
            // btreadfromfile
            // 
            this.btreadfromfile.Location = new System.Drawing.Point(383, 14);
            this.btreadfromfile.Name = "btreadfromfile";
            this.btreadfromfile.Size = new System.Drawing.Size(158, 39);
            this.btreadfromfile.TabIndex = 1;
            this.btreadfromfile.Text = "Open File with array";
            this.btreadfromfile.UseVisualStyleBackColor = true;
            this.btreadfromfile.Click += new System.EventHandler(this.btreadfromfile_Click);
            // 
            // btsavetofile
            // 
            this.btsavetofile.Location = new System.Drawing.Point(383, 309);
            this.btsavetofile.Name = "btsavetofile";
            this.btsavetofile.Size = new System.Drawing.Size(158, 44);
            this.btsavetofile.TabIndex = 2;
            this.btsavetofile.Text = "Save an ordered array";
            this.btsavetofile.UseVisualStyleBackColor = true;
            this.btsavetofile.Click += new System.EventHandler(this.btsavetofile_Click);
            // 
            // pbsort
            // 
            this.pbsort.Location = new System.Drawing.Point(166, 161);
            this.pbsort.Name = "pbsort";
            this.pbsort.Size = new System.Drawing.Size(375, 33);
            this.pbsort.TabIndex = 3;
            // 
            // rtbSortArray
            // 
            this.rtbSortArray.Location = new System.Drawing.Point(29, 233);
            this.rtbSortArray.Name = "rtbSortArray";
            this.rtbSortArray.ReadOnly = true;
            this.rtbSortArray.Size = new System.Drawing.Size(512, 70);
            this.rtbSortArray.TabIndex = 4;
            this.rtbSortArray.Text = "";
            // 
            // rtbOpenArray
            // 
            this.rtbOpenArray.Location = new System.Drawing.Point(29, 59);
            this.rtbOpenArray.Name = "rtbOpenArray";
            this.rtbOpenArray.ReadOnly = true;
            this.rtbOpenArray.Size = new System.Drawing.Size(512, 70);
            this.rtbOpenArray.TabIndex = 5;
            this.rtbOpenArray.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Array";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ordered array";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sorting time :";
            // 
            // tbTime
            // 
            this.tbTime.Enabled = false;
            this.tbTime.Location = new System.Drawing.Point(187, 320);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(100, 23);
            this.tbTime.TabIndex = 9;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChangedReported);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 373);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbOpenArray);
            this.Controls.Add(this.rtbSortArray);
            this.Controls.Add(this.pbsort);
            this.Controls.Add(this.btsavetofile);
            this.Controls.Add(this.btreadfromfile);
            this.Controls.Add(this.btsort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Сортування масиву";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsort;
        private System.Windows.Forms.Button btreadfromfile;
        private System.Windows.Forms.Button btsavetofile;
        private System.Windows.Forms.ProgressBar pbsort;
        private System.Windows.Forms.RichTextBox rtbOpenArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.RichTextBox rtbSortArray;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


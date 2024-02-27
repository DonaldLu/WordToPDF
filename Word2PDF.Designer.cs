namespace WordToPDF
{
    partial class Word2PDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Word2PDF));
            this.wordPathBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PDFPathBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sureBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.oneToOne = new System.Windows.Forms.TabPage();
            this.multiToOne = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.wordsBtn = new System.Windows.Forms.Button();
            this.PDFBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.wordPathTB = new System.Windows.Forms.TextBox();
            this.PDFPathTB = new System.Windows.Forms.TextBox();
            this.PDFTB = new System.Windows.Forms.TextBox();
            this.PDFNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.wordTB = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.oneToOne.SuspendLayout();
            this.multiToOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordPathBtn
            // 
            this.wordPathBtn.Location = new System.Drawing.Point(9, 28);
            this.wordPathBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wordPathBtn.Name = "wordPathBtn";
            this.wordPathBtn.Size = new System.Drawing.Size(60, 32);
            this.wordPathBtn.TabIndex = 0;
            this.wordPathBtn.Text = "選擇";
            this.wordPathBtn.UseVisualStyleBackColor = true;
            this.wordPathBtn.Click += new System.EventHandler(this.wordPathBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "請選擇要轉換Word的資料夾路徑";
            // 
            // PDFPathBtn
            // 
            this.PDFPathBtn.Location = new System.Drawing.Point(9, 98);
            this.PDFPathBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PDFPathBtn.Name = "PDFPathBtn";
            this.PDFPathBtn.Size = new System.Drawing.Size(60, 32);
            this.PDFPathBtn.TabIndex = 0;
            this.PDFPathBtn.Text = "選擇";
            this.PDFPathBtn.UseVisualStyleBackColor = true;
            this.PDFPathBtn.Click += new System.EventHandler(this.PDFPathBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "請選擇要輸出PDF的資料夾路徑";
            // 
            // sureBtn
            // 
            this.sureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sureBtn.Location = new System.Drawing.Point(15, 427);
            this.sureBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sureBtn.Name = "sureBtn";
            this.sureBtn.Size = new System.Drawing.Size(60, 32);
            this.sureBtn.TabIndex = 0;
            this.sureBtn.Text = "確定";
            this.sureBtn.UseVisualStyleBackColor = true;
            this.sureBtn.Click += new System.EventHandler(this.sureBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(545, 427);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(60, 32);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.oneToOne);
            this.tabControl1.Controls.Add(this.multiToOne);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 408);
            this.tabControl1.TabIndex = 3;
            // 
            // oneToOne
            // 
            this.oneToOne.BackColor = System.Drawing.Color.WhiteSmoke;
            this.oneToOne.Controls.Add(this.PDFPathTB);
            this.oneToOne.Controls.Add(this.wordPathTB);
            this.oneToOne.Controls.Add(this.label1);
            this.oneToOne.Controls.Add(this.wordPathBtn);
            this.oneToOne.Controls.Add(this.PDFPathBtn);
            this.oneToOne.Controls.Add(this.label3);
            this.oneToOne.Location = new System.Drawing.Point(4, 26);
            this.oneToOne.Name = "oneToOne";
            this.oneToOne.Padding = new System.Windows.Forms.Padding(3);
            this.oneToOne.Size = new System.Drawing.Size(589, 378);
            this.oneToOne.TabIndex = 0;
            this.oneToOne.Text = "一到一";
            // 
            // multiToOne
            // 
            this.multiToOne.BackColor = System.Drawing.Color.WhiteSmoke;
            this.multiToOne.Controls.Add(this.checkedListBox1);
            this.multiToOne.Controls.Add(this.listBox1);
            this.multiToOne.Controls.Add(this.PDFNameTB);
            this.multiToOne.Controls.Add(this.wordTB);
            this.multiToOne.Controls.Add(this.PDFTB);
            this.multiToOne.Controls.Add(this.label4);
            this.multiToOne.Controls.Add(this.label5);
            this.multiToOne.Controls.Add(this.showBtn);
            this.multiToOne.Controls.Add(this.wordsBtn);
            this.multiToOne.Controls.Add(this.PDFBtn);
            this.multiToOne.Controls.Add(this.label2);
            this.multiToOne.Controls.Add(this.label8);
            this.multiToOne.Location = new System.Drawing.Point(4, 26);
            this.multiToOne.Name = "multiToOne";
            this.multiToOne.Padding = new System.Windows.Forms.Padding(3);
            this.multiToOne.Size = new System.Drawing.Size(589, 378);
            this.multiToOne.TabIndex = 1;
            this.multiToOne.Text = "多合一";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "請選擇要合併的Word檔";
            // 
            // wordsBtn
            // 
            this.wordsBtn.Location = new System.Drawing.Point(9, 28);
            this.wordsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wordsBtn.Name = "wordsBtn";
            this.wordsBtn.Size = new System.Drawing.Size(60, 32);
            this.wordsBtn.TabIndex = 3;
            this.wordsBtn.Text = "選擇";
            this.wordsBtn.UseVisualStyleBackColor = true;
            this.wordsBtn.Click += new System.EventHandler(this.wordsBtn_Click);
            // 
            // PDFBtn
            // 
            this.PDFBtn.Location = new System.Drawing.Point(10, 280);
            this.PDFBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PDFBtn.Name = "PDFBtn";
            this.PDFBtn.Size = new System.Drawing.Size(60, 32);
            this.PDFBtn.TabIndex = 4;
            this.PDFBtn.Text = "選擇";
            this.PDFBtn.UseVisualStyleBackColor = true;
            this.PDFBtn.Click += new System.EventHandler(this.PDFBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "請選擇要輸出PDF檔的路徑";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // wordPathTB
            // 
            this.wordPathTB.Location = new System.Drawing.Point(76, 33);
            this.wordPathTB.Name = "wordPathTB";
            this.wordPathTB.Size = new System.Drawing.Size(507, 25);
            this.wordPathTB.TabIndex = 3;
            // 
            // PDFPathTB
            // 
            this.PDFPathTB.Location = new System.Drawing.Point(76, 103);
            this.PDFPathTB.Name = "PDFPathTB";
            this.PDFPathTB.Size = new System.Drawing.Size(507, 25);
            this.PDFPathTB.TabIndex = 3;
            // 
            // PDFTB
            // 
            this.PDFTB.Location = new System.Drawing.Point(77, 285);
            this.PDFTB.Name = "PDFTB";
            this.PDFTB.Size = new System.Drawing.Size(237, 25);
            this.PDFTB.TabIndex = 9;
            // 
            // PDFNameTB
            // 
            this.PDFNameTB.Location = new System.Drawing.Point(10, 338);
            this.PDFNameTB.Name = "PDFNameTB";
            this.PDFNameTB.Size = new System.Drawing.Size(304, 25);
            this.PDFNameTB.TabIndex = 9;
            this.PDFNameTB.Text = "合併後的PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "請輸入合併後的PDF檔名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "合併順序";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(322, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 225);
            this.listBox1.TabIndex = 10;
            // 
            // wordTB
            // 
            this.wordTB.Location = new System.Drawing.Point(76, 33);
            this.wordTB.Name = "wordTB";
            this.wordTB.Size = new System.Drawing.Size(170, 25);
            this.wordTB.TabIndex = 9;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(10, 68);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(303, 184);
            this.checkedListBox1.TabIndex = 11;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(253, 29);
            this.showBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(60, 32);
            this.showBtn.TabIndex = 3;
            this.showBtn.Text = "顯示";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // Word2PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 470);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sureBtn);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(636, 509);
            this.Name = "Word2PDF";
            this.Text = "Word To PDF";
            this.tabControl1.ResumeLayout(false);
            this.oneToOne.ResumeLayout(false);
            this.oneToOne.PerformLayout();
            this.multiToOne.ResumeLayout(false);
            this.multiToOne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wordPathBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PDFPathBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sureBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage oneToOne;
        private System.Windows.Forms.TabPage multiToOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button wordsBtn;
        private System.Windows.Forms.Button PDFBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox PDFPathTB;
        private System.Windows.Forms.TextBox wordPathTB;
        private System.Windows.Forms.TextBox PDFTB;
        private System.Windows.Forms.TextBox PDFNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wordTB;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button showBtn;
    }
}
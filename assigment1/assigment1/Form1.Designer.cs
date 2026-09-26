namespace assigment1
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
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtyeartext = new System.Windows.Forms.TextBox();
            this.txtdayofmonth = new System.Windows.Forms.TextBox();
            this.txtmonthtext = new System.Windows.Forms.TextBox();
            this.dayofweek = new System.Windows.Forms.Label();
            this.nameofmonth = new System.Windows.Forms.Label();
            this.dayofmonth = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.txtshowdata = new System.Windows.Forms.Button();
            this.txtclear = new System.Windows.Forms.Button();
            this.dateoutputlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.Location = new System.Drawing.Point(565, 59);
            this.txtdayoftheweek.Multiline = true;
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(218, 37);
            this.txtdayoftheweek.TabIndex = 0;
            // 
            // txtyeartext
            // 
            this.txtyeartext.Location = new System.Drawing.Point(565, 184);
            this.txtyeartext.Name = "txtyeartext";
            this.txtyeartext.Size = new System.Drawing.Size(218, 26);
            this.txtyeartext.TabIndex = 1;
            // 
            // txtdayofmonth
            // 
            this.txtdayofmonth.Location = new System.Drawing.Point(565, 143);
            this.txtdayofmonth.Name = "txtdayofmonth";
            this.txtdayofmonth.Size = new System.Drawing.Size(218, 26);
            this.txtdayofmonth.TabIndex = 2;
            // 
            // txtmonthtext
            // 
            this.txtmonthtext.Location = new System.Drawing.Point(565, 111);
            this.txtmonthtext.Name = "txtmonthtext";
            this.txtmonthtext.Size = new System.Drawing.Size(218, 26);
            this.txtmonthtext.TabIndex = 3;
            // 
            // dayofweek
            // 
            this.dayofweek.AutoSize = true;
            this.dayofweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofweek.Location = new System.Drawing.Point(173, 87);
            this.dayofweek.Name = "dayofweek";
            this.dayofweek.Size = new System.Drawing.Size(197, 25);
            this.dayofweek.TabIndex = 4;
            this.dayofweek.Text = "enter the day of week";
            // 
            // nameofmonth
            // 
            this.nameofmonth.AutoSize = true;
            this.nameofmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameofmonth.Location = new System.Drawing.Point(173, 114);
            this.nameofmonth.Name = "nameofmonth";
            this.nameofmonth.Size = new System.Drawing.Size(222, 25);
            this.nameofmonth.TabIndex = 5;
            this.nameofmonth.Text = "enter the name of month";
            // 
            // dayofmonth
            // 
            this.dayofmonth.AutoSize = true;
            this.dayofmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofmonth.Location = new System.Drawing.Point(173, 149);
            this.dayofmonth.Name = "dayofmonth";
            this.dayofmonth.Size = new System.Drawing.Size(311, 25);
            this.dayofmonth.TabIndex = 6;
            this.dayofmonth.Text = "enter the numeric day of the month";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(173, 181);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(131, 25);
            this.year.TabIndex = 7;
            this.year.Text = "enter the year";
            // 
            // txtshowdata
            // 
            this.txtshowdata.Location = new System.Drawing.Point(308, 308);
            this.txtshowdata.Name = "txtshowdata";
            this.txtshowdata.Size = new System.Drawing.Size(108, 34);
            this.txtshowdata.TabIndex = 8;
            this.txtshowdata.Text = "show data";
            this.txtshowdata.UseVisualStyleBackColor = true;
            this.txtshowdata.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtclear
            // 
            this.txtclear.Location = new System.Drawing.Point(483, 308);
            this.txtclear.Name = "txtclear";
            this.txtclear.Size = new System.Drawing.Size(91, 34);
            this.txtclear.TabIndex = 9;
            this.txtclear.Text = "clear";
            this.txtclear.UseVisualStyleBackColor = true;
            this.txtclear.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateoutputlabel
            // 
            this.dateoutputlabel.AutoSize = true;
            this.dateoutputlabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dateoutputlabel.Location = new System.Drawing.Point(259, 241);
            this.dateoutputlabel.Name = "dateoutputlabel";
            this.dateoutputlabel.Size = new System.Drawing.Size(389, 40);
            this.dateoutputlabel.TabIndex = 10;
            this.dateoutputlabel.Text = "                                                                                 " +
    "              \r\n\r\n";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(795, 444);
            this.Controls.Add(this.dateoutputlabel);
            this.Controls.Add(this.txtclear);
            this.Controls.Add(this.txtshowdata);
            this.Controls.Add(this.year);
            this.Controls.Add(this.dayofmonth);
            this.Controls.Add(this.nameofmonth);
            this.Controls.Add(this.dayofweek);
            this.Controls.Add(this.txtmonthtext);
            this.Controls.Add(this.txtdayofmonth);
            this.Controls.Add(this.txtyeartext);
            this.Controls.Add(this.txtdayoftheweek);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdayofWeekTextBox;
        private System.Windows.Forms.TextBox txtmonthTextBox;
        private System.Windows.Forms.TextBox txtdayofMonthTextBox;
        private System.Windows.Forms.TextBox txtyearTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtyeartext;
        private System.Windows.Forms.TextBox txtdayofmonth;
        private System.Windows.Forms.TextBox txtmonthtext;
        private System.Windows.Forms.Label dayofweek;
        private System.Windows.Forms.Label nameofmonth;
        private System.Windows.Forms.Label dayofmonth;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Button txtshowdata;
        private System.Windows.Forms.Button txtclear;
        private System.Windows.Forms.Label dateoutputlabel;
    }
}


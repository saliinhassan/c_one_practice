namespace room_booking_system
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
            this.bookingdetails = new System.Windows.Forms.ListBox();
            this.txtguests = new System.Windows.Forms.TextBox();
            this.txtneights = new System.Windows.Forms.TextBox();
            this.txtguestage = new System.Windows.Forms.TextBox();
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiohight = new System.Windows.Forms.RadioButton();
            this.radionormal = new System.Windows.Forms.RadioButton();
            this.radiostandard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingdetails
            // 
            this.bookingdetails.FormattingEnabled = true;
            this.bookingdetails.ItemHeight = 20;
            this.bookingdetails.Location = new System.Drawing.Point(699, 32);
            this.bookingdetails.Name = "bookingdetails";
            this.bookingdetails.Size = new System.Drawing.Size(344, 544);
            this.bookingdetails.TabIndex = 12;
            // 
            // txtguests
            // 
            this.txtguests.Location = new System.Drawing.Point(298, 145);
            this.txtguests.Name = "txtguests";
            this.txtguests.Size = new System.Drawing.Size(215, 32);
            this.txtguests.TabIndex = 9;
            // 
            // txtneights
            // 
            this.txtneights.Location = new System.Drawing.Point(298, 96);
            this.txtneights.Name = "txtneights";
            this.txtneights.Size = new System.Drawing.Size(215, 32);
            this.txtneights.TabIndex = 7;
            // 
            // txtguestage
            // 
            this.txtguestage.Location = new System.Drawing.Point(298, 58);
            this.txtguestage.Name = "txtguestage";
            this.txtguestage.Size = new System.Drawing.Size(215, 32);
            this.txtguestage.TabIndex = 6;
            // 
            // txtguestname
            // 
            this.txtguestname.Location = new System.Drawing.Point(298, 20);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(215, 32);
            this.txtguestname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Guest";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiohight);
            this.groupBox2.Controls.Add(this.radionormal);
            this.groupBox2.Controls.Add(this.radiostandard);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room type";
            // 
            // radiohight
            // 
            this.radiohight.AutoSize = true;
            this.radiohight.Location = new System.Drawing.Point(311, 60);
            this.radiohight.Name = "radiohight";
            this.radiohight.Size = new System.Drawing.Size(87, 29);
            this.radiohight.TabIndex = 2;
            this.radiohight.TabStop = true;
            this.radiohight.Text = "Hight";
            this.radiohight.UseVisualStyleBackColor = true;
            // 
            // radionormal
            // 
            this.radionormal.AutoSize = true;
            this.radionormal.Location = new System.Drawing.Point(157, 60);
            this.radionormal.Name = "radionormal";
            this.radionormal.Size = new System.Drawing.Size(105, 29);
            this.radionormal.TabIndex = 1;
            this.radionormal.TabStop = true;
            this.radionormal.Text = "Normal";
            this.radionormal.UseVisualStyleBackColor = true;
            // 
            // radiostandard
            // 
            this.radiostandard.AutoSize = true;
            this.radiostandard.Location = new System.Drawing.Point(11, 60);
            this.radiostandard.Name = "radiostandard";
            this.radiostandard.Size = new System.Drawing.Size(121, 29);
            this.radiostandard.TabIndex = 0;
            this.radiostandard.TabStop = true;
            this.radiostandard.Text = "standard";
            this.radiostandard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtguests);
            this.groupBox1.Controls.Add(this.txtneights);
            this.groupBox1.Controls.Add(this.txtguestage);
            this.groupBox1.Controls.Add(this.txtguestname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 247);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "personal information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of neights";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "guest age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "guest name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(378, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Breakfast(10 per guest per neights)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.exit);
            this.groupBox3.Controls.Add(this.clear);
            this.groupBox3.Controls.Add(this.calculate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 158);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "aditional options";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(387, 94);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(126, 44);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(204, 94);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(126, 44);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(26, 94);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(126, 44);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 638);
            this.Controls.Add(this.bookingdetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookingdetails;
        private System.Windows.Forms.TextBox txtguests;
        private System.Windows.Forms.TextBox txtneights;
        private System.Windows.Forms.TextBox txtguestage;
        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiohight;
        private System.Windows.Forms.RadioButton radionormal;
        private System.Windows.Forms.RadioButton radiostandard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button calculate;
    }
}


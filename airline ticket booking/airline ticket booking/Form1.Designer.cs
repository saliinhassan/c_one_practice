namespace airline_ticket_booking
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
            this.AirlineBookDetails = new System.Windows.Forms.ListBox();
            this.txtBaggageWeights = new System.Windows.Forms.TextBox();
            this.txttickets = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobussiness = new System.Windows.Forms.RadioButton();
            this.radionormal = new System.Windows.Forms.RadioButton();
            this.radiofirst = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkaddtravel = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AirlineBookDetails
            // 
            this.AirlineBookDetails.FormattingEnabled = true;
            this.AirlineBookDetails.ItemHeight = 20;
            this.AirlineBookDetails.Location = new System.Drawing.Point(750, 8);
            this.AirlineBookDetails.Name = "AirlineBookDetails";
            this.AirlineBookDetails.Size = new System.Drawing.Size(314, 444);
            this.AirlineBookDetails.TabIndex = 12;
            // 
            // txtBaggageWeights
            // 
            this.txtBaggageWeights.Location = new System.Drawing.Point(298, 145);
            this.txtBaggageWeights.Name = "txtBaggageWeights";
            this.txtBaggageWeights.Size = new System.Drawing.Size(215, 32);
            this.txtBaggageWeights.TabIndex = 9;
            // 
            // txttickets
            // 
            this.txttickets.Location = new System.Drawing.Point(298, 96);
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(215, 32);
            this.txttickets.TabIndex = 7;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(298, 58);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(215, 32);
            this.txtage.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(298, 20);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(215, 32);
            this.txtname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Baggage weight(kg)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobussiness);
            this.groupBox2.Controls.Add(this.radionormal);
            this.groupBox2.Controls.Add(this.radiofirst);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Travel Class";
            // 
            // radiobussiness
            // 
            this.radiobussiness.AutoSize = true;
            this.radiobussiness.Location = new System.Drawing.Point(361, 60);
            this.radiobussiness.Name = "radiobussiness";
            this.radiobussiness.Size = new System.Drawing.Size(190, 29);
            this.radiobussiness.TabIndex = 2;
            this.radiobussiness.TabStop = true;
            this.radiobussiness.Text = "bussiness class";
            this.radiobussiness.UseVisualStyleBackColor = true;
            // 
            // radionormal
            // 
            this.radionormal.AutoSize = true;
            this.radionormal.Location = new System.Drawing.Point(159, 60);
            this.radionormal.Name = "radionormal";
            this.radionormal.Size = new System.Drawing.Size(161, 29);
            this.radionormal.TabIndex = 1;
            this.radionormal.TabStop = true;
            this.radionormal.Text = "Normal class";
            this.radionormal.UseVisualStyleBackColor = true;
            // 
            // radiofirst
            // 
            this.radiofirst.AutoSize = true;
            this.radiofirst.Location = new System.Drawing.Point(11, 60);
            this.radiofirst.Name = "radiofirst";
            this.radiofirst.Size = new System.Drawing.Size(128, 29);
            this.radiofirst.TabIndex = 0;
            this.radiofirst.TabStop = true;
            this.radiofirst.Text = "first class";
            this.radiofirst.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBaggageWeights);
            this.groupBox1.Controls.Add(this.txttickets);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            this.label3.Size = new System.Drawing.Size(199, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "passenger age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "passenger name ";
            // 
            // checkaddtravel
            // 
            this.checkaddtravel.AutoSize = true;
            this.checkaddtravel.Location = new System.Drawing.Point(11, 46);
            this.checkaddtravel.Name = "checkaddtravel";
            this.checkaddtravel.Size = new System.Drawing.Size(402, 29);
            this.checkaddtravel.TabIndex = 4;
            this.checkaddtravel.Text = "Add Travel insurance ($25  per ticket)";
            this.checkaddtravel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkaddtravel);
            this.groupBox3.Controls.Add(this.exit);
            this.groupBox3.Controls.Add(this.clear);
            this.groupBox3.Controls.Add(this.calculate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 417);
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
            this.ClientSize = new System.Drawing.Size(1158, 621);
            this.Controls.Add(this.AirlineBookDetails);
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

        private System.Windows.Forms.ListBox AirlineBookDetails;
        private System.Windows.Forms.TextBox txtBaggageWeights;
        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobussiness;
        private System.Windows.Forms.RadioButton radionormal;
        private System.Windows.Forms.RadioButton radiofirst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkaddtravel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button calculate;
    }
}


namespace assigment_lab
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnumberpackage = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtperpackage = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.txtnumberpackage = new System.Windows.Forms.TextBox();
            this.purchaseresults = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnumberpackage);
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.btncalculate);
            this.groupBox1.Controls.Add(this.txtperpackage);
            this.groupBox1.Controls.Add(this.lblprice);
            this.groupBox1.Controls.Add(this.lblnumberpackage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "purchase information";
            // 
            // lblnumberpackage
            // 
            this.lblnumberpackage.AutoSize = true;
            this.lblnumberpackage.Location = new System.Drawing.Point(27, 43);
            this.lblnumberpackage.Name = "lblnumberpackage";
            this.lblnumberpackage.Size = new System.Drawing.Size(207, 25);
            this.lblnumberpackage.TabIndex = 0;
            this.lblnumberpackage.Text = "number of packages";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(27, 88);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(178, 25);
            this.lblprice.TabIndex = 1;
            this.lblprice.Text = "price perpackage";
            // 
            // txtperpackage
            // 
            this.txtperpackage.Location = new System.Drawing.Point(264, 85);
            this.txtperpackage.Name = "txtperpackage";
            this.txtperpackage.Size = new System.Drawing.Size(219, 30);
            this.txtperpackage.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(31, 172);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(127, 38);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(204, 172);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(127, 38);
            this.clear.TabIndex = 3;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(368, 172);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(127, 38);
            this.exit.TabIndex = 4;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // txtnumberpackage
            // 
            this.txtnumberpackage.Location = new System.Drawing.Point(264, 40);
            this.txtnumberpackage.Name = "txtnumberpackage";
            this.txtnumberpackage.Size = new System.Drawing.Size(219, 30);
            this.txtnumberpackage.TabIndex = 0;
            // 
            // purchaseresults
            // 
            this.purchaseresults.FormattingEnabled = true;
            this.purchaseresults.ItemHeight = 20;
            this.purchaseresults.Location = new System.Drawing.Point(620, 36);
            this.purchaseresults.Name = "purchaseresults";
            this.purchaseresults.Size = new System.Drawing.Size(288, 364);
            this.purchaseresults.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 472);
            this.Controls.Add(this.purchaseresults);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtperpackage;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblnumberpackage;
        private System.Windows.Forms.TextBox txtnumberpackage;
        private System.Windows.Forms.ListBox purchaseresults;
    }
}


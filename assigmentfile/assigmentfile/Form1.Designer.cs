namespace assigmentfile
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
            this.btnwriteline = new System.Windows.Forms.Button();
            this.btnreadline = new System.Windows.Forms.Button();
            this.btnreadall = new System.Windows.Forms.Button();
            this.btnreadblock = new System.Windows.Forms.Button();
            this.btndeleteitems = new System.Windows.Forms.Button();
            this.btndeletefile = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnwriteline
            // 
            this.btnwriteline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwriteline.Location = new System.Drawing.Point(354, 53);
            this.btnwriteline.Name = "btnwriteline";
            this.btnwriteline.Size = new System.Drawing.Size(114, 54);
            this.btnwriteline.TabIndex = 0;
            this.btnwriteline.Text = "writeline";
            this.btnwriteline.UseVisualStyleBackColor = true;
            this.btnwriteline.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreadline
            // 
            this.btnreadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadline.Location = new System.Drawing.Point(102, 53);
            this.btnreadline.Name = "btnreadline";
            this.btnreadline.Size = new System.Drawing.Size(105, 42);
            this.btnreadline.TabIndex = 1;
            this.btnreadline.Text = "readlines";
            this.btnreadline.UseVisualStyleBackColor = true;
            this.btnreadline.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnreadall
            // 
            this.btnreadall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadall.Location = new System.Drawing.Point(102, 140);
            this.btnreadall.Name = "btnreadall";
            this.btnreadall.Size = new System.Drawing.Size(142, 53);
            this.btnreadall.TabIndex = 2;
            this.btnreadall.Text = "read all lines";
            this.btnreadall.UseVisualStyleBackColor = true;
            this.btnreadall.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnreadblock
            // 
            this.btnreadblock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadblock.Location = new System.Drawing.Point(102, 278);
            this.btnreadblock.Name = "btnreadblock";
            this.btnreadblock.Size = new System.Drawing.Size(142, 46);
            this.btnreadblock.TabIndex = 3;
            this.btnreadblock.Text = "read block";
            this.btnreadblock.UseVisualStyleBackColor = true;
            this.btnreadblock.Click += new System.EventHandler(this.btnreadblock_Click);
            // 
            // btndeleteitems
            // 
            this.btndeleteitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteitems.Location = new System.Drawing.Point(339, 131);
            this.btndeleteitems.Name = "btndeleteitems";
            this.btndeleteitems.Size = new System.Drawing.Size(199, 62);
            this.btndeleteitems.TabIndex = 4;
            this.btndeleteitems.Text = "delete items files";
            this.btndeleteitems.UseVisualStyleBackColor = true;
            this.btndeleteitems.Click += new System.EventHandler(this.btndeleteitems_Click);
            // 
            // btndeletefile
            // 
            this.btndeletefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletefile.Location = new System.Drawing.Point(339, 227);
            this.btndeletefile.Name = "btndeletefile";
            this.btndeletefile.Size = new System.Drawing.Size(199, 55);
            this.btndeletefile.TabIndex = 5;
            this.btndeletefile.Text = "delete files";
            this.btndeletefile.UseVisualStyleBackColor = true;
            this.btndeletefile.Click += new System.EventHandler(this.btndeletefile_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(363, 348);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(105, 42);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(102, 370);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(105, 42);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(601, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 384);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 474);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndeletefile);
            this.Controls.Add(this.btndeleteitems);
            this.Controls.Add(this.btnreadblock);
            this.Controls.Add(this.btnreadall);
            this.Controls.Add(this.btnreadline);
            this.Controls.Add(this.btnwriteline);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnwriteline;
        private System.Windows.Forms.Button btnreadline;
        private System.Windows.Forms.Button btnreadall;
        private System.Windows.Forms.Button btnreadblock;
        private System.Windows.Forms.Button btndeleteitems;
        private System.Windows.Forms.Button btndeletefile;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox listBox1;
    }
}


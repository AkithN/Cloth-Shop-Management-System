namespace Course_Work_GAD
{
    partial class Remove
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
            this.btn_rback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rpno = new System.Windows.Forms.TextBox();
            this.txt_rpname = new System.Windows.Forms.TextBox();
            this.lbl_upno = new System.Windows.Forms.Label();
            this.lbl_upname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_rback
            // 
            this.btn_rback.BackColor = System.Drawing.Color.Black;
            this.btn_rback.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_rback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_rback.Location = new System.Drawing.Point(16, 497);
            this.btn_rback.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rback.Name = "btn_rback";
            this.btn_rback.Size = new System.Drawing.Size(137, 42);
            this.btn_rback.TabIndex = 0;
            this.btn_rback.Text = "Back";
            this.btn_rback.UseVisualStyleBackColor = false;
            this.btn_rback.Click += new System.EventHandler(this.btn_rback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(376, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 40);
            this.label1.TabIndex = 27;
            this.label1.Text = "REMOVE ITEMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_rpno
            // 
            this.txt_rpno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.txt_rpno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rpno.Location = new System.Drawing.Point(541, 269);
            this.txt_rpno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rpno.Multiline = true;
            this.txt_rpno.Name = "txt_rpno";
            this.txt_rpno.Size = new System.Drawing.Size(244, 40);
            this.txt_rpno.TabIndex = 31;
            // 
            // txt_rpname
            // 
            this.txt_rpname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.txt_rpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rpname.Location = new System.Drawing.Point(541, 200);
            this.txt_rpname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rpname.Multiline = true;
            this.txt_rpname.Name = "txt_rpname";
            this.txt_rpname.Size = new System.Drawing.Size(244, 39);
            this.txt_rpname.TabIndex = 30;
            // 
            // lbl_upno
            // 
            this.lbl_upno.AutoSize = true;
            this.lbl_upno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_upno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_upno.Location = new System.Drawing.Point(282, 277);
            this.lbl_upno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_upno.Name = "lbl_upno";
            this.lbl_upno.Size = new System.Drawing.Size(219, 32);
            this.lbl_upno.TabIndex = 29;
            this.lbl_upno.Text = "Product Number";
            // 
            // lbl_upname
            // 
            this.lbl_upname.AutoSize = true;
            this.lbl_upname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_upname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_upname.Location = new System.Drawing.Point(282, 207);
            this.lbl_upname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_upname.Name = "lbl_upname";
            this.lbl_upname.Size = new System.Drawing.Size(194, 32);
            this.lbl_upname.TabIndex = 28;
            this.lbl_upname.Text = "Product Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(433, 358);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 47);
            this.button2.TabIndex = 32;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Course_Work_GAD.Properties.Resources.Registation_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_rpno);
            this.Controls.Add(this.txt_rpname);
            this.Controls.Add(this.lbl_upno);
            this.Controls.Add(this.lbl_upname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rback);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Remove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rpno;
        private System.Windows.Forms.TextBox txt_rpname;
        private System.Windows.Forms.Label lbl_upno;
        private System.Windows.Forms.Label lbl_upname;
        private System.Windows.Forms.Button button2;
    }
}
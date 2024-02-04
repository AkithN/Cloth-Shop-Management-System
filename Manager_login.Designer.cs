namespace Course_Work_GAD
{
    partial class Manager_login
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
            this.lbl_msg = new System.Windows.Forms.Label();
            this.txt_mpw = new System.Windows.Forms.TextBox();
            this.txt_mun = new System.Windows.Forms.TextBox();
            this.btn_mlogin = new System.Windows.Forms.Button();
            this.lbl_mpw = new System.Windows.Forms.Label();
            this.lbl_mun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.Black;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_msg.Location = new System.Drawing.Point(339, 377);
            this.lbl_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 20);
            this.lbl_msg.TabIndex = 20;
            // 
            // txt_mpw
            // 
            this.txt_mpw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.txt_mpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mpw.Location = new System.Drawing.Point(435, 302);
            this.txt_mpw.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mpw.Name = "txt_mpw";
            this.txt_mpw.PasswordChar = '*';
            this.txt_mpw.Size = new System.Drawing.Size(292, 41);
            this.txt_mpw.TabIndex = 19;
            // 
            // txt_mun
            // 
            this.txt_mun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.txt_mun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mun.Location = new System.Drawing.Point(435, 207);
            this.txt_mun.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mun.Name = "txt_mun";
            this.txt_mun.Size = new System.Drawing.Size(292, 41);
            this.txt_mun.TabIndex = 18;
            // 
            // btn_mlogin
            // 
            this.btn_mlogin.BackColor = System.Drawing.Color.Black;
            this.btn_mlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mlogin.ForeColor = System.Drawing.Color.White;
            this.btn_mlogin.Location = new System.Drawing.Point(355, 406);
            this.btn_mlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mlogin.Name = "btn_mlogin";
            this.btn_mlogin.Size = new System.Drawing.Size(164, 54);
            this.btn_mlogin.TabIndex = 16;
            this.btn_mlogin.Text = "Login";
            this.btn_mlogin.UseVisualStyleBackColor = false;
            this.btn_mlogin.Click += new System.EventHandler(this.btn_mlogin_Click);
            // 
            // lbl_mpw
            // 
            this.lbl_mpw.AutoSize = true;
            this.lbl_mpw.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mpw.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mpw.ForeColor = System.Drawing.Color.White;
            this.lbl_mpw.Location = new System.Drawing.Point(232, 306);
            this.lbl_mpw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mpw.Name = "lbl_mpw";
            this.lbl_mpw.Size = new System.Drawing.Size(143, 38);
            this.lbl_mpw.TabIndex = 15;
            this.lbl_mpw.Text = "Password";
            // 
            // lbl_mun
            // 
            this.lbl_mun.AutoSize = true;
            this.lbl_mun.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mun.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mun.ForeColor = System.Drawing.Color.White;
            this.lbl_mun.Location = new System.Drawing.Point(232, 211);
            this.lbl_mun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mun.Name = "lbl_mun";
            this.lbl_mun.Size = new System.Drawing.Size(159, 38);
            this.lbl_mun.TabIndex = 14;
            this.lbl_mun.Text = "User name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(331, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "Log In ";
            // 
            // btn_mback
            // 
            this.btn_mback.BackColor = System.Drawing.Color.Black;
            this.btn_mback.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_mback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mback.ForeColor = System.Drawing.Color.Yellow;
            this.btn_mback.Location = new System.Drawing.Point(13, 507);
            this.btn_mback.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mback.Name = "btn_mback";
            this.btn_mback.Size = new System.Drawing.Size(107, 34);
            this.btn_mback.TabIndex = 22;
            this.btn_mback.Text = "Back";
            this.btn_mback.UseVisualStyleBackColor = false;
            this.btn_mback.Click += new System.EventHandler(this.btn_mback_Click);
            // 
            // Manager_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Course_Work_GAD.Properties.Resources.Registation_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 555);
            this.Controls.Add(this.btn_mback);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.txt_mpw);
            this.Controls.Add(this.txt_mun);
            this.Controls.Add(this.btn_mlogin);
            this.Controls.Add(this.lbl_mpw);
            this.Controls.Add(this.lbl_mun);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_login";
            this.Load += new System.EventHandler(this.Manager_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.TextBox txt_mpw;
        private System.Windows.Forms.TextBox txt_mun;
        private System.Windows.Forms.Button btn_mlogin;
        private System.Windows.Forms.Label lbl_mpw;
        private System.Windows.Forms.Label lbl_mun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mback;
    }
}
namespace Course_Work_GAD
{
    partial class Sing_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.txt_un = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.lbl_un = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(643, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In ";
            // 
            // txt_pw
            // 
            this.txt_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.txt_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw.Location = new System.Drawing.Point(697, 269);
            this.txt_pw.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(292, 41);
            this.txt_pw.TabIndex = 11;
            // 
            // txt_un
            // 
            this.txt_un.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.txt_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_un.Location = new System.Drawing.Point(697, 194);
            this.txt_un.Margin = new System.Windows.Forms.Padding(4);
            this.txt_un.Name = "txt_un";
            this.txt_un.Size = new System.Drawing.Size(292, 41);
            this.txt_un.TabIndex = 10;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(636, 374);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(164, 54);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pw.Location = new System.Drawing.Point(495, 269);
            this.lbl_pw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(167, 39);
            this.lbl_pw.TabIndex = 7;
            this.lbl_pw.Text = "Password";
            // 
            // lbl_un
            // 
            this.lbl_un.AutoSize = true;
            this.lbl_un.BackColor = System.Drawing.Color.Transparent;
            this.lbl_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_un.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_un.Location = new System.Drawing.Point(495, 194);
            this.lbl_un.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_un.Name = "lbl_un";
            this.lbl_un.Size = new System.Drawing.Size(183, 39);
            this.lbl_un.TabIndex = 6;
            this.lbl_un.Text = "User name";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_msg.Location = new System.Drawing.Point(548, 338);
            this.lbl_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 20);
            this.lbl_msg.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 441);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Not a Member?";
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Black;
            this.btn_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(599, 485);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(327, 48);
            this.btn_new.TabIndex = 14;
            this.btn_new.Text = "Create an Account";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Black;
            this.btnback.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Yellow;
            this.btnback.Location = new System.Drawing.Point(481, 544);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 34);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::Course_Work_GAD.Properties.Resources.Infinity;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 565);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Sing_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Course_Work_GAD.Properties.Resources.WhatsApp_Image_2023_03_23_at_20_30_31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_un);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_pw);
            this.Controls.Add(this.lbl_un);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sing_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Sing_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.TextBox txt_un;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.Label lbl_un;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btnback;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}


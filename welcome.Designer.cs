namespace Course_Work_GAD
{
    partial class welcome
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
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_manager = new System.Windows.Forms.Button();
            this.btn_wclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btn_customer.FlatAppearance.BorderSize = 0;
            this.btn_customer.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.Location = new System.Drawing.Point(89, 644);
            this.btn_customer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(281, 52);
            this.btn_customer.TabIndex = 0;
            this.btn_customer.Text = "STAFF";
            this.btn_customer.UseVisualStyleBackColor = false;
            this.btn_customer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btn_admin.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(421, 644);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(281, 52);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "ADMIN";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_manager
            // 
            this.btn_manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btn_manager.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manager.Location = new System.Drawing.Point(744, 644);
            this.btn_manager.Margin = new System.Windows.Forms.Padding(4);
            this.btn_manager.Name = "btn_manager";
            this.btn_manager.Size = new System.Drawing.Size(281, 52);
            this.btn_manager.TabIndex = 2;
            this.btn_manager.Text = "MANAGER";
            this.btn_manager.UseVisualStyleBackColor = false;
            this.btn_manager.Click += new System.EventHandler(this.btn_manager_Click);
            // 
            // btn_wclose
            // 
            this.btn_wclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btn_wclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_wclose.Location = new System.Drawing.Point(1043, 15);
            this.btn_wclose.Margin = new System.Windows.Forms.Padding(4);
            this.btn_wclose.Name = "btn_wclose";
            this.btn_wclose.Size = new System.Drawing.Size(47, 32);
            this.btn_wclose.TabIndex = 10;
            this.btn_wclose.Text = "X";
            this.btn_wclose.UseVisualStyleBackColor = false;
            this.btn_wclose.Click += new System.EventHandler(this.btn_wclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Stencil", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(293, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 119);
            this.label1.TabIndex = 11;
            this.label1.Text = "WELCOME";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Course_Work_GAD.Properties.Resources.istockphoto_691471792_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 779);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_wclose);
            this.Controls.Add(this.btn_manager);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_customer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_manager;
        private System.Windows.Forms.Button btn_wclose;
        private System.Windows.Forms.Label label1;
    }
}
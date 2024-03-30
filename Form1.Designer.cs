using System;

namespace FilmSite
{
    partial class Login
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
            this.Welcome = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(182, 59);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(245, 55);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome!";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(144, 146);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(150, 33);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(144, 206);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(143, 33);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(300, 159);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(153, 20);
            this.txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(300, 219);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(153, 20);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(200, 272);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(87, 35);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Enter
            // 
            this.Enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Enter.Location = new System.Drawing.Point(371, 272);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(82, 35);
            this.Enter.TabIndex = 6;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(105, 356);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(87, 42);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(615, 447);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Welcome);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Exit;
    }
}



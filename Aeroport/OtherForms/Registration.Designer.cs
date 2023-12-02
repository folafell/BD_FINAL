namespace Aeroport
{
    partial class Registration
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
            linkLabelAlready = new LinkLabel();
            button1 = new Button();
            textBoxPassword = new TextBox();
            label2 = new Label();
            textBoxLogin = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabelAlready
            // 
            linkLabelAlready.AutoSize = true;
            linkLabelAlready.Location = new Point(94, 327);
            linkLabelAlready.Name = "linkLabelAlready";
            linkLabelAlready.Size = new Size(136, 20);
            linkLabelAlready.TabIndex = 11;
            linkLabelAlready.TabStop = true;
            linkLabelAlready.Text = "already registered?";
            linkLabelAlready.LinkClicked += linkLabelAlready_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGoldenrodYellow;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(75, 250);
            button1.Name = "button1";
            button1.Size = new Size(172, 65);
            button1.TabIndex = 10;
            button1.Text = "Registration";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(12, 179);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(305, 38);
            textBoxPassword.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(94, 144);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(12, 68);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(305, 38);
            textBoxLogin.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 32);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(329, 356);
            Controls.Add(linkLabelAlready);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabelAlready;
        private Button button1;
        private TextBox textBoxPassword;
        private Label label2;
        private TextBox textBoxLogin;
        private Label label1;
    }
}
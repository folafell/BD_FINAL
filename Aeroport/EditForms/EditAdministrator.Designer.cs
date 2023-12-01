namespace Aeroport.EditForms
{
    partial class EditAdministrator
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
            btnAdd = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            labelLogin = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(54, 163);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(12, 48);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(209, 27);
            textBoxLogin.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 116);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(209, 27);
            textBoxPassword.TabIndex = 7;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(82, 93);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(93, 25);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(46, 20);
            labelLogin.TabIndex = 5;
            labelLogin.Text = "Login";
            // 
            // EditAdministrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 205);
            Controls.Add(btnAdd);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditAdministrator";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditAdministrator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Label labelLogin;
    }
}
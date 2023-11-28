namespace Aeroport
{
    partial class AddSecurity
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
            label1 = new Label();
            fieldSecurityEmployeeId = new ComboBox();
            label2 = new Label();
            fieldEducation = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 26);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "SecurityEmployeeId";
            // 
            // fieldSecurityEmployeeId
            // 
            fieldSecurityEmployeeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldSecurityEmployeeId.FormattingEnabled = true;
            fieldSecurityEmployeeId.Location = new Point(12, 49);
            fieldSecurityEmployeeId.Name = "fieldSecurityEmployeeId";
            fieldSecurityEmployeeId.Size = new Size(253, 28);
            fieldSecurityEmployeeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 91);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Education";
            // 
            // fieldEducation
            // 
            fieldEducation.Location = new Point(12, 114);
            fieldEducation.Name = "fieldEducation";
            fieldEducation.Size = new Size(252, 27);
            fieldEducation.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(85, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddSecurity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 204);
            Controls.Add(btnAdd);
            Controls.Add(fieldEducation);
            Controls.Add(label2);
            Controls.Add(fieldSecurityEmployeeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSecurity";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddSecurity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fieldSecurityEmployeeId;
        private Label label2;
        private TextBox fieldEducation;
        private Button btnAdd;
    }
}
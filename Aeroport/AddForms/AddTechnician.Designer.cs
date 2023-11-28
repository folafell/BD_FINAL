namespace Aeroport
{
    partial class AddTechnician
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
            fieldTechnicianEmployeeId = new ComboBox();
            label2 = new Label();
            fieldEducation = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 22);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "TechnicianEmployeeId";
            // 
            // fieldTechnicianEmployeeId
            // 
            fieldTechnicianEmployeeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldTechnicianEmployeeId.FormattingEnabled = true;
            fieldTechnicianEmployeeId.Location = new Point(12, 43);
            fieldTechnicianEmployeeId.Name = "fieldTechnicianEmployeeId";
            fieldTechnicianEmployeeId.Size = new Size(257, 28);
            fieldTechnicianEmployeeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 83);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Education";
            // 
            // fieldEducation
            // 
            fieldEducation.Location = new Point(12, 103);
            fieldEducation.Name = "fieldEducation";
            fieldEducation.Size = new Size(257, 27);
            fieldEducation.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(93, 148);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddTechnician
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 191);
            Controls.Add(btnAdd);
            Controls.Add(fieldEducation);
            Controls.Add(label2);
            Controls.Add(fieldTechnicianEmployeeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTechnician";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddTechnician";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fieldTechnicianEmployeeId;
        private Label label2;
        private TextBox fieldEducation;
        private Button btnAdd;
    }
}
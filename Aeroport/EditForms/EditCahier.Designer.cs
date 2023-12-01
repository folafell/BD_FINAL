namespace Aeroport.EditForms
{
    partial class EditCahier
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
            fieldAccountantEducation = new TextBox();
            btnAdd = new Button();
            label2 = new Label();
            fieldCashierEmployeeId = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // fieldAccountantEducation
            // 
            fieldAccountantEducation.Location = new Point(12, 97);
            fieldAccountantEducation.Name = "fieldAccountantEducation";
            fieldAccountantEducation.Size = new Size(232, 27);
            fieldAccountantEducation.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(77, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 74);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 8;
            label2.Text = "AccountantEducation";
            // 
            // fieldCashierEmployeeId
            // 
            fieldCashierEmployeeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldCashierEmployeeId.FormattingEnabled = true;
            fieldCashierEmployeeId.Location = new Point(12, 40);
            fieldCashierEmployeeId.Name = "fieldCashierEmployeeId";
            fieldCashierEmployeeId.Size = new Size(232, 28);
            fieldCashierEmployeeId.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 17);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 6;
            label1.Text = "CashierEmployeeID";
            // 
            // EditCahier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 181);
            Controls.Add(fieldAccountantEducation);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(fieldCashierEmployeeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditCahier";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditCahier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fieldAccountantEducation;
        private Button btnAdd;
        private Label label2;
        private ComboBox fieldCashierEmployeeId;
        private Label label1;
    }
}
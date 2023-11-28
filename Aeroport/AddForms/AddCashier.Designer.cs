namespace Aeroport
{
    partial class AddCashier
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
            fieldCashierEmployeeId = new ComboBox();
            label2 = new Label();
            btnAdd = new Button();
            fieldAccountantEducation = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 41);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "CashierEmployeeID";
            // 
            // fieldCashierEmployeeId
            // 
            fieldCashierEmployeeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldCashierEmployeeId.FormattingEnabled = true;
            fieldCashierEmployeeId.Location = new Point(12, 64);
            fieldCashierEmployeeId.Name = "fieldCashierEmployeeId";
            fieldCashierEmployeeId.Size = new Size(232, 28);
            fieldCashierEmployeeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 98);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 2;
            label2.Text = "AccountantEducation";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(77, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // fieldAccountantEducation
            // 
            fieldAccountantEducation.Location = new Point(12, 121);
            fieldAccountantEducation.Name = "fieldAccountantEducation";
            fieldAccountantEducation.Size = new Size(232, 27);
            fieldAccountantEducation.TabIndex = 5;
            // 
            // AddCashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 209);
            Controls.Add(fieldAccountantEducation);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(fieldCashierEmployeeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCashier";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCashier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fieldCashierEmployeeId;
        private Label label2;
        private Button btnAdd;
        private TextBox fieldAccountantEducation;
    }
}
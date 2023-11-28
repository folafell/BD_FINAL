namespace Aeroport
{
    partial class AddDispatcher
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
            fieldDispatcherEmployeeId = new ComboBox();
            label2 = new Label();
            fieldEducation = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 33);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "DispatcherEmployeeId";
            // 
            // fieldDispatcherEmployeeId
            // 
            fieldDispatcherEmployeeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldDispatcherEmployeeId.FormattingEnabled = true;
            fieldDispatcherEmployeeId.Location = new Point(12, 56);
            fieldDispatcherEmployeeId.Name = "fieldDispatcherEmployeeId";
            fieldDispatcherEmployeeId.Size = new Size(221, 28);
            fieldDispatcherEmployeeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 87);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Education";
            // 
            // fieldEducation
            // 
            fieldEducation.Location = new Point(12, 110);
            fieldEducation.Name = "fieldEducation";
            fieldEducation.Size = new Size(218, 27);
            fieldEducation.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(73, 143);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddDispatcher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 180);
            Controls.Add(btnAdd);
            Controls.Add(fieldEducation);
            Controls.Add(label2);
            Controls.Add(fieldDispatcherEmployeeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddDispatcher";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddDispatcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fieldDispatcherEmployeeId;
        private Label label2;
        private TextBox fieldEducation;
        private Button btnAdd;
    }
}
namespace Aeroport.EditForms
{
    partial class EditPilot
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
            physical = new NumericUpDown();
            label2 = new Label();
            fieldPilotEmployeeId = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)physical).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(93, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // physical
            // 
            physical.Location = new Point(12, 95);
            physical.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            physical.Minimum = new decimal(new int[] { 2015, 0, 0, 0 });
            physical.Name = "physical";
            physical.Size = new Size(251, 27);
            physical.TabIndex = 8;
            physical.Value = new decimal(new int[] { 2015, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 73);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "Physical";
            // 
            // fieldPilotEmployeeId
            // 
            fieldPilotEmployeeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldPilotEmployeeId.FormattingEnabled = true;
            fieldPilotEmployeeId.Location = new Point(12, 32);
            fieldPilotEmployeeId.Name = "fieldPilotEmployeeId";
            fieldPilotEmployeeId.Size = new Size(251, 28);
            fieldPilotEmployeeId.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 5;
            label1.Text = "PilotEmployeeId";
            // 
            // EditPilot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 180);
            Controls.Add(btnAdd);
            Controls.Add(physical);
            Controls.Add(label2);
            Controls.Add(fieldPilotEmployeeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditPilot";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditPilot";
            ((System.ComponentModel.ISupportInitialize)physical).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private NumericUpDown physical;
        private Label label2;
        private ComboBox fieldPilotEmployeeId;
        private Label label1;
    }
}
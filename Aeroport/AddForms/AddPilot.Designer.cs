namespace Aeroport
{
    partial class AddPilot
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
            fieldPilotEmployeeId = new ComboBox();
            label2 = new Label();
            physical = new NumericUpDown();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)physical).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 24);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "PilotEmployeeId";
            // 
            // fieldPilotEmployeeId
            // 
            fieldPilotEmployeeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldPilotEmployeeId.FormattingEnabled = true;
            fieldPilotEmployeeId.Location = new Point(12, 47);
            fieldPilotEmployeeId.Name = "fieldPilotEmployeeId";
            fieldPilotEmployeeId.Size = new Size(251, 28);
            fieldPilotEmployeeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 88);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Physical";
            // 
            // physical
            // 
            physical.Location = new Point(12, 110);
            physical.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            physical.Minimum = new decimal(new int[] { 2015, 0, 0, 0 });
            physical.Name = "physical";
            physical.Size = new Size(251, 27);
            physical.TabIndex = 3;
            physical.Value = new decimal(new int[] { 2015, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(93, 157);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddPilot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 203);
            Controls.Add(btnAdd);
            Controls.Add(physical);
            Controls.Add(label2);
            Controls.Add(fieldPilotEmployeeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPilot";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddPilot";
            ((System.ComponentModel.ISupportInitialize)physical).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fieldPilotEmployeeId;
        private Label label2;
        private NumericUpDown physical;
        private Button btnAdd;
    }
}
namespace Aeroport.EditForms
{
    partial class EditEmployee
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
            fieldSalary = new NumericUpDown();
            label7 = new Label();
            fieldChildren = new NumericUpDown();
            label6 = new Label();
            fieldExperience = new NumericUpDown();
            label5 = new Label();
            fieldGender = new ComboBox();
            label4 = new Label();
            fieldAge = new NumericUpDown();
            label3 = new Label();
            fieldLastname = new TextBox();
            label2 = new Label();
            fieldEmployeeBrigadeId = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fieldSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldChildren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldAge).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(72, 431);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // fieldSalary
            // 
            fieldSalary.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            fieldSalary.Location = new Point(12, 388);
            fieldSalary.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            fieldSalary.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            fieldSalary.Name = "fieldSalary";
            fieldSalary.Size = new Size(221, 27);
            fieldSalary.TabIndex = 28;
            fieldSalary.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 368);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 27;
            label7.Text = "Salary";
            // 
            // fieldChildren
            // 
            fieldChildren.Location = new Point(12, 334);
            fieldChildren.Name = "fieldChildren";
            fieldChildren.Size = new Size(221, 27);
            fieldChildren.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 311);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 25;
            label6.Text = "Children";
            // 
            // fieldExperience
            // 
            fieldExperience.Location = new Point(12, 276);
            fieldExperience.Name = "fieldExperience";
            fieldExperience.Size = new Size(221, 27);
            fieldExperience.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 255);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 23;
            label5.Text = "Experience";
            // 
            // fieldGender
            // 
            fieldGender.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldGender.FormattingEnabled = true;
            fieldGender.Items.AddRange(new object[] { "М", "Ж" });
            fieldGender.Location = new Point(12, 220);
            fieldGender.Name = "fieldGender";
            fieldGender.Size = new Size(221, 28);
            fieldGender.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 197);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 21;
            label4.Text = "Gender";
            // 
            // fieldAge
            // 
            fieldAge.Location = new Point(12, 160);
            fieldAge.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            fieldAge.Name = "fieldAge";
            fieldAge.Size = new Size(220, 27);
            fieldAge.TabIndex = 20;
            fieldAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 137);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 19;
            label3.Text = "Age";
            // 
            // fieldLastname
            // 
            fieldLastname.Location = new Point(12, 96);
            fieldLastname.Name = "fieldLastname";
            fieldLastname.Size = new Size(220, 27);
            fieldLastname.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 73);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 17;
            label2.Text = "Lastname";
            // 
            // fieldEmployeeBrigadeId
            // 
            fieldEmployeeBrigadeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldEmployeeBrigadeId.FormattingEnabled = true;
            fieldEmployeeBrigadeId.Location = new Point(12, 35);
            fieldEmployeeBrigadeId.Name = "fieldEmployeeBrigadeId";
            fieldEmployeeBrigadeId.Size = new Size(220, 28);
            fieldEmployeeBrigadeId.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 12);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 15;
            label1.Text = "EmployeeBrigadeId";
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 466);
            Controls.Add(btnAdd);
            Controls.Add(fieldSalary);
            Controls.Add(label7);
            Controls.Add(fieldChildren);
            Controls.Add(label6);
            Controls.Add(fieldExperience);
            Controls.Add(label5);
            Controls.Add(fieldGender);
            Controls.Add(label4);
            Controls.Add(fieldAge);
            Controls.Add(label3);
            Controls.Add(fieldLastname);
            Controls.Add(label2);
            Controls.Add(fieldEmployeeBrigadeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditEmployee";
            ((System.ComponentModel.ISupportInitialize)fieldSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldChildren).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private NumericUpDown fieldSalary;
        private Label label7;
        private NumericUpDown fieldChildren;
        private Label label6;
        private NumericUpDown fieldExperience;
        private Label label5;
        private ComboBox fieldGender;
        private Label label4;
        private NumericUpDown fieldAge;
        private Label label3;
        private TextBox fieldLastname;
        private Label label2;
        private ComboBox fieldEmployeeBrigadeId;
        private Label label1;
    }
}
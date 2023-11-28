namespace Aeroport
{
    partial class AddEmployee
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
            fieldEmployeeBrigadeId = new ComboBox();
            label2 = new Label();
            fieldLastname = new TextBox();
            label3 = new Label();
            fieldAge = new NumericUpDown();
            label4 = new Label();
            fieldGender = new ComboBox();
            label5 = new Label();
            fieldExperience = new NumericUpDown();
            label6 = new Label();
            fieldChildren = new NumericUpDown();
            label7 = new Label();
            fieldSalary = new NumericUpDown();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)fieldAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldChildren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldSalary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 22);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "EmployeeBrigadeId";
            // 
            // fieldEmployeeBrigadeId
            // 
            fieldEmployeeBrigadeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldEmployeeBrigadeId.FormattingEnabled = true;
            fieldEmployeeBrigadeId.Location = new Point(12, 45);
            fieldEmployeeBrigadeId.Name = "fieldEmployeeBrigadeId";
            fieldEmployeeBrigadeId.Size = new Size(220, 28);
            fieldEmployeeBrigadeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 83);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Lastname";
            // 
            // fieldLastname
            // 
            fieldLastname.Location = new Point(12, 106);
            fieldLastname.Name = "fieldLastname";
            fieldLastname.Size = new Size(220, 27);
            fieldLastname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 147);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 4;
            label3.Text = "Age";
            // 
            // fieldAge
            // 
            fieldAge.Location = new Point(12, 170);
            fieldAge.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            fieldAge.Name = "fieldAge";
            fieldAge.Size = new Size(220, 27);
            fieldAge.TabIndex = 5;
            fieldAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 207);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // fieldGender
            // 
            fieldGender.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldGender.FormattingEnabled = true;
            fieldGender.Items.AddRange(new object[] { "М", "Ж" });
            fieldGender.Location = new Point(12, 230);
            fieldGender.Name = "fieldGender";
            fieldGender.Size = new Size(221, 28);
            fieldGender.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 265);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 8;
            label5.Text = "Experience";
            // 
            // fieldExperience
            // 
            fieldExperience.Location = new Point(12, 286);
            fieldExperience.Name = "fieldExperience";
            fieldExperience.Size = new Size(221, 27);
            fieldExperience.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 321);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 10;
            label6.Text = "Children";
            // 
            // fieldChildren
            // 
            fieldChildren.Location = new Point(12, 344);
            fieldChildren.Name = "fieldChildren";
            fieldChildren.Size = new Size(221, 27);
            fieldChildren.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 378);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 12;
            label7.Text = "Salary";
            // 
            // fieldSalary
            // 
            fieldSalary.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            fieldSalary.Location = new Point(12, 398);
            fieldSalary.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            fieldSalary.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            fieldSalary.Name = "fieldSalary";
            fieldSalary.Size = new Size(221, 27);
            fieldSalary.TabIndex = 13;
            fieldSalary.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(72, 441);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 482);
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
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)fieldAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldChildren).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fieldEmployeeBrigadeId;
        private Label label2;
        private TextBox fieldLastname;
        private Label label3;
        private NumericUpDown fieldAge;
        private Label label4;
        private ComboBox fieldGender;
        private Label label5;
        private NumericUpDown fieldExperience;
        private Label label6;
        private NumericUpDown fieldChildren;
        private Label label7;
        private NumericUpDown fieldSalary;
        private Button btnAdd;
    }
}
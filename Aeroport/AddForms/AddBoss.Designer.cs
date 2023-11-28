namespace Aeroport
{
    partial class AddBoss
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
            fieldFirstname = new TextBox();
            fieldLastname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            fieldPatronymic = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            fieldSalary = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)fieldSalary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 33);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Firstname";
            // 
            // fieldFirstname
            // 
            fieldFirstname.Location = new Point(12, 56);
            fieldFirstname.Name = "fieldFirstname";
            fieldFirstname.Size = new Size(229, 27);
            fieldFirstname.TabIndex = 1;
            // 
            // fieldLastname
            // 
            fieldLastname.Location = new Point(12, 109);
            fieldLastname.Name = "fieldLastname";
            fieldLastname.Size = new Size(229, 27);
            fieldLastname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 86);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Lastname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 194);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Salary";
            // 
            // fieldPatronymic
            // 
            fieldPatronymic.Location = new Point(12, 164);
            fieldPatronymic.Name = "fieldPatronymic";
            fieldPatronymic.Size = new Size(229, 27);
            fieldPatronymic.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 141);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 4;
            label4.Text = "Patronymic";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(77, 265);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // fieldSalary
            // 
            fieldSalary.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            fieldSalary.Location = new Point(12, 217);
            fieldSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            fieldSalary.Name = "fieldSalary";
            fieldSalary.Size = new Size(229, 27);
            fieldSalary.TabIndex = 9;
            fieldSalary.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // AddBoss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 313);
            Controls.Add(fieldSalary);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(fieldPatronymic);
            Controls.Add(label4);
            Controls.Add(fieldLastname);
            Controls.Add(label2);
            Controls.Add(fieldFirstname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddBoss";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddBoss";
            ((System.ComponentModel.ISupportInitialize)fieldSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fieldFirstname;
        private TextBox fieldLastname;
        private Label label2;
        private Label label3;
        private TextBox fieldPatronymic;
        private Label label4;
        private Button btnAdd;
        private NumericUpDown fieldSalary;
    }
}
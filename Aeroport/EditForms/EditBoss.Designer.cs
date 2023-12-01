namespace Aeroport.EditForms
{
    partial class EditBoss
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
            fieldSalary = new NumericUpDown();
            btnAdd = new Button();
            label3 = new Label();
            fieldPatronymic = new TextBox();
            label4 = new Label();
            fieldLastname = new TextBox();
            label2 = new Label();
            fieldFirstname = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fieldSalary).BeginInit();
            SuspendLayout();
            // 
            // fieldSalary
            // 
            fieldSalary.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            fieldSalary.Location = new Point(12, 197);
            fieldSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            fieldSalary.Name = "fieldSalary";
            fieldSalary.Size = new Size(229, 27);
            fieldSalary.TabIndex = 18;
            fieldSalary.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(77, 245);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 174);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 16;
            label3.Text = "Salary";
            // 
            // fieldPatronymic
            // 
            fieldPatronymic.Location = new Point(12, 144);
            fieldPatronymic.Name = "fieldPatronymic";
            fieldPatronymic.Size = new Size(229, 27);
            fieldPatronymic.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 121);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 14;
            label4.Text = "Patronymic";
            // 
            // fieldLastname
            // 
            fieldLastname.Location = new Point(12, 89);
            fieldLastname.Name = "fieldLastname";
            fieldLastname.Size = new Size(229, 27);
            fieldLastname.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 66);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 12;
            label2.Text = "Lastname";
            // 
            // fieldFirstname
            // 
            fieldFirstname.Location = new Point(12, 36);
            fieldFirstname.Name = "fieldFirstname";
            fieldFirstname.Size = new Size(229, 27);
            fieldFirstname.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 13);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 10;
            label1.Text = "Firstname";
            // 
            // EditBoss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 287);
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
            Name = "EditBoss";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditBoss";
            ((System.ComponentModel.ISupportInitialize)fieldSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown fieldSalary;
        private Button btnAdd;
        private Label label3;
        private TextBox fieldPatronymic;
        private Label label4;
        private TextBox fieldLastname;
        private Label label2;
        private TextBox fieldFirstname;
        private Label label1;
    }
}
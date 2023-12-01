namespace Aeroport.EditForms
{
    partial class EditPassenger
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
            fieldGender = new ComboBox();
            label5 = new Label();
            fieldAge = new NumericUpDown();
            label4 = new Label();
            fieldPatronymic = new TextBox();
            label3 = new Label();
            fieldLastname = new TextBox();
            label2 = new Label();
            fieldFirstname = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fieldAge).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(81, 333);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // fieldGender
            // 
            fieldGender.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldGender.FormattingEnabled = true;
            fieldGender.Items.AddRange(new object[] { "M", "Ж" });
            fieldGender.Location = new Point(12, 285);
            fieldGender.Name = "fieldGender";
            fieldGender.Size = new Size(233, 28);
            fieldGender.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 264);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 19;
            label5.Text = "Gender";
            // 
            // fieldAge
            // 
            fieldAge.Location = new Point(12, 223);
            fieldAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            fieldAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            fieldAge.Name = "fieldAge";
            fieldAge.Size = new Size(233, 27);
            fieldAge.TabIndex = 18;
            fieldAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 200);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 17;
            label4.Text = "Age";
            // 
            // fieldPatronymic
            // 
            fieldPatronymic.Location = new Point(12, 160);
            fieldPatronymic.Name = "fieldPatronymic";
            fieldPatronymic.Size = new Size(233, 27);
            fieldPatronymic.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 137);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 15;
            label3.Text = "Patronymic";
            // 
            // fieldLastname
            // 
            fieldLastname.Location = new Point(12, 98);
            fieldLastname.Name = "fieldLastname";
            fieldLastname.Size = new Size(233, 27);
            fieldLastname.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 77);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 13;
            label2.Text = "Lastname";
            // 
            // fieldFirstname
            // 
            fieldFirstname.Location = new Point(12, 36);
            fieldFirstname.Name = "fieldFirstname";
            fieldFirstname.Size = new Size(233, 27);
            fieldFirstname.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 13);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 11;
            label1.Text = "Firstname";
            // 
            // EditPassenger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 372);
            Controls.Add(btnAdd);
            Controls.Add(fieldGender);
            Controls.Add(label5);
            Controls.Add(fieldAge);
            Controls.Add(label4);
            Controls.Add(fieldPatronymic);
            Controls.Add(label3);
            Controls.Add(fieldLastname);
            Controls.Add(label2);
            Controls.Add(fieldFirstname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditPassenger";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditPassenger";
            ((System.ComponentModel.ISupportInitialize)fieldAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ComboBox fieldGender;
        private Label label5;
        private NumericUpDown fieldAge;
        private Label label4;
        private TextBox fieldPatronymic;
        private Label label3;
        private TextBox fieldLastname;
        private Label label2;
        private TextBox fieldFirstname;
        private Label label1;
    }
}
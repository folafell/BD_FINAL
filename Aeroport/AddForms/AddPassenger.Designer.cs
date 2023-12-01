namespace Aeroport
{
    partial class AddPassenger
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
            label2 = new Label();
            fieldLastname = new TextBox();
            label3 = new Label();
            fieldPatronymic = new TextBox();
            label4 = new Label();
            fieldAge = new NumericUpDown();
            label5 = new Label();
            fieldGender = new ComboBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)fieldAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Firstname";
            label1.Click += label1_Click;
            // 
            // fieldFirstname
            // 
            fieldFirstname.Location = new Point(12, 43);
            fieldFirstname.Name = "fieldFirstname";
            fieldFirstname.Size = new Size(233, 27);
            fieldFirstname.TabIndex = 1;
            fieldFirstname.TextChanged += fieldFirstname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 84);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Lastname";
            label2.Click += label2_Click;
            // 
            // fieldLastname
            // 
            fieldLastname.Location = new Point(12, 105);
            fieldLastname.Name = "fieldLastname";
            fieldLastname.Size = new Size(233, 27);
            fieldLastname.TabIndex = 3;
            fieldLastname.TextChanged += fieldLastname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 144);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 4;
            label3.Text = "Patronymic";
            label3.Click += label3_Click;
            // 
            // fieldPatronymic
            // 
            fieldPatronymic.Location = new Point(12, 167);
            fieldPatronymic.Name = "fieldPatronymic";
            fieldPatronymic.Size = new Size(233, 27);
            fieldPatronymic.TabIndex = 5;
            fieldPatronymic.TextChanged += fieldPatronymic_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 207);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "Age";
            label4.Click += label4_Click;
            // 
            // fieldAge
            // 
            fieldAge.Location = new Point(12, 230);
            fieldAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            fieldAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            fieldAge.Name = "fieldAge";
            fieldAge.Size = new Size(233, 27);
            fieldAge.TabIndex = 7;
            fieldAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            fieldAge.ValueChanged += fieldAge_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 271);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 8;
            label5.Text = "Gender";
            label5.Click += label5_Click;
            // 
            // fieldGender
            // 
            fieldGender.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldGender.FormattingEnabled = true;
            fieldGender.Items.AddRange(new object[] { "M", "Ж" });
            fieldGender.Location = new Point(12, 292);
            fieldGender.Name = "fieldGender";
            fieldGender.Size = new Size(233, 28);
            fieldGender.TabIndex = 9;
            fieldGender.SelectedIndexChanged += fieldGender_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(81, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddPassenger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 377);
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
            Name = "AddPassenger";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddPassenger";
            ((System.ComponentModel.ISupportInitialize)fieldAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fieldFirstname;
        private Label label2;
        private TextBox fieldLastname;
        private Label label3;
        private TextBox fieldPatronymic;
        private Label label4;
        private NumericUpDown fieldAge;
        private Label label5;
        private ComboBox fieldGender;
        private Button btnAdd;
    }
}
namespace Aeroport.AddForms
{
    partial class AddFlight
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
            label2 = new Label();
            fieldPlacefrom = new TextBox();
            fieldPlaceTo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            fieldCategory = new ComboBox();
            label5 = new Label();
            fieldHours = new NumericUpDown();
            fieldMinutes = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            fieldAirplaneTypeId = new ComboBox();
            fieldBrigadeId = new ComboBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)fieldHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldMinutes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "PlaceFrom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 20);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "PlaceTo";
            // 
            // fieldPlacefrom
            // 
            fieldPlacefrom.Location = new Point(12, 43);
            fieldPlacefrom.Name = "fieldPlacefrom";
            fieldPlacefrom.Size = new Size(190, 27);
            fieldPlacefrom.TabIndex = 2;
            // 
            // fieldPlaceTo
            // 
            fieldPlaceTo.Location = new Point(273, 42);
            fieldPlaceTo.Name = "fieldPlaceTo";
            fieldPlaceTo.Size = new Size(190, 27);
            fieldPlaceTo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(219, 32);
            label3.Name = "label3";
            label3.Size = new Size(41, 38);
            label3.TabIndex = 4;
            label3.Text = "→";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 85);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Category";
            // 
            // fieldCategory
            // 
            fieldCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldCategory.FormattingEnabled = true;
            fieldCategory.Items.AddRange(new object[] { "Внутренний", "Международный", "Чартерный", "Грузоперевозка", "Специальный" });
            fieldCategory.Location = new Point(135, 108);
            fieldCategory.Name = "fieldCategory";
            fieldCategory.Size = new Size(198, 28);
            fieldCategory.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 150);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 7;
            label5.Text = "Duration";
            // 
            // fieldHours
            // 
            fieldHours.Location = new Point(135, 191);
            fieldHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            fieldHours.Name = "fieldHours";
            fieldHours.Size = new Size(67, 27);
            fieldHours.TabIndex = 8;
            // 
            // fieldMinutes
            // 
            fieldMinutes.Location = new Point(273, 191);
            fieldMinutes.Name = "fieldMinutes";
            fieldMinutes.Size = new Size(60, 27);
            fieldMinutes.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 170);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 10;
            label6.Text = "hours";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(273, 171);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 11;
            label7.Text = "minutes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 231);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 12;
            label8.Text = "FieldAirplaneTypeId";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(317, 230);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 13;
            label9.Text = "FieldBrigadeId";
            // 
            // fieldAirplaneTypeId
            // 
            fieldAirplaneTypeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldAirplaneTypeId.FormattingEnabled = true;
            fieldAirplaneTypeId.Location = new Point(12, 251);
            fieldAirplaneTypeId.Name = "fieldAirplaneTypeId";
            fieldAirplaneTypeId.Size = new Size(190, 28);
            fieldAirplaneTypeId.TabIndex = 14;
            // 
            // fieldBrigadeId
            // 
            fieldBrigadeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldBrigadeId.FormattingEnabled = true;
            fieldBrigadeId.Location = new Point(273, 249);
            fieldBrigadeId.Name = "fieldBrigadeId";
            fieldBrigadeId.Size = new Size(190, 28);
            fieldBrigadeId.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(187, 309);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 348);
            Controls.Add(btnAdd);
            Controls.Add(fieldBrigadeId);
            Controls.Add(fieldAirplaneTypeId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(fieldMinutes);
            Controls.Add(fieldHours);
            Controls.Add(label5);
            Controls.Add(fieldCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(fieldPlaceTo);
            Controls.Add(fieldPlacefrom);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFlight";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddFlight";
            ((System.ComponentModel.ISupportInitialize)fieldHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldMinutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox fieldPlacefrom;
        private TextBox fieldPlaceTo;
        private Label label3;
        private Label label4;
        private ComboBox fieldCategory;
        private Label label5;
        private NumericUpDown fieldHours;
        private NumericUpDown fieldMinutes;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox fieldAirplaneTypeId;
        private ComboBox fieldBrigadeId;
        private Button btnAdd;
    }
}
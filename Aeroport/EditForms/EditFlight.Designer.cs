namespace Aeroport.EditForms
{
    partial class EditFlight
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
            fieldBrigadeId = new ComboBox();
            fieldAirplaneTypeId = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            fieldMinutes = new NumericUpDown();
            fieldHours = new NumericUpDown();
            label5 = new Label();
            fieldCategory = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            fieldPlaceTo = new TextBox();
            fieldPlacefrom = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fieldMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldHours).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(187, 303);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // fieldBrigadeId
            // 
            fieldBrigadeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldBrigadeId.FormattingEnabled = true;
            fieldBrigadeId.Location = new Point(273, 243);
            fieldBrigadeId.Name = "fieldBrigadeId";
            fieldBrigadeId.Size = new Size(190, 28);
            fieldBrigadeId.TabIndex = 32;
            // 
            // fieldAirplaneTypeId
            // 
            fieldAirplaneTypeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldAirplaneTypeId.FormattingEnabled = true;
            fieldAirplaneTypeId.Location = new Point(12, 245);
            fieldAirplaneTypeId.Name = "fieldAirplaneTypeId";
            fieldAirplaneTypeId.Size = new Size(190, 28);
            fieldAirplaneTypeId.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(317, 224);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 30;
            label9.Text = "FieldBrigadeId";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 225);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 29;
            label8.Text = "FieldAirplaneTypeId";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(273, 165);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 28;
            label7.Text = "minutes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 164);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 27;
            label6.Text = "hours";
            // 
            // fieldMinutes
            // 
            fieldMinutes.Location = new Point(273, 185);
            fieldMinutes.Name = "fieldMinutes";
            fieldMinutes.Size = new Size(60, 27);
            fieldMinutes.TabIndex = 26;
            // 
            // fieldHours
            // 
            fieldHours.Location = new Point(135, 185);
            fieldHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            fieldHours.Name = "fieldHours";
            fieldHours.Size = new Size(67, 27);
            fieldHours.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 144);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 24;
            label5.Text = "Duration";
            // 
            // fieldCategory
            // 
            fieldCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldCategory.FormattingEnabled = true;
            fieldCategory.Items.AddRange(new object[] { "Внутренний", "Международный", "Чартерный", "Грузоперевозка", "Специальный" });
            fieldCategory.Location = new Point(135, 102);
            fieldCategory.Name = "fieldCategory";
            fieldCategory.Size = new Size(198, 28);
            fieldCategory.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 79);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 22;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(219, 26);
            label3.Name = "label3";
            label3.Size = new Size(41, 38);
            label3.TabIndex = 21;
            label3.Text = "→";
            // 
            // fieldPlaceTo
            // 
            fieldPlaceTo.Location = new Point(273, 36);
            fieldPlaceTo.Name = "fieldPlaceTo";
            fieldPlaceTo.Size = new Size(190, 27);
            fieldPlaceTo.TabIndex = 20;
            // 
            // fieldPlacefrom
            // 
            fieldPlacefrom.Location = new Point(12, 37);
            fieldPlacefrom.Name = "fieldPlacefrom";
            fieldPlacefrom.Size = new Size(190, 27);
            fieldPlacefrom.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 14);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 18;
            label2.Text = "PlaceTo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 14);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 17;
            label1.Text = "PlaceFrom";
            // 
            // EditFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 343);
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
            Name = "EditFlight";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditFlight";
            ((System.ComponentModel.ISupportInitialize)fieldMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ComboBox fieldBrigadeId;
        private ComboBox fieldAirplaneTypeId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private NumericUpDown fieldMinutes;
        private NumericUpDown fieldHours;
        private Label label5;
        private ComboBox fieldCategory;
        private Label label4;
        private Label label3;
        private TextBox fieldPlaceTo;
        private TextBox fieldPlacefrom;
        private Label label2;
        private Label label1;
    }
}
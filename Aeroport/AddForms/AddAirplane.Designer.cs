namespace Aeroport
{
    partial class AddAirplane
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
            fieldToAirplaneType = new ComboBox();
            label1 = new Label();
            fieldLastRepair = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            fieldCountOfRepairs = new NumericUpDown();
            label4 = new Label();
            fieldTechnicalInspectation = new DateTimePicker();
            fieldAge = new NumericUpDown();
            label5 = new Label();
            fieldCountOfFlights = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            fieldReceiptDate = new DateTimePicker();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)fieldCountOfRepairs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldCountOfFlights).BeginInit();
            SuspendLayout();
            // 
            // fieldToAirplaneType
            // 
            fieldToAirplaneType.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldToAirplaneType.FormattingEnabled = true;
            fieldToAirplaneType.Location = new Point(12, 58);
            fieldToAirplaneType.Name = "fieldToAirplaneType";
            fieldToAirplaneType.Size = new Size(250, 28);
            fieldToAirplaneType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 35);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "ToAirplaneType";
            // 
            // fieldLastRepair
            // 
            fieldLastRepair.Location = new Point(12, 116);
            fieldLastRepair.Name = "fieldLastRepair";
            fieldLastRepair.Size = new Size(250, 27);
            fieldLastRepair.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 93);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "LastRepair";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 150);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 4;
            label3.Text = "CountOfRepairs";
            // 
            // fieldCountOfRepairs
            // 
            fieldCountOfRepairs.Location = new Point(12, 173);
            fieldCountOfRepairs.Name = "fieldCountOfRepairs";
            fieldCountOfRepairs.Size = new Size(250, 27);
            fieldCountOfRepairs.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 205);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 7;
            label4.Text = "TechnicalInspectation";
            // 
            // fieldTechnicalInspectation
            // 
            fieldTechnicalInspectation.Location = new Point(12, 228);
            fieldTechnicalInspectation.Name = "fieldTechnicalInspectation";
            fieldTechnicalInspectation.Size = new Size(250, 27);
            fieldTechnicalInspectation.TabIndex = 6;
            // 
            // fieldAge
            // 
            fieldAge.Location = new Point(12, 283);
            fieldAge.Name = "fieldAge";
            fieldAge.Size = new Size(250, 27);
            fieldAge.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 260);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 8;
            label5.Text = "Age";
            // 
            // fieldCountOfFlights
            // 
            fieldCountOfFlights.Location = new Point(12, 394);
            fieldCountOfFlights.Name = "fieldCountOfFlights";
            fieldCountOfFlights.Size = new Size(250, 27);
            fieldCountOfFlights.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 371);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 12;
            label6.Text = "CountOfFlights";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 316);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 11;
            label7.Text = "ReceiptDate";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fieldReceiptDate
            // 
            fieldReceiptDate.Location = new Point(12, 339);
            fieldReceiptDate.Name = "fieldReceiptDate";
            fieldReceiptDate.Size = new Size(250, 27);
            fieldReceiptDate.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(84, 442);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddAirplane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 488);
            Controls.Add(btnAdd);
            Controls.Add(fieldCountOfFlights);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(fieldReceiptDate);
            Controls.Add(fieldAge);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(fieldTechnicalInspectation);
            Controls.Add(fieldCountOfRepairs);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(fieldLastRepair);
            Controls.Add(label1);
            Controls.Add(fieldToAirplaneType);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAirplane";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddAirplane";
            ((System.ComponentModel.ISupportInitialize)fieldCountOfRepairs).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldCountOfFlights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox fieldToAirplaneType;
        private Label label1;
        private DateTimePicker fieldLastRepair;
        private Label label2;
        private Label label3;
        private NumericUpDown fieldCountOfRepairs;
        private Label label4;
        private DateTimePicker fieldTechnicalInspectation;
        private NumericUpDown fieldAge;
        private Label label5;
        private NumericUpDown fieldCountOfFlights;
        private Label label6;
        private Label label7;
        private DateTimePicker fieldReceiptDate;
        private Button btnAdd;
    }
}
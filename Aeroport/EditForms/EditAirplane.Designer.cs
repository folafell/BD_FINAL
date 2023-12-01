namespace Aeroport.EditForms
{
    partial class EditAirplane
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
            fieldLastRepair = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            fieldCountOfRepairs = new NumericUpDown();
            fieldTechnicalInspectation = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            fieldAge = new NumericUpDown();
            fieldReceiptDate = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            fieldCountOfFlights = new NumericUpDown();
            label1 = new Label();
            fieldToAirplaneType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)fieldCountOfRepairs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldCountOfFlights).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(84, 414);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // fieldLastRepair
            // 
            fieldLastRepair.Location = new Point(12, 88);
            fieldLastRepair.Name = "fieldLastRepair";
            fieldLastRepair.Size = new Size(250, 27);
            fieldLastRepair.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 65);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 18;
            label2.Text = "LastRepair";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 122);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 19;
            label3.Text = "CountOfRepairs";
            // 
            // fieldCountOfRepairs
            // 
            fieldCountOfRepairs.Location = new Point(12, 145);
            fieldCountOfRepairs.Name = "fieldCountOfRepairs";
            fieldCountOfRepairs.Size = new Size(250, 27);
            fieldCountOfRepairs.TabIndex = 20;
            // 
            // fieldTechnicalInspectation
            // 
            fieldTechnicalInspectation.Location = new Point(12, 200);
            fieldTechnicalInspectation.Name = "fieldTechnicalInspectation";
            fieldTechnicalInspectation.Size = new Size(250, 27);
            fieldTechnicalInspectation.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 177);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 22;
            label4.Text = "TechnicalInspectation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 232);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 23;
            label5.Text = "Age";
            // 
            // fieldAge
            // 
            fieldAge.Location = new Point(12, 255);
            fieldAge.Name = "fieldAge";
            fieldAge.Size = new Size(250, 27);
            fieldAge.TabIndex = 24;
            // 
            // fieldReceiptDate
            // 
            fieldReceiptDate.Location = new Point(12, 311);
            fieldReceiptDate.Name = "fieldReceiptDate";
            fieldReceiptDate.Size = new Size(250, 27);
            fieldReceiptDate.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 288);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 26;
            label7.Text = "ReceiptDate";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 343);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 27;
            label6.Text = "CountOfFlights";
            // 
            // fieldCountOfFlights
            // 
            fieldCountOfFlights.Location = new Point(12, 366);
            fieldCountOfFlights.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            fieldCountOfFlights.Name = "fieldCountOfFlights";
            fieldCountOfFlights.Size = new Size(250, 27);
            fieldCountOfFlights.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 11);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 33;
            label1.Text = "ToAirplaneType";
            // 
            // fieldToAirplaneType
            // 
            fieldToAirplaneType.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldToAirplaneType.FormattingEnabled = true;
            fieldToAirplaneType.Location = new Point(12, 34);
            fieldToAirplaneType.Name = "fieldToAirplaneType";
            fieldToAirplaneType.Size = new Size(250, 28);
            fieldToAirplaneType.TabIndex = 32;
            // 
            // EditAirplane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 450);
            Controls.Add(label1);
            Controls.Add(fieldToAirplaneType);
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
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditAirplane";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditAirplane";
            ((System.ComponentModel.ISupportInitialize)fieldCountOfRepairs).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldCountOfFlights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private DateTimePicker fieldLastRepair;
        private Label label2;
        private Label label3;
        private NumericUpDown fieldCountOfRepairs;
        private DateTimePicker fieldTechnicalInspectation;
        private Label label4;
        private Label label5;
        private NumericUpDown fieldAge;
        private DateTimePicker fieldReceiptDate;
        private Label label7;
        private Label label6;
        private NumericUpDown fieldCountOfFlights;
        private Label label1;
        private ComboBox fieldToAirplaneType;
    }
}
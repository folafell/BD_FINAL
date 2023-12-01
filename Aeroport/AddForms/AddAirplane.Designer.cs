namespace Aeroport.AddForms
{
    partial class AddAirplane_fixed
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
            fieldCountOfFlights = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            fieldReceiptDate = new DateTimePicker();
            fieldAge = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            fieldTechnicalInspectation = new DateTimePicker();
            fieldCountOfRepairs = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            fieldLastRepair = new DateTimePicker();
            label1 = new Label();
            fieldToAirplaneType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)fieldCountOfFlights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldCountOfRepairs).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(84, 414);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // fieldCountOfFlights
            // 
            fieldCountOfFlights.Location = new Point(12, 366);
            fieldCountOfFlights.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            fieldCountOfFlights.Name = "fieldCountOfFlights";
            fieldCountOfFlights.Size = new Size(250, 27);
            fieldCountOfFlights.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 343);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 42;
            label6.Text = "CountOfFlights";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 288);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 41;
            label7.Text = "ReceiptDate";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fieldReceiptDate
            // 
            fieldReceiptDate.Location = new Point(12, 311);
            fieldReceiptDate.Name = "fieldReceiptDate";
            fieldReceiptDate.Size = new Size(250, 27);
            fieldReceiptDate.TabIndex = 40;
            // 
            // fieldAge
            // 
            fieldAge.Location = new Point(12, 255);
            fieldAge.Name = "fieldAge";
            fieldAge.Size = new Size(250, 27);
            fieldAge.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 232);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 38;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 177);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 37;
            label4.Text = "TechnicalInspectation";
            // 
            // fieldTechnicalInspectation
            // 
            fieldTechnicalInspectation.Location = new Point(12, 200);
            fieldTechnicalInspectation.Name = "fieldTechnicalInspectation";
            fieldTechnicalInspectation.Size = new Size(250, 27);
            fieldTechnicalInspectation.TabIndex = 36;
            // 
            // fieldCountOfRepairs
            // 
            fieldCountOfRepairs.Location = new Point(12, 145);
            fieldCountOfRepairs.Name = "fieldCountOfRepairs";
            fieldCountOfRepairs.Size = new Size(250, 27);
            fieldCountOfRepairs.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 122);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 34;
            label3.Text = "CountOfRepairs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 65);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 33;
            label2.Text = "LastRepair";
            // 
            // fieldLastRepair
            // 
            fieldLastRepair.Location = new Point(12, 88);
            fieldLastRepair.Name = "fieldLastRepair";
            fieldLastRepair.Size = new Size(250, 27);
            fieldLastRepair.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 7);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 31;
            label1.Text = "ToAirplaneType";
            // 
            // fieldToAirplaneType
            // 
            fieldToAirplaneType.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldToAirplaneType.FormattingEnabled = true;
            fieldToAirplaneType.Location = new Point(12, 30);
            fieldToAirplaneType.Name = "fieldToAirplaneType";
            fieldToAirplaneType.Size = new Size(250, 28);
            fieldToAirplaneType.TabIndex = 30;
            // 
            // AddAirplane_fixed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 450);
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
            Name = "AddAirplane_fixed";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddAirplane_fixed";
            ((System.ComponentModel.ISupportInitialize)fieldCountOfFlights).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldCountOfRepairs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private NumericUpDown fieldCountOfFlights;
        private Label label6;
        private Label label7;
        private DateTimePicker fieldReceiptDate;
        private NumericUpDown fieldAge;
        private Label label5;
        private Label label4;
        private DateTimePicker fieldTechnicalInspectation;
        private NumericUpDown fieldCountOfRepairs;
        private Label label3;
        private Label label2;
        private DateTimePicker fieldLastRepair;
        private Label label1;
        private ComboBox fieldToAirplaneType;
    }
}
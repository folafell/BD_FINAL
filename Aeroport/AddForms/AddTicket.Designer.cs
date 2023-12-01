namespace Aeroport
{
    partial class AddTicket
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
            fieldTicketPassengerId = new ComboBox();
            label2 = new Label();
            fieldTicketFlightId = new ComboBox();
            label3 = new Label();
            fieldPriceOf = new NumericUpDown();
            label4 = new Label();
            fieldDateOf = new DateTimePicker();
            label5 = new Label();
            fieldSeatLetter = new ComboBox();
            fieldSeatNumber = new NumericUpDown();
            label6 = new Label();
            fieldStatus = new ComboBox();
            label7 = new Label();
            btnAdd = new Button();
            fieldHours = new NumericUpDown();
            fieldMinutes = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)fieldPriceOf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldSeatNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldMinutes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 23);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "TicketPassengerId";
            // 
            // fieldTicketPassengerId
            // 
            fieldTicketPassengerId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldTicketPassengerId.FormattingEnabled = true;
            fieldTicketPassengerId.Location = new Point(12, 46);
            fieldTicketPassengerId.Name = "fieldTicketPassengerId";
            fieldTicketPassengerId.Size = new Size(276, 28);
            fieldTicketPassengerId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 85);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "TicketFlightId";
            // 
            // fieldTicketFlightId
            // 
            fieldTicketFlightId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldTicketFlightId.FormattingEnabled = true;
            fieldTicketFlightId.Location = new Point(12, 108);
            fieldTicketFlightId.Name = "fieldTicketFlightId";
            fieldTicketFlightId.Size = new Size(276, 28);
            fieldTicketFlightId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 148);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "PriceOf";
            // 
            // fieldPriceOf
            // 
            fieldPriceOf.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            fieldPriceOf.Location = new Point(12, 171);
            fieldPriceOf.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            fieldPriceOf.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            fieldPriceOf.Name = "fieldPriceOf";
            fieldPriceOf.Size = new Size(276, 27);
            fieldPriceOf.TabIndex = 5;
            fieldPriceOf.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 208);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "DateOf";
            // 
            // fieldDateOf
            // 
            fieldDateOf.Location = new Point(12, 230);
            fieldDateOf.Name = "fieldDateOf";
            fieldDateOf.Size = new Size(275, 27);
            fieldDateOf.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 268);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 8;
            label5.Text = "Seat";
            // 
            // fieldSeatLetter
            // 
            fieldSeatLetter.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldSeatLetter.FormattingEnabled = true;
            fieldSeatLetter.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            fieldSeatLetter.Location = new Point(12, 290);
            fieldSeatLetter.Name = "fieldSeatLetter";
            fieldSeatLetter.Size = new Size(131, 28);
            fieldSeatLetter.TabIndex = 9;
            // 
            // fieldSeatNumber
            // 
            fieldSeatNumber.Location = new Point(149, 290);
            fieldSeatNumber.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            fieldSeatNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            fieldSeatNumber.Name = "fieldSeatNumber";
            fieldSeatNumber.Size = new Size(139, 27);
            fieldSeatNumber.TabIndex = 10;
            fieldSeatNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 330);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 11;
            label6.Text = "Status";
            // 
            // fieldStatus
            // 
            fieldStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldStatus.FormattingEnabled = true;
            fieldStatus.Items.AddRange(new object[] { "Доступен", "Отменен", "Продан" });
            fieldStatus.Location = new Point(12, 352);
            fieldStatus.Name = "fieldStatus";
            fieldStatus.Size = new Size(276, 28);
            fieldStatus.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(114, 394);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 13;
            label7.Text = "TimeOf";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(97, 463);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // fieldHours
            // 
            fieldHours.Location = new Point(16, 417);
            fieldHours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            fieldHours.Name = "fieldHours";
            fieldHours.Size = new Size(127, 27);
            fieldHours.TabIndex = 16;
            fieldHours.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // fieldMinutes
            // 
            fieldMinutes.Location = new Point(149, 417);
            fieldMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            fieldMinutes.Name = "fieldMinutes";
            fieldMinutes.Size = new Size(139, 27);
            fieldMinutes.TabIndex = 17;
            fieldMinutes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 508);
            Controls.Add(fieldMinutes);
            Controls.Add(fieldHours);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(fieldStatus);
            Controls.Add(label6);
            Controls.Add(fieldSeatNumber);
            Controls.Add(fieldSeatLetter);
            Controls.Add(label5);
            Controls.Add(fieldDateOf);
            Controls.Add(label4);
            Controls.Add(fieldPriceOf);
            Controls.Add(label3);
            Controls.Add(fieldTicketFlightId);
            Controls.Add(label2);
            Controls.Add(fieldTicketPassengerId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTicket";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddTicket";
            ((System.ComponentModel.ISupportInitialize)fieldPriceOf).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldSeatNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldMinutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fieldTicketPassengerId;
        private Label label2;
        private ComboBox fieldTicketFlightId;
        private Label label3;
        private NumericUpDown fieldPriceOf;
        private Label label4;
        private DateTimePicker fieldDateOf;
        private Label label5;
        private ComboBox fieldSeatLetter;
        private NumericUpDown fieldSeatNumber;
        private Label label6;
        private ComboBox fieldStatus;
        private Label label7;
        private Button btnAdd;
        private NumericUpDown fieldHours;
        private NumericUpDown fieldMinutes;
    }
}
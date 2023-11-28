namespace Aeroport
{
    partial class AddCancelledFlight
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
            fieldReason = new ComboBox();
            label1 = new Label();
            fieldFlightID = new ComboBox();
            label2 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // fieldReason
            // 
            fieldReason.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldReason.FormattingEnabled = true;
            fieldReason.Items.AddRange(new object[] { "Технические неполадки ", "Погодные условия", "Продано недостаточное количество билетов" });
            fieldReason.Location = new Point(12, 120);
            fieldReason.Name = "fieldReason";
            fieldReason.Size = new Size(214, 28);
            fieldReason.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 100);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Reason";
            // 
            // fieldFlightID
            // 
            fieldFlightID.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldFlightID.FormattingEnabled = true;
            fieldFlightID.Location = new Point(12, 69);
            fieldFlightID.Name = "fieldFlightID";
            fieldFlightID.Size = new Size(214, 28);
            fieldFlightID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 46);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Flight";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(71, 172);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddCancelledFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 213);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(fieldFlightID);
            Controls.Add(label1);
            Controls.Add(fieldReason);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCancelledFlight";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCancelledFlight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox fieldReason;
        private Label label1;
        private ComboBox fieldFlightID;
        private Label label2;
        private Button btnAdd;
    }
}
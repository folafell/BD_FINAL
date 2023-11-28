namespace Aeroport
{
    partial class AddBrigade
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
            fieldBrigadeAirplane = new ComboBox();
            fieldBrigadeBoss = new ComboBox();
            label2 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "BrigadeAirplane";
            // 
            // fieldBrigadeAirplane
            // 
            fieldBrigadeAirplane.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldBrigadeAirplane.FormattingEnabled = true;
            fieldBrigadeAirplane.Location = new Point(12, 55);
            fieldBrigadeAirplane.Name = "fieldBrigadeAirplane";
            fieldBrigadeAirplane.Size = new Size(197, 28);
            fieldBrigadeAirplane.TabIndex = 1;
            // 
            // fieldBrigadeBoss
            // 
            fieldBrigadeBoss.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldBrigadeBoss.FormattingEnabled = true;
            fieldBrigadeBoss.Location = new Point(12, 112);
            fieldBrigadeBoss.Name = "fieldBrigadeBoss";
            fieldBrigadeBoss.Size = new Size(197, 28);
            fieldBrigadeBoss.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 89);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "BrigadeBoss";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(62, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddBrigade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 198);
            Controls.Add(btnAdd);
            Controls.Add(fieldBrigadeBoss);
            Controls.Add(label2);
            Controls.Add(fieldBrigadeAirplane);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddBrigade";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddBrigade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fieldBrigadeAirplane;
        private ComboBox fieldBrigadeBoss;
        private Label label2;
        private Button btnAdd;
    }
}
namespace Aeroport.EditForms
{
    partial class EditBrigade
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
            fieldBrigadeBoss = new ComboBox();
            label2 = new Label();
            fieldBrigadeAirplane = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(62, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // fieldBrigadeBoss
            // 
            fieldBrigadeBoss.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldBrigadeBoss.FormattingEnabled = true;
            fieldBrigadeBoss.Location = new Point(12, 96);
            fieldBrigadeBoss.Name = "fieldBrigadeBoss";
            fieldBrigadeBoss.Size = new Size(197, 28);
            fieldBrigadeBoss.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 73);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 7;
            label2.Text = "BrigadeBoss";
            // 
            // fieldBrigadeAirplane
            // 
            fieldBrigadeAirplane.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldBrigadeAirplane.FormattingEnabled = true;
            fieldBrigadeAirplane.Location = new Point(12, 39);
            fieldBrigadeAirplane.Name = "fieldBrigadeAirplane";
            fieldBrigadeAirplane.Size = new Size(197, 28);
            fieldBrigadeAirplane.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 16);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 5;
            label1.Text = "BrigadeAirplane";
            // 
            // EditBrigade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 174);
            Controls.Add(btnAdd);
            Controls.Add(fieldBrigadeBoss);
            Controls.Add(label2);
            Controls.Add(fieldBrigadeAirplane);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditBrigade";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditBrigade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ComboBox fieldBrigadeBoss;
        private Label label2;
        private ComboBox fieldBrigadeAirplane;
        private Label label1;
    }
}
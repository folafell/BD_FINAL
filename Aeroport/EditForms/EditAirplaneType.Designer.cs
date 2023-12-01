namespace Aeroport.EditForms
{
    partial class EditAirplaneType
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
            fieldAirplaneTypeName = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // fieldAirplaneTypeName
            // 
            fieldAirplaneTypeName.Location = new Point(12, 38);
            fieldAirplaneTypeName.Name = "fieldAirplaneTypeName";
            fieldAirplaneTypeName.Size = new Size(212, 27);
            fieldAirplaneTypeName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 15);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 4;
            label1.Text = "AirplaneTypeName";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(72, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // EditAirplaneType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 129);
            Controls.Add(fieldAirplaneTypeName);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditAirplaneType";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditAirplaneType";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fieldAirplaneTypeName;
        private Label label1;
        private Button btnAdd;
    }
}
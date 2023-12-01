namespace Aeroport.EditForms
{
    partial class EditStewardess
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
            checkBoxJapanese = new CheckBox();
            checkBoxChinese = new CheckBox();
            checkBoxSpanish = new CheckBox();
            checkBoxFrench = new CheckBox();
            checkBoxGerman = new CheckBox();
            checkBoxEnglish = new CheckBox();
            label2 = new Label();
            fieldStewardessEmployeeId = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(81, 288);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // checkBoxJapanese
            // 
            checkBoxJapanese.AutoSize = true;
            checkBoxJapanese.Location = new Point(12, 250);
            checkBoxJapanese.Name = "checkBoxJapanese";
            checkBoxJapanese.Size = new Size(99, 24);
            checkBoxJapanese.TabIndex = 18;
            checkBoxJapanese.Text = "Японский";
            checkBoxJapanese.UseVisualStyleBackColor = true;
            // 
            // checkBoxChinese
            // 
            checkBoxChinese.AutoSize = true;
            checkBoxChinese.Location = new Point(12, 220);
            checkBoxChinese.Name = "checkBoxChinese";
            checkBoxChinese.Size = new Size(104, 24);
            checkBoxChinese.TabIndex = 17;
            checkBoxChinese.Text = "Китайский";
            checkBoxChinese.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpanish
            // 
            checkBoxSpanish.AutoSize = true;
            checkBoxSpanish.Location = new Point(12, 190);
            checkBoxSpanish.Name = "checkBoxSpanish";
            checkBoxSpanish.Size = new Size(107, 24);
            checkBoxSpanish.TabIndex = 16;
            checkBoxSpanish.Text = "Испанский";
            checkBoxSpanish.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrench
            // 
            checkBoxFrench.AutoSize = true;
            checkBoxFrench.Location = new Point(12, 160);
            checkBoxFrench.Name = "checkBoxFrench";
            checkBoxFrench.Size = new Size(123, 24);
            checkBoxFrench.TabIndex = 15;
            checkBoxFrench.Text = "Французский";
            checkBoxFrench.UseVisualStyleBackColor = true;
            // 
            // checkBoxGerman
            // 
            checkBoxGerman.AutoSize = true;
            checkBoxGerman.Location = new Point(12, 130);
            checkBoxGerman.Name = "checkBoxGerman";
            checkBoxGerman.Size = new Size(103, 24);
            checkBoxGerman.TabIndex = 14;
            checkBoxGerman.Text = "Немецкий";
            checkBoxGerman.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnglish
            // 
            checkBoxEnglish.AutoSize = true;
            checkBoxEnglish.Location = new Point(12, 100);
            checkBoxEnglish.Name = "checkBoxEnglish";
            checkBoxEnglish.Size = new Size(114, 24);
            checkBoxEnglish.TabIndex = 13;
            checkBoxEnglish.Text = "Английский";
            checkBoxEnglish.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 78);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 12;
            label2.Text = "ForeignLanguage";
            // 
            // fieldStewardessEmployeeId
            // 
            fieldStewardessEmployeeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldStewardessEmployeeId.FormattingEnabled = true;
            fieldStewardessEmployeeId.Location = new Point(12, 36);
            fieldStewardessEmployeeId.Name = "fieldStewardessEmployeeId";
            fieldStewardessEmployeeId.Size = new Size(248, 28);
            fieldStewardessEmployeeId.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 15);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 10;
            label1.Text = "StewardessEmployeeId";
            // 
            // EditStewardess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 329);
            Controls.Add(btnAdd);
            Controls.Add(checkBoxJapanese);
            Controls.Add(checkBoxChinese);
            Controls.Add(checkBoxSpanish);
            Controls.Add(checkBoxFrench);
            Controls.Add(checkBoxGerman);
            Controls.Add(checkBoxEnglish);
            Controls.Add(label2);
            Controls.Add(fieldStewardessEmployeeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditStewardess";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditStewardess";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private CheckBox checkBoxJapanese;
        private CheckBox checkBoxChinese;
        private CheckBox checkBoxSpanish;
        private CheckBox checkBoxFrench;
        private CheckBox checkBoxGerman;
        private CheckBox checkBoxEnglish;
        private Label label2;
        private ComboBox fieldStewardessEmployeeId;
        private Label label1;
    }
}
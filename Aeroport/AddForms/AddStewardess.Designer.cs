namespace Aeroport
{
    partial class AddStewardess
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
            fieldStewardessEmployeeId = new ComboBox();
            label2 = new Label();
            checkBoxEnglish = new CheckBox();
            checkBoxGerman = new CheckBox();
            checkBoxFrench = new CheckBox();
            checkBoxSpanish = new CheckBox();
            checkBoxChinese = new CheckBox();
            checkBoxJapanese = new CheckBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 22);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "StewardessEmployeeId";
            // 
            // fieldStewardessEmployeeId
            // 
            fieldStewardessEmployeeId.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldStewardessEmployeeId.FormattingEnabled = true;
            fieldStewardessEmployeeId.Location = new Point(12, 43);
            fieldStewardessEmployeeId.Name = "fieldStewardessEmployeeId";
            fieldStewardessEmployeeId.Size = new Size(248, 28);
            fieldStewardessEmployeeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 85);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "ForeignLanguage";
            // 
            // checkBoxEnglish
            // 
            checkBoxEnglish.AutoSize = true;
            checkBoxEnglish.Location = new Point(12, 107);
            checkBoxEnglish.Name = "checkBoxEnglish";
            checkBoxEnglish.Size = new Size(114, 24);
            checkBoxEnglish.TabIndex = 3;
            checkBoxEnglish.Text = "Английский";
            checkBoxEnglish.UseVisualStyleBackColor = true;
            // 
            // checkBoxGerman
            // 
            checkBoxGerman.AutoSize = true;
            checkBoxGerman.Location = new Point(12, 137);
            checkBoxGerman.Name = "checkBoxGerman";
            checkBoxGerman.Size = new Size(103, 24);
            checkBoxGerman.TabIndex = 4;
            checkBoxGerman.Text = "Немецкий";
            checkBoxGerman.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrench
            // 
            checkBoxFrench.AutoSize = true;
            checkBoxFrench.Location = new Point(12, 167);
            checkBoxFrench.Name = "checkBoxFrench";
            checkBoxFrench.Size = new Size(123, 24);
            checkBoxFrench.TabIndex = 5;
            checkBoxFrench.Text = "Французский";
            checkBoxFrench.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpanish
            // 
            checkBoxSpanish.AutoSize = true;
            checkBoxSpanish.Location = new Point(12, 197);
            checkBoxSpanish.Name = "checkBoxSpanish";
            checkBoxSpanish.Size = new Size(107, 24);
            checkBoxSpanish.TabIndex = 6;
            checkBoxSpanish.Text = "Испанский";
            checkBoxSpanish.UseVisualStyleBackColor = true;
            // 
            // checkBoxChinese
            // 
            checkBoxChinese.AutoSize = true;
            checkBoxChinese.Location = new Point(12, 227);
            checkBoxChinese.Name = "checkBoxChinese";
            checkBoxChinese.Size = new Size(104, 24);
            checkBoxChinese.TabIndex = 7;
            checkBoxChinese.Text = "Китайский";
            checkBoxChinese.UseVisualStyleBackColor = true;
            // 
            // checkBoxJapanese
            // 
            checkBoxJapanese.AutoSize = true;
            checkBoxJapanese.Location = new Point(12, 257);
            checkBoxJapanese.Name = "checkBoxJapanese";
            checkBoxJapanese.Size = new Size(99, 24);
            checkBoxJapanese.TabIndex = 8;
            checkBoxJapanese.Text = "Японский";
            checkBoxJapanese.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(81, 295);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddStewardess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 336);
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
            Name = "AddStewardess";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddStewardess";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fieldStewardessEmployeeId;
        private Label label2;
        private CheckBox checkBoxEnglish;
        private CheckBox checkBoxGerman;
        private CheckBox checkBoxFrench;
        private CheckBox checkBoxSpanish;
        private CheckBox checkBoxChinese;
        private CheckBox checkBoxJapanese;
        private Button btnAdd;
    }
}
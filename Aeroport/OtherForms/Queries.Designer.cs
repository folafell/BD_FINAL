namespace Aeroport.OtherForms
{
    partial class Queries
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            comboBoxQueries = new ComboBox();
            btnExecute = new Button();
            txtQueryDescription = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxQueries
            // 
            comboBoxQueries.Dock = DockStyle.Fill;
            comboBoxQueries.FormattingEnabled = true;
            comboBoxQueries.Location = new Point(3, 3);
            comboBoxQueries.Name = "comboBoxQueries";
            comboBoxQueries.Size = new Size(211, 28);
            comboBoxQueries.TabIndex = 0;
            comboBoxQueries.SelectedIndexChanged += ComboBoxQueries_SelectedIndexChanged;
            // 
            // btnExecute
            // 
            btnExecute.BackColor = Color.DarkSeaGreen;
            btnExecute.Dock = DockStyle.Fill;
            btnExecute.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnExecute.Location = new Point(220, 3);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(889, 31);
            btnExecute.TabIndex = 2;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            // 
            // txtQueryDescription
            // 
            txtQueryDescription.BackColor = Color.DarkSeaGreen;
            txtQueryDescription.Dock = DockStyle.Fill;
            txtQueryDescription.Location = new Point(3, 40);
            txtQueryDescription.Multiline = true;
            txtQueryDescription.Name = "txtQueryDescription";
            txtQueryDescription.ReadOnly = true;
            txtQueryDescription.Size = new Size(211, 566);
            txtQueryDescription.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.514389F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.48561F));
            tableLayoutPanel1.Controls.Add(txtQueryDescription, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBoxQueries, 0, 0);
            tableLayoutPanel1.Controls.Add(btnExecute, 1, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.075534F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.92447F));
            tableLayoutPanel1.Size = new Size(1112, 609);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(220, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(889, 566);
            dataGridView1.TabIndex = 4;
            // 
            // Queries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 609);
            Controls.Add(tableLayoutPanel1);
            Name = "Queries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Queries";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxQueries;
        private Button btnExecute;
        private TextBox txtQueryDescription;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
    }
}
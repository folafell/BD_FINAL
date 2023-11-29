namespace Aeroport
{
    partial class Aeroport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            linkAirplaneTypes = new LinkLabel();
            btnAdd = new Button();
            comboBox = new ComboBox();
            linkTickets = new LinkLabel();
            linkTechnicians = new LinkLabel();
            linkStewardesses = new LinkLabel();
            linkSecurities = new LinkLabel();
            linkPilots = new LinkLabel();
            linkPassengers = new LinkLabel();
            linkFlights = new LinkLabel();
            linkEmployees = new LinkLabel();
            linkDispatchers = new LinkLabel();
            linkCashiers = new LinkLabel();
            linkCancelledFlights = new LinkLabel();
            linkBrigades = new LinkLabel();
            linkBosses = new LinkLabel();
            linkAirplanes = new LinkLabel();
            linkAdministrators = new LinkLabel();
            labelTableName = new Label();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            fieldSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(190, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1026, 482);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.3404427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.65955F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(labelTableName, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.37729F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.62271F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1219, 584);
            tableLayoutPanel1.TabIndex = 23;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(linkAirplaneTypes);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(comboBox);
            groupBox1.Controls.Add(linkTickets);
            groupBox1.Controls.Add(linkTechnicians);
            groupBox1.Controls.Add(linkStewardesses);
            groupBox1.Controls.Add(linkSecurities);
            groupBox1.Controls.Add(linkPilots);
            groupBox1.Controls.Add(linkPassengers);
            groupBox1.Controls.Add(linkFlights);
            groupBox1.Controls.Add(linkEmployees);
            groupBox1.Controls.Add(linkDispatchers);
            groupBox1.Controls.Add(linkCashiers);
            groupBox1.Controls.Add(linkCancelledFlights);
            groupBox1.Controls.Add(linkBrigades);
            groupBox1.Controls.Add(linkBosses);
            groupBox1.Controls.Add(linkAirplanes);
            groupBox1.Controls.Add(linkAdministrators);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 482);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 192);
            btnDelete.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(6, 441);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 39);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete a note";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // linkAirplaneTypes
            // 
            linkAirplaneTypes.AutoSize = true;
            linkAirplaneTypes.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkAirplaneTypes.LinkColor = Color.FromArgb(192, 0, 192);
            linkAirplaneTypes.Location = new Point(6, 47);
            linkAirplaneTypes.Name = "linkAirplaneTypes";
            linkAirplaneTypes.Size = new Size(136, 20);
            linkAirplaneTypes.TabIndex = 17;
            linkAirplaneTypes.TabStop = true;
            linkAirplaneTypes.Text = "AirplaneTypes";
            linkAirplaneTypes.Click += link_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 0, 192);
            btnAdd.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(6, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 39);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add a note";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += addButton_Click;
            // 
            // comboBox
            // 
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Administrators", "Airplanes", "AirplaneTypes", "Bosses", "Brigades", "CancelledFlights", "Cashiers", "Dispatchers", "Employees", "Flights", "Passengers", "Pilots", "Securities", "Stewardesses", "Technicians", "Tickets" });
            comboBox.Location = new Point(6, 364);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(175, 28);
            comboBox.TabIndex = 2;
            // 
            // linkTickets
            // 
            linkTickets.AutoSize = true;
            linkTickets.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkTickets.LinkColor = Color.FromArgb(192, 0, 192);
            linkTickets.Location = new Point(6, 307);
            linkTickets.Name = "linkTickets";
            linkTickets.Size = new Size(73, 20);
            linkTickets.TabIndex = 15;
            linkTickets.TabStop = true;
            linkTickets.Text = "Tickets";
            linkTickets.Click += link_Click;
            // 
            // linkTechnicians
            // 
            linkTechnicians.AutoSize = true;
            linkTechnicians.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkTechnicians.LinkColor = Color.FromArgb(192, 0, 192);
            linkTechnicians.Location = new Point(6, 287);
            linkTechnicians.Name = "linkTechnicians";
            linkTechnicians.Size = new Size(112, 20);
            linkTechnicians.TabIndex = 14;
            linkTechnicians.TabStop = true;
            linkTechnicians.Text = "Technicians";
            linkTechnicians.Click += link_Click;
            // 
            // linkStewardesses
            // 
            linkStewardesses.AutoSize = true;
            linkStewardesses.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkStewardesses.LinkColor = Color.FromArgb(192, 0, 192);
            linkStewardesses.Location = new Point(6, 267);
            linkStewardesses.Name = "linkStewardesses";
            linkStewardesses.Size = new Size(126, 20);
            linkStewardesses.TabIndex = 13;
            linkStewardesses.TabStop = true;
            linkStewardesses.Text = "Stewardesses";
            linkStewardesses.Click += link_Click;
            // 
            // linkSecurities
            // 
            linkSecurities.AutoSize = true;
            linkSecurities.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkSecurities.LinkColor = Color.FromArgb(192, 0, 192);
            linkSecurities.Location = new Point(6, 247);
            linkSecurities.Name = "linkSecurities";
            linkSecurities.Size = new Size(96, 20);
            linkSecurities.TabIndex = 12;
            linkSecurities.TabStop = true;
            linkSecurities.Text = "Securities";
            linkSecurities.Click += link_Click;
            // 
            // linkPilots
            // 
            linkPilots.AutoSize = true;
            linkPilots.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkPilots.LinkColor = Color.FromArgb(192, 0, 192);
            linkPilots.Location = new Point(6, 228);
            linkPilots.Name = "linkPilots";
            linkPilots.Size = new Size(59, 20);
            linkPilots.TabIndex = 10;
            linkPilots.TabStop = true;
            linkPilots.Text = "Pilots";
            linkPilots.Click += link_Click;
            // 
            // linkPassengers
            // 
            linkPassengers.AutoSize = true;
            linkPassengers.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkPassengers.LinkColor = Color.FromArgb(192, 0, 192);
            linkPassengers.Location = new Point(6, 208);
            linkPassengers.Name = "linkPassengers";
            linkPassengers.Size = new Size(103, 20);
            linkPassengers.TabIndex = 9;
            linkPassengers.TabStop = true;
            linkPassengers.Text = "Passengers";
            linkPassengers.Click += link_Click;
            // 
            // linkFlights
            // 
            linkFlights.AutoSize = true;
            linkFlights.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkFlights.LinkColor = Color.FromArgb(192, 0, 192);
            linkFlights.Location = new Point(6, 188);
            linkFlights.Name = "linkFlights";
            linkFlights.Size = new Size(70, 20);
            linkFlights.TabIndex = 8;
            linkFlights.TabStop = true;
            linkFlights.Text = "Flights";
            linkFlights.Click += link_Click;
            // 
            // linkEmployees
            // 
            linkEmployees.AutoSize = true;
            linkEmployees.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkEmployees.LinkColor = Color.FromArgb(192, 0, 192);
            linkEmployees.Location = new Point(6, 168);
            linkEmployees.Name = "linkEmployees";
            linkEmployees.Size = new Size(101, 20);
            linkEmployees.TabIndex = 7;
            linkEmployees.TabStop = true;
            linkEmployees.Text = "Employees";
            linkEmployees.Click += link_Click;
            // 
            // linkDispatchers
            // 
            linkDispatchers.AutoSize = true;
            linkDispatchers.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkDispatchers.LinkColor = Color.FromArgb(192, 0, 192);
            linkDispatchers.Location = new Point(6, 148);
            linkDispatchers.Name = "linkDispatchers";
            linkDispatchers.Size = new Size(113, 20);
            linkDispatchers.TabIndex = 6;
            linkDispatchers.TabStop = true;
            linkDispatchers.Text = "Dispatchers";
            linkDispatchers.Click += link_Click;
            // 
            // linkCashiers
            // 
            linkCashiers.AutoSize = true;
            linkCashiers.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkCashiers.LinkColor = Color.FromArgb(192, 0, 192);
            linkCashiers.Location = new Point(6, 128);
            linkCashiers.Name = "linkCashiers";
            linkCashiers.Size = new Size(83, 20);
            linkCashiers.TabIndex = 5;
            linkCashiers.TabStop = true;
            linkCashiers.Text = "Cashiers";
            linkCashiers.Click += link_Click;
            // 
            // linkCancelledFlights
            // 
            linkCancelledFlights.AutoSize = true;
            linkCancelledFlights.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkCancelledFlights.LinkColor = Color.FromArgb(192, 0, 192);
            linkCancelledFlights.Location = new Point(6, 108);
            linkCancelledFlights.Name = "linkCancelledFlights";
            linkCancelledFlights.Size = new Size(153, 20);
            linkCancelledFlights.TabIndex = 4;
            linkCancelledFlights.TabStop = true;
            linkCancelledFlights.Text = "CancelledFlights";
            linkCancelledFlights.Click += link_Click;
            // 
            // linkBrigades
            // 
            linkBrigades.AutoSize = true;
            linkBrigades.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkBrigades.LinkColor = Color.FromArgb(192, 0, 192);
            linkBrigades.Location = new Point(6, 88);
            linkBrigades.Name = "linkBrigades";
            linkBrigades.Size = new Size(84, 20);
            linkBrigades.TabIndex = 3;
            linkBrigades.TabStop = true;
            linkBrigades.Text = "Brigades";
            linkBrigades.Click += link_Click;
            // 
            // linkBosses
            // 
            linkBosses.AutoSize = true;
            linkBosses.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkBosses.LinkColor = Color.FromArgb(192, 0, 192);
            linkBosses.Location = new Point(6, 68);
            linkBosses.Name = "linkBosses";
            linkBosses.Size = new Size(64, 20);
            linkBosses.TabIndex = 2;
            linkBosses.TabStop = true;
            linkBosses.Text = "Bosses";
            linkBosses.Click += link_Click;
            // 
            // linkAirplanes
            // 
            linkAirplanes.AutoSize = true;
            linkAirplanes.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkAirplanes.LinkColor = Color.FromArgb(192, 0, 192);
            linkAirplanes.Location = new Point(6, 27);
            linkAirplanes.Name = "linkAirplanes";
            linkAirplanes.Size = new Size(93, 20);
            linkAirplanes.TabIndex = 1;
            linkAirplanes.TabStop = true;
            linkAirplanes.Text = "Airplanes";
            linkAirplanes.Click += link_Click;
            // 
            // linkAdministrators
            // 
            linkAdministrators.AutoSize = true;
            linkAdministrators.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkAdministrators.LinkColor = Color.FromArgb(192, 0, 192);
            linkAdministrators.Location = new Point(6, 6);
            linkAdministrators.Name = "linkAdministrators";
            linkAdministrators.Size = new Size(143, 20);
            linkAdministrators.TabIndex = 0;
            linkAdministrators.TabStop = true;
            linkAdministrators.Text = "Administrators";
            linkAdministrators.Click += link_Click;
            // 
            // labelTableName
            // 
            labelTableName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTableName.AutoSize = true;
            labelTableName.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTableName.ForeColor = Color.FromArgb(192, 0, 192);
            labelTableName.Location = new Point(190, 0);
            labelTableName.Name = "labelTableName";
            labelTableName.Size = new Size(1026, 38);
            labelTableName.TabIndex = 2;
            labelTableName.Text = "label1";
            labelTableName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(fieldSearch);
            groupBox2.Location = new Point(190, 529);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 52);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 192);
            btnSearch.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(232, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 37);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // fieldSearch
            // 
            fieldSearch.Location = new Point(6, 16);
            fieldSearch.Name = "fieldSearch";
            fieldSearch.Size = new Size(220, 27);
            fieldSearch.TabIndex = 0;
            // 
            // Aeroport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1219, 584);
            Controls.Add(tableLayoutPanel1);
            Name = "Aeroport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aeroport";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private LinkLabel linkTickets;
        private LinkLabel linkTechnicians;
        private LinkLabel linkStewardesses;
        private LinkLabel linkSecurities;
        private LinkLabel linkPilots;
        private LinkLabel linkPassengers;
        private LinkLabel linkFlights;
        private LinkLabel linkEmployees;
        private LinkLabel linkDispatchers;
        private LinkLabel linkCashiers;
        private LinkLabel linkCancelledFlights;
        private LinkLabel linkBrigades;
        private LinkLabel linkBosses;
        private LinkLabel linkAirplanes;
        private LinkLabel linkAdministrators;
        private ComboBox comboBox;
        private Button btnAdd;
        private LinkLabel linkAirplaneTypes;
        private Button btnDelete;
        private Label labelTableName;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox fieldSearch;
    }
}
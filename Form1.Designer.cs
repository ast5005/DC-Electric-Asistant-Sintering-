namespace dcascontroller
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInit = new System.Windows.Forms.TabPage();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.minimumCurrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumCurrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thermocoupleTypeSelector = new System.Windows.Forms.ComboBox();
            this.tempReaderChannel = new System.Windows.Forms.ComboBox();
            this.queryInstrumentStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.simulateSelector = new System.Windows.Forms.CheckBox();
            this.descriptor = new System.Windows.Forms.Label();
            this.psAddress = new System.Windows.Forms.ComboBox();
            this.tabMainCont = new System.Windows.Forms.TabPage();
            this.autoControlGroup = new System.Windows.Forms.GroupBox();
            this.treadButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.currentdown = new System.Windows.Forms.NumericUpDown();
            this.contcooling = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progInd = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Kdget = new System.Windows.Forms.NumericUpDown();
            this.Kiget = new System.Windows.Forms.NumericUpDown();
            this.Kpget = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resistanceIndicator = new System.Windows.Forms.Label();
            this.autovoltageindicator = new System.Windows.Forms.Label();
            this.autotimerindicator = new System.Windows.Forms.Label();
            this.autocurrentindicator = new System.Windows.Forms.Label();
            this.tempIndicator = new System.Windows.Forms.Label();
            this.resistanceIndicatorLabel = new System.Windows.Forms.Label();
            this.autocurrentindicatorLabel = new System.Windows.Forms.Label();
            this.autotimerindicatorLabel = new System.Windows.Forms.Label();
            this.autovoltageindicatorLabel = new System.Windows.Forms.Label();
            this.tempIndicatorLabel = new System.Windows.Forms.Label();
            this.autostopButton = new System.Windows.Forms.Button();
            this.autostartButton = new System.Windows.Forms.Button();
            this.autoControlSelector = new System.Windows.Forms.RadioButton();
            this.manualContselector = new System.Windows.Forms.RadioButton();
            this.manualcontrolGroup = new System.Windows.Forms.GroupBox();
            this.currentIndicator = new System.Windows.Forms.Label();
            this.voltageindicator = new System.Windows.Forms.Label();
            this.timerindicator = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeUpDown = new System.Windows.Forms.NumericUpDown();
            this.manStop = new System.Windows.Forms.Button();
            this.manStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.currentUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.voltageUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabControl.SuspendLayout();
            this.tabInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctDataBindingSource)).BeginInit();
            this.tabMainCont.SuspendLayout();
            this.autoControlGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kdget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kiget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kpget)).BeginInit();
            this.panel1.SuspendLayout();
            this.manualcontrolGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltageUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Initialize Instruments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInit);
            this.tabControl.Controls.Add(this.tabMainCont);
            this.tabControl.Location = new System.Drawing.Point(7, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(883, 490);
            this.tabControl.TabIndex = 1;
            // 
            // tabInit
            // 
            this.tabInit.Controls.Add(this.statusLabel);
            this.tabInit.Controls.Add(this.dataGridView1);
            this.tabInit.Controls.Add(this.label5);
            this.tabInit.Controls.Add(this.label4);
            this.tabInit.Controls.Add(this.thermocoupleTypeSelector);
            this.tabInit.Controls.Add(this.tempReaderChannel);
            this.tabInit.Controls.Add(this.queryInstrumentStatusCheckbox);
            this.tabInit.Controls.Add(this.simulateSelector);
            this.tabInit.Controls.Add(this.descriptor);
            this.tabInit.Controls.Add(this.psAddress);
            this.tabInit.Controls.Add(this.button1);
            this.tabInit.Location = new System.Drawing.Point(4, 22);
            this.tabInit.Name = "tabInit";
            this.tabInit.Padding = new System.Windows.Forms.Padding(3);
            this.tabInit.Size = new System.Drawing.Size(875, 464);
            this.tabInit.TabIndex = 0;
            this.tabInit.Text = "Initialization Tab";
            this.tabInit.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.statusLabel.Location = new System.Drawing.Point(312, 286);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(200, 15);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Power Supply was not intialized yet.";
            this.statusLabel.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.minimumCurrDataGridViewTextBoxColumn,
            this.maximumCurrDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ctDataBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(315, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 232);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // minimumCurrDataGridViewTextBoxColumn
            // 
            this.minimumCurrDataGridViewTextBoxColumn.DataPropertyName = "minimumCurr";
            this.minimumCurrDataGridViewTextBoxColumn.HeaderText = "Minimum Current (A)";
            this.minimumCurrDataGridViewTextBoxColumn.Name = "minimumCurrDataGridViewTextBoxColumn";
            // 
            // maximumCurrDataGridViewTextBoxColumn
            // 
            this.maximumCurrDataGridViewTextBoxColumn.DataPropertyName = "maximumCurr";
            this.maximumCurrDataGridViewTextBoxColumn.HeaderText = "Maximum Current (A)";
            this.maximumCurrDataGridViewTextBoxColumn.Name = "maximumCurrDataGridViewTextBoxColumn";
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature (C)";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration (s)";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // ctDataBindingSource
            // 
            this.ctDataBindingSource.DataSource = typeof(dcascontroller.ctData);
            this.ctDataBindingSource.CurrentChanged += new System.EventHandler(this.ctDataBindingSource_CurrentChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thermocouple Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Channel List";
            // 
            // thermocoupleTypeSelector
            // 
            this.thermocoupleTypeSelector.FormattingEnabled = true;
            this.thermocoupleTypeSelector.Items.AddRange(new object[] {
            "T",
            "K",
            "B",
            "E",
            "J",
            "R",
            "S",
            "N"});
            this.thermocoupleTypeSelector.Location = new System.Drawing.Point(9, 141);
            this.thermocoupleTypeSelector.Name = "thermocoupleTypeSelector";
            this.thermocoupleTypeSelector.Size = new System.Drawing.Size(121, 21);
            this.thermocoupleTypeSelector.TabIndex = 6;
            // 
            // tempReaderChannel
            // 
            this.tempReaderChannel.FormattingEnabled = true;
            this.tempReaderChannel.Location = new System.Drawing.Point(9, 102);
            this.tempReaderChannel.Name = "tempReaderChannel";
            this.tempReaderChannel.Size = new System.Drawing.Size(121, 21);
            this.tempReaderChannel.TabIndex = 5;
            this.tempReaderChannel.SelectedIndexChanged += new System.EventHandler(this.tempReaderChannel_SelectedIndexChanged);
            // 
            // queryInstrumentStatusCheckbox
            // 
            this.queryInstrumentStatusCheckbox.AutoSize = true;
            this.queryInstrumentStatusCheckbox.Checked = true;
            this.queryInstrumentStatusCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.queryInstrumentStatusCheckbox.Location = new System.Drawing.Point(9, 69);
            this.queryInstrumentStatusCheckbox.Name = "queryInstrumentStatusCheckbox";
            this.queryInstrumentStatusCheckbox.Size = new System.Drawing.Size(139, 17);
            this.queryInstrumentStatusCheckbox.TabIndex = 4;
            this.queryInstrumentStatusCheckbox.Text = "Query Instrument Status";
            this.queryInstrumentStatusCheckbox.UseVisualStyleBackColor = true;
            this.queryInstrumentStatusCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // simulateSelector
            // 
            this.simulateSelector.AutoSize = true;
            this.simulateSelector.Location = new System.Drawing.Point(9, 40);
            this.simulateSelector.Name = "simulateSelector";
            this.simulateSelector.Size = new System.Drawing.Size(104, 17);
            this.simulateSelector.TabIndex = 3;
            this.simulateSelector.Text = "Simulation Mode";
            this.simulateSelector.UseVisualStyleBackColor = true;
            this.simulateSelector.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // descriptor
            // 
            this.descriptor.AutoSize = true;
            this.descriptor.Location = new System.Drawing.Point(136, 9);
            this.descriptor.Name = "descriptor";
            this.descriptor.Size = new System.Drawing.Size(113, 13);
            this.descriptor.TabIndex = 2;
            this.descriptor.Text = "Power Supply Address";
            this.descriptor.Click += new System.EventHandler(this.label1_Click);
            // 
            // psAddress
            // 
            this.psAddress.FormattingEnabled = true;
            this.psAddress.Items.AddRange(new object[] {
            "ASRL3::INSTR",
            "GPIB1::INSTR"});
            this.psAddress.Location = new System.Drawing.Point(9, 6);
            this.psAddress.Name = "psAddress";
            this.psAddress.Size = new System.Drawing.Size(121, 21);
            this.psAddress.TabIndex = 1;
            this.psAddress.SelectedIndexChanged += new System.EventHandler(this.psAddress_SelectedIndexChanged);
            // 
            // tabMainCont
            // 
            this.tabMainCont.Controls.Add(this.autoControlGroup);
            this.tabMainCont.Controls.Add(this.autoControlSelector);
            this.tabMainCont.Controls.Add(this.manualContselector);
            this.tabMainCont.Controls.Add(this.manualcontrolGroup);
            this.tabMainCont.Location = new System.Drawing.Point(4, 22);
            this.tabMainCont.Name = "tabMainCont";
            this.tabMainCont.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainCont.Size = new System.Drawing.Size(875, 464);
            this.tabMainCont.TabIndex = 1;
            this.tabMainCont.Text = "Main Control Tab";
            this.tabMainCont.UseVisualStyleBackColor = true;
            // 
            // autoControlGroup
            // 
            this.autoControlGroup.Controls.Add(this.treadButton);
            this.autoControlGroup.Controls.Add(this.label11);
            this.autoControlGroup.Controls.Add(this.label10);
            this.autoControlGroup.Controls.Add(this.label9);
            this.autoControlGroup.Controls.Add(this.currentdown);
            this.autoControlGroup.Controls.Add(this.contcooling);
            this.autoControlGroup.Controls.Add(this.button2);
            this.autoControlGroup.Controls.Add(this.progInd);
            this.autoControlGroup.Controls.Add(this.chart1);
            this.autoControlGroup.Controls.Add(this.label8);
            this.autoControlGroup.Controls.Add(this.label7);
            this.autoControlGroup.Controls.Add(this.Kdget);
            this.autoControlGroup.Controls.Add(this.Kiget);
            this.autoControlGroup.Controls.Add(this.Kpget);
            this.autoControlGroup.Controls.Add(this.label6);
            this.autoControlGroup.Controls.Add(this.panel1);
            this.autoControlGroup.Controls.Add(this.autostopButton);
            this.autoControlGroup.Controls.Add(this.autostartButton);
            this.autoControlGroup.Enabled = false;
            this.autoControlGroup.Location = new System.Drawing.Point(252, 33);
            this.autoControlGroup.Name = "autoControlGroup";
            this.autoControlGroup.Size = new System.Drawing.Size(608, 425);
            this.autoControlGroup.TabIndex = 3;
            this.autoControlGroup.TabStop = false;
            this.autoControlGroup.Text = "Automatic Control";
            // 
            // treadButton
            // 
            this.treadButton.Location = new System.Drawing.Point(512, 317);
            this.treadButton.Name = "treadButton";
            this.treadButton.Size = new System.Drawing.Size(67, 29);
            this.treadButton.TabIndex = 31;
            this.treadButton.Text = "T Read";
            this.treadButton.UseVisualStyleBackColor = true;
            this.treadButton.Click += new System.EventHandler(this.treadButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(240, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(321, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Currrent Decrease Rate";
            this.label9.Click += new System.EventHandler(this.label9_Click_2);
            // 
            // currentdown
            // 
            this.currentdown.Location = new System.Drawing.Point(128, 399);
            this.currentdown.Name = "currentdown";
            this.currentdown.Size = new System.Drawing.Size(42, 20);
            this.currentdown.TabIndex = 27;
            this.currentdown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.currentdown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // contcooling
            // 
            this.contcooling.AutoSize = true;
            this.contcooling.Checked = true;
            this.contcooling.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contcooling.Location = new System.Drawing.Point(14, 402);
            this.contcooling.Name = "contcooling";
            this.contcooling.Size = new System.Drawing.Size(111, 17);
            this.contcooling.TabIndex = 26;
            this.contcooling.Text = "Controlled Cooling";
            this.contcooling.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 28);
            this.button2.TabIndex = 25;
            this.button2.Text = "Full Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progInd
            // 
            this.progInd.AutoSize = true;
            this.progInd.Location = new System.Drawing.Point(16, 284);
            this.progInd.Name = "progInd";
            this.progInd.Size = new System.Drawing.Size(13, 13);
            this.progInd.TabIndex = 24;
            this.progInd.Text = "0";
            this.progInd.Click += new System.EventHandler(this.label9_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Time (s)";
            chartArea1.AxisY.Title = "Temperature (C)";
            chartArea1.AxisY2.Title = "Current (A) or Resistance (10 uohm)";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.LegendText = "Temperature";
            series1.Name = "tempSeries";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Goldenrod;
            series2.Legend = "Legend1";
            series2.LegendText = "Current";
            series2.Name = "currSeries";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "Set Point";
            series3.Name = "setpointSeries";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Green;
            series4.Legend = "Legend1";
            series4.LegendText = "Resistance";
            series4.Name = "resistanceSeries";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(552, 266);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "Program 1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ki";
            // 
            // Kdget
            // 
            this.Kdget.Location = new System.Drawing.Point(436, 352);
            this.Kdget.Name = "Kdget";
            this.Kdget.Size = new System.Drawing.Size(43, 20);
            this.Kdget.TabIndex = 20;
            this.Kdget.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Kdget.ValueChanged += new System.EventHandler(this.Kdget_ValueChanged);
            // 
            // Kiget
            // 
            this.Kiget.Location = new System.Drawing.Point(436, 326);
            this.Kiget.Name = "Kiget";
            this.Kiget.Size = new System.Drawing.Size(43, 20);
            this.Kiget.TabIndex = 19;
            this.Kiget.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Kiget.ValueChanged += new System.EventHandler(this.Kiget_ValueChanged);
            // 
            // Kpget
            // 
            this.Kpget.Location = new System.Drawing.Point(436, 300);
            this.Kpget.Name = "Kpget";
            this.Kpget.Size = new System.Drawing.Size(43, 20);
            this.Kpget.TabIndex = 18;
            this.Kpget.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Kpget.ValueChanged += new System.EventHandler(this.Kpget_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kp";
            this.label6.Click += new System.EventHandler(this.label6_Click_2);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resistanceIndicator);
            this.panel1.Controls.Add(this.autovoltageindicator);
            this.panel1.Controls.Add(this.autotimerindicator);
            this.panel1.Controls.Add(this.autocurrentindicator);
            this.panel1.Controls.Add(this.tempIndicator);
            this.panel1.Controls.Add(this.resistanceIndicatorLabel);
            this.panel1.Controls.Add(this.autocurrentindicatorLabel);
            this.panel1.Controls.Add(this.autotimerindicatorLabel);
            this.panel1.Controls.Add(this.autovoltageindicatorLabel);
            this.panel1.Controls.Add(this.tempIndicatorLabel);
            this.panel1.Location = new System.Drawing.Point(14, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 98);
            this.panel1.TabIndex = 3;
            // 
            // resistanceIndicator
            // 
            this.resistanceIndicator.AutoSize = true;
            this.resistanceIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resistanceIndicator.Location = new System.Drawing.Point(173, 72);
            this.resistanceIndicator.Name = "resistanceIndicator";
            this.resistanceIndicator.Size = new System.Drawing.Size(16, 16);
            this.resistanceIndicator.TabIndex = 17;
            this.resistanceIndicator.Text = "0";
            // 
            // autovoltageindicator
            // 
            this.autovoltageindicator.AutoSize = true;
            this.autovoltageindicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autovoltageindicator.Location = new System.Drawing.Point(173, 54);
            this.autovoltageindicator.Name = "autovoltageindicator";
            this.autovoltageindicator.Size = new System.Drawing.Size(16, 16);
            this.autovoltageindicator.TabIndex = 16;
            this.autovoltageindicator.Text = "0";
            // 
            // autotimerindicator
            // 
            this.autotimerindicator.AutoSize = true;
            this.autotimerindicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autotimerindicator.Location = new System.Drawing.Point(173, 37);
            this.autotimerindicator.Name = "autotimerindicator";
            this.autotimerindicator.Size = new System.Drawing.Size(16, 16);
            this.autotimerindicator.TabIndex = 15;
            this.autotimerindicator.Text = "0";
            // 
            // autocurrentindicator
            // 
            this.autocurrentindicator.AutoSize = true;
            this.autocurrentindicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autocurrentindicator.Location = new System.Drawing.Point(173, 20);
            this.autocurrentindicator.Name = "autocurrentindicator";
            this.autocurrentindicator.Size = new System.Drawing.Size(16, 16);
            this.autocurrentindicator.TabIndex = 14;
            this.autocurrentindicator.Text = "0";
            // 
            // tempIndicator
            // 
            this.tempIndicator.AutoSize = true;
            this.tempIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempIndicator.Location = new System.Drawing.Point(173, 3);
            this.tempIndicator.Name = "tempIndicator";
            this.tempIndicator.Size = new System.Drawing.Size(16, 16);
            this.tempIndicator.TabIndex = 13;
            this.tempIndicator.Text = "0";
            this.tempIndicator.Click += new System.EventHandler(this.label12_Click);
            // 
            // resistanceIndicatorLabel
            // 
            this.resistanceIndicatorLabel.AutoSize = true;
            this.resistanceIndicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resistanceIndicatorLabel.Location = new System.Drawing.Point(3, 75);
            this.resistanceIndicatorLabel.Name = "resistanceIndicatorLabel";
            this.resistanceIndicatorLabel.Size = new System.Drawing.Size(86, 16);
            this.resistanceIndicatorLabel.TabIndex = 12;
            this.resistanceIndicatorLabel.Text = "Resistance";
            // 
            // autocurrentindicatorLabel
            // 
            this.autocurrentindicatorLabel.AutoSize = true;
            this.autocurrentindicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autocurrentindicatorLabel.Location = new System.Drawing.Point(2, 20);
            this.autocurrentindicatorLabel.Name = "autocurrentindicatorLabel";
            this.autocurrentindicatorLabel.Size = new System.Drawing.Size(61, 16);
            this.autocurrentindicatorLabel.TabIndex = 11;
            this.autocurrentindicatorLabel.Text = "Current ";
            // 
            // autotimerindicatorLabel
            // 
            this.autotimerindicatorLabel.AutoSize = true;
            this.autotimerindicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autotimerindicatorLabel.Location = new System.Drawing.Point(2, 37);
            this.autotimerindicatorLabel.Name = "autotimerindicatorLabel";
            this.autotimerindicatorLabel.Size = new System.Drawing.Size(121, 16);
            this.autotimerindicatorLabel.TabIndex = 11;
            this.autotimerindicatorLabel.Text = "Time Remaining";
            // 
            // autovoltageindicatorLabel
            // 
            this.autovoltageindicatorLabel.AutoSize = true;
            this.autovoltageindicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autovoltageindicatorLabel.Location = new System.Drawing.Point(2, 56);
            this.autovoltageindicatorLabel.Name = "autovoltageindicatorLabel";
            this.autovoltageindicatorLabel.Size = new System.Drawing.Size(62, 16);
            this.autovoltageindicatorLabel.TabIndex = 10;
            this.autovoltageindicatorLabel.Text = "Voltage";
            // 
            // tempIndicatorLabel
            // 
            this.tempIndicatorLabel.AutoSize = true;
            this.tempIndicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempIndicatorLabel.Location = new System.Drawing.Point(2, 3);
            this.tempIndicatorLabel.Name = "tempIndicatorLabel";
            this.tempIndicatorLabel.Size = new System.Drawing.Size(97, 16);
            this.tempIndicatorLabel.TabIndex = 2;
            this.tempIndicatorLabel.Text = "Temperature";
            this.tempIndicatorLabel.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // autostopButton
            // 
            this.autostopButton.Location = new System.Drawing.Point(512, 351);
            this.autostopButton.Name = "autostopButton";
            this.autostopButton.Size = new System.Drawing.Size(67, 29);
            this.autostopButton.TabIndex = 1;
            this.autostopButton.Text = "DC Stop";
            this.autostopButton.UseVisualStyleBackColor = true;
            this.autostopButton.Click += new System.EventHandler(this.autostopButton_Click);
            // 
            // autostartButton
            // 
            this.autostartButton.Location = new System.Drawing.Point(512, 284);
            this.autostartButton.Name = "autostartButton";
            this.autostartButton.Size = new System.Drawing.Size(67, 29);
            this.autostartButton.TabIndex = 0;
            this.autostartButton.Text = "Auto Start";
            this.autostartButton.UseVisualStyleBackColor = true;
            this.autostartButton.Click += new System.EventHandler(this.autostartButton_Click);
            // 
            // autoControlSelector
            // 
            this.autoControlSelector.AutoSize = true;
            this.autoControlSelector.Location = new System.Drawing.Point(263, 6);
            this.autoControlSelector.Name = "autoControlSelector";
            this.autoControlSelector.Size = new System.Drawing.Size(123, 17);
            this.autoControlSelector.TabIndex = 2;
            this.autoControlSelector.Text = "Control Automatically";
            this.autoControlSelector.UseVisualStyleBackColor = true;
            this.autoControlSelector.CheckedChanged += new System.EventHandler(this.autoControlSelector_CheckedChanged);
            // 
            // manualContselector
            // 
            this.manualContselector.AutoSize = true;
            this.manualContselector.Checked = true;
            this.manualContselector.Location = new System.Drawing.Point(41, 10);
            this.manualContselector.Name = "manualContselector";
            this.manualContselector.Size = new System.Drawing.Size(103, 17);
            this.manualContselector.TabIndex = 1;
            this.manualContselector.TabStop = true;
            this.manualContselector.Text = "Control Manually";
            this.manualContselector.UseVisualStyleBackColor = true;
            this.manualContselector.CheckedChanged += new System.EventHandler(this.manualContselector_CheckedChanged);
            // 
            // manualcontrolGroup
            // 
            this.manualcontrolGroup.Controls.Add(this.currentIndicator);
            this.manualcontrolGroup.Controls.Add(this.voltageindicator);
            this.manualcontrolGroup.Controls.Add(this.timerindicator);
            this.manualcontrolGroup.Controls.Add(this.label3);
            this.manualcontrolGroup.Controls.Add(this.timeUpDown);
            this.manualcontrolGroup.Controls.Add(this.manStop);
            this.manualcontrolGroup.Controls.Add(this.manStart);
            this.manualcontrolGroup.Controls.Add(this.label2);
            this.manualcontrolGroup.Controls.Add(this.currentUpDown);
            this.manualcontrolGroup.Controls.Add(this.label1);
            this.manualcontrolGroup.Controls.Add(this.voltageUpDown);
            this.manualcontrolGroup.Location = new System.Drawing.Point(26, 33);
            this.manualcontrolGroup.Name = "manualcontrolGroup";
            this.manualcontrolGroup.Size = new System.Drawing.Size(220, 425);
            this.manualcontrolGroup.TabIndex = 0;
            this.manualcontrolGroup.TabStop = false;
            this.manualcontrolGroup.Text = "Manual Control";
            this.manualcontrolGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // currentIndicator
            // 
            this.currentIndicator.AutoSize = true;
            this.currentIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentIndicator.Location = new System.Drawing.Point(15, 184);
            this.currentIndicator.Name = "currentIndicator";
            this.currentIndicator.Size = new System.Drawing.Size(16, 16);
            this.currentIndicator.TabIndex = 10;
            this.currentIndicator.Text = "0";
            // 
            // voltageindicator
            // 
            this.voltageindicator.AutoSize = true;
            this.voltageindicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageindicator.Location = new System.Drawing.Point(15, 146);
            this.voltageindicator.Name = "voltageindicator";
            this.voltageindicator.Size = new System.Drawing.Size(16, 16);
            this.voltageindicator.TabIndex = 9;
            this.voltageindicator.Text = "0";
            this.voltageindicator.Click += new System.EventHandler(this.voltageindicator_Click);
            // 
            // timerindicator
            // 
            this.timerindicator.AutoSize = true;
            this.timerindicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerindicator.Location = new System.Drawing.Point(15, 105);
            this.timerindicator.Name = "timerindicator";
            this.timerindicator.Size = new System.Drawing.Size(16, 16);
            this.timerindicator.TabIndex = 8;
            this.timerindicator.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sintering Time";
            // 
            // timeUpDown
            // 
            this.timeUpDown.Location = new System.Drawing.Point(15, 78);
            this.timeUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.timeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeUpDown.Name = "timeUpDown";
            this.timeUpDown.Size = new System.Drawing.Size(120, 20);
            this.timeUpDown.TabIndex = 6;
            this.timeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeUpDown.ValueChanged += new System.EventHandler(this.timeUpDown_ValueChanged);
            // 
            // manStop
            // 
            this.manStop.Location = new System.Drawing.Point(81, 219);
            this.manStop.Name = "manStop";
            this.manStop.Size = new System.Drawing.Size(54, 29);
            this.manStop.TabIndex = 5;
            this.manStop.Text = "Stop";
            this.manStop.UseVisualStyleBackColor = true;
            this.manStop.Click += new System.EventHandler(this.manStop_Click);
            // 
            // manStart
            // 
            this.manStart.Location = new System.Drawing.Point(15, 219);
            this.manStart.Name = "manStart";
            this.manStart.Size = new System.Drawing.Size(54, 29);
            this.manStart.TabIndex = 4;
            this.manStart.Text = "Start";
            this.manStart.UseVisualStyleBackColor = true;
            this.manStart.Click += new System.EventHandler(this.manStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // currentUpDown
            // 
            this.currentUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.currentUpDown.Location = new System.Drawing.Point(15, 52);
            this.currentUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.currentUpDown.Name = "currentUpDown";
            this.currentUpDown.Size = new System.Drawing.Size(120, 20);
            this.currentUpDown.TabIndex = 2;
            this.currentUpDown.ValueChanged += new System.EventHandler(this.currentUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voltage";
            // 
            // voltageUpDown
            // 
            this.voltageUpDown.Location = new System.Drawing.Point(15, 26);
            this.voltageUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.voltageUpDown.Name = "voltageUpDown";
            this.voltageUpDown.Size = new System.Drawing.Size(120, 20);
            this.voltageUpDown.TabIndex = 0;
            this.voltageUpDown.ValueChanged += new System.EventHandler(this.voltageUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 539);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "DCAS Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabInit.ResumeLayout(false);
            this.tabInit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctDataBindingSource)).EndInit();
            this.tabMainCont.ResumeLayout(false);
            this.tabMainCont.PerformLayout();
            this.autoControlGroup.ResumeLayout(false);
            this.autoControlGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kdget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kiget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kpget)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.manualcontrolGroup.ResumeLayout(false);
            this.manualcontrolGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltageUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInit;
        private System.Windows.Forms.Label descriptor;
        private System.Windows.Forms.ComboBox psAddress;
        private System.Windows.Forms.CheckBox simulateSelector;
        private System.Windows.Forms.CheckBox queryInstrumentStatusCheckbox;
        private System.Windows.Forms.TabPage tabMainCont;
        private System.Windows.Forms.GroupBox manualcontrolGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown currentUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown voltageUpDown;
        private System.Windows.Forms.RadioButton manualContselector;
        private System.Windows.Forms.RadioButton autoControlSelector;
        private System.Windows.Forms.Button manStop;
        private System.Windows.Forms.Button manStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown timeUpDown;
        private System.Windows.Forms.Label timerindicator;
        private System.Windows.Forms.Label currentIndicator;
        private System.Windows.Forms.Label voltageindicator;
        private System.Windows.Forms.ComboBox tempReaderChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox thermocoupleTypeSelector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox autoControlGroup;
        private System.Windows.Forms.Button autostopButton;
        private System.Windows.Forms.Button autostartButton;
        private System.Windows.Forms.Label tempIndicatorLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label autovoltageindicatorLabel;
        private System.Windows.Forms.Label autotimerindicatorLabel;
        private System.Windows.Forms.Label autocurrentindicatorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Kdget;
        private System.Windows.Forms.NumericUpDown Kiget;
        private System.Windows.Forms.NumericUpDown Kpget;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label progInd;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumCurrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumCurrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ctDataBindingSource;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox contcooling;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown currentdown;
        private System.Windows.Forms.Label resistanceIndicatorLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tempIndicator;
        private System.Windows.Forms.Label autocurrentindicator;
        private System.Windows.Forms.Label autotimerindicator;
        private System.Windows.Forms.Button treadButton;
        private System.Windows.Forms.Label autovoltageindicator;
        private System.Windows.Forms.Label resistanceIndicator;

    }
}


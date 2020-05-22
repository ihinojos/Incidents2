namespace Incidents2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.reportType_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.incident_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.employee_name = new System.Windows.Forms.TextBox();
            this.inc_location = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.truck_number = new System.Windows.Forms.TextBox();
            this.trailer_number = new System.Windows.Forms.TextBox();
            this.warning_radio = new System.Windows.Forms.RadioButton();
            this.warning2_radio = new System.Windows.Forms.RadioButton();
            this.penalty_radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compliance_box2 = new System.Windows.Forms.ComboBox();
            this.compliance_box1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.payroll_box2 = new System.Windows.Forms.ComboBox();
            this.payroll_box1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maintenance_box2 = new System.Windows.Forms.ComboBox();
            this.maintenance_box1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.safety_box2 = new System.Windows.Forms.ComboBox();
            this.safety_box1 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.behaviour_box2 = new System.Windows.Forms.ComboBox();
            this.behaviour_box1 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.remarks = new System.Windows.Forms.RichTextBox();
            this.addImg_button = new System.Windows.Forms.Button();
            this.viweImg_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.deducted_amount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.reporter_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.report_date = new System.Windows.Forms.DateTimePicker();
            this.create_button = new System.Windows.Forms.Button();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report type:";
            // 
            // reportType_box
            // 
            this.reportType_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportType_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportType_box.FormattingEnabled = true;
            this.reportType_box.Location = new System.Drawing.Point(83, 6);
            this.reportType_box.Name = "reportType_box";
            this.reportType_box.Size = new System.Drawing.Size(92, 21);
            this.reportType_box.TabIndex = 1;
            this.reportType_box.SelectedIndexChanged += new System.EventHandler(this.reportType_box_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Incident date:";
            // 
            // incident_date
            // 
            this.incident_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incident_date.CustomFormat = "dddd, MMM dd, yyyy";
            this.incident_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.incident_date.Location = new System.Drawing.Point(261, 6);
            this.incident_date.Name = "incident_date";
            this.incident_date.Size = new System.Drawing.Size(162, 20);
            this.incident_date.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee name:";
            // 
            // employee_name
            // 
            this.employee_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employee_name.Location = new System.Drawing.Point(103, 33);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(150, 20);
            this.employee_name.TabIndex = 5;
            // 
            // inc_location
            // 
            this.inc_location.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inc_location.Location = new System.Drawing.Point(103, 59);
            this.inc_location.Name = "inc_location";
            this.inc_location.Size = new System.Drawing.Size(150, 20);
            this.inc_location.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Truck #:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trailer #:";
            // 
            // truck_number
            // 
            this.truck_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.truck_number.Location = new System.Drawing.Point(323, 33);
            this.truck_number.Name = "truck_number";
            this.truck_number.Size = new System.Drawing.Size(100, 20);
            this.truck_number.TabIndex = 10;
            // 
            // trailer_number
            // 
            this.trailer_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trailer_number.Location = new System.Drawing.Point(323, 59);
            this.trailer_number.Name = "trailer_number";
            this.trailer_number.Size = new System.Drawing.Size(100, 20);
            this.trailer_number.TabIndex = 11;
            // 
            // warning_radio
            // 
            this.warning_radio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warning_radio.AutoSize = true;
            this.warning_radio.Location = new System.Drawing.Point(15, 114);
            this.warning_radio.Name = "warning_radio";
            this.warning_radio.Size = new System.Drawing.Size(126, 17);
            this.warning_radio.TabIndex = 12;
            this.warning_radio.TabStop = true;
            this.warning_radio.Text = "Warning - No Penalty";
            this.warning_radio.UseVisualStyleBackColor = true;
            // 
            // warning2_radio
            // 
            this.warning2_radio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warning2_radio.AutoSize = true;
            this.warning2_radio.Location = new System.Drawing.Point(147, 114);
            this.warning2_radio.Name = "warning2_radio";
            this.warning2_radio.Size = new System.Drawing.Size(147, 17);
            this.warning2_radio.TabIndex = 13;
            this.warning2_radio.TabStop = true;
            this.warning2_radio.Text = "2nd Warning - No Penalty";
            this.warning2_radio.UseVisualStyleBackColor = true;
            // 
            // penalty_radio
            // 
            this.penalty_radio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.penalty_radio.AutoSize = true;
            this.penalty_radio.Location = new System.Drawing.Point(300, 114);
            this.penalty_radio.Name = "penalty_radio";
            this.penalty_radio.Size = new System.Drawing.Size(118, 17);
            this.penalty_radio.TabIndex = 14;
            this.penalty_radio.TabStop = true;
            this.penalty_radio.Text = "Penalty - Deduction";
            this.penalty_radio.UseVisualStyleBackColor = true;
            this.penalty_radio.CheckedChanged += new System.EventHandler(this.penalty_radio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.compliance_box2);
            this.groupBox1.Controls.Add(this.compliance_box1);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 76);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compliance Issues";
            // 
            // compliance_box2
            // 
            this.compliance_box2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compliance_box2.FormattingEnabled = true;
            this.compliance_box2.Location = new System.Drawing.Point(6, 46);
            this.compliance_box2.Name = "compliance_box2";
            this.compliance_box2.Size = new System.Drawing.Size(399, 21);
            this.compliance_box2.TabIndex = 1;
            // 
            // compliance_box1
            // 
            this.compliance_box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compliance_box1.FormattingEnabled = true;
            this.compliance_box1.Location = new System.Drawing.Point(6, 19);
            this.compliance_box1.Name = "compliance_box1";
            this.compliance_box1.Size = new System.Drawing.Size(399, 21);
            this.compliance_box1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.payroll_box2);
            this.groupBox2.Controls.Add(this.payroll_box1);
            this.groupBox2.Location = new System.Drawing.Point(12, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 81);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payroll Issues";
            // 
            // payroll_box2
            // 
            this.payroll_box2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_box2.FormattingEnabled = true;
            this.payroll_box2.Location = new System.Drawing.Point(6, 46);
            this.payroll_box2.Name = "payroll_box2";
            this.payroll_box2.Size = new System.Drawing.Size(399, 21);
            this.payroll_box2.TabIndex = 1;
            // 
            // payroll_box1
            // 
            this.payroll_box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payroll_box1.FormattingEnabled = true;
            this.payroll_box1.Location = new System.Drawing.Point(6, 19);
            this.payroll_box1.Name = "payroll_box1";
            this.payroll_box1.Size = new System.Drawing.Size(399, 21);
            this.payroll_box1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.maintenance_box2);
            this.groupBox3.Controls.Add(this.maintenance_box1);
            this.groupBox3.Location = new System.Drawing.Point(12, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 80);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Maintenance Issues";
            // 
            // maintenance_box2
            // 
            this.maintenance_box2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maintenance_box2.FormattingEnabled = true;
            this.maintenance_box2.Location = new System.Drawing.Point(6, 46);
            this.maintenance_box2.Name = "maintenance_box2";
            this.maintenance_box2.Size = new System.Drawing.Size(399, 21);
            this.maintenance_box2.TabIndex = 1;
            // 
            // maintenance_box1
            // 
            this.maintenance_box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maintenance_box1.FormattingEnabled = true;
            this.maintenance_box1.Location = new System.Drawing.Point(6, 19);
            this.maintenance_box1.Name = "maintenance_box1";
            this.maintenance_box1.Size = new System.Drawing.Size(399, 21);
            this.maintenance_box1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.safety_box2);
            this.groupBox4.Controls.Add(this.safety_box1);
            this.groupBox4.Location = new System.Drawing.Point(12, 421);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 76);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Safety Issues";
            // 
            // safety_box2
            // 
            this.safety_box2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.safety_box2.FormattingEnabled = true;
            this.safety_box2.Location = new System.Drawing.Point(6, 46);
            this.safety_box2.Name = "safety_box2";
            this.safety_box2.Size = new System.Drawing.Size(399, 21);
            this.safety_box2.TabIndex = 1;
            // 
            // safety_box1
            // 
            this.safety_box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.safety_box1.FormattingEnabled = true;
            this.safety_box1.Location = new System.Drawing.Point(6, 19);
            this.safety_box1.Name = "safety_box1";
            this.safety_box1.Size = new System.Drawing.Size(399, 21);
            this.safety_box1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.behaviour_box2);
            this.groupBox5.Controls.Add(this.behaviour_box1);
            this.groupBox5.Location = new System.Drawing.Point(12, 503);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(411, 76);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Behavioral Issues";
            // 
            // behaviour_box2
            // 
            this.behaviour_box2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.behaviour_box2.FormattingEnabled = true;
            this.behaviour_box2.Location = new System.Drawing.Point(6, 46);
            this.behaviour_box2.Name = "behaviour_box2";
            this.behaviour_box2.Size = new System.Drawing.Size(399, 21);
            this.behaviour_box2.TabIndex = 1;
            // 
            // behaviour_box1
            // 
            this.behaviour_box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.behaviour_box1.FormattingEnabled = true;
            this.behaviour_box1.Location = new System.Drawing.Point(6, 19);
            this.behaviour_box1.Name = "behaviour_box1";
            this.behaviour_box1.Size = new System.Drawing.Size(399, 21);
            this.behaviour_box1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.remarks);
            this.groupBox6.Location = new System.Drawing.Point(12, 585);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(411, 71);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Remarks";
            // 
            // remarks
            // 
            this.remarks.Location = new System.Drawing.Point(6, 19);
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(399, 46);
            this.remarks.TabIndex = 0;
            this.remarks.Text = "";
            // 
            // addImg_button
            // 
            this.addImg_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addImg_button.Location = new System.Drawing.Point(12, 681);
            this.addImg_button.Name = "addImg_button";
            this.addImg_button.Size = new System.Drawing.Size(75, 23);
            this.addImg_button.TabIndex = 21;
            this.addImg_button.Text = "Add Images";
            this.addImg_button.UseVisualStyleBackColor = true;
            this.addImg_button.Click += new System.EventHandler(this.addImg_button_Click);
            // 
            // viweImg_button
            // 
            this.viweImg_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viweImg_button.Location = new System.Drawing.Point(93, 681);
            this.viweImg_button.Name = "viweImg_button";
            this.viweImg_button.Size = new System.Drawing.Size(75, 23);
            this.viweImg_button.TabIndex = 22;
            this.viweImg_button.Text = "View Images";
            this.viweImg_button.UseVisualStyleBackColor = true;
            this.viweImg_button.Click += new System.EventHandler(this.viweImg_button_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 686);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Deducation Amount";
            // 
            // deducted_amount
            // 
            this.deducted_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deducted_amount.Enabled = false;
            this.deducted_amount.Location = new System.Drawing.Point(322, 683);
            this.deducted_amount.Name = "deducted_amount";
            this.deducted_amount.Size = new System.Drawing.Size(100, 20);
            this.deducted_amount.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 713);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Incident reported by: ";
            // 
            // reporter_name
            // 
            this.reporter_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reporter_name.Location = new System.Drawing.Point(128, 710);
            this.reporter_name.Name = "reporter_name";
            this.reporter_name.Size = new System.Drawing.Size(177, 20);
            this.reporter_name.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 742);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "On:";
            // 
            // report_date
            // 
            this.report_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.report_date.Enabled = false;
            this.report_date.Location = new System.Drawing.Point(128, 736);
            this.report_date.Name = "report_date";
            this.report_date.Size = new System.Drawing.Size(177, 20);
            this.report_date.TabIndex = 28;
            // 
            // create_button
            // 
            this.create_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_button.Location = new System.Drawing.Point(322, 713);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(101, 46);
            this.create_button.TabIndex = 29;
            this.create_button.Text = "Create Report";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl1.Location = new System.Drawing.Point(15, 85);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(408, 23);
            this.separatorControl1.TabIndex = 30;
            // 
            // separatorControl2
            // 
            this.separatorControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl2.Location = new System.Drawing.Point(2, 137);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(421, 23);
            this.separatorControl2.TabIndex = 31;
            // 
            // separatorControl3
            // 
            this.separatorControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl3.Location = new System.Drawing.Point(12, 656);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(411, 23);
            this.separatorControl3.TabIndex = 32;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toggleSwitch1.Location = new System.Drawing.Point(18, 737);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(69, 24);
            this.toggleSwitch1.TabIndex = 33;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 765);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.report_date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reporter_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deducted_amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.viweImg_button);
            this.Controls.Add(this.addImg_button);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.penalty_radio);
            this.Controls.Add(this.warning2_radio);
            this.Controls.Add(this.warning_radio);
            this.Controls.Add(this.trailer_number);
            this.Controls.Add(this.truck_number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inc_location);
            this.Controls.Add(this.employee_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.incident_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportType_box);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Incidents";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox reportType_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker incident_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employee_name;
        private System.Windows.Forms.TextBox inc_location;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox truck_number;
        private System.Windows.Forms.TextBox trailer_number;
        private System.Windows.Forms.RadioButton warning_radio;
        private System.Windows.Forms.RadioButton warning2_radio;
        private System.Windows.Forms.RadioButton penalty_radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox compliance_box2;
        private System.Windows.Forms.ComboBox compliance_box1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox payroll_box2;
        private System.Windows.Forms.ComboBox payroll_box1;
        private System.Windows.Forms.ComboBox maintenance_box2;
        private System.Windows.Forms.ComboBox maintenance_box1;
        private System.Windows.Forms.ComboBox safety_box2;
        private System.Windows.Forms.ComboBox safety_box1;
        private System.Windows.Forms.ComboBox behaviour_box2;
        private System.Windows.Forms.ComboBox behaviour_box1;
        private System.Windows.Forms.RichTextBox remarks;
        private System.Windows.Forms.Button addImg_button;
        private System.Windows.Forms.Button viweImg_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox deducted_amount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox reporter_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker report_date;
        private System.Windows.Forms.Button create_button;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}


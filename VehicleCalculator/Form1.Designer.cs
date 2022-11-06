using System.Windows.Forms;

namespace VehicleCalculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPlanet = new System.Windows.Forms.ComboBox();
            this.bCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbFrontalArea = new System.Windows.Forms.TextBox();
            this.tbMaxPower = new System.Windows.Forms.TextBox();
            this.tbMaxPowerRPM = new System.Windows.Forms.TextBox();
            this.tbMaxTorque = new System.Windows.Forms.TextBox();
            this.tbMaxTorqueRPM = new System.Windows.Forms.TextBox();
            this.tbDragCoefficient = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lMaxSpeed = new System.Windows.Forms.Label();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbGearRatio1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbGearRatio2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbGearRatio3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbGearRatio4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbGearRatio5 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbMaxRPM = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbGearEfficiency5 = new System.Windows.Forms.TextBox();
            this.tbGearEfficiency4 = new System.Windows.Forms.TextBox();
            this.tbGearEfficiency3 = new System.Windows.Forms.TextBox();
            this.tbGearEfficiency2 = new System.Windows.Forms.TextBox();
            this.tbGearEfficiency1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbDriveRatio = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tbWheelAspectRatio = new System.Windows.Forms.TextBox();
            this.tbWheelWidth = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbWheelDiameter = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lMaxSpeed1 = new System.Windows.Forms.Label();
            this.lMaxSpeed2 = new System.Windows.Forms.Label();
            this.lMaxSpeed3 = new System.Windows.Forms.Label();
            this.lMaxSpeed4 = new System.Windows.Forms.Label();
            this.lMaxSpeed5 = new System.Windows.Forms.Label();
            this.PowerRPMChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.MaxSpeedGearChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.bFillData = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Max Power / RPM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Max Torque / RPM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Select Planet";
            // 
            // cbPlanet
            // 
            this.cbPlanet.FormattingEnabled = true;
            this.cbPlanet.Items.AddRange(new object[] {
            "Earth",
            "Mars"});
            this.cbPlanet.Location = new System.Drawing.Point(89, 16);
            this.cbPlanet.Name = "cbPlanet";
            this.cbPlanet.Size = new System.Drawing.Size(213, 23);
            this.cbPlanet.TabIndex = 19;
            // 
            // bCalculate
            // 
            this.bCalculate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalculate.Location = new System.Drawing.Point(66, 568);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(130, 39);
            this.bCalculate.TabIndex = 20;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = false;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frontal Area";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(89, 103);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(39, 23);
            this.tbWeight.TabIndex = 21;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(89, 138);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(39, 23);
            this.tbWidth.TabIndex = 22;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(238, 138);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(40, 23);
            this.tbHeight.TabIndex = 23;
            // 
            // tbFrontalArea
            // 
            this.tbFrontalArea.Location = new System.Drawing.Point(89, 180);
            this.tbFrontalArea.Name = "tbFrontalArea";
            this.tbFrontalArea.Size = new System.Drawing.Size(39, 23);
            this.tbFrontalArea.TabIndex = 24;
            // 
            // tbMaxPower
            // 
            this.tbMaxPower.Location = new System.Drawing.Point(522, 18);
            this.tbMaxPower.Name = "tbMaxPower";
            this.tbMaxPower.Size = new System.Drawing.Size(40, 23);
            this.tbMaxPower.TabIndex = 25;
            // 
            // tbMaxPowerRPM
            // 
            this.tbMaxPowerRPM.Location = new System.Drawing.Point(616, 18);
            this.tbMaxPowerRPM.Name = "tbMaxPowerRPM";
            this.tbMaxPowerRPM.Size = new System.Drawing.Size(40, 23);
            this.tbMaxPowerRPM.TabIndex = 26;
            // 
            // tbMaxTorque
            // 
            this.tbMaxTorque.Location = new System.Drawing.Point(522, 47);
            this.tbMaxTorque.Name = "tbMaxTorque";
            this.tbMaxTorque.Size = new System.Drawing.Size(40, 23);
            this.tbMaxTorque.TabIndex = 27;
            // 
            // tbMaxTorqueRPM
            // 
            this.tbMaxTorqueRPM.Location = new System.Drawing.Point(616, 47);
            this.tbMaxTorqueRPM.Name = "tbMaxTorqueRPM";
            this.tbMaxTorqueRPM.Size = new System.Drawing.Size(40, 23);
            this.tbMaxTorqueRPM.TabIndex = 28;
            // 
            // tbDragCoefficient
            // 
            this.tbDragCoefficient.Location = new System.Drawing.Point(89, 212);
            this.tbDragCoefficient.Name = "tbDragCoefficient";
            this.tbDragCoefficient.Size = new System.Drawing.Size(39, 23);
            this.tbDragCoefficient.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Drag Coef.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lMaxSpeed
            // 
            this.lMaxSpeed.AutoSize = true;
            this.lMaxSpeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lMaxSpeed.Location = new System.Drawing.Point(94, 379);
            this.lMaxSpeed.Name = "lMaxSpeed";
            this.lMaxSpeed.Size = new System.Drawing.Size(80, 15);
            this.lMaxSpeed.TabIndex = 31;
            this.lMaxSpeed.Text = "Max Speed: ?";
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(89, 45);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(40, 23);
            this.tbAngle.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Road Angle";
            // 
            // tbGearRatio1
            // 
            this.tbGearRatio1.Location = new System.Drawing.Point(523, 162);
            this.tbGearRatio1.Name = "tbGearRatio1";
            this.tbGearRatio1.Size = new System.Drawing.Size(39, 23);
            this.tbGearRatio1.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "1st Gear Ratio / Efficiency";
            // 
            // tbGearRatio2
            // 
            this.tbGearRatio2.Location = new System.Drawing.Point(523, 188);
            this.tbGearRatio2.Name = "tbGearRatio2";
            this.tbGearRatio2.Size = new System.Drawing.Size(39, 23);
            this.tbGearRatio2.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "2nd Gear Ratio / Efficiency";
            // 
            // tbGearRatio3
            // 
            this.tbGearRatio3.Location = new System.Drawing.Point(523, 219);
            this.tbGearRatio3.Name = "tbGearRatio3";
            this.tbGearRatio3.Size = new System.Drawing.Size(39, 23);
            this.tbGearRatio3.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(366, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 15);
            this.label15.TabIndex = 41;
            this.label15.Text = "3rd Gear Ratio / Efficiency";
            // 
            // tbGearRatio4
            // 
            this.tbGearRatio4.Location = new System.Drawing.Point(523, 247);
            this.tbGearRatio4.Name = "tbGearRatio4";
            this.tbGearRatio4.Size = new System.Drawing.Size(39, 23);
            this.tbGearRatio4.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(366, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 15);
            this.label16.TabIndex = 43;
            this.label16.Text = "4th Gear Ratio / Efficiency";
            // 
            // tbGearRatio5
            // 
            this.tbGearRatio5.Location = new System.Drawing.Point(523, 271);
            this.tbGearRatio5.Name = "tbGearRatio5";
            this.tbGearRatio5.Size = new System.Drawing.Size(39, 23);
            this.tbGearRatio5.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(366, 274);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 15);
            this.label17.TabIndex = 45;
            this.label17.Text = "5th Gear Ratio / Efficiency";
            // 
            // tbMaxRPM
            // 
            this.tbMaxRPM.Location = new System.Drawing.Point(522, 77);
            this.tbMaxRPM.Name = "tbMaxRPM";
            this.tbMaxRPM.Size = new System.Drawing.Size(40, 23);
            this.tbMaxRPM.TabIndex = 48;
            this.tbMaxRPM.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(455, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 15);
            this.label18.TabIndex = 47;
            this.label18.Text = "Max. RPM";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // tbGearEfficiency5
            // 
            this.tbGearEfficiency5.Location = new System.Drawing.Point(616, 274);
            this.tbGearEfficiency5.Name = "tbGearEfficiency5";
            this.tbGearEfficiency5.Size = new System.Drawing.Size(39, 23);
            this.tbGearEfficiency5.TabIndex = 53;
            // 
            // tbGearEfficiency4
            // 
            this.tbGearEfficiency4.Location = new System.Drawing.Point(616, 250);
            this.tbGearEfficiency4.Name = "tbGearEfficiency4";
            this.tbGearEfficiency4.Size = new System.Drawing.Size(39, 23);
            this.tbGearEfficiency4.TabIndex = 52;
            // 
            // tbGearEfficiency3
            // 
            this.tbGearEfficiency3.Location = new System.Drawing.Point(616, 222);
            this.tbGearEfficiency3.Name = "tbGearEfficiency3";
            this.tbGearEfficiency3.Size = new System.Drawing.Size(39, 23);
            this.tbGearEfficiency3.TabIndex = 51;
            // 
            // tbGearEfficiency2
            // 
            this.tbGearEfficiency2.Location = new System.Drawing.Point(616, 191);
            this.tbGearEfficiency2.Name = "tbGearEfficiency2";
            this.tbGearEfficiency2.Size = new System.Drawing.Size(39, 23);
            this.tbGearEfficiency2.TabIndex = 50;
            // 
            // tbGearEfficiency1
            // 
            this.tbGearEfficiency1.Location = new System.Drawing.Point(616, 165);
            this.tbGearEfficiency1.Name = "tbGearEfficiency1";
            this.tbGearEfficiency1.Size = new System.Drawing.Size(39, 23);
            this.tbGearEfficiency1.TabIndex = 49;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(585, 165);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 15);
            this.label20.TabIndex = 54;
            this.label20.Text = "/";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(585, 191);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 15);
            this.label19.TabIndex = 55;
            this.label19.Text = "/";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(585, 222);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 15);
            this.label21.TabIndex = 56;
            this.label21.Text = "/";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(585, 250);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 15);
            this.label22.TabIndex = 57;
            this.label22.Text = "/";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(585, 278);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 15);
            this.label23.TabIndex = 58;
            this.label23.Text = "/";
            // 
            // tbDriveRatio
            // 
            this.tbDriveRatio.Location = new System.Drawing.Point(523, 106);
            this.tbDriveRatio.Name = "tbDriveRatio";
            this.tbDriveRatio.Size = new System.Drawing.Size(39, 23);
            this.tbDriveRatio.TabIndex = 60;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(424, 110);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 15);
            this.label24.TabIndex = 59;
            this.label24.Text = "Final Drive Ratio";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(142, 270);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(12, 15);
            this.label25.TabIndex = 65;
            this.label25.Text = "/";
            // 
            // tbWheelAspectRatio
            // 
            this.tbWheelAspectRatio.Location = new System.Drawing.Point(168, 266);
            this.tbWheelAspectRatio.Name = "tbWheelAspectRatio";
            this.tbWheelAspectRatio.Size = new System.Drawing.Size(39, 23);
            this.tbWheelAspectRatio.TabIndex = 64;
            // 
            // tbWheelWidth
            // 
            this.tbWheelWidth.Location = new System.Drawing.Point(89, 266);
            this.tbWheelWidth.Name = "tbWheelWidth";
            this.tbWheelWidth.Size = new System.Drawing.Size(39, 23);
            this.tbWheelWidth.TabIndex = 62;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 271);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 15);
            this.label26.TabIndex = 61;
            this.label26.Text = "Wheel Size";
            // 
            // tbWheelDiameter
            // 
            this.tbWheelDiameter.Location = new System.Drawing.Point(239, 266);
            this.tbWheelDiameter.Name = "tbWheelDiameter";
            this.tbWheelDiameter.Size = new System.Drawing.Size(39, 23);
            this.tbWheelDiameter.TabIndex = 66;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(215, 270);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 15);
            this.label27.TabIndex = 67;
            this.label27.Text = "R";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(132, 49);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 15);
            this.label29.TabIndex = 69;
            this.label29.Text = "degree";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(129, 106);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 15);
            this.label30.TabIndex = 70;
            this.label30.Text = "kg";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(129, 143);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(18, 15);
            this.label31.TabIndex = 71;
            this.label31.Text = "m";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(281, 143);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(18, 15);
            this.label32.TabIndex = 72;
            this.label32.Text = "m";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(129, 184);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(24, 15);
            this.label33.TabIndex = 73;
            this.label33.Text = "m2";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(564, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(21, 15);
            this.label35.TabIndex = 75;
            this.label35.Text = "hp";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(563, 50);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(31, 15);
            this.label36.TabIndex = 76;
            this.label36.Text = "kgm";
            // 
            // lMaxSpeed1
            // 
            this.lMaxSpeed1.AutoSize = true;
            this.lMaxSpeed1.Location = new System.Drawing.Point(53, 403);
            this.lMaxSpeed1.Name = "lMaxSpeed1";
            this.lMaxSpeed1.Size = new System.Drawing.Size(121, 15);
            this.lMaxSpeed1.TabIndex = 77;
            this.lMaxSpeed1.Text = "1st Gear Max Speed: ?";
            // 
            // lMaxSpeed2
            // 
            this.lMaxSpeed2.AutoSize = true;
            this.lMaxSpeed2.Location = new System.Drawing.Point(48, 418);
            this.lMaxSpeed2.Name = "lMaxSpeed2";
            this.lMaxSpeed2.Size = new System.Drawing.Size(126, 15);
            this.lMaxSpeed2.TabIndex = 78;
            this.lMaxSpeed2.Text = "2nd Gear Max Speed: ?";
            // 
            // lMaxSpeed3
            // 
            this.lMaxSpeed3.AutoSize = true;
            this.lMaxSpeed3.Location = new System.Drawing.Point(51, 433);
            this.lMaxSpeed3.Name = "lMaxSpeed3";
            this.lMaxSpeed3.Size = new System.Drawing.Size(123, 15);
            this.lMaxSpeed3.TabIndex = 79;
            this.lMaxSpeed3.Text = "3rd Gear Max Speed: ?";
            // 
            // lMaxSpeed4
            // 
            this.lMaxSpeed4.AutoSize = true;
            this.lMaxSpeed4.Location = new System.Drawing.Point(51, 448);
            this.lMaxSpeed4.Name = "lMaxSpeed4";
            this.lMaxSpeed4.Size = new System.Drawing.Size(123, 15);
            this.lMaxSpeed4.TabIndex = 80;
            this.lMaxSpeed4.Text = "4th Gear Max Speed: ?";
            // 
            // lMaxSpeed5
            // 
            this.lMaxSpeed5.AutoSize = true;
            this.lMaxSpeed5.Location = new System.Drawing.Point(51, 463);
            this.lMaxSpeed5.Name = "lMaxSpeed5";
            this.lMaxSpeed5.Size = new System.Drawing.Size(123, 15);
            this.lMaxSpeed5.TabIndex = 81;
            this.lMaxSpeed5.Text = "5th Gear Max Speed: ?";
            // 
            // PowerRPMChart
            // 
            this.PowerRPMChart.Location = new System.Drawing.Point(735, 22);
            this.PowerRPMChart.Name = "PowerRPMChart";
            this.PowerRPMChart.Size = new System.Drawing.Size(424, 585);
            this.PowerRPMChart.TabIndex = 83;
            // 
            // MaxSpeedGearChart
            // 
            this.MaxSpeedGearChart.Location = new System.Drawing.Point(281, 321);
            this.MaxSpeedGearChart.Name = "MaxSpeedGearChart";
            this.MaxSpeedGearChart.Size = new System.Drawing.Size(424, 286);
            this.MaxSpeedGearChart.TabIndex = 84;
            // 
            // bFillData
            // 
            this.bFillData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFillData.Location = new System.Drawing.Point(66, 540);
            this.bFillData.Name = "bFillData";
            this.bFillData.Size = new System.Drawing.Size(129, 22);
            this.bFillData.TabIndex = 85;
            this.bFillData.Text = "Auto Fill";
            this.bFillData.UseVisualStyleBackColor = true;
            this.bFillData.Click += new System.EventHandler(this.bFillData_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(1058, 612);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(115, 15);
            this.label34.TabIndex = 86;
            this.label34.Text = "Designed by HY Soft";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 633);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.bFillData);
            this.Controls.Add(this.MaxSpeedGearChart);
            this.Controls.Add(this.PowerRPMChart);
            this.Controls.Add(this.lMaxSpeed5);
            this.Controls.Add(this.lMaxSpeed4);
            this.Controls.Add(this.lMaxSpeed3);
            this.Controls.Add(this.lMaxSpeed2);
            this.Controls.Add(this.lMaxSpeed1);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.tbWheelDiameter);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tbWheelAspectRatio);
            this.Controls.Add(this.tbWheelWidth);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tbDriveRatio);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbGearEfficiency5);
            this.Controls.Add(this.tbGearEfficiency4);
            this.Controls.Add(this.tbGearEfficiency3);
            this.Controls.Add(this.tbGearEfficiency2);
            this.Controls.Add(this.tbGearEfficiency1);
            this.Controls.Add(this.tbMaxRPM);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbGearRatio5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbGearRatio4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbGearRatio3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbGearRatio2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbGearRatio1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lMaxSpeed);
            this.Controls.Add(this.tbDragCoefficient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbMaxTorqueRPM);
            this.Controls.Add(this.tbMaxTorque);
            this.Controls.Add(this.tbMaxPowerRPM);
            this.Controls.Add(this.tbMaxPower);
            this.Controls.Add(this.tbFrontalArea);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.cbPlanet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label8;
        private Label label9;
        private ComboBox cbPlanet;
        private Button bCalculate;
        private Label label4;
        private TextBox tbWeight;
        private TextBox tbWidth;
        private TextBox tbHeight;
        private TextBox tbFrontalArea;
        private TextBox tbMaxPower;
        private TextBox tbMaxPowerRPM;
        private TextBox tbMaxTorque;
        private TextBox tbMaxTorqueRPM;
        private TextBox tbDragCoefficient;
        private Label label10;
        private Label lMaxSpeed;
        private TextBox tbAngle;
        private Label label11;
        private TextBox tbGearRatio1;
        private Label label13;
        private TextBox tbGearRatio2;
        private Label label14;
        private TextBox tbGearRatio3;
        private Label label15;
        private TextBox tbGearRatio4;
        private Label label16;
        private TextBox tbGearRatio5;
        private Label label17;
        private TextBox tbMaxRPM;
        private Label label18;
        private TextBox tbGearEfficiency5;
        private TextBox tbGearEfficiency4;
        private TextBox tbGearEfficiency3;
        private TextBox tbGearEfficiency2;
        private TextBox tbGearEfficiency1;
        private Label label20;
        private Label label19;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox tbDriveRatio;
        private Label label24;
        private Label label25;
        private TextBox tbWheelAspectRatio;
        private TextBox tbWheelWidth;
        private Label label26;
        private TextBox tbWheelDiameter;
        private Label label27;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label35;
        private Label label36;
        private Label lMaxSpeed1;
        private Label lMaxSpeed2;
        private Label lMaxSpeed3;
        private Label lMaxSpeed4;
        private Label lMaxSpeed5;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart PowerRPMChart;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart MaxSpeedGearChart;
        private Button bFillData;
        private Label label34;
    }
}
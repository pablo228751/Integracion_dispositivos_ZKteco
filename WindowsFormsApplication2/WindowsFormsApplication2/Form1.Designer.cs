namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnDeleteFP = new System.Windows.Forms.Button();
            this.cmbOutAddr = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.txt485 = new System.Windows.Forms.TextBox();
            this.radbtn485 = new System.Windows.Forms.RadioButton();
            this.button23 = new System.Windows.Forms.Button();
            this.txt_tcp = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControlFingerPrint = new System.Windows.Forms.TabControl();
            this.device_param = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnchgparam = new System.Windows.Forms.Button();
            this.txtchgparam = new System.Windows.Forms.TextBox();
            this.cmbparam = new System.Windows.Forms.ComboBox();
            this.btnsetparam = new System.Windows.Forms.Button();
            this.btngetparam = new System.Windows.Forms.Button();
            this.btncleparam = new System.Windows.Forms.Button();
            this.btnselparam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvselparam = new System.Windows.Forms.ListView();
            this.param3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.param4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvpreparam = new System.Windows.Forms.ListView();
            this.laname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvremarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.control_devie = new System.Windows.Forms.TabPage();
            this.txtAuxoutCount = new System.Windows.Forms.TextBox();
            this.txtDoorCount = new System.Windows.Forms.TextBox();
            this.labelStartOrOverValue = new System.Windows.Forms.Label();
            this.labelStartOrOver = new System.Windows.Forms.Label();
            this.cmbNorOpenOrNot = new System.Windows.Forms.ComboBox();
            this.cmbAuxoutID = new System.Windows.Forms.ComboBox();
            this.labelAuxoutID = new System.Windows.Forms.Label();
            this.labelDoorActionValue = new System.Windows.Forms.Label();
            this.txtDoorAction = new System.Windows.Forms.TextBox();
            this.labelDoorAction = new System.Windows.Forms.Label();
            this.labelAddrTypeValue = new System.Windows.Forms.Label();
            this.labelOperIDValue = new System.Windows.Forms.Label();
            this.btnDevControl = new System.Windows.Forms.Button();
            this.cmbDoorID = new System.Windows.Forms.ComboBox();
            this.labelAddrType = new System.Windows.Forms.Label();
            this.labelDoorID = new System.Windows.Forms.Label();
            this.labelOperID = new System.Windows.Forms.Label();
            this.cmbOperID = new System.Windows.Forms.ComboBox();
            this.labelControlDevice = new System.Windows.Forms.Label();
            this.device_data = new System.Windows.Forms.TabPage();
            this.btndelall = new System.Windows.Forms.Button();
            this.btndeldata = new System.Windows.Forms.Button();
            this.txtgetdata10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnclefil = new System.Windows.Forms.Button();
            this.txtfilval = new System.Windows.Forms.TextBox();
            this.txtfil = new System.Windows.Forms.TextBox();
            this.btnfil = new System.Windows.Forms.Button();
            this.cmbfil = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grabar = new System.Windows.Forms.Button();
            this.grabar_2 = new System.Windows.Forms.Button();
            this.txtdev1 = new System.Windows.Forms.TextBox();
            this.cmbdevtable = new System.Windows.Forms.ComboBox();
            this.rt_log = new System.Windows.Forms.TabPage();
            this.btncls = new System.Windows.Forms.Button();
            this.btnrtlogstart = new System.Windows.Forms.Button();
            this.btnrtlogstop = new System.Windows.Forms.Button();
            this.lsvrtlog = new System.Windows.Forms.ListView();
            this.coltime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colpin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colcardno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coldoorid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colevtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInOutState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colvermode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search_device = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.txtnewip = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbseardev = new System.Windows.Forms.ComboBox();
            this.lsvseardev = new System.Windows.Forms.ListView();
            this.colmac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colsn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coldev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnmodip = new System.Windows.Forms.Button();
            this.btnseardev = new System.Windows.Forms.Button();
            this.device_file = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDData = new System.Windows.Forms.TextBox();
            this.btnParseSDData = new System.Windows.Forms.Button();
            this.btnTarFile = new System.Windows.Forms.Button();
            this.txtTarFile = new System.Windows.Forms.TextBox();
            this.btnSetDevFile = new System.Windows.Forms.Button();
            this.labelTarFileChoose = new System.Windows.Forms.Label();
            this.btnGetDevFile = new System.Windows.Forms.Button();
            this.txtGetDevFile = new System.Windows.Forms.TextBox();
            this.labelDevFile = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.forceFPMake = new System.Windows.Forms.CheckBox();
            this.txtFingerID = new System.Windows.Forms.TextBox();
            this.labelFingerID = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.labelPin = new System.Windows.Forms.Label();
            this.labelFingerPrint = new System.Windows.Forms.Label();
            this.btnUploadFP = new System.Windows.Forms.Button();
            this.axAFXOnlineMain = new Axzkonline.AxAFXOnlineMain();
            this.txtTemplateDatas = new System.Windows.Forms.TextBox();
            this.btnVerifyfp = new System.Windows.Forms.Button();
            this.btnRegsterFingerprint = new System.Windows.Forms.Button();
            this.labelTemplateDatas = new System.Windows.Forms.Label();
            this.trglog = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labsearchdev = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAFXOnlineMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM12";
            // 
            // btnDeleteFP
            // 
            this.btnDeleteFP.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteFP.Name = "btnDeleteFP";
            this.btnDeleteFP.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFP.TabIndex = 0;
            // 
            // cmbOutAddr
            // 
            this.cmbOutAddr.Location = new System.Drawing.Point(0, 0);
            this.cmbOutAddr.Name = "cmbOutAddr";
            this.cmbOutAddr.Size = new System.Drawing.Size(121, 21);
            this.cmbOutAddr.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnconnect);
            this.groupBox1.Controls.Add(this.txt485);
            this.groupBox1.Controls.Add(this.radbtn485);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please select connection:";
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(0, 0);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(75, 23);
            this.btnconnect.TabIndex = 0;
            // 
            // txt485
            // 
            this.txt485.Location = new System.Drawing.Point(0, 0);
            this.txt485.Name = "txt485";
            this.txt485.Size = new System.Drawing.Size(100, 20);
            this.txt485.TabIndex = 0;
            // 
            // radbtn485
            // 
            this.radbtn485.Location = new System.Drawing.Point(0, 0);
            this.radbtn485.Name = "radbtn485";
            this.radbtn485.Size = new System.Drawing.Size(104, 24);
            this.radbtn485.TabIndex = 0;
            // 
            // button23
            // 
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(537, 58);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(142, 67);
            this.button23.TabIndex = 12;
            this.button23.Text = "Desconectar";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // txt_tcp
            // 
            this.txt_tcp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tcp.Location = new System.Drawing.Point(188, 11);
            this.txt_tcp.Name = "txt_tcp";
            this.txt_tcp.Size = new System.Drawing.Size(491, 23);
            this.txt_tcp.TabIndex = 8;
            this.txt_tcp.Text = "protocol=TCP,ipaddress=cocheraroma.dyndns.org,port=4370,timeout=2000,passwd=";
            this.txt_tcp.TextChanged += new System.EventHandler(this.txt_tcp_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(89, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TCP/IP:";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabControlFingerPrint
            // 
            this.tabControlFingerPrint.Location = new System.Drawing.Point(0, 0);
            this.tabControlFingerPrint.Name = "tabControlFingerPrint";
            this.tabControlFingerPrint.SelectedIndex = 0;
            this.tabControlFingerPrint.Size = new System.Drawing.Size(200, 100);
            this.tabControlFingerPrint.TabIndex = 0;
            // 
            // device_param
            // 
            this.device_param.Location = new System.Drawing.Point(0, 0);
            this.device_param.Name = "device_param";
            this.device_param.Size = new System.Drawing.Size(200, 100);
            this.device_param.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // btnchgparam
            // 
            this.btnchgparam.Location = new System.Drawing.Point(0, 0);
            this.btnchgparam.Name = "btnchgparam";
            this.btnchgparam.Size = new System.Drawing.Size(75, 23);
            this.btnchgparam.TabIndex = 0;
            // 
            // txtchgparam
            // 
            this.txtchgparam.Location = new System.Drawing.Point(0, 0);
            this.txtchgparam.Name = "txtchgparam";
            this.txtchgparam.Size = new System.Drawing.Size(100, 20);
            this.txtchgparam.TabIndex = 0;
            // 
            // cmbparam
            // 
            this.cmbparam.Location = new System.Drawing.Point(0, 0);
            this.cmbparam.Name = "cmbparam";
            this.cmbparam.Size = new System.Drawing.Size(121, 21);
            this.cmbparam.TabIndex = 0;
            // 
            // btnsetparam
            // 
            this.btnsetparam.Location = new System.Drawing.Point(0, 0);
            this.btnsetparam.Name = "btnsetparam";
            this.btnsetparam.Size = new System.Drawing.Size(75, 23);
            this.btnsetparam.TabIndex = 0;
            // 
            // btngetparam
            // 
            this.btngetparam.Location = new System.Drawing.Point(0, 0);
            this.btngetparam.Name = "btngetparam";
            this.btngetparam.Size = new System.Drawing.Size(75, 23);
            this.btngetparam.TabIndex = 0;
            // 
            // btncleparam
            // 
            this.btncleparam.Location = new System.Drawing.Point(0, 0);
            this.btncleparam.Name = "btncleparam";
            this.btncleparam.Size = new System.Drawing.Size(75, 23);
            this.btncleparam.TabIndex = 0;
            // 
            // btnselparam
            // 
            this.btnselparam.Location = new System.Drawing.Point(0, 0);
            this.btnselparam.Name = "btnselparam";
            this.btnselparam.Size = new System.Drawing.Size(75, 23);
            this.btnselparam.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // lsvselparam
            // 
            this.lsvselparam.Location = new System.Drawing.Point(0, 0);
            this.lsvselparam.Name = "lsvselparam";
            this.lsvselparam.Size = new System.Drawing.Size(121, 97);
            this.lsvselparam.TabIndex = 0;
            this.lsvselparam.UseCompatibleStateImageBehavior = false;
            // 
            // lsvpreparam
            // 
            this.lsvpreparam.Location = new System.Drawing.Point(0, 0);
            this.lsvpreparam.Name = "lsvpreparam";
            this.lsvpreparam.Size = new System.Drawing.Size(121, 97);
            this.lsvpreparam.TabIndex = 0;
            this.lsvpreparam.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // control_devie
            // 
            this.control_devie.Location = new System.Drawing.Point(0, 0);
            this.control_devie.Name = "control_devie";
            this.control_devie.Size = new System.Drawing.Size(200, 100);
            this.control_devie.TabIndex = 0;
            // 
            // txtAuxoutCount
            // 
            this.txtAuxoutCount.Location = new System.Drawing.Point(0, 0);
            this.txtAuxoutCount.Name = "txtAuxoutCount";
            this.txtAuxoutCount.Size = new System.Drawing.Size(100, 20);
            this.txtAuxoutCount.TabIndex = 0;
            // 
            // txtDoorCount
            // 
            this.txtDoorCount.Location = new System.Drawing.Point(0, 0);
            this.txtDoorCount.Name = "txtDoorCount";
            this.txtDoorCount.Size = new System.Drawing.Size(100, 20);
            this.txtDoorCount.TabIndex = 0;
            // 
            // labelStartOrOverValue
            // 
            this.labelStartOrOverValue.Location = new System.Drawing.Point(0, 0);
            this.labelStartOrOverValue.Name = "labelStartOrOverValue";
            this.labelStartOrOverValue.Size = new System.Drawing.Size(100, 23);
            this.labelStartOrOverValue.TabIndex = 0;
            // 
            // labelStartOrOver
            // 
            this.labelStartOrOver.Location = new System.Drawing.Point(0, 0);
            this.labelStartOrOver.Name = "labelStartOrOver";
            this.labelStartOrOver.Size = new System.Drawing.Size(100, 23);
            this.labelStartOrOver.TabIndex = 0;
            // 
            // cmbNorOpenOrNot
            // 
            this.cmbNorOpenOrNot.Location = new System.Drawing.Point(0, 0);
            this.cmbNorOpenOrNot.Name = "cmbNorOpenOrNot";
            this.cmbNorOpenOrNot.Size = new System.Drawing.Size(121, 21);
            this.cmbNorOpenOrNot.TabIndex = 0;
            // 
            // cmbAuxoutID
            // 
            this.cmbAuxoutID.Location = new System.Drawing.Point(0, 0);
            this.cmbAuxoutID.Name = "cmbAuxoutID";
            this.cmbAuxoutID.Size = new System.Drawing.Size(121, 21);
            this.cmbAuxoutID.TabIndex = 0;
            // 
            // labelAuxoutID
            // 
            this.labelAuxoutID.Location = new System.Drawing.Point(0, 0);
            this.labelAuxoutID.Name = "labelAuxoutID";
            this.labelAuxoutID.Size = new System.Drawing.Size(100, 23);
            this.labelAuxoutID.TabIndex = 0;
            // 
            // labelDoorActionValue
            // 
            this.labelDoorActionValue.Location = new System.Drawing.Point(0, 0);
            this.labelDoorActionValue.Name = "labelDoorActionValue";
            this.labelDoorActionValue.Size = new System.Drawing.Size(100, 23);
            this.labelDoorActionValue.TabIndex = 0;
            // 
            // txtDoorAction
            // 
            this.txtDoorAction.Location = new System.Drawing.Point(0, 0);
            this.txtDoorAction.Name = "txtDoorAction";
            this.txtDoorAction.Size = new System.Drawing.Size(100, 20);
            this.txtDoorAction.TabIndex = 0;
            // 
            // labelDoorAction
            // 
            this.labelDoorAction.Location = new System.Drawing.Point(0, 0);
            this.labelDoorAction.Name = "labelDoorAction";
            this.labelDoorAction.Size = new System.Drawing.Size(100, 23);
            this.labelDoorAction.TabIndex = 0;
            // 
            // labelAddrTypeValue
            // 
            this.labelAddrTypeValue.Location = new System.Drawing.Point(0, 0);
            this.labelAddrTypeValue.Name = "labelAddrTypeValue";
            this.labelAddrTypeValue.Size = new System.Drawing.Size(100, 23);
            this.labelAddrTypeValue.TabIndex = 0;
            // 
            // labelOperIDValue
            // 
            this.labelOperIDValue.Location = new System.Drawing.Point(0, 0);
            this.labelOperIDValue.Name = "labelOperIDValue";
            this.labelOperIDValue.Size = new System.Drawing.Size(100, 23);
            this.labelOperIDValue.TabIndex = 0;
            // 
            // btnDevControl
            // 
            this.btnDevControl.Location = new System.Drawing.Point(0, 0);
            this.btnDevControl.Name = "btnDevControl";
            this.btnDevControl.Size = new System.Drawing.Size(75, 23);
            this.btnDevControl.TabIndex = 0;
            // 
            // cmbDoorID
            // 
            this.cmbDoorID.Location = new System.Drawing.Point(0, 0);
            this.cmbDoorID.Name = "cmbDoorID";
            this.cmbDoorID.Size = new System.Drawing.Size(121, 21);
            this.cmbDoorID.TabIndex = 0;
            // 
            // labelAddrType
            // 
            this.labelAddrType.Location = new System.Drawing.Point(0, 0);
            this.labelAddrType.Name = "labelAddrType";
            this.labelAddrType.Size = new System.Drawing.Size(100, 23);
            this.labelAddrType.TabIndex = 0;
            // 
            // labelDoorID
            // 
            this.labelDoorID.Location = new System.Drawing.Point(0, 0);
            this.labelDoorID.Name = "labelDoorID";
            this.labelDoorID.Size = new System.Drawing.Size(100, 23);
            this.labelDoorID.TabIndex = 0;
            // 
            // labelOperID
            // 
            this.labelOperID.Location = new System.Drawing.Point(0, 0);
            this.labelOperID.Name = "labelOperID";
            this.labelOperID.Size = new System.Drawing.Size(100, 23);
            this.labelOperID.TabIndex = 0;
            // 
            // cmbOperID
            // 
            this.cmbOperID.Location = new System.Drawing.Point(0, 0);
            this.cmbOperID.Name = "cmbOperID";
            this.cmbOperID.Size = new System.Drawing.Size(121, 21);
            this.cmbOperID.TabIndex = 0;
            // 
            // labelControlDevice
            // 
            this.labelControlDevice.Location = new System.Drawing.Point(0, 0);
            this.labelControlDevice.Name = "labelControlDevice";
            this.labelControlDevice.Size = new System.Drawing.Size(100, 23);
            this.labelControlDevice.TabIndex = 0;
            // 
            // device_data
            // 
            this.device_data.Location = new System.Drawing.Point(0, 0);
            this.device_data.Name = "device_data";
            this.device_data.Size = new System.Drawing.Size(200, 100);
            this.device_data.TabIndex = 0;
            // 
            // btndelall
            // 
            this.btndelall.Location = new System.Drawing.Point(0, 0);
            this.btndelall.Name = "btndelall";
            this.btndelall.Size = new System.Drawing.Size(75, 23);
            this.btndelall.TabIndex = 0;
            // 
            // btndeldata
            // 
            this.btndeldata.Location = new System.Drawing.Point(0, 0);
            this.btndeldata.Name = "btndeldata";
            this.btndeldata.Size = new System.Drawing.Size(75, 23);
            this.btndeldata.TabIndex = 0;
            // 
            // txtgetdata10
            // 
            this.txtgetdata10.AcceptsReturn = true;
            this.txtgetdata10.AcceptsTab = true;
            this.txtgetdata10.Location = new System.Drawing.Point(89, 148);
            this.txtgetdata10.Multiline = true;
            this.txtgetdata10.Name = "txtgetdata10";
            this.txtgetdata10.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtgetdata10.Size = new System.Drawing.Size(254, 222);
            this.txtgetdata10.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            // 
            // btnclefil
            // 
            this.btnclefil.Location = new System.Drawing.Point(0, 0);
            this.btnclefil.Name = "btnclefil";
            this.btnclefil.Size = new System.Drawing.Size(75, 23);
            this.btnclefil.TabIndex = 0;
            // 
            // txtfilval
            // 
            this.txtfilval.Location = new System.Drawing.Point(0, 0);
            this.txtfilval.Name = "txtfilval";
            this.txtfilval.Size = new System.Drawing.Size(100, 20);
            this.txtfilval.TabIndex = 0;
            // 
            // txtfil
            // 
            this.txtfil.Location = new System.Drawing.Point(0, 0);
            this.txtfil.Name = "txtfil";
            this.txtfil.Size = new System.Drawing.Size(100, 20);
            this.txtfil.TabIndex = 0;
            // 
            // btnfil
            // 
            this.btnfil.Location = new System.Drawing.Point(0, 0);
            this.btnfil.Name = "btnfil";
            this.btnfil.Size = new System.Drawing.Size(75, 23);
            this.btnfil.TabIndex = 0;
            // 
            // cmbfil
            // 
            this.cmbfil.Location = new System.Drawing.Point(0, 0);
            this.cmbfil.Name = "cmbfil";
            this.cmbfil.Size = new System.Drawing.Size(121, 21);
            this.cmbfil.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // grabar
            // 
            this.grabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grabar.Location = new System.Drawing.Point(4, 148);
            this.grabar.Name = "grabar";
            this.grabar.Size = new System.Drawing.Size(79, 33);
            this.grabar.TabIndex = 5;
            this.grabar.Text = "Leer";
            this.grabar.UseVisualStyleBackColor = true;
            this.grabar.Click += new System.EventHandler(this.grabar_Click);
            // 
            // grabar_2
            // 
            this.grabar_2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grabar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grabar_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grabar_2.Location = new System.Drawing.Point(349, 146);
            this.grabar_2.Name = "grabar_2";
            this.grabar_2.Size = new System.Drawing.Size(79, 33);
            this.grabar_2.TabIndex = 20;
            this.grabar_2.Text = "Grabar";
            this.grabar_2.UseVisualStyleBackColor = false;
            this.grabar_2.Click += new System.EventHandler(this.grabar_2_Click_1);
            // 
            // txtdev1
            // 
            this.txtdev1.AcceptsReturn = true;
            this.txtdev1.AcceptsTab = true;
            this.txtdev1.Location = new System.Drawing.Point(79, 47);
            this.txtdev1.Multiline = true;
            this.txtdev1.Name = "txtdev1";
            this.txtdev1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdev1.Size = new System.Drawing.Size(229, 108);
            this.txtdev1.TabIndex = 2;
            // 
            // cmbdevtable
            // 
            this.cmbdevtable.FormattingEnabled = true;
            this.cmbdevtable.Items.AddRange(new object[] {
            "user",
            "userauthorize",
            "holiday",
            "timezone",
            "transaction",
            "firstcard",
            "multimcard",
            "inoutfun",
            "templatev10"});
            this.cmbdevtable.Location = new System.Drawing.Point(25, 104);
            this.cmbdevtable.Name = "cmbdevtable";
            this.cmbdevtable.Size = new System.Drawing.Size(583, 21);
            this.cmbdevtable.TabIndex = 22;
            this.cmbdevtable.DropDownClosed += new System.EventHandler(this.cmbdevtable_DropDownClosed);
            // 
            // rt_log
            // 
            this.rt_log.Location = new System.Drawing.Point(0, 0);
            this.rt_log.Name = "rt_log";
            this.rt_log.Size = new System.Drawing.Size(200, 100);
            this.rt_log.TabIndex = 0;
            // 
            // btncls
            // 
            this.btncls.Location = new System.Drawing.Point(0, 0);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(75, 23);
            this.btncls.TabIndex = 0;
            // 
            // btnrtlogstart
            // 
            this.btnrtlogstart.Location = new System.Drawing.Point(0, 0);
            this.btnrtlogstart.Name = "btnrtlogstart";
            this.btnrtlogstart.Size = new System.Drawing.Size(75, 23);
            this.btnrtlogstart.TabIndex = 0;
            // 
            // btnrtlogstop
            // 
            this.btnrtlogstop.Location = new System.Drawing.Point(0, 0);
            this.btnrtlogstop.Name = "btnrtlogstop";
            this.btnrtlogstop.Size = new System.Drawing.Size(75, 23);
            this.btnrtlogstop.TabIndex = 0;
            // 
            // lsvrtlog
            // 
            this.lsvrtlog.Location = new System.Drawing.Point(0, 0);
            this.lsvrtlog.Name = "lsvrtlog";
            this.lsvrtlog.Size = new System.Drawing.Size(121, 97);
            this.lsvrtlog.TabIndex = 0;
            this.lsvrtlog.UseCompatibleStateImageBehavior = false;
            // 
            // search_device
            // 
            this.search_device.Location = new System.Drawing.Point(0, 0);
            this.search_device.Name = "search_device";
            this.search_device.Size = new System.Drawing.Size(200, 100);
            this.search_device.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 0;
            // 
            // txtnewip
            // 
            this.txtnewip.Location = new System.Drawing.Point(0, 0);
            this.txtnewip.Name = "txtnewip";
            this.txtnewip.Size = new System.Drawing.Size(100, 20);
            this.txtnewip.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 0;
            // 
            // cmbseardev
            // 
            this.cmbseardev.Location = new System.Drawing.Point(0, 0);
            this.cmbseardev.Name = "cmbseardev";
            this.cmbseardev.Size = new System.Drawing.Size(121, 21);
            this.cmbseardev.TabIndex = 0;
            // 
            // lsvseardev
            // 
            this.lsvseardev.Location = new System.Drawing.Point(0, 0);
            this.lsvseardev.Name = "lsvseardev";
            this.lsvseardev.Size = new System.Drawing.Size(121, 97);
            this.lsvseardev.TabIndex = 0;
            this.lsvseardev.UseCompatibleStateImageBehavior = false;
            // 
            // btnmodip
            // 
            this.btnmodip.Location = new System.Drawing.Point(0, 0);
            this.btnmodip.Name = "btnmodip";
            this.btnmodip.Size = new System.Drawing.Size(75, 23);
            this.btnmodip.TabIndex = 0;
            // 
            // btnseardev
            // 
            this.btnseardev.Location = new System.Drawing.Point(0, 0);
            this.btnseardev.Name = "btnseardev";
            this.btnseardev.Size = new System.Drawing.Size(75, 23);
            this.btnseardev.TabIndex = 0;
            // 
            // device_file
            // 
            this.device_file.Location = new System.Drawing.Point(0, 0);
            this.device_file.Name = "device_file";
            this.device_file.Size = new System.Drawing.Size(200, 100);
            this.device_file.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // txtSDData
            // 
            this.txtSDData.Location = new System.Drawing.Point(0, 0);
            this.txtSDData.Name = "txtSDData";
            this.txtSDData.Size = new System.Drawing.Size(100, 20);
            this.txtSDData.TabIndex = 0;
            // 
            // btnParseSDData
            // 
            this.btnParseSDData.Location = new System.Drawing.Point(0, 0);
            this.btnParseSDData.Name = "btnParseSDData";
            this.btnParseSDData.Size = new System.Drawing.Size(75, 23);
            this.btnParseSDData.TabIndex = 0;
            // 
            // btnTarFile
            // 
            this.btnTarFile.Location = new System.Drawing.Point(0, 0);
            this.btnTarFile.Name = "btnTarFile";
            this.btnTarFile.Size = new System.Drawing.Size(75, 23);
            this.btnTarFile.TabIndex = 0;
            // 
            // txtTarFile
            // 
            this.txtTarFile.Location = new System.Drawing.Point(0, 0);
            this.txtTarFile.Name = "txtTarFile";
            this.txtTarFile.Size = new System.Drawing.Size(100, 20);
            this.txtTarFile.TabIndex = 0;
            // 
            // btnSetDevFile
            // 
            this.btnSetDevFile.Location = new System.Drawing.Point(0, 0);
            this.btnSetDevFile.Name = "btnSetDevFile";
            this.btnSetDevFile.Size = new System.Drawing.Size(75, 23);
            this.btnSetDevFile.TabIndex = 0;
            // 
            // labelTarFileChoose
            // 
            this.labelTarFileChoose.Location = new System.Drawing.Point(0, 0);
            this.labelTarFileChoose.Name = "labelTarFileChoose";
            this.labelTarFileChoose.Size = new System.Drawing.Size(100, 23);
            this.labelTarFileChoose.TabIndex = 0;
            // 
            // btnGetDevFile
            // 
            this.btnGetDevFile.Location = new System.Drawing.Point(0, 0);
            this.btnGetDevFile.Name = "btnGetDevFile";
            this.btnGetDevFile.Size = new System.Drawing.Size(75, 23);
            this.btnGetDevFile.TabIndex = 0;
            // 
            // txtGetDevFile
            // 
            this.txtGetDevFile.Location = new System.Drawing.Point(0, 0);
            this.txtGetDevFile.Name = "txtGetDevFile";
            this.txtGetDevFile.Size = new System.Drawing.Size(100, 20);
            this.txtGetDevFile.TabIndex = 0;
            // 
            // labelDevFile
            // 
            this.labelDevFile.Location = new System.Drawing.Point(0, 0);
            this.labelDevFile.Name = "labelDevFile";
            this.labelDevFile.Size = new System.Drawing.Size(100, 23);
            this.labelDevFile.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(0, 0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(200, 100);
            this.tabPage7.TabIndex = 0;
            // 
            // forceFPMake
            // 
            this.forceFPMake.Location = new System.Drawing.Point(0, 0);
            this.forceFPMake.Name = "forceFPMake";
            this.forceFPMake.Size = new System.Drawing.Size(104, 24);
            this.forceFPMake.TabIndex = 0;
            // 
            // txtFingerID
            // 
            this.txtFingerID.Location = new System.Drawing.Point(0, 0);
            this.txtFingerID.Name = "txtFingerID";
            this.txtFingerID.Size = new System.Drawing.Size(100, 20);
            this.txtFingerID.TabIndex = 0;
            // 
            // labelFingerID
            // 
            this.labelFingerID.Location = new System.Drawing.Point(0, 0);
            this.labelFingerID.Name = "labelFingerID";
            this.labelFingerID.Size = new System.Drawing.Size(100, 23);
            this.labelFingerID.TabIndex = 0;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(0, 0);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 0;
            // 
            // labelPin
            // 
            this.labelPin.Location = new System.Drawing.Point(0, 0);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(100, 23);
            this.labelPin.TabIndex = 0;
            // 
            // labelFingerPrint
            // 
            this.labelFingerPrint.Location = new System.Drawing.Point(0, 0);
            this.labelFingerPrint.Name = "labelFingerPrint";
            this.labelFingerPrint.Size = new System.Drawing.Size(100, 23);
            this.labelFingerPrint.TabIndex = 0;
            // 
            // btnUploadFP
            // 
            this.btnUploadFP.Location = new System.Drawing.Point(0, 0);
            this.btnUploadFP.Name = "btnUploadFP";
            this.btnUploadFP.Size = new System.Drawing.Size(75, 23);
            this.btnUploadFP.TabIndex = 0;
            // 
            // axAFXOnlineMain
            // 
            this.axAFXOnlineMain.Location = new System.Drawing.Point(0, 0);
            this.axAFXOnlineMain.Name = "axAFXOnlineMain";
            this.axAFXOnlineMain.TabIndex = 0;
            // 
            // txtTemplateDatas
            // 
            this.txtTemplateDatas.Location = new System.Drawing.Point(0, 0);
            this.txtTemplateDatas.Name = "txtTemplateDatas";
            this.txtTemplateDatas.Size = new System.Drawing.Size(100, 20);
            this.txtTemplateDatas.TabIndex = 0;
            // 
            // btnVerifyfp
            // 
            this.btnVerifyfp.Location = new System.Drawing.Point(0, 0);
            this.btnVerifyfp.Name = "btnVerifyfp";
            this.btnVerifyfp.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyfp.TabIndex = 0;
            // 
            // btnRegsterFingerprint
            // 
            this.btnRegsterFingerprint.Location = new System.Drawing.Point(0, 0);
            this.btnRegsterFingerprint.Name = "btnRegsterFingerprint";
            this.btnRegsterFingerprint.Size = new System.Drawing.Size(75, 23);
            this.btnRegsterFingerprint.TabIndex = 0;
            // 
            // labelTemplateDatas
            // 
            this.labelTemplateDatas.Location = new System.Drawing.Point(0, 0);
            this.labelTemplateDatas.Name = "labelTemplateDatas";
            this.labelTemplateDatas.Size = new System.Drawing.Size(100, 23);
            this.labelTemplateDatas.TabIndex = 0;
            // 
            // labsearchdev
            // 
            this.labsearchdev.Location = new System.Drawing.Point(0, 0);
            this.labsearchdev.Name = "labsearchdev";
            this.labsearchdev.Size = new System.Drawing.Size(100, 23);
            this.labsearchdev.TabIndex = 0;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 23);
            this.label22.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(121, 97);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 23);
            this.label23.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 23);
            this.label24.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 23);
            this.label25.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 23);
            this.label26.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 23);
            this.label27.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(0, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.Location = new System.Drawing.Point(0, 0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 23);
            this.label28.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 23);
            this.label29.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(0, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 23);
            this.label30.TabIndex = 0;
            // 
            // comboBox4
            // 
            this.comboBox4.Location = new System.Drawing.Point(0, 0);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 0;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(0, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 23);
            this.label31.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(0, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 23);
            this.label32.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 0;
            // 
            // comboBox5
            // 
            this.comboBox5.Location = new System.Drawing.Point(0, 0);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 0;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(0, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(100, 23);
            this.label33.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(0, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 23);
            this.label34.TabIndex = 0;
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(0, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(100, 23);
            this.label35.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 0;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 0;
            // 
            // comboBox6
            // 
            this.comboBox6.Location = new System.Drawing.Point(0, 0);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 0;
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(0, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(100, 23);
            this.label36.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(200, 100);
            this.tabPage4.TabIndex = 0;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(0, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 0;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(0, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 0;
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(0, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(121, 97);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(0, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(200, 100);
            this.tabPage5.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(0, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 0;
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(100, 23);
            this.label37.TabIndex = 0;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(0, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(100, 23);
            this.label38.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(0, 0);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 0;
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(0, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(100, 23);
            this.label39.TabIndex = 0;
            // 
            // comboBox7
            // 
            this.comboBox7.Location = new System.Drawing.Point(0, 0);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 0;
            // 
            // listView4
            // 
            this.listView4.Location = new System.Drawing.Point(0, 0);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(121, 97);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(0, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 0;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(0, 0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(0, 0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(200, 100);
            this.tabPage6.TabIndex = 0;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(0, 0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(0, 0);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 0;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(0, 0);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 0;
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(0, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(100, 23);
            this.label40.TabIndex = 0;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(0, 0);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 0;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(0, 0);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 0;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(0, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(100, 23);
            this.label41.TabIndex = 0;
            // 
            // button21
            // 
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(349, 58);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(142, 67);
            this.button21.TabIndex = 9;
            this.button21.Text = "Conectar";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // borrar
            // 
            this.borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.borrar.Location = new System.Drawing.Point(4, 268);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(79, 35);
            this.borrar.TabIndex = 21;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // button22
            // 
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button22.Location = new System.Drawing.Point(4, 206);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(79, 35);
            this.button22.TabIndex = 23;
            this.button22.Text = "Actualizar";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(4, 349);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(12, 21);
            this.textBox11.TabIndex = 22;
            this.textBox11.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(430, 148);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(249, 29);
            this.textBox12.TabIndex = 24;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(349, 267);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(156, 33);
            this.button24.TabIndex = 25;
            this.button24.Text = "Ituzaingo";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            this.button24.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button24_MouseClick);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(349, 206);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(156, 33);
            this.button25.TabIndex = 26;
            this.button25.Text = "Roma";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            this.button25.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button25_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(687, 382);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.grabar_2);
            this.Controls.Add(this.txtgetdata10);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.grabar);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.txt_tcp);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uno Nuevas Tecnologias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAFXOnlineMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tcp;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txt485;
        private System.Windows.Forms.RadioButton radbtn485;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.TabControl tabControlFingerPrint;
        private System.Windows.Forms.TabPage device_param;
        private System.Windows.Forms.TabPage control_devie;
        private System.Windows.Forms.TabPage device_data;
        private System.Windows.Forms.TabPage rt_log;
        private System.Windows.Forms.TabPage search_device;
        private System.Windows.Forms.TabPage device_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvpreparam;
        private System.Windows.Forms.ColumnHeader laname;
        private System.Windows.Forms.ColumnHeader lvremarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvselparam;
        private System.Windows.Forms.ColumnHeader param3;
        private System.Windows.Forms.Button btnsetparam;
        private System.Windows.Forms.Button btngetparam;
        private System.Windows.Forms.Button btncleparam;
        private System.Windows.Forms.Button btnselparam;
        private System.Windows.Forms.Label labelControlDevice;
        private System.Windows.Forms.ComboBox cmbOperID;
        private System.Windows.Forms.Label labelOperID;
        private System.Windows.Forms.ComboBox cmbDoorID;
        private System.Windows.Forms.Label labelAddrType;
        private System.Windows.Forms.Label labelDoorID;
        private System.Windows.Forms.Button btnDevControl;
        private System.Windows.Forms.TextBox txtdev1;
        private System.Windows.Forms.ComboBox cmbdevtable;
        private System.Windows.Forms.Button grabar;
        private System.Windows.Forms.Button grabar_2;
        private System.Windows.Forms.ListView lsvrtlog;
        private System.Windows.Forms.Button btnrtlogstart;
        private System.Windows.Forms.Button btnrtlogstop;
        private System.Windows.Forms.ColumnHeader coltime;
        private System.Windows.Forms.ColumnHeader colpin;
        private System.Windows.Forms.ColumnHeader colcardno;
        private System.Windows.Forms.ColumnHeader coldoorid;
        private System.Windows.Forms.Button btnmodip;
        private System.Windows.Forms.Button btnseardev;
        public System.Windows.Forms.ColumnHeader param4;
        private System.Windows.Forms.ComboBox cmbparam;
        private System.Windows.Forms.TextBox txtchgparam;
        private System.Windows.Forms.Button btnchgparam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelOperIDValue;
        private System.Windows.Forms.Label labelAddrTypeValue;
        private System.Windows.Forms.ComboBox cmbOutAddr;
        private System.Windows.Forms.Label labelDoorAction;
        private System.Windows.Forms.Label labelDoorActionValue;
        private System.Windows.Forms.TextBox txtDoorAction;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtfil;
        private System.Windows.Forms.Button btnfil;
        private System.Windows.Forms.ComboBox cmbfil;
        private System.Windows.Forms.TextBox txtfilval;
        private System.Windows.Forms.Button btnclefil;
        private System.Windows.Forms.TextBox txtgetdata10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader colevtype;
        private System.Windows.Forms.ColumnHeader colInOutState;
        private System.Windows.Forms.ColumnHeader colvermode;
        private System.Windows.Forms.Timer trglog;
        private System.Windows.Forms.ListView lsvseardev;
        private System.Windows.Forms.ColumnHeader colmac;
        private System.Windows.Forms.ColumnHeader colip;
        private System.Windows.Forms.ColumnHeader colsn;
        private System.Windows.Forms.ColumnHeader coldev;
        private System.Windows.Forms.ColumnHeader colver;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtnewip;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbseardev;
        private System.Windows.Forms.Label labelDevFile;
        private System.Windows.Forms.Label labelTarFileChoose;
        private System.Windows.Forms.Button btnGetDevFile;
        private System.Windows.Forms.TextBox txtGetDevFile;
        private System.Windows.Forms.Button btnSetDevFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnTarFile;
        private System.Windows.Forms.TextBox txtTarFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btndeldata;
        private System.Windows.Forms.Label labsearchdev;
        private System.Windows.Forms.Button btndelall;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label labelTemplateDatas;
        private System.Windows.Forms.Button btnRegsterFingerprint;
        // private Axzkemkeeper.AxCZKEM axCZKEM1;

        private System.Windows.Forms.Button btnVerifyfp;
        private System.Windows.Forms.TextBox txtTemplateDatas;
        private Axzkonline.AxAFXOnlineMain axAFXOnlineMain;
        private System.Windows.Forms.Button btnUploadFP;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.Label labelFingerPrint;
        private System.Windows.Forms.TextBox txtFingerID;
        private System.Windows.Forms.Label labelFingerID;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.CheckBox forceFPMake;
        private System.Windows.Forms.Button btnParseSDData;
        private System.Windows.Forms.TextBox txtSDData;
        private System.Windows.Forms.ComboBox cmbAuxoutID;
        private System.Windows.Forms.Label labelAuxoutID;
        private System.Windows.Forms.Label labelStartOrOver;
        private System.Windows.Forms.ComboBox cmbNorOpenOrNot;
        private System.Windows.Forms.Label labelStartOrOverValue;
        private System.Windows.Forms.TextBox txtAuxoutCount;
        private System.Windows.Forms.TextBox txtDoorCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncls;
        private System.Windows.Forms.Button btnDeleteFP;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
       
        
        
        
        
        
        
        
        
        





        public System.Windows.Forms.TextBox txtde1 { get; set; }



        public System.Windows.Forms.Button grabar1 { get; set; }

        public System.EventHandler btndatcount_Click_1 { get; set; }



        public System.EventHandler txtdev1_TextChanged { get; set; }

        
    }
}


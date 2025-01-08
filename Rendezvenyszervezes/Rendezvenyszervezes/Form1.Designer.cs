namespace Rendezvenyszervezes
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
			System.Windows.Forms.Label label13;
			System.Windows.Forms.Label label14;
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btn_refreshEvents = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.dgw_events = new System.Windows.Forms.DataGridView();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.dgw_equipments = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_refreshtables = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgw_trucks = new System.Windows.Forms.DataGridView();
			this.lb_carNumber = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tb_eventId = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.tb_truckId = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.tb_equipmentId = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.nud_equipmentVolume = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			this.tb_equipmentLocation = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.tb_equipmentName = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.btn_addEquipment = new System.Windows.Forms.Button();
			this.tb_truckLocation = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_addCars = new System.Windows.Forms.Button();
			this.btn_addEvent = new System.Windows.Forms.Button();
			this.btn_addProp_newevent = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tb_propId_adding = new System.Windows.Forms.TextBox();
			this.nud_propQuantity_adding = new System.Windows.Forms.NumericUpDown();
			this.cb_eventType = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.dtp_eventEnds = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.dtp_eventStarts = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_eventVenue = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dgw_eventequipment = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_eventId_Find = new System.Windows.Forms.TextBox();
			this.btn_evaluateEvent = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.dgw_eventequipments_inspection = new System.Windows.Forms.DataGridView();
			this.lbl_eventcanbe = new System.Windows.Forms.Label();
			this.lbl_venue = new System.Windows.Forms.Label();
			this.lbl_type = new System.Windows.Forms.Label();
			this.lbl_start = new System.Windows.Forms.Label();
			this.lbl_end = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_events)).BeginInit();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_equipments)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_trucks)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_equipmentVolume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_propQuantity_adding)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_eventequipment)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_eventequipments_inspection)).BeginInit();
			this.SuspendLayout();
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			label13.Location = new System.Drawing.Point(361, 15);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(150, 25);
			label13.TabIndex = 21;
			label13.Text = "Új autó felvétele";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			label14.Location = new System.Drawing.Point(361, 128);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(183, 25);
			label14.TabIndex = 25;
			label14.Text = "Új kellékek felvétele";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btn_refreshEvents);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.dgw_events);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 400);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Rendezvények";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btn_refreshEvents
			// 
			this.btn_refreshEvents.Location = new System.Drawing.Point(6, 6);
			this.btn_refreshEvents.Name = "btn_refreshEvents";
			this.btn_refreshEvents.Size = new System.Drawing.Size(75, 23);
			this.btn_refreshEvents.TabIndex = 2;
			this.btn_refreshEvents.Text = "Frissítés";
			this.btn_refreshEvents.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(272, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(195, 31);
			this.label6.TabIndex = 1;
			this.label6.Text = "Rendezvények";
			// 
			// dgw_events
			// 
			this.dgw_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_events.Location = new System.Drawing.Point(6, 65);
			this.dgw_events.Name = "dgw_events";
			this.dgw_events.ReadOnly = true;
			this.dgw_events.Size = new System.Drawing.Size(762, 332);
			this.dgw_events.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(768, 400);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Erőforrások";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.dgw_equipments);
			this.panel2.Location = new System.Drawing.Point(6, 202);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(756, 195);
			this.panel2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(343, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Kellékek";
			// 
			// dgw_equipments
			// 
			this.dgw_equipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgw_equipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_equipments.Location = new System.Drawing.Point(-3, 45);
			this.dgw_equipments.Name = "dgw_equipments";
			this.dgw_equipments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgw_equipments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgw_equipments.Size = new System.Drawing.Size(753, 144);
			this.dgw_equipments.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.btn_refreshtables);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dgw_trucks);
			this.panel1.Controls.Add(this.lb_carNumber);
			this.panel1.Location = new System.Drawing.Point(6, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(756, 190);
			this.panel1.TabIndex = 0;
			// 
			// btn_refreshtables
			// 
			this.btn_refreshtables.Location = new System.Drawing.Point(13, 22);
			this.btn_refreshtables.Name = "btn_refreshtables";
			this.btn_refreshtables.Size = new System.Drawing.Size(75, 23);
			this.btn_refreshtables.TabIndex = 5;
			this.btn_refreshtables.Text = "Frissítés";
			this.btn_refreshtables.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(287, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Elérhető autók:";
			// 
			// dgw_trucks
			// 
			this.dgw_trucks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgw_trucks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_trucks.Location = new System.Drawing.Point(3, 64);
			this.dgw_trucks.Name = "dgw_trucks";
			this.dgw_trucks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgw_trucks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgw_trucks.Size = new System.Drawing.Size(750, 126);
			this.dgw_trucks.TabIndex = 4;
			// 
			// lb_carNumber
			// 
			this.lb_carNumber.AutoSize = true;
			this.lb_carNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lb_carNumber.Location = new System.Drawing.Point(436, 22);
			this.lb_carNumber.Name = "lb_carNumber";
			this.lb_carNumber.Size = new System.Drawing.Size(23, 25);
			this.lb_carNumber.TabIndex = 0;
			this.lb_carNumber.Text = "0";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 426);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.dgw_eventequipment);
			this.tabPage4.Controls.Add(this.tb_eventId);
			this.tabPage4.Controls.Add(this.label20);
			this.tabPage4.Controls.Add(this.tb_truckId);
			this.tabPage4.Controls.Add(this.label19);
			this.tabPage4.Controls.Add(this.tb_equipmentId);
			this.tabPage4.Controls.Add(this.label18);
			this.tabPage4.Controls.Add(this.nud_equipmentVolume);
			this.tabPage4.Controls.Add(this.label17);
			this.tabPage4.Controls.Add(this.tb_equipmentLocation);
			this.tabPage4.Controls.Add(this.label16);
			this.tabPage4.Controls.Add(this.tb_equipmentName);
			this.tabPage4.Controls.Add(label14);
			this.tabPage4.Controls.Add(this.label15);
			this.tabPage4.Controls.Add(this.btn_addEquipment);
			this.tabPage4.Controls.Add(this.tb_truckLocation);
			this.tabPage4.Controls.Add(label13);
			this.tabPage4.Controls.Add(this.label3);
			this.tabPage4.Controls.Add(this.btn_addCars);
			this.tabPage4.Controls.Add(this.btn_addEvent);
			this.tabPage4.Controls.Add(this.btn_addProp_newevent);
			this.tabPage4.Controls.Add(this.label12);
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Controls.Add(this.tb_propId_adding);
			this.tabPage4.Controls.Add(this.nud_propQuantity_adding);
			this.tabPage4.Controls.Add(this.cb_eventType);
			this.tabPage4.Controls.Add(this.label10);
			this.tabPage4.Controls.Add(this.dtp_eventEnds);
			this.tabPage4.Controls.Add(this.label9);
			this.tabPage4.Controls.Add(this.dtp_eventStarts);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Controls.Add(this.tb_eventVenue);
			this.tabPage4.Controls.Add(this.label7);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(768, 400);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Hozzáadás";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tb_eventId
			// 
			this.tb_eventId.Location = new System.Drawing.Point(148, 24);
			this.tb_eventId.Name = "tb_eventId";
			this.tb_eventId.Size = new System.Drawing.Size(200, 20);
			this.tb_eventId.TabIndex = 35;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(27, 27);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(128, 13);
			this.label20.TabIndex = 34;
			this.label20.Text = "Rendezvény azonosítója:";
			// 
			// tb_truckId
			// 
			this.tb_truckId.Location = new System.Drawing.Point(419, 48);
			this.tb_truckId.Name = "tb_truckId";
			this.tb_truckId.Size = new System.Drawing.Size(166, 20);
			this.tb_truckId.TabIndex = 9;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(357, 48);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(58, 13);
			this.label19.TabIndex = 33;
			this.label19.Text = "Azonosító:";
			// 
			// tb_equipmentId
			// 
			this.tb_equipmentId.Location = new System.Drawing.Point(419, 168);
			this.tb_equipmentId.Name = "tb_equipmentId";
			this.tb_equipmentId.Size = new System.Drawing.Size(166, 20);
			this.tb_equipmentId.TabIndex = 12;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(357, 168);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(58, 13);
			this.label18.TabIndex = 31;
			this.label18.Text = "Azonosító:";
			// 
			// nud_equipmentVolume
			// 
			this.nud_equipmentVolume.Location = new System.Drawing.Point(419, 243);
			this.nud_equipmentVolume.Name = "nud_equipmentVolume";
			this.nud_equipmentVolume.Size = new System.Drawing.Size(166, 20);
			this.nud_equipmentVolume.TabIndex = 15;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(357, 243);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(63, 13);
			this.label17.TabIndex = 29;
			this.label17.Text = "Darabszám:";
			// 
			// tb_equipmentLocation
			// 
			this.tb_equipmentLocation.Location = new System.Drawing.Point(419, 219);
			this.tb_equipmentLocation.Name = "tb_equipmentLocation";
			this.tb_equipmentLocation.Size = new System.Drawing.Size(166, 20);
			this.tb_equipmentLocation.TabIndex = 14;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(357, 219);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(56, 13);
			this.label16.TabIndex = 27;
			this.label16.Text = "Telephely:";
			// 
			// tb_equipmentName
			// 
			this.tb_equipmentName.Location = new System.Drawing.Point(419, 194);
			this.tb_equipmentName.Name = "tb_equipmentName";
			this.tb_equipmentName.Size = new System.Drawing.Size(166, 20);
			this.tb_equipmentName.TabIndex = 13;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(357, 194);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(30, 13);
			this.label15.TabIndex = 24;
			this.label15.Text = "Név:";
			// 
			// btn_addEquipment
			// 
			this.btn_addEquipment.Location = new System.Drawing.Point(360, 268);
			this.btn_addEquipment.Name = "btn_addEquipment";
			this.btn_addEquipment.Size = new System.Drawing.Size(151, 23);
			this.btn_addEquipment.TabIndex = 16;
			this.btn_addEquipment.Text = "Kellék hozzáadása";
			this.btn_addEquipment.UseVisualStyleBackColor = true;
			// 
			// tb_truckLocation
			// 
			this.tb_truckLocation.Location = new System.Drawing.Point(419, 74);
			this.tb_truckLocation.Name = "tb_truckLocation";
			this.tb_truckLocation.Size = new System.Drawing.Size(166, 20);
			this.tb_truckLocation.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(357, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 20;
			this.label3.Text = "Telephely:";
			// 
			// btn_addCars
			// 
			this.btn_addCars.Location = new System.Drawing.Point(360, 95);
			this.btn_addCars.Name = "btn_addCars";
			this.btn_addCars.Size = new System.Drawing.Size(151, 23);
			this.btn_addCars.TabIndex = 11;
			this.btn_addCars.Text = "Autó hozzáadása";
			this.btn_addCars.UseVisualStyleBackColor = true;
			// 
			// btn_addEvent
			// 
			this.btn_addEvent.Location = new System.Drawing.Point(68, 360);
			this.btn_addEvent.Name = "btn_addEvent";
			this.btn_addEvent.Size = new System.Drawing.Size(227, 37);
			this.btn_addEvent.TabIndex = 8;
			this.btn_addEvent.Text = "Rendezvény hozzáadása";
			this.btn_addEvent.UseVisualStyleBackColor = true;
			// 
			// btn_addProp_newevent
			// 
			this.btn_addProp_newevent.BackColor = System.Drawing.Color.LightGray;
			this.btn_addProp_newevent.Location = new System.Drawing.Point(148, 204);
			this.btn_addProp_newevent.Name = "btn_addProp_newevent";
			this.btn_addProp_newevent.Size = new System.Drawing.Size(200, 23);
			this.btn_addProp_newevent.TabIndex = 7;
			this.btn_addProp_newevent.Text = "Kellék felvétele";
			this.btn_addProp_newevent.UseVisualStyleBackColor = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(27, 180);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(98, 13);
			this.label12.TabIndex = 15;
			this.label12.Text = "Kellék mennyisége:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(27, 154);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(97, 13);
			this.label11.TabIndex = 14;
			this.label11.Text = "Kellék azonosítója:";
			// 
			// tb_propId_adding
			// 
			this.tb_propId_adding.Location = new System.Drawing.Point(148, 151);
			this.tb_propId_adding.Name = "tb_propId_adding";
			this.tb_propId_adding.Size = new System.Drawing.Size(200, 20);
			this.tb_propId_adding.TabIndex = 5;
			// 
			// nud_propQuantity_adding
			// 
			this.nud_propQuantity_adding.Location = new System.Drawing.Point(148, 178);
			this.nud_propQuantity_adding.Name = "nud_propQuantity_adding";
			this.nud_propQuantity_adding.Size = new System.Drawing.Size(200, 20);
			this.nud_propQuantity_adding.TabIndex = 6;
			// 
			// cb_eventType
			// 
			this.cb_eventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_eventType.FormattingEnabled = true;
			this.cb_eventType.Items.AddRange(new object[] {
            "ülő",
            "álló",
            "vegyes",
            "étkezés nélkül"});
			this.cb_eventType.Location = new System.Drawing.Point(148, 124);
			this.cb_eventType.Name = "cb_eventType";
			this.cb_eventType.Size = new System.Drawing.Size(200, 21);
			this.cb_eventType.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(27, 128);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(103, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "Rendezvény típusa:";
			// 
			// dtp_eventEnds
			// 
			this.dtp_eventEnds.Location = new System.Drawing.Point(148, 98);
			this.dtp_eventEnds.Name = "dtp_eventEnds";
			this.dtp_eventEnds.Size = new System.Drawing.Size(200, 20);
			this.dtp_eventEnds.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(27, 101);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(97, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Rendezvény vége:";
			// 
			// dtp_eventStarts
			// 
			this.dtp_eventStarts.Location = new System.Drawing.Point(148, 72);
			this.dtp_eventStarts.Name = "dtp_eventStarts";
			this.dtp_eventStarts.Size = new System.Drawing.Size(200, 20);
			this.dtp_eventStarts.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(27, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(111, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Rendezvény kezdete:";
			// 
			// tb_eventVenue
			// 
			this.tb_eventVenue.Location = new System.Drawing.Point(148, 46);
			this.tb_eventVenue.Name = "tb_eventVenue";
			this.tb_eventVenue.Size = new System.Drawing.Size(200, 20);
			this.tb_eventVenue.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(27, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(118, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Rendezvény helyszíne:";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.panel3);
			this.tabPage3.Controls.Add(this.btn_evaluateEvent);
			this.tabPage3.Controls.Add(this.tb_eventId_Find);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(768, 400);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Rendezvény tervezés";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dgw_eventequipment
			// 
			this.dgw_eventequipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_eventequipment.Location = new System.Drawing.Point(30, 233);
			this.dgw_eventequipment.Name = "dgw_eventequipment";
			this.dgw_eventequipment.Size = new System.Drawing.Size(318, 98);
			this.dgw_eventequipment.TabIndex = 36;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(194, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "A rendezvény azonosítója:";
			// 
			// tb_eventId_Find
			// 
			this.tb_eventId_Find.Location = new System.Drawing.Point(203, 9);
			this.tb_eventId_Find.Name = "tb_eventId_Find";
			this.tb_eventId_Find.Size = new System.Drawing.Size(105, 20);
			this.tb_eventId_Find.TabIndex = 1;
			// 
			// btn_evaluateEvent
			// 
			this.btn_evaluateEvent.Location = new System.Drawing.Point(314, 9);
			this.btn_evaluateEvent.Name = "btn_evaluateEvent";
			this.btn_evaluateEvent.Size = new System.Drawing.Size(75, 23);
			this.btn_evaluateEvent.TabIndex = 2;
			this.btn_evaluateEvent.Text = "Mehet";
			this.btn_evaluateEvent.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lbl_end);
			this.panel3.Controls.Add(this.lbl_start);
			this.panel3.Controls.Add(this.lbl_type);
			this.panel3.Controls.Add(this.lbl_venue);
			this.panel3.Controls.Add(this.lbl_eventcanbe);
			this.panel3.Controls.Add(this.dgw_eventequipments_inspection);
			this.panel3.Controls.Add(this.label24);
			this.panel3.Controls.Add(this.label23);
			this.panel3.Controls.Add(this.label22);
			this.panel3.Controls.Add(this.label21);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(7, 50);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(758, 347);
			this.panel3.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Helyszín:";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(3, 38);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(51, 20);
			this.label21.TabIndex = 2;
			this.label21.Text = "Típus:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(3, 68);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(63, 20);
			this.label22.TabIndex = 3;
			this.label22.Text = "Kezdet:";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(3, 102);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(51, 20);
			this.label23.TabIndex = 4;
			this.label23.Text = "Vége:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(389, 9);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(68, 20);
			this.label24.TabIndex = 5;
			this.label24.Text = "Kellékek";
			// 
			// dgw_eventequipments_inspection
			// 
			this.dgw_eventequipments_inspection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_eventequipments_inspection.Location = new System.Drawing.Point(393, 38);
			this.dgw_eventequipments_inspection.Name = "dgw_eventequipments_inspection";
			this.dgw_eventequipments_inspection.Size = new System.Drawing.Size(362, 306);
			this.dgw_eventequipments_inspection.TabIndex = 6;
			// 
			// lbl_eventcanbe
			// 
			this.lbl_eventcanbe.AutoSize = true;
			this.lbl_eventcanbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_eventcanbe.ForeColor = System.Drawing.Color.DarkOrange;
			this.lbl_eventcanbe.Location = new System.Drawing.Point(3, 159);
			this.lbl_eventcanbe.Name = "lbl_eventcanbe";
			this.lbl_eventcanbe.Size = new System.Drawing.Size(14, 20);
			this.lbl_eventcanbe.TabIndex = 7;
			this.lbl_eventcanbe.Text = "-";
			// 
			// lbl_venue
			// 
			this.lbl_venue.AutoSize = true;
			this.lbl_venue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_venue.Location = new System.Drawing.Point(81, 9);
			this.lbl_venue.Name = "lbl_venue";
			this.lbl_venue.Size = new System.Drawing.Size(14, 20);
			this.lbl_venue.TabIndex = 8;
			this.lbl_venue.Text = "-";
			// 
			// lbl_type
			// 
			this.lbl_type.AutoSize = true;
			this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_type.Location = new System.Drawing.Point(81, 38);
			this.lbl_type.Name = "lbl_type";
			this.lbl_type.Size = new System.Drawing.Size(14, 20);
			this.lbl_type.TabIndex = 9;
			this.lbl_type.Text = "-";
			// 
			// lbl_start
			// 
			this.lbl_start.AutoSize = true;
			this.lbl_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_start.Location = new System.Drawing.Point(81, 68);
			this.lbl_start.Name = "lbl_start";
			this.lbl_start.Size = new System.Drawing.Size(14, 20);
			this.lbl_start.TabIndex = 10;
			this.lbl_start.Text = "-";
			// 
			// lbl_end
			// 
			this.lbl_end.AutoSize = true;
			this.lbl_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_end.Location = new System.Drawing.Point(81, 102);
			this.lbl_end.Name = "lbl_end";
			this.lbl_end.Size = new System.Drawing.Size(14, 20);
			this.lbl_end.TabIndex = 11;
			this.lbl_end.Text = "-";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Rendezvényszervezés";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_events)).EndInit();
			this.tabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_equipments)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_trucks)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_equipmentVolume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_propQuantity_adding)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_eventequipment)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_eventequipments_inspection)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_carNumber;
        private System.Windows.Forms.DataGridView dgw_trucks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgw_equipments;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgw_events;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_eventVenue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_eventStarts;
        private System.Windows.Forms.DateTimePicker dtp_eventEnds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_eventType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_propId_adding;
        private System.Windows.Forms.NumericUpDown nud_propQuantity_adding;
        private System.Windows.Forms.Button btn_addEvent;
        private System.Windows.Forms.Button btn_addProp_newevent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addCars;
        private System.Windows.Forms.TextBox tb_equipmentName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_addEquipment;
        private System.Windows.Forms.TextBox tb_truckLocation;
        private System.Windows.Forms.NumericUpDown nud_equipmentVolume;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_equipmentLocation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_equipmentId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_truckId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_eventId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_refreshEvents;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_refreshtables;
		private System.Windows.Forms.DataGridView dgw_eventequipment;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_evaluateEvent;
		private System.Windows.Forms.TextBox tb_eventId_Find;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgw_eventequipments_inspection;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label lbl_end;
		private System.Windows.Forms.Label lbl_start;
		private System.Windows.Forms.Label lbl_type;
		private System.Windows.Forms.Label lbl_venue;
		private System.Windows.Forms.Label lbl_eventcanbe;
	}
}


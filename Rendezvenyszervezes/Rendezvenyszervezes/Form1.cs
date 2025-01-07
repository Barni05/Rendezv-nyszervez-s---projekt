using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Rendezvenyszervezes {
    public partial class Form1 : Form {

        public static DatabaseHandler databaseHandler = new("server=127.0.0.1;user=root;password=;database=event_organizer");
        public List<Equipment> equipment_request = new();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BindInputs();
			LoadResourceTables();
			FetchEvents();
        }
		private void LoadResourceTables()
		{
			//Loading Truck table
			string[][] trucks = databaseHandler.Query($"SELECT truck_id, current_location FROM truck;");
			lb_carNumber.Text = trucks.Length.ToString();
			DataTable dt = new DataTable();

			dt.Columns.Add("Autó azonosító");
			dt.Columns.Add("Helyzet");

			for (int i = 0; i < trucks.Length; i++)
			{
				DataRow dr = dt.NewRow();
				for (int j = 0; j < trucks[i].Length; j++)
				{
					dr[j] = trucks[i][j];
				}
				dt.Rows.Add(dr);
			}

			dgw_trucks.DataSource = dt;

			//Loading Equipment table
			string[][] equipments = databaseHandler.Query($"SELECT equipment.name, SUM(warehouse_equipment.quantity) AS total_quantity FROM equipment JOIN warehouse_equipment ON equipment.equipment_id = warehouse_equipment.equipment_id GROUP BY equipment.name;");
			dt = new DataTable();
			dt.Columns.Add("Név");
			dt.Columns.Add("Mennyiség összesen");

			for (int i = 0; i < equipments.Length; i++)
			{
				DataRow dr = dt.NewRow();
				for (int j = 0; j < equipments[i].Length; j++)
				{
					dr[j] = equipments[i][j];
				}
				dt.Rows.Add(dr);
			}

			dgw_equipments.DataSource = dt;

		}
        private void Click_kellekfelvetel() {
            //Extracting user data
            int quantity = Convert.ToInt32(nud_equipmentVolume.Value);
            string propName = tb_equipmentName.Text;
            int propLocation = Convert.ToInt32(tb_equipmentLocation.Text);
            int equipmentId = Convert.ToInt32(tb_equipmentId.Text);
            string query = $"INSERT INTO equipment (equipment_id, name, size) VALUES(\"{equipmentId}\",\"{propName}\", \"{quantity}\");";
            databaseHandler.Query(query);
            query = $"INSERT INTO warehouse_equipment (warehouse_id, equipment_id, quantity) VALUES(\"{propLocation}\", \"{equipmentId}\", \"{quantity}\");";
            databaseHandler.Query(query);
        }
        private void Click_autofelvetel() {
            //Extracting user data
            int truckId = Convert.ToInt32(tb_truckId.Text);
            int truckLocation = Convert.ToInt32(tb_truckLocation.Text);
            string query = $"""INSERT INTO truck (truck_id, current_location) VALUES("{truckId}", "{truckLocation}");""";
            databaseHandler.Query(query);
        }
        private void Click_kellekfelvetel_event() {
            int propId = Convert.ToInt32(tb_propId_adding.Text);
            int propQuantity = Convert.ToInt32(nud_propQuantity_adding.Value);
            string[][] result = databaseHandler.Query($"SELECT name FROM equipment WHERE equipment_id={propId} LIMIT 1;");
            equipment_request.Add(new Equipment(propId, result[0][0],0, 0, propQuantity));
        }
        private void Click_eventfelvetel() {
            int eventLocation = Convert.ToInt32(tb_eventVenue.Text);
            int eventId = Convert.ToInt32(tb_eventId.Text);
            DateTime eventStart = dtp_eventStarts.Value;
            DateTime eventEnd = dtp_eventEnds.Value;
            EventType eventType;
            Enum.TryParse(cb_eventType.SelectedText.ToString(), false, out eventType);
            string query = $"""INSERT INTO event (event_id,location_id,start_date,end_date,type) VALUES({eventId},{eventLocation}, "{eventStart.ToString("yyyy-MM-dd HH:mm:ss.fff")}", "{eventEnd.ToString("yyyy-MM-dd HH:mm:ss.fff")}", "{eventType.ToString()}");""";
            databaseHandler.Query(query);

            foreach(var equipment in equipment_request) {
                query = $"""INSERT INTO event_equipment (event_id,equipment_id,quantity) VALUES({eventId}, {equipment.Id}, {equipment.Size})""";
                databaseHandler.Query(query);
            }
        }
        private void FetchEvents() {
            string[][] events = databaseHandler.Query($"SELECT event_id, start_date, end_date, type, capacity, available_times, elegance, catering_type FROM event inner join locations on event.location_id = locations.location_id;");

			DataTable dt = new DataTable();

			//Naming the column names
			dt.Columns.Add("Event ID");
			dt.Columns.Add("Start Date");
			dt.Columns.Add("End Date");
			dt.Columns.Add("Type");
			dt.Columns.Add("Capacity");
			dt.Columns.Add("Available Times");
			dt.Columns.Add("Elegance");
			dt.Columns.Add("Catering Type");

			//Filling it with data
			for (int i = 0; i < events.Length; i++)
			{
				DataRow dr = dt.NewRow();
				for (int j = 0; j < events[i].Length; j++)
				{
					dr[j] = events[i][j];
				}
				dt.Rows.Add(dr);
			}

			dgw_events.DataSource = dt;
		}
        private void BindInputs() {
            btn_addEquipment.Click += (sender, e) => Click_kellekfelvetel();
            btn_addCars.Click += (sender, e) => Click_autofelvetel();
            btn_addProp_newevent.Click += (sender, e) => Click_kellekfelvetel_event();
            btn_addEvent.Click += (sender, e) => Click_eventfelvetel();
            btn_refreshEvents.Click += (sender, e) => FetchEvents();
			btn_refreshtables.Click += (sender, e) => LoadResourceTables();
        }
    }
}

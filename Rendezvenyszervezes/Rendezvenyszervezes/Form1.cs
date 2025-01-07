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
            DataTable dt = new();
            dt.Columns.Add("Autó neve".ToString());
            dt.Columns.Add("Hol tartózkodik".ToString());
            DataRow dr = dt.NewRow();
            dr["Autó neve"] = "Mike Wazowski";
            dr["Hol tartózkodik"] = "Hajdúszoboszló";
            dt.Rows.Add(dr);

            grid_cars.DataSource = dt;
            dt = new DataTable();
            dt.Columns.Add("Kellék neve".ToString());
            dt.Columns.Add("Hol tartózkodik".ToString());
            dr = dt.NewRow();
            dr["Kellék neve"] = "Mike Wazowski";
            dr["Hol tartózkodik"] = "Hajdúszoboszló";
            dt.Rows.Add(dr);

            grid_props.DataSource = dt;

            Venue v = new(400, TimeOfDay.AllDay, 10, VenueType.Seated);
            BindInputs();
        }
        private void Click_kellekfelvetel() {
            //Extracting user data
            int quantity = Convert.ToInt32(nud_equipmentVolume.Value);
            string propName = tb_equipmentName.Text;
            int propLocation = Convert.ToInt32(tb_equipmentLocation.Text);
            int equipmentId = Convert.ToInt32(tb_equipmentId.Text);
            string query = $"INSERT INTO equipment (equipment_id, name, volume) VALUES(\"{equipmentId}\",\"{propName}\", \"{quantity}\");";
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
            query = $"""INSERT INTO truckparking (parking_id, truck_id) VALUES("{truckLocation}", "{truckId}");""";
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
            Enum.TryParse(cb_eventType.SelectedValue.ToString(), false, out eventType);

        }  
        private void BindInputs() {
            btn_addEquipment.Click += (sender, e) => Click_kellekfelvetel();
            btn_addCars.Click += (sender, e) => Click_autofelvetel();
            btn_addProp_newevent.Click += (sender, e) => Click_kellekfelvetel_event();
            btn_addEvent.Click += (sender, e) => Click_eventfelvetel();
        }
    }
}

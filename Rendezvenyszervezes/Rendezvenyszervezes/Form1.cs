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

        public static DatabaseHandler databaseHandler = new DatabaseHandler("server=127.0.0.1;user=root;password=;database=event_organizer");

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            DataTable dt = new DataTable();
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
            query = $"INSERT INTO warehouse_equipment (warehouse_id, equipment_id, quantity) VALUES(\"{propLocation}\", \"{equipmentId}\", \"{quantity}\")";
            databaseHandler.Query(query);
        }
        private void Click_autofelvetel() {
            //Extracting user data
            int truckId = Convert.ToInt32(tb_truckId.Text);
            int truckLocation = Convert.ToInt32(tb_truckLocation.Text);
            string query = $"""INSERT INTO truck (truck_id, current_location) VALUES("{truckId}", "{truckLocation}");""";
            databaseHandler.Query(query);
            query = $""" INSERT INTO truckparking (parking_id, truck_id) VALUES("{truckLocation}", "{truckId}");""";
            databaseHandler.Query(query);
        }
        private void BindInputs() {
            btn_addEquipment.Click += (sender, e) => Click_kellekfelvetel();
            btn_addCars.Click += (sender, e) => Click_autofelvetel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendezvenyszervezes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Autó neve".ToString());
            dt.Columns.Add("Hol tartózkodik".ToString());
            DataRow dr = dt.NewRow();
            dr["Autó neve"] = "Mike";
            dr["Hol tartózkodik"] = "Hajdúszoboszló";
            dt.Rows.Add(dr);

            grid_cars.DataSource = dt;
            dt = new DataTable();
            dt.Columns.Add("Kellék neve".ToString());
            dt.Columns.Add("Hol tartózkodik".ToString());
             dr = dt.NewRow();
            dr["Kellék neve"] = "Mike";
            dr["Hol tartózkodik"] = "Hajdúszoboszló";
            dt.Rows.Add(dr);

            grid_props.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
                
        }
    }
}

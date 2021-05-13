using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr6
{
    public partial class fPlane : Form
    {
        private Plane plane = new Plane();
        public fPlane(ref Plane plane)
        {
            this.plane = plane;
            InitializeComponent();
        }
        //додавання публічного поля, та зміна конструктора

        public Plane ThPlane;
        public fPlane(Plane t)
        {
            ThPlane = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThPlane.Name_plane = tbNamePlane.Text.Trim();
            ThPlane.Country_departure = tbMistoVid.Text.Trim();
            ThPlane.Country_arrival = tbMistoPr.Text.Trim();
            ThPlane.Flight_number = int.Parse(tbNomPlane.Text.Trim());
            ThPlane.pepolnumber_of_seats = int.Parse(tbKilkMisKlasClasic.Text.Trim());
            ThPlane.lux_seats = int.Parse(tbKilkMisKlasLux.Text.Trim());
            ThPlane.eat = chbObid.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
    
    }
}

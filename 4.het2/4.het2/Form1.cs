using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _4.het2
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> Flats;

        public Form1()
        {
            InitializeComponent();
            Loaddata();
        }
        private void Loaddata()
        {

            Flats = context.Flats.ToList();
        }

}
}

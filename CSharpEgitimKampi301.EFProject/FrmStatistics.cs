using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        EgitimKampiEFTravelDBEntities db = new EgitimKampiEFTravelDBEntities();
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Location.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).ToString();

            int lastCountryId = db.Location.Max(x => x.LocationID);
            lblLastCountry.Text = db.Location.Where(x => x.LocationID == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkeyCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideID).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideID == romeGuideId).Select(y => y.Name + " " + y.Surname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacity.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPrice.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByNameOrhanŞimşek = db.Guide.Where(x => x.Name == "Orhan" && x.Surname == "Şimşek").Select(y => y.GuideID).FirstOrDefault();
            lblGuideIdByNameOrhanŞimşek.Text = db.Location.Where(x => x.GuideID == guideIdByNameOrhanŞimşek).Count().ToString();
        }
    }
}

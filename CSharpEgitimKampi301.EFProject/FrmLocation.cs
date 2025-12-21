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
    public partial class FrmLocation : Form
    {
        EgitimKampiEFTravelDBEntities db = new EgitimKampiEFTravelDBEntities();
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void List(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            DataGridView1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(numCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideID = int.Parse(cmbGuideName.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();

            List(sender, e);
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.Name + " " + x.Surname,
                x.GuideID
            }).ToList();

            cmbGuideName.DisplayMember = "FullName";
            cmbGuideName.ValueMember = "GuideID";
            cmbGuideName.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var removeValue = db.Location.Find(id);
            db.Location.Remove(removeValue);
            db.SaveChanges();
            List(sender, e);
            MessageBox.Show("Lokasyon başarıyla silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var updateValue = db.Location.Find(id);
            updateValue.Capacity = byte.Parse(numCapacity.Value.ToString());
            updateValue.City = txtCity.Text;
            updateValue.Country = txtCountry.Text;
            updateValue.Price = decimal.Parse(txtPrice.Text);
            updateValue.DayNight = txtDayNight.Text;
            updateValue.GuideID = int.Parse(cmbGuideName.SelectedValue.ToString());
            db.SaveChanges();

            List(sender, e);
            MessageBox.Show("Lokasyon başarıyla güncellendi");
        }
    }
}

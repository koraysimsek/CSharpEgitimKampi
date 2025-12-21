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
    public partial class Form1 : Form
    {
        EgitimKampiEFTravelDBEntities db = new EgitimKampiEFTravelDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void List(object sender, EventArgs e)
        {
            var values = db.Guide.ToList();
            DataGridView1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.Name = txtGuideName.Text;
            guide.Surname = txtGuideSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            List(sender, e);
            MessageBox.Show("Rehber başarıyla eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuideId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            List(sender, e);
            MessageBox.Show("Rehber başarıyla silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuideId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.Name = txtGuideName.Text;
            updateValue.Surname = txtGuideSurname.Text;
            db.SaveChanges();
            List (sender, e);
            MessageBox.Show("Rehber başarıyla güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuideId.Text);
            var values = db.Guide.Where(x=>x.GuideID == id).ToList();
            DataGridView1.DataSource = values;
        }
    }
}

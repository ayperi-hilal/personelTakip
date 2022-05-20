using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PersonelTakipOtomasyonu.Entity;

namespace PersonelTakipOtomasyonu
{
    public partial class frm_departmanlar : Form
    {
        public frm_departmanlar()
        {
            InitializeComponent();
        }

        personelTakipOtomasyonuEntities2 db = new personelTakipOtomasyonuEntities2();

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            /*tbl_departmanlar t = new tbl_departmanlar();

             t.ad = txt_adi.Text;
             db.tbl_departmanlar.Add(t);
             db.SaveChanges();
             XtraMessageBox.Show("Departman başarılı bir şekilde kaydedbilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             listele();*/

            tbl_departmanlar d = new tbl_departmanlar();
            d.adi = txt_departmanAdi.Text;
            d.aciklama = txt_departmanAciklama.Text;
            db.tbl_departmanlar.Add(d);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde kaydedbilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }
        public void listele()
        {

        }
    }
}

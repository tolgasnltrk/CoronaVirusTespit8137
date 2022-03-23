using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaVirusTespit8137
{
    public partial class BelirtiTespitForm : Form
    {

        string[] _sehirler = new string[3]
        {
               "Ankara", "İstanbul", "İzmir"
        };
        string sonuc;

        public BelirtiTespitForm()
        {
            InitializeComponent();
        }

        private void BelirtiTespitForm_Load(object sender, EventArgs e)
        {
            this.Text = "Belirti Tespit";

            //ddlSehir.Items.Add("Ankara"); // 1. yol
            //ddlSehir.Items.Add("İstanbul");
            //ddlSehir.Items.Add("İzmir");

            //foreach (var s in _sehirler) // 2. yol
            //{
            //    ddlSehir.Items.Add(s);
            //}
            ddlSehir.Items.AddRange(_sehirler); // 3. yol
            ddlSehir.SelectedIndex = 0;

            dtpTarih.Value = DateTime.Now;
            dbKadın.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolEt();
        }

        private void KontrolEt()
        {
            sonuc = "";
            if (dbKadın.Checked)
                sonuc += "Bayan ";
            else
                sonuc += "Bay ";
            sonuc += txtAdi.Text + " " + tbSoyadi.Text + "\r\n";
            sonuc += "Şehriniz " + ddlSehir.Text + "\r\n";
            sonuc += "Yaşınız " + nudYas.Value + "\r\n";
            sonuc += "Kontrol Tarihi " + dtpTarih.Value.ToLongDateString() + "\r\n";
            if (cbAtes.Checked || (cbOksuruk.Checked && cbBogaz.Checked))
                    sonuc += "Koronavirüs olabilirsiniz.";
            else
                sonuc += "Koronavirüs olmayabilirsiniz.";


        }

        
     
            
    }
}

   
  


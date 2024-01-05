using Ekstenzije;
using Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Podaci.ListaOsoba;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace OOPR_LV3
{
    public partial class OOProjektovanjeLV3 : Form
    {
        public OOProjektovanjeLV3()
        {
            InitializeComponent();
            //  this.Load += new EventHandler(OOProjektovanjeLV3_Load);
        }
        private void OOProjektovanjeLV3_Load(object sender, EventArgs e)
        {

            // inicijalizuj ComboBox
            cboNacinSortiranja.Items.Add("PO IMENU");
            cboNacinSortiranja.Items.Add("PO PREZIMENU");
            cboNacinSortiranja.Items.Add("PO DATUMU RODJENJA");
      
        }
        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool ValidacijaKontrola()
        {
            if (String.IsNullOrEmpty(tbTelefon.Text) &&
                String.IsNullOrEmpty(tbPrezime.Text) && String.IsNullOrEmpty(tbIme.Text) && String.IsNullOrEmpty(tbAdresa.Text))
            {
                MessageBox.Show("Vi ste mrzovoljan korisnik, nista niste uneli !",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }
            if (tbTelefon.Text.Length < 15)
            {
                MessageBox.Show("Telefon mora biti tacno 15 karaktera! Formata: +381 11 5659898",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(tbIme.Text))
            {
                MessageBox.Show("Ime ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(tbPrezime.Text))
            {
                MessageBox.Show("Prezime ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(tbTelefon.Text))
            {
                MessageBox.Show("Svaki covek ima telefon!",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(dtpOdabirDatuma.Text))
            {
                MessageBox.Show("Datum mora biti unet !",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }
            if (String.IsNullOrEmpty(tbAdresa.Text))
            {
                MessageBox.Show("Adresa stanovanja mora biti uneta !",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }
            

            return true;
        }

        private void dtpOdabirDatuma_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {

            if (!ValidacijaKontrola())
                return;
            bool postoji=false;
            Osoba o2=null;
            if (lbLista.SelectedIndex!=-1)
            {
                 o2 = (Osoba)lbLista.SelectedItem;
                postoji = ListaOsoba.Instance.PostojiOsobaUListi(o2);
            }
                String ime = tbIme.Text;
                ime = char.ToUpper(ime[0]) + ime.Substring(1).ToLower();
                String prezime = tbPrezime.Text;
                prezime = char.ToUpper(prezime[0]) + prezime.Substring(1).ToLower();

                String broj = tbTelefon.Text;
                String adresa = tbAdresa.Text;
                DateTime datum = dtpOdabirDatuma.Value;
                Osoba o = new Osoba(ime, prezime, broj, adresa, datum);

                //Osoba osobaZaAzuriranje = ListaOsoba.Instance.FirstOrDefault(osoba => osoba.broj == broj);

            if (postoji)
            {
                //azuriranje
                int i = ListaOsoba.Instance.GetIndex(o2);
                ListaOsoba.Instance.AzurirajOsobu(i,o);
                UcitajListBox();
                return;
            }
            else
            {
                bool resultat = ListaOsoba.Instance.DodajOsobu(o);

                if (!resultat)
                {
                    MessageBox.Show("Osoba nije uspesno dodata u listu osoba. Mozda takva osoba vec postoji u listi.",
                                     "Obavestenje",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Osoba je uspesno dodata u listu osoba.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }

            UcitajListBox();
            btnObrisiJednuOsobu.Enabled = true;
            tbIme.Focus();
            lbLista.ClearSelected();
            PraznjenjePolja();
            return;
        }
        private void PraznjenjePolja()
        {
            tbIme.Clear();
            tbPrezime.Clear();
            tbTelefon.Clear();
            tbAdresa.Clear();
            DateTime trenutniDatum = DateTime.Now;
            dtpOdabirDatuma.Value = trenutniDatum;
        }
        private void btnPonisti_Click(object sender, EventArgs e)
        {
            
            if (isEmpty())
            {
                MessageBox.Show("Ops, nema sta da se brise!",
                                    "Obavestenje",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                lbLista.ClearSelected();
                return;
            }
            PraznjenjePolja();
            MessageBox.Show("Akcija brisanja je uspesno obavljena.",
                                   "Obavestenje",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            lbLista.ClearSelected();
        }
        private bool isEmpty()
        {
            if (String.IsNullOrEmpty(tbTelefon.Text) && String.IsNullOrEmpty(tbPrezime.Text) && String.IsNullOrEmpty(tbIme.Text)&& String.IsNullOrEmpty(tbAdresa.Text))
                return true;

            return false;
        }

        private bool closingFlag = false;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing && !closingFlag)
            {
                closingFlag = true;
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da zatvorite aplikaciju?",
                                                        "Potvrda zatvaranja",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    closingFlag = false;
                    e.Cancel = true;
                }
            }
        }
  
        void UcitajListBox()
        {
            lbLista.DisplayMember = "ZaPrikaz";
            lbLista.ValueMember = "Jmbg";
            lbLista.DataSource = ListaOsoba.Instance.ListaOsobaValues.ToList();
        }
        private void OOProjektovanjeLV3_DoubleClick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formatiranoVreme = now.TrenutnoVreme();
            DialogResult result = MessageBox.Show(now.TrenutnoVreme(), "Trenutni datum i vreme.");
        }

        private void cboNacinSortiranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSortirajListu.Enabled = true;
        }

        private void btnObrisiJednuOsobu_Click(object sender, EventArgs e)
        {
            Osoba odabrana = (Osoba)lbLista.SelectedItem;

            if (odabrana != null)
            {
                bool resultat = ListaOsoba.Instance.ObrisiOsobu(odabrana);
                if (resultat)
                {
                    MessageBox.Show("Osoba je uspesno obrisana iz liste osoba.",
                            "Obavestenje",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);

                    UcitajListBox();
                    return;
                }
            }
            MessageBox.Show("Osoba nije uspesno obrisana sa liste osoba.",
                        "Obavestenje",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            return;
        }

        private void btnObrisiListuOsoba_Click(object sender, EventArgs e)
        {
            bool resultat = ListaOsoba.Instance.ObrisiListu();
            if (resultat)
            {
                MessageBox.Show("Lista je uspesno obrisana.",
                        "Obavestenje",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);

                UcitajListBox();
                return;
            }
            MessageBox.Show("Lista nije uspesno obrisana.",
                        "Obavestenje",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            return;
        }
        private void lbLista_DoubleClick(object sender, EventArgs e)
        {
            int index = lbLista.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Lista je prazna.",
                       "Obavestenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            Osoba selectedPerson = lbLista.Items[index] as Osoba;          
            tbIme.Text = selectedPerson.Ime;
            tbPrezime.Text = selectedPerson.Prezime;
            tbTelefon.Text = selectedPerson.Broj;
            dtpOdabirDatuma.Text = selectedPerson.Datum.ToString();
            tbAdresa.Text = selectedPerson.Adresa;
            
        }

        private void btnSortirajListu_Click(object sender, EventArgs e)
        {
            string selected = null;
            if (cboNacinSortiranja.SelectedItem != null)
            { selected = cboNacinSortiranja.SelectedItem.ToString();
                SortDelegate del = null;
                if (selected == "PO IMENU")
                {
                    del = new SortDelegate(ListaOsoba.PoredjenjePoImenu);
                }
                if (selected == "PO PREZIMENU")
                {
                    del = new SortDelegate(ListaOsoba.PoredjenjePoPrezimenu);
                }
                if (selected == "PO DATUMU RODJENJA")
                {
                    del = new SortDelegate(ListaOsoba.PoredjenjePoDatumuRodjenja);
                }

                ListaOsoba.Instance.Sortiraj(del);
                UcitajListBox();

                MessageBox.Show("Odabrano" + selected,
                       "Obavestenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Moras odabrati mod sortiranja",
                      "Obavestenje",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }    
        }

        private void tbAdresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





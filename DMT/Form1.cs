using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var charakter = new Charakter("André", "Alexander", Klasse.Paladin, Rasse.Elf, Gesinnung.rechtschaffendGut, 7, 65, 18, 13, 19, 6, 13, 20, 10000);

            txtCharName.Text = charakter.CharakterName;
            txtSpielerName.Text = charakter.SpielerName;
            FülleCmbKlasse(charakter);
            numLevel.Value = charakter.Level;
            FülleCmbRasse(charakter);
            FülleCmbGesinnung(charakter);
            numStärke.Value = charakter.Stärke;
            numGeschick.Value = charakter.Geschick;
            numKonstitution.Value = charakter.Konstitution;
            numIntelligenz.Value = charakter.Intelligenz;
            numWeisheit.Value = charakter.Weisheit;
            numCharisma.Value = charakter.Charisma;
            if (charakter.ModStärke < 0)
            {
                lblModStärke.Text = $"- {-charakter.ModStärke}";
            }
            else
            {
                lblModStärke.Text += charakter.ModStärke;
            }
            if (charakter.ModGeschick < 0)
            {
                lblModGeschick.Text = $"- {-charakter.ModGeschick}";
            }
            else
            {
                lblModGeschick.Text += charakter.ModGeschick;
            }
            if(charakter.ModKonstitution < 0)
            {
                lblModKonstitution.Text = $"- {-charakter.ModKonstitution}";
            }
            else
            {
                lblModKonstitution.Text += charakter.ModKonstitution;
            }
            if(charakter.ModIntelligenz < 0)
            {
                lblModIntelligenz.Text = $"- {-charakter.ModIntelligenz}";
            }
            else
            {
                lblModIntelligenz.Text += charakter.ModIntelligenz;
            }
            if(charakter.ModWeisheit < 0)
            {
                lblModWeisheit.Text = $"- {-charakter.ModWeisheit}";
            }
            else
            {
                lblModWeisheit.Text += charakter.ModWeisheit;
            }
            if(charakter.ModCharisma < 0)
            {
                lblModCharisma.Text = $"- {-charakter.ModCharisma}";
            }
            else
            {
                lblModCharisma.Text += charakter.ModCharisma;
            }
            
            
            






        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        void FülleCmbRasse(Charakter charakter)
        {
            cmbRasse.Items.Add(Rasse.Aasimar.ToString());
            cmbRasse.Items.Add(Rasse.Drachenblütiger.ToString());
            cmbRasse.Items.Add(Rasse.Echsenvolk.ToString());
            cmbRasse.Items.Add(Rasse.Elf.ToString());
            cmbRasse.Items.Add(Rasse.Firbolg.ToString());
            cmbRasse.Items.Add(Rasse.Gnom.ToString());
            cmbRasse.Items.Add(Rasse.Goliat.ToString());
            cmbRasse.Items.Add(Rasse.Halbelf.ToString());
            cmbRasse.Items.Add(Rasse.Halbling.ToString());
            cmbRasse.Items.Add(Rasse.Halbork.ToString());
            cmbRasse.Items.Add(Rasse.Kenku.ToString());
            cmbRasse.Items.Add(Rasse.Mensch.ToString());
            cmbRasse.Items.Add(Rasse.Tabaxi.ToString());
            cmbRasse.Items.Add(Rasse.Tiefling.ToString());
            cmbRasse.Items.Add(Rasse.Triton.ToString());
            cmbRasse.Items.Add(Rasse.Zwerg.ToString());
            cmbRasse.SelectedItem = charakter.Rasse.ToString();            
        }

        void FülleCmbKlasse(Charakter charakter)
        {
            cmbKlasse.Items.Add(Klasse.Barbar.ToString());
            cmbKlasse.Items.Add(Klasse.Barde.ToString());
            cmbKlasse.Items.Add(Klasse.Druide.ToString());
            cmbKlasse.Items.Add(Klasse.Hexenmeister.ToString());
            cmbKlasse.Items.Add(Klasse.Kleriker.ToString());
            cmbKlasse.Items.Add(Klasse.Kämpfer.ToString());
            cmbKlasse.Items.Add(Klasse.Magier.ToString());
            cmbKlasse.Items.Add(Klasse.Mönch.ToString());
            cmbKlasse.Items.Add(Klasse.Paladin.ToString());
            cmbKlasse.Items.Add(Klasse.Schurke.ToString());
            cmbKlasse.Items.Add(Klasse.Waldläufer.ToString());
            cmbKlasse.Items.Add(Klasse.Zauberer.ToString());
            cmbKlasse.SelectedItem = charakter.Klasse.ToString();
        }

        void FülleCmbGesinnung(Charakter charakter)
        {
            cmbGesinnung.Items.Add(Gesinnung.rechtschaffendGut.ToString());
            cmbGesinnung.Items.Add(Gesinnung.neutralGut.ToString());
            cmbGesinnung.Items.Add(Gesinnung.chaotischGut.ToString());
            cmbGesinnung.Items.Add(Gesinnung.rechtschaffendNeutral.ToString());
            cmbGesinnung.Items.Add(Gesinnung.neutral.ToString());
            cmbGesinnung.Items.Add(Gesinnung.chaotischNeutral.ToString());
            cmbGesinnung.Items.Add(Gesinnung.rechtschaffendBöse.ToString());
            cmbGesinnung.Items.Add(Gesinnung.neutralBöse.ToString());
            cmbGesinnung.Items.Add(Gesinnung.chaotischBöse.ToString());
            cmbGesinnung.SelectedItem = charakter.Gesinnung.ToString();
        }
    }
}

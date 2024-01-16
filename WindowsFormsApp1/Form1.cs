using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form2();
            f2.ShowDialog();
            f2 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form3();
            f3.ShowDialog();
            f3 = null;
        }
    }

    public class Lietotajs
    {
        public int LietotajaId { get; set; }
        public string Lietotajvards { get; set; }
        // Citas lietotāja saistītās īpašības

        // Fiziskā aktivitāte
        public List<FiziskaAktivitate> FiziskasAktivitates { get; set; }

        // Uztura uzraudzība
        public List<DietasIeraksts> DietasIeraksti { get; set; }

        // Miega uzraudzība
        public List<MiegaIeraksts> MiegaIeraksti { get; set; }

        // Izdevumu reģistrs
        public List<IzdevumuIeraksts> IzdevumuIeraksti { get; set; }

        // Citas saistītās īpašības

        public Lietotajs()
        {
            FiziskasAktivitates = new List<FiziskaAktivitate>();
            DietasIeraksti = new List<DietasIeraksts>();
            MiegaIeraksti = new List<MiegaIeraksts>();
            IzdevumuIeraksti = new List<IzdevumuIeraksts>();
        }
    }

    public class FiziskaAktivitate
    {
        public int AktivitatesId { get; set; }
        public string AktivitatesNosaukums { get; set; }
        public DateTime Datums { get; set; }
        public int IlgumsMinutēs { get; set; }
    }

    public class DietasIeraksts
    {
        public int IerakstaId { get; set; }
        public string EdienaVeids { get; set; }
        public DateTime Datums { get; set; }
        // Citas diētas saistītās īpašības
    }

    public class MiegaIeraksts
    {
        public int MiegaId { get; set; }
        public DateTime Datums { get; set; }
        public int NosnaidesStundas { get; set; }
    }

    public class IzdevumuIeraksts
    {
        public int IzdevumuId { get; set; }
        public string IzdevumuVeids { get; set; }
        public decimal Summa { get; set; }
        public DateTime Datums { get; set; }
    }
}

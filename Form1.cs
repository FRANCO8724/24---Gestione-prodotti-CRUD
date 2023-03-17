using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24___Gestione_prodotti_CRUD
{
    public partial class Form1 : Form 
    {
        public struct prodotto
        {
            public string nome; 
            public float prezzo;
        }
        public prodotto[] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}

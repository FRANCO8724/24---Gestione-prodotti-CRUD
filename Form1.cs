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



        private void button1_Click(object sender, EventArgs e)
        {

            Aggiunta(p);

            nome.Text = "";
            nome.Focus();
            prezzo.Text = "";
            prezzo.Focus();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            visualizza(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elimina(p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Funzioni di servizio

        public void Aggiunta(prodotto[] pp)
        {
            p[dim].nome = nome.Text;
            p[dim].prezzo = float.Parse(prezzo.Text);
            dim++;
        }

        public string Scritta(prodotto p)
        {
            return "Nome: " + p.nome + " prezzo: " + p.prezzo.ToString() + " €";
        }

        public void visualizza(prodotto[] pp)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                if (pp[i].nome != null)
                listView1.Items.Add(Scritta(p[i]));
            }
        }

        public void Elimina(prodotto[] p)
        {
             for(int i = 0; i < dim;i++)
             {
                if(nome.Text == p[i].nome)
                {
                    for (int j = i; j < dim; j++)
                    {
                        p[j] = p[j + 1];
                    }
                     
                }
             }
        }

    }
}
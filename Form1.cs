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

            nome.Text = "";
            nome.Focus();
            prezzo.Text = "";
            prezzo.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifica(p);
            nome.Text = "";
            nome.Focus();
            prezzo.Text = "";
            prezzo.Focus();

            nuovonome.Text = "";
            nuovonome.Focus();
            nuovoprezzo.Text = "";
            nuovoprezzo.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            float g = Totale(p);

            listView1.Items.Add("Prezzo complessivo: " + g);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            float g = Piùalto(p);

            listView1.Items.Add("Prezzo pià alto: " + g);
        }

        private void button6_Click(object sender, EventArgs e)
        {

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

        public void Modifica(prodotto[] pp)
        {
            for (int i = 0; i < dim; i++)
            {
                float a = float.Parse(nuovoprezzo.Text);

                if (p[i].nome == nome.Text)
                {
                    p[i].nome = nuovonome.Text;

                    p[i].prezzo = a;
                }

            }
        }

        public float Totale(prodotto[] pp)
        {
            float a = 0;

            for (int i = 0; i < dim; i++)
            {
                 a = a + p[i].prezzo;

            }

            return a;
        }

        public float Piùalto(prodotto[] pp)
        {
            float a = 0;
            int c = 0;

            for (int i = 0; i < dim; i++)
            {

                if (p[i].prezzo > p[i + 1].prezzo || p[i + 1].prezzo != 0)
                {
                    c = 1;
                    a = p[i].prezzo;
                }
                else
                {
                    c = 0;
                }

                if (c == 1)
                {
                    break;
                }

            }
            return a;
        }


            
        }


    }

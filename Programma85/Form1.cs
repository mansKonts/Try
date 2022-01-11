using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programma85
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int piemeri=0;
        int punkti=0;
        string[] pilsetas = new string[] { "Ainaži","Aizkraukle","Aizpute","Aknīste","Aloja",
                                           "Alūksne","Ape","Auce","Baldone","Baloži",
                                           "Balvi","Bauska","Brocēni","Cēsis","Cesvaine",
                                           "Dagda","Daugavpils","Dobele","Durbe","Grobiņa",
                                           "Gulbene","Ikšķile","Ilūkste","Jaunjelgava","Jēkabpils",
                                           "Jelgava","Jūrmala","Kandava","Kārsava","Krāslava",
                                           "Kuldīga","Ķegums","Lielvārde","Liepāja","Līgatne",
                                           "Limbaži","Līvāni","Lubāna","Ludza","Madona",
                                           "Mazsalaca","Ogre","Olaine","Pāvilosta","Piltene",
                                           "Pļaviņas","Preiļi","Priekule","Rēzekne",
                                           "Rīga","Rūjiena","Sabile","Salacgrīva","Salaspils",
                                           "Saldus","Saulkrasti","Seda","Sigulda","Skrunda",
                                           "Smiltene","Staicele","Stende","Strenči","Subate",
                                           "Talsi","Tukums","Valdemārpils","Valka","Valmiera",
                                           "Vangaži","Varakļāni","Ventspils","Viesīte","Viļaka",
                                           "Viļāni","Zilupe"};
        int x, n;

        public Form1()
        {
            InitializeComponent();
        }

        private void butParbaudit_Click(object sender, EventArgs e)
        {
            txtAtbilde.Enabled = false;
            txtAtbilde.Text = txtAtbilde.Text.ToUpper();
            piemeri++;
            if(txtAtbilde.Text== pilsetas[x])
            {
                punkti++;
            }
            labRez.Text = punkti + " no " + piemeri;
            butParbaudit.Visible = false;
            butTurpinat.Visible = true;
        }

        void Pilseta()
        {
            n = pilsetas.Length;
            x = rand.Next(n);
            pilsetas[x]=pilsetas[x].ToUpper();
            char[] pilseta = pilsetas[x].ToCharArray();
            int q1, q2, i;
            char pag;
            n = pilseta.Length;
            for (i=1; i<10; i++)
            {
                q1 = rand.Next(n);
                q2 = rand.Next(n);
                pag = pilseta[q1];
                pilseta[q1] = pilseta[q2];
                pilseta[q2] = pag;
            }
            labPilseta.Text = "";
            for(i=0; i<n; i++){
                labPilseta.Text=labPilseta.Text+pilseta[i]; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butTurpinat.Visible = false;
            butParbaudit.Top = butTurpinat.Top;
            Pilseta();
        }

        private void butTurpinat_Click(object sender, EventArgs e)
        {
            Pilseta();
            txtAtbilde.Text = ""; 
            butParbaudit.Visible = true;
            butTurpinat.Visible = false;
            txtAtbilde.Enabled = true;
        }
    }
}

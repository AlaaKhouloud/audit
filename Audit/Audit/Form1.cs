using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Audit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        sphysique forme1;
        private void sécuritéPhysiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forme1 == null)
            {
                forme1 = new sphysique();
                forme1.MdiParent = this; 
                forme1.Show();
            }
            else
                forme1.Activate();
        }

        private void organiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade); 
        }

        slogique forme2;
        private void traitementsEtSuivisDesRisquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forme2 == null)
            {
                forme2 = new slogique();
                forme2.MdiParent = this;
                forme2.Show();
            }
            else
                forme2.Activate();
        }

        splan forme3;
        private void sauvegardeEtPlanDeSecourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forme3 == null)
            {
                forme3 = new splan();
                forme3.MdiParent = this;
                forme3.Show();
            }
            else
                forme3.Activate();
        }

        sControleStratgie forme4;
        private void stratégieEtControleInterneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forme4 == null)
            {
                forme4 = new sControleStratgie();
                forme4.MdiParent = this;
                forme4.Show();
            }
            else
                forme4.Activate();
        }

        gestionChangement forme5;
        private void gestionDesChangementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forme5 == null)
            {
                forme5 = new gestionChangement();
                forme5.MdiParent = this;
                forme5.Show();
            }
            else
                forme5.Activate();
        }

        ITIL forme6;
        private void iTILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forme6 == null)
            {
                forme6 = new ITIL();
                forme6.MdiParent = this;
                forme6.Show();
            }
            else
                forme6.Activate();
        }



 

        
    }
}

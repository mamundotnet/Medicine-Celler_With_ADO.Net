using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicine_Celler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entryEditDeleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMedicineCompany fmc = new frmMedicineCompany();
            fmc.Show();
            fmc.MdiParent = this;
        }

        private void entryEditDeleteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmMedicineForm fmc = new frmMedicineForm();
            fmc.Show();
            fmc.MdiParent = this;
        }

        private void insertUpdateDeleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMedicineInfo fmc = new frmMedicineInfo();
            fmc.Show();
            fmc.MdiParent = this;
        }

        private void entryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPurchaseInfo fmc = new frmPurchaseInfo();
            fmc.Show();
            fmc.MdiParent = this;
        }

        private void medicineInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineReport medic = new MedicineReport();
            medic.Show();
            medic.MdiParent = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epic_2._0
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btntroy_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form2 form2 = new Form2())
                {
                    this.Hide();
                    form2.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir the Troy saga: " + ex.Message);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        

        private void btncyclop_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form3 form3 = new Form3())
                {
                    this.Hide();
                    form3.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir the Cyclops saga: " + ex.Message);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        
        
        private void btnocean_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form4 form4 = new Form4())
                {
                    this.Hide();
                    form4.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir the ocean saga: " + ex.Message);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btncirce_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form5 form5 = new Form5())
                {
                    this.Hide();
                    form5.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir the circe saga: " + ex.Message);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnunderworld_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form6 form6 = new Form6())
                {
                    this.Hide();
                    form6.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir the underworld saga: " + ex.Message);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnthunder_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form7 form7 = new Form7())
                {
                    this.Hide();
                    form7.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir the Thunder saga: " + ex.Message);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
    
}

    


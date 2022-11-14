using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_vyjimky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            try
            {
                double aritm = 0;
                int soucet = 0;
                double pocetzapornychcisel = 0;
                int i;
                for (i = 0; i < textBox1.Lines.Length; i++)
                {
                    string aktualniradek = textBox1.Lines[i];
                    int n = int.Parse(aktualniradek);
                    if (n < 0)
                    {
                        soucet += n;
                        pocetzapornychcisel++;
                    }
                }
                checked
                {
                    aritm = (double)soucet / (double)pocetzapornychcisel;
                }
                if (i == 0)
                {
                    throw new Exception("Zadej nějaká celá čísla do TextBoxu!");
                }
                else if (pocetzapornychcisel == 0)
                {
                    throw new Exception("Nelze dělit nulou");
                }
                else
                {
                    MessageBox.Show("Aritmetický průměr záporných čísel z TextBoxu je: " + aritm);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadal jsi špatný formát!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Přetečení čísla, zadej menší!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala tato chyba: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Jsi na konci :)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

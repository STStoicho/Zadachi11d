using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("DOBRE LI STE DNES???", "NADPISSSSS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result1 != DialogResult.Yes)
            {
                return;
            }

            string vidPizza = "";
            string sizePizza = "";
            string dobavkiNaPizza = "";

            if (!string.IsNullOrEmpty(cb_pizza_selection.Text))
            {
                vidPizza = cb_pizza_selection.Text;
            }
            else
            {
                MessageBox.Show("Не си избрал пица!!!");
                cb_pizza_selection.Focus();
                return;
            }

            if (rb_small.Checked)
            {
                sizePizza = rb_small.Text;
            }
            if (rb_medium.Checked)
            {
                sizePizza = rb_medium.Text;
            }
            if (rb_large.Checked)
            {
                sizePizza = rb_large.Text;
            }

            if (sizePizza == "")
            {
                MessageBox.Show("Не си избрал размер!!!");
                return;
            }

            if (check_cubrica.Checked)
            {
                dobavkiNaPizza = dobavkiNaPizza + "," + check_cubrica.Text;
            }
            if (check_gorchica.Checked)
            {
                dobavkiNaPizza = dobavkiNaPizza + "," + check_gorchica.Text;
            }
            if (check_ketchup.Checked)
            {
                dobavkiNaPizza = dobavkiNaPizza + "," + check_ketchup.Text;
            }
            if (check_mayonese.Checked)
            {
                dobavkiNaPizza = dobavkiNaPizza + "," + check_mayonese.Text;
            }

            MessageBox.Show($"Ти избра {vidPizza}" + $", размер: \"{sizePizza}\"," + $" добавки: {dobavkiNaPizza}");



        }
    }
}

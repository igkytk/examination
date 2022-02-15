using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace bookkeeping
{
    public partial class InputForm : Form
    {
        private Action<Book.Item> inputAction;
        private Book.Item loadItem;

        public InputForm(Action<Book.Item> action, Book.Item item = null)
        {
            InitializeComponent();
            inputAction = action;
            loadItem = item;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            if (loadItem != null)
            {
                checkBox_continue.Enabled = false;

                textBox_name.Text = loadItem.Name;
                numericUpDown_total.Value = loadItem.TotalAmount;

                var tax = string.Format("{0:d}%", loadItem.TaxRate);
                var index = comboBox_tax.Items.IndexOf(tax);
                if (index >= 0)
                {
                    comboBox_tax.SelectedIndex = index;
                }
            }
        }

        private void button_decide_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Length > 0)
            {
                Debug.Assert(inputAction != null);

                inputAction(ToBookItem());

                if (!checkBox_continue.Checked)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                textBox_name.Focus();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Book.Item ToBookItem()
        {
            return new Book.Item() { 
                Name = textBox_name.Text, 
                TotalAmount = (int)numericUpDown_total.Value, 
                TaxRate = int.Parse(comboBox_tax.Text.Replace("%", "")) 
            };
        }
    }
}

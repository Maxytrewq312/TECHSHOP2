using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace TECHSHOP
{
    public partial class ORDERZ : Form
    {
        public ORDERZ()
        {
            InitializeComponent();
            ShowList();
        }

        void ShowList()
        {
            LVORDERZ.Items.Clear();
            foreach (ORDERS or in Program.HookanShop.ORDERS)
            {
                ListViewItem it = new ListViewItem(new string[]
                {
                    or.PRODUCTS.NAMEP, or.PRODUCTS.PRICEP, or.COUNT.ToString(), or.PRICEALL.ToString(), or.STATUSO
            });
                it.Tag = or;
                LVORDERZ.Items.Add(it);
            }
            LVORDERZ.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void ORDERZ_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LVORDERZ.SelectedItems.Count == 1)
            {
                ORDERS or = LVORDERZ.SelectedItems[0].Tag as ORDERS;
                or.STATUSO = Convert.ToString(STATUSCB.Text);
                Program.HookanShop.SaveChanges();
                ShowList();
            }
        }

        private void LABELSUMMA_Click(object sender, EventArgs e)
        {

        }

        private void LVORDERZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (LVORDERZ.SelectedItems.Count == 1)
                {
                    ORDERS or = LVORDERZ.SelectedItems[0].Tag as ORDERS;
                    Program.HookanShop.ORDERS.Remove(or);
                    Program.HookanShop.SaveChanges();
                    ShowList();
                    MessageBox.Show("Запись успешно удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

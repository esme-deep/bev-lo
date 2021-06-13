using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bovelo_SuperApp
{
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
            loadTable(null);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string data = txtChercher.Text;
            loadTable(data);
        }

        public void loadTable(string data)
        {
            List<Items> lista = new List<Items>();
            CtrlItems _ctrlItems = new CtrlItems();
            dataGridView1.DataSource = _ctrlItems.request(data);
        }

        private void grpItem_Enter(object sender, EventArgs e)
        {

        }

        

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            bool flag = false;

            Items _items = new Items();
            _items.Name_model_item = txtItem.Text;
            _items.Size_model_item = txtSize.Text;
            _items.Colour_model_item = txtColour.Text;
            _items.Price_model_item = double.Parse(txtPrice.Text);
            _items.Item_quantity = int.Parse(txtQuantity.Text);
            _items.Status_stock = cmbStatus.Text;
        

            CtrlItems ctrl = new CtrlItems();

   

            if (txtItem_ID.Text != "")
            {
                _items.Id_model_item = int.Parse(txtItem_ID.Text);
                flag = ctrl.update(_items);
            }
            else
            {
                flag = ctrl.insert(_items);
            }

            if (flag)
            {
                MessageBox.Show("Item saved");
                clear_data();
                loadTable(null);
            }

        }

        private void clear_data()
        {
            txtItem.Text = "";
            txtSize.Text = "";
            txtColour.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            cmbStatus.Text = "";
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            //txtItem_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtItem.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSize.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtColour.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtQuantity.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbStatus.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            bool flag = false;
            DialogResult message = MessageBox.Show("Are you sure that you want to delete the item?", "Exit", MessageBoxButtons.YesNoCancel);
            if (message == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                CtrlItems _ctrl = new CtrlItems();
                flag = _ctrl.delete(id);

                if (flag)
                {
                    MessageBox.Show("Item saved");
                    clear_data();
                    loadTable(null);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string status = cmbFilter.Text;
            loadTable(status);
        }

        private void itemsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}

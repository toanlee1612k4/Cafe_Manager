using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Form1 : Form
    {
        Dictionary<string, decimal> menuItems = new Dictionary<string, decimal>()
    {
        { "Cà phê đen", 25000 },
        { "Cà phê sữa", 30000 },
        { "Trà đá", 10000 },
        { "Sinh tố", 40000 },
        { "Nước ép", 35000 }
        };
        decimal totalPrice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvMenu.View = View.Details;
            lvMenu.Columns.Add("Tên món", 150);
            lvMenu.Columns.Add("Giá", 100);

            
            foreach (var item in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.Key);
                listViewItem.SubItems.Add(item.Value.ToString() + " VND");
                lvMenu.Items.Add(listViewItem);
            }
        
    }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lvMenu.SelectedItems.Count > 0)
            {
                var selectedItem = lvMenu.SelectedItems[0];
                string itemName = selectedItem.Text;
                decimal itemPrice = menuItems[itemName];

                int quantity;
                if (int.TryParse(txtQuantity.Text, out quantity) && quantity > 0)
                {
                    
                    decimal itemTotalPrice = itemPrice * quantity;

                    
                    lbCart.Items.Add($"{itemName} - Số lượng: {quantity} - Giá: {itemTotalPrice} VND");

                    
                    totalPrice += itemTotalPrice;

                    
                    lblTotalPrice.Text = $"Tổng tiền: {totalPrice} VND";

                    
                    txtQuantity.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món.");
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (lbCart.Items.Count > 0)
            {
                MessageBox.Show($"Tổng tiền thanh toán: {totalPrice} VND", "Thanh toán thành công");

                
                lbCart.Items.Clear();
                totalPrice = 0;
                lblTotalPrice.Text = "Tổng tiền: 0 VND";
            }
            else
            {
                MessageBox.Show("Giỏ hàng trống. Vui lòng chọn món.");
            }
        }
    
    }
}

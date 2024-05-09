using System.Windows.Forms;

namespace BiaManager.Components
{
    public partial class BillDetailItems : UserControl
    {
        public BillDetailItems()
        {
            InitializeComponent();
            panelSTT.Controls.Add(labelSTT);
            panelNameItem.Controls.Add(labelItemName);
            panelQuantity.Controls.Add(labelQuantity);
            panelPrice.Controls.Add(labelPrice);
        }

        public void SetInfoItems(int stt, string nameItem, int quantity, int price)
        {
            labelSTT.Text = stt.ToString();
            labelItemName.Text = nameItem.ToString();
            labelQuantity.Text = quantity.ToString();
            labelPrice.Text = price.ToString();
        }
    }
}

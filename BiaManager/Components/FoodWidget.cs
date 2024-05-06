using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BiaManager.Components
{
    public partial class FoodWidget : UserControl
    {
        public FoodWidget()
        {
            InitializeComponent();
        }
        public void SetFoodInfo(string name, int price, byte[] imageData)
        {
            FoodNameLabel.Text = name;
            MoneyQuantity.Text = price.ToString();

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                pictureBoxFood.Image = Image.FromStream(ms);
            }
        }
    }
}

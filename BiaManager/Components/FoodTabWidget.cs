using System.Drawing;
using System.Windows.Forms;

namespace BiaManager.Components
{
    public partial class FoodTabWidget : UserControl
    {
        private bool typeFoodContainerExpand = false;
        public FoodTabWidget()
        {
            InitializeComponent();
        }
        private void TypeFoodBtn_Click(object sender, System.EventArgs e)
        {
            ShowFoodTransition.Start();
        }

        private void ShowFoodTransition_Tick(object sender, System.EventArgs e)
        {
            if (!typeFoodContainerExpand)
            {
                panelTypeFoodContainer.Height += 10;
                if (panelTypeFoodContainer.Height >= 250)
                {
                    ShowFoodTransition.Stop();
                    typeFoodContainerExpand = true;
                }
            }
            else
            {
                panelTypeFoodContainer.Height -= 10;
                if (panelTypeFoodContainer.Height <= 40)
                {
                    ShowFoodTransition.Stop();
                    typeFoodContainerExpand = false;
                }
            }
        }

        public void AddFoodWidget(FoodWidget foodWidget)
        {
            flowLayoutPanelFoodContent.Controls.Add(foodWidget);
        }

        public void SetFoodTabInfo(string label, int num)
        {
            TypeFoodBtn.Text = label;
            if (num > 0)
            {
                pictureBoxNum.Show();
                labelNum.Show();
                labelNum.Text = num.ToString();
            }
        }

        private void FoodTabWidget_Load(object sender, System.EventArgs e)
        {
            pictureBoxNum.BackColor = Color.Transparent;
            pictureBoxNum.Hide();
            labelNum.Parent = pictureBoxNum;
            labelNum.Dock = DockStyle.Fill;
            labelNum.BringToFront();
            labelNum.TextAlign = ContentAlignment.MiddleCenter;
            labelNum.BackColor = Color.Transparent;
            labelNum.Hide();
        }
        public void AddFood(FoodWidget foodWidget)
        {
            flowLayoutPanelFoodContent.Controls.Add(foodWidget);
            foodWidget.BringToFront();
            foodWidget.Show();
        }
    }
}

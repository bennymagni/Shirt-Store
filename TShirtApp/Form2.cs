using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace TShirtApp
{
    public partial class FormConfirmation : Form
    {

        ClothSelected clothSelected = new ClothSelected();
        
         
        public FormConfirmation()
        {
            this.EnableBlur();
            BackColor = Color.Azure;
            TransparencyKey = Color.Azure;
            InitializeComponent();
        }

        private void FormConfirmation_Load(object sender, EventArgs e)
        {
            //picBxSelectedImage.Image = Image.FromFile(GetFolderPath(SpecialFolder.Personal) + @"\navy blue t-shirt.png");
        }

        public void SetImage(string picName)
        {
            picBxSelectedImage.ImageLocation = picName;

            picBxSelectedImage.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void displayOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 foorm = new Form1();

            clothSelected.Amount = Convert.ToInt32(txtBxAmount.Text);
            double totalAmountDue;

            if (radBtnSmall.Checked)
                clothSelected.Size = radBtnSmall.Text;
            else if(radBtnMedium.Checked)
                clothSelected.Size = radBtnMedium.Text;
            else if(radBtnLarge.Checked)
                clothSelected.Size = radBtnLarge.Text;
            else if(radBtnXLarge.Checked)
                clothSelected.Size= radBtnXLarge.Text;

            totalAmountDue = clothSelected.TotalCost(clothSelected.Amount, foorm.marker);

            MessageBox.Show($"You Selected {clothSelected.Amount} {clothSelected.Size}pieces \n\n Your total charge is {totalAmountDue:C}", "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GetMainForm().Close();
            if(radBtnLarge.Checked)
                radBtnLarge.Checked = false;
            else if(radBtnSmall.Checked)
                radBtnSmall.Checked = false;
            else if(radBtnMedium.Checked)
                radBtnMedium.Checked = false;
            else if(radBtnXLarge.Checked)
                radBtnXLarge.Checked = false;
            txtBxAmount.Text = "";
        }

        public FormConfirmation GetMainForm()
        {
            foreach (Form form in Application.OpenForms)
                if (form is FormConfirmation)
                    return (FormConfirmation)form;
            return null;
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetMainForm().Close();
        }
    }
}

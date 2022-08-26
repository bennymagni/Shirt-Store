using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TShirtApp
{
    public partial class Form1 : Form
    {

        FormConfirmation form2 = new FormConfirmation();
        public int marker;

        public Form1()
        {
            this.EnableBlur();
            BackColor = Color.Azure;
            TransparencyKey = Color.Azure;
            InitializeComponent();
            
            //guna2ShadowForm1.SetShadowForm(this);

            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent;
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;
        }

        private void NavyBlueShirt_Click(object sender, EventArgs e)
        {
            form2.SetImage("navy blue t-shirt.png");
            form2.EnableBlur();
            form2.ShowDialog();
            marker = Convert.ToInt32(picBxNavyBlue.Tag);
        }

        private void MichaelsSweatShirt_Click(object sender, EventArgs e)
        {
            form2.SetImage("Michaels SweatShirt.jpg");
            form2.EnableBlur();
            form2.ShowDialog();
            marker = Convert.ToInt32(picBxSweatShirt.Tag);
        }

        private void Jxmi_Click(object sender, EventArgs e)
        {
            form2.SetImage("Jxmi Sportswear.jpg");
            form2.EnableBlur();
            form2.ShowDialog();
            marker = Convert.ToInt32(picBxJxmi.Tag);
        }

        private void picBxLongSleeve_Click(object sender, EventArgs e)
        {
            form2.SetImage("Reece Long-Sleeve.jpg");
            form2.EnableBlur();
            form2.ShowDialog();
            marker =  Convert.ToInt32(picBxLongSleeve.Tag);
        }

        private void picBxHoodie_Click(object sender, EventArgs e)
        {
            form2.SetImage("Louis Vuitton Hoodies.jpg");
            form2.EnableBlur();
            form2.ShowDialog();
            marker = Convert.ToInt32(picBxHoodie.Tag);
        }

        private void picBxWhiteTop_Click(object sender, EventArgs e)
        {
            form2.SetImage("Kory Winehouse White Top.jpg");
            form2.EnableBlur();
            form2.ShowDialog();
            marker = Convert.ToInt32(picBxWhiteTop.Tag);
        }


        /*protected override void OnPaintBackground(PaintEventArgs e)

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LimeGreen, e.ClipRectangle);
        }*/

    }

   
}

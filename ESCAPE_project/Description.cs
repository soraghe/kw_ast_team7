using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCAPE_project
{
    public partial class Description : Form
    {
        private Image descriptionscreen = Properties.Resources.pj_description;

        public Description()
        {
            InitializeComponent();
            SetBackGroundImage();
            this.AcceptButton = btnReturn;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.ClientSize = new Size(960, 540);
        }

        private void SetBackGroundImage()
        {
            Bitmap bitmap = new Bitmap(descriptionscreen.Width, descriptionscreen.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = 0.9f;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(descriptionscreen, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                            0, 0, descriptionscreen.Width, descriptionscreen.Height,
                            GraphicsUnit.Pixel, attributes);
            }
            this.BackgroundImage = bitmap;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

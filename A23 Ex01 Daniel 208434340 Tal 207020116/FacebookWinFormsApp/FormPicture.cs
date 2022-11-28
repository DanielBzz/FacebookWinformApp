using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPicture : Form
    {
        public FormPicture(string i_ImageUrl)
        {
            InitializeComponent();
            pictureBox.Load(i_ImageUrl);
            Size = pictureBox.Size;
        }

        public FormPicture(Image i_Image)
        {
            InitializeComponent();
            pictureBox.Image = i_Image;
            Size = pictureBox.Size;
        }
    }
}

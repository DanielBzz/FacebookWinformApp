using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPicture : Form
    {
        public FormPicture(string i_ImageUrl)
        {
            InitializeComponent();
            pictureBox.LoadAsync(i_ImageUrl);
        }

        public FormPicture(Image i_Image)
        {
            InitializeComponent();
            pictureBox.Image = i_Image;
        }
    }
}

using image_game.Properties;
using System.Windows.Forms;

namespace image_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbPen_CheckedChanged( object sender, System.EventArgs e )
        {
            pbImages.Image = Resources.Pen;
            lblImage.Text = ( ( RadioButton ) sender ).Tag.ToString();
        }

        private void rbBooks_CheckedChanged( object sender, System.EventArgs e )
        {
            pbImages.Image = Resources.Books;
            lblImage.Text = ( ( RadioButton ) sender ).Tag.ToString();
        }

        private void rbBoy_CheckedChanged( object sender, System.EventArgs e )
        {
            pbImages.Image = Resources.Boy;
            lblImage.Text = ( ( RadioButton ) sender ).Tag.ToString();
        }

        private void rbGirl_CheckedChanged( object sender, System.EventArgs e )
        {
            pbImages.Image = Resources.Girl;
            lblImage.Text = ( ( RadioButton ) sender ).Tag.ToString();
        }
    }
}

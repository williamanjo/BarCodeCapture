using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace BarCodeCapture
{
    public partial class BarCodeCapture : Form
    {
        public BarCodeCapture()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (Clipboard.ContainsImage())
            {

                pictureBox1.Image = Clipboard.GetImage();
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    textBox1.Text = result.ToString();
                    Clipboard.SetText(result.ToString());
                }
                else
                {
                    Clipboard.Clear();
                }
            }
            else {
                MessageBox.Show("Utilize a Combinação (Win + Shift + S) para capturar o Codigo de Barra");
            }
        }

        private void BarCodeCapture_Load(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {

                pictureBox1.Image = Clipboard.GetImage();
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    textBox1.Text = result.ToString();
                    Clipboard.SetText(result.ToString());
                }
                else
                {
                    Clipboard.Clear();
                }
            }
        }
    }
}

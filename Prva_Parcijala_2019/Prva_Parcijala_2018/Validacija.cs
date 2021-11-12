using System.Windows.Forms;

namespace Prva_Parcijala_2018
{
    internal class Validacija
    {
        public static bool Validiraj(Control control,ErrorProvider err)
        {
            if(control is TextBox)
            {
                var textBox = (TextBox)control;
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    err.SetError(textBox, "Ovo polje je obavezno");
                    return false;
                }
            }
            if (control is PictureBox)
            {
                var pic = (PictureBox)control;
                if (pic.Image == null)
                {
                    err.SetError(pic, "Ovo polje je obavezno");
                    return false;
                }
            }
            err.Clear();
            return true;
        }
    }
}

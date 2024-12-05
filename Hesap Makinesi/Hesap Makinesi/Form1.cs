using System.Data;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string islemIfadesi = txtInput.Text;

            try
            {
                DataTable dt = new DataTable();
                var sonuc = dt.Compute(islemIfadesi, "");
                lblResult.Text = "Sonuç: " + sonuc.ToString();
            }
            catch (Exception ex)
            {
                lblResult.Text = "Geçersiz iþlem ifadesi.";
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Clear(); // Hata sonrasý input alanýný temizliyoruz
                txtInput.Focus(); // Kullanýcýyý yeni bir iþlem girmesi için yönlendiriyoruz
            }
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalculate.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }
    }
}

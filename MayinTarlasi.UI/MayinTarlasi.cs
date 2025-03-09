namespace MayinTarlasi.UI
{
    public partial class MayinTarlasi : Form
    {
        public MayinTarlasi()
        {
            InitializeComponent();
        }
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            ButonOlustur();
        }
        private Dictionary<Button, bool> mayinlar = new();
        int mayinOlmayanButonSayisi;
        private void ButonOlustur()
        {
            grpMayinlar.Controls.Clear();
            mayinlar.Clear();
            mayinOlmayanButonSayisi = 0;

            Random rnd = new();
            int buttonBoyutu = 20;
            int bosluk = 11;

            int sutunSayisi = grpMayinlar.Height / (buttonBoyutu + bosluk);
            int satirSayisi = grpMayinlar.Width / (buttonBoyutu + bosluk);

            int toplamGenislik = satirSayisi * (buttonBoyutu + bosluk) - bosluk;
            int toplamYukseklik = sutunSayisi * (buttonBoyutu + bosluk) - bosluk;

            int baslangicX = (grpMayinlar.Width - toplamGenislik) / 2;
            int baslangicY = (grpMayinlar.Height - toplamYukseklik) / 2;

            int konumX = baslangicX;
            int konumY = baslangicY;

            for (int i = 0; i < sutunSayisi; i++)
            {
                for (int j = 0; j < satirSayisi; j++)
                {
                    Button button = new();
                    button.Width = buttonBoyutu;
                    button.Height = buttonBoyutu;
                    button.Location = new Point(konumX, konumY);
                    button.BackColor = Color.White;
                    button.Click += Button_Click;

                    bool mayinVarMi = rnd.Next(100) < 20; // ? true : false; // %20 ihtimalle mayýn atama

                    mayinlar.Add(button, mayinVarMi);
                    grpMayinlar.Controls.Add(button);

                    if (!mayinVarMi)
                    {
                        mayinOlmayanButonSayisi++;
                    }

                    konumX += buttonBoyutu + bosluk;
                }
                konumX = baslangicX;
                konumY += buttonBoyutu + bosluk;
            }
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            Button buton = sender as Button; // as ile casting iþlemi yapýldý
            bool mayinVarMi = mayinlar[buton];

            if (!mayinVarMi)
            {
                buton.BackColor = Color.Green;
                buton.Enabled = false;
                mayinOlmayanButonSayisi--;
            }
            if (mayinVarMi || mayinOlmayanButonSayisi == 0)
            {
                foreach (var mayin in mayinlar)
                {
                    mayin.Key.BackColor = mayin.Value ? Color.Red : Color.Green;
                    mayin.Key.Enabled = false;
                }
                MessageBox.Show("Kaybettiniz.", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult sonuc = MessageBox.Show("Yeni oyun oynamak ister misiniz?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    ButonOlustur();
                }
            }
        }
    }
}

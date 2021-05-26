using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;
namespace Savas.Library.Concrete
{
    public class Oyun : IOyun
    {
        #region Alanlar

        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private readonly Timer _hareketTimer = new Timer { Interval = 100 };
        private readonly Timer _SinekOlusturmaTimer = new Timer { Interval = 2500 };
        private TimeSpan _gecenSure;
        private readonly Panel _spiderPanel;
        private readonly Panel _savasAlaniPanel;
        private Orumcek _Orumcek;
        private readonly List<Ağ> _Ağlar = new List<Ağ>();
        private readonly List<Sinek> _Sinekler = new List<Sinek>();
        private readonly Label _gameOver;
        private readonly Label _scoreLabel;
        private readonly Panel _scoreTable;
        private readonly Label _endScore;
        private readonly Button _TekrarButton;


        #endregion

        #region Olaylar

        public event EventHandler GecenSureDegisti;

        #endregion

        #region Özellikler

        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSure
        {
            get => _gecenSure;
            private set
            {
                _gecenSure = value;

                GecenSureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool pauseControl { get; private set; }
        public static int score = 0;


        #endregion

        #region Metotlar

        public Oyun(Panel spiderPanel, Panel savasAlaniPanel, Label gameOver, Label scoreLabel, Panel scoreTable, Label endScore, Button TekrarButton)
        {
            _spiderPanel = spiderPanel;
            _savasAlaniPanel = savasAlaniPanel;
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _hareketTimer.Tick += HareketTimer_Tick;
            _SinekOlusturmaTimer.Tick += SinekOlusturmaTimer_Tick;
            _gameOver = gameOver;
            _scoreLabel = scoreLabel;
            _scoreTable = scoreTable;
            _endScore = endScore;
            _TekrarButton = TekrarButton;
        }


        public void Zorluk()
        {
            if (score == 80) {
                _hareketTimer.Enabled = false;
                _hareketTimer.Interval = 50;
                _hareketTimer.Enabled = true;
                _SinekOlusturmaTimer.Enabled = false;
                _SinekOlusturmaTimer.Interval = 2000;
                _SinekOlusturmaTimer.Enabled = true;
            }

            else if (score == 180) {
                _hareketTimer.Enabled = false;
                _hareketTimer.Interval = 40;
                _hareketTimer.Enabled = true;
                _SinekOlusturmaTimer.Enabled = false;
                _SinekOlusturmaTimer.Interval = 1500;
                _SinekOlusturmaTimer.Enabled = true;
            }

            else if (score == 280)
            {
                _hareketTimer.Enabled = false;
                _hareketTimer.Interval = 30;
                _hareketTimer.Enabled = true;
                _SinekOlusturmaTimer.Enabled = false;
                _SinekOlusturmaTimer.Interval = 1000;
                _SinekOlusturmaTimer.Enabled = true;
            }

            else if (score == 380)
            {
                _hareketTimer.Enabled = false;
                _hareketTimer.Interval = 20;
                _hareketTimer.Enabled = true;
                _SinekOlusturmaTimer.Enabled = false;
                _SinekOlusturmaTimer.Interval = 1000;
                _SinekOlusturmaTimer.Enabled = true;
            }

            else if (score == 480)
            {
                _hareketTimer.Enabled = false;
                _hareketTimer.Interval = 20;
                _hareketTimer.Enabled = true;
                _SinekOlusturmaTimer.Enabled = false;
                _SinekOlusturmaTimer.Interval = 500;
                _SinekOlusturmaTimer.Enabled = true;
            }
        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            if (pauseControl) return;
            GecenSure += TimeSpan.FromSeconds(1);
        }


        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            if (pauseControl) return;
            AğlariHareketEttir();
            SinekleriHareketEttir();
            VurulanSinekleriCikar();
        }

        private void VurulanSinekleriCikar()
        {
            for (var i = _Sinekler.Count - 1; i >= 0; i--)
            {
                var Sinek = _Sinekler[i];

                var vuranAğ = Sinek.VurulduMu(_Ağlar);
                if (vuranAğ is null) continue;

                _Sinekler.Remove(Sinek);
                _Ağlar.Remove(vuranAğ);
                _savasAlaniPanel.Controls.Remove(Sinek);
                _savasAlaniPanel.Controls.Remove(vuranAğ);
                Zorluk();
                score += 20;
                _scoreLabel.Text = Convert.ToString(score);
            }

        }

        private void SinekleriHareketEttir()
        {
            foreach (var Sinek in _Sinekler)
            {
                var carptiMi = Sinek.HareketEttir(Yon.Asagi);
                if (!carptiMi) continue;

                Bitir();
                break;
            }
        }

        private void SinekOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            SinekOlustur();
        }

        private void AğlariHareketEttir()
        {
            for (int i = _Ağlar.Count - 1; i >= 0; i--)
            {
                var Ağ = _Ağlar[i];
                var carptiMi = Ağ.HareketEttir(Yon.Yukari);
                if (carptiMi)
                {
                    _Ağlar.Remove(Ağ);
                    _savasAlaniPanel.Controls.Remove(Ağ);
                }
            }
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;
            
            ZamanlayicilariBaslat();
            OrumcekOlustur();
            SinekOlustur();
        }


        public void PControl()
        {
            if(pauseControl == true)
            {
                pauseControl = false;
            }
            else
            {
                pauseControl = true;
            }
        }

        private void SinekOlustur()
        {
            if (pauseControl) return;
            var Sinek = new Sinek(_savasAlaniPanel.Size);
            _Sinekler.Add(Sinek);
            _savasAlaniPanel.Controls.Add(Sinek);
        }

        private void ZamanlayicilariBaslat()
        {
            _gecenSureTimer.Start();
            _hareketTimer.Start();
            _SinekOlusturmaTimer.Start();
        }


        private void OrumcekOlustur()
        {
            if (!DevamEdiyorMu) return;
            _Orumcek = new Orumcek(_spiderPanel.Width, _spiderPanel.Size);
            _spiderPanel.Controls.Add(_Orumcek);
        }

        private void Bitir()
        {
            if (!DevamEdiyorMu) return;
            pauseControl = true;
            ZamanlayicilariDurdur();
            _gameOver.Visible = true;
            _endScore.Text = Convert.ToString(score);
            _scoreTable.Visible = true;
            _endScore.Visible = true;
            _TekrarButton.Visible = true;
            dosyayaYaz();
        }

        private void ZamanlayicilariDurdur()
        {
            _gecenSureTimer.Stop();
            _hareketTimer.Stop();
            _SinekOlusturmaTimer.Stop();
        }

        public void AtesEt()
        {
            if (!DevamEdiyorMu) return;
            if (pauseControl) return;

            var Ağ = new Ağ(_savasAlaniPanel.Size, _Orumcek.Center);
            _Ağlar.Add(Ağ);
            _savasAlaniPanel.Controls.Add(Ağ);
        }

        public void OrumcekiHareketEttir(Yon yon)
        {
            if (!DevamEdiyorMu) return;
            if (pauseControl) return;

            _Orumcek.HareketEttir(yon);
        }

        public void dosyayaYaz()
        {

            string DosyaYolu = "Yaz.txt";
            if (!(File.Exists(DosyaYolu)))
            {
                StreamWriter Yaz = new StreamWriter(DosyaYolu);
                Yaz.WriteLine("0");
                Yaz.WriteLine("0");
                Yaz.WriteLine("0");
                Yaz.WriteLine("0");
                Yaz.WriteLine("0");
                Yaz.Close();
            }

            string[] skorlar = File.ReadAllLines(DosyaYolu, Encoding.UTF8);

            List<int> yeniSkorList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                yeniSkorList.Add(Convert.ToInt32(skorlar[i]));
            }

            yeniSkorList.Sort();

            for (int i = 0; i < 5; i++)
            {
                if (score > Convert.ToInt32(skorlar[i]))
                {
                    yeniSkorList[0] = score;

                    yeniSkorList.Sort();


                    String lastScores = yeniSkorList[4].ToString() + "\n" +
                                    yeniSkorList[3].ToString() + "\n" +
                                    yeniSkorList[2].ToString() + "\n" +
                                    yeniSkorList[1].ToString() + "\n" +
                                    yeniSkorList[0].ToString() + "\n";


                    File.WriteAllText(DosyaYolu, lastScores);

                    break;
                }
            }

          //  _SkorTablosu.Text = yeniSkorList[4].ToString() + "\n" +
          //  yeniSkorList[3].ToString() + "\n" +
          //  yeniSkorList[2].ToString() + "\n" +
          //  yeniSkorList[1].ToString() + "\n" +
          //  yeniSkorList[0].ToString() + "\n";


        }


    }
        #endregion
    
}

using System;
using System.Windows.Forms;
using Savas.Library.Concrete;
using Savas.Library.Enum;

namespace Savas.Desktop
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun;

        public AnaForm()
        {
            InitializeComponent();

            _oyun = new Oyun(spiderPanel, savasAlaniPanel, gameOver, scoreLabel, scoreTable, endScore, TekrarButton);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.P:
                    _oyun.PControl();
                    break;
                case Keys.Right:
                    _oyun.OrumcekiHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.OrumcekiHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
            }
        }


        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            sureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
        }

        private void TekrarButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

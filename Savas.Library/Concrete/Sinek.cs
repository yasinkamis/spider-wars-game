using System;
using System.Collections.Generic;
using System.Drawing;
using Savas.Library.Abstract;
using Savas.Library.Concrete;

namespace Savas.Library.Concrete
{
    internal class Sinek : Cisim
    {
        private static readonly Random Random = new Random();
        public int Level { get; set; }

        public Sinek(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * .1);
            Left = Random.Next(hareketAlaniBoyutlari.Width - Width + 1);
        }


        public Ağ VurulduMu(List<Ağ> Ağlar)
        {
            foreach (var Ağ in Ağlar)
            {
                var vurulduMu = Ağ.Top < Bottom && Ağ.Right > Left && Ağ.Left < Right;
                if (vurulduMu) return Ağ;
            }
            return null;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kiemtraketthucmon
{
    class DongVat
    {
        public DongVat(string Keu)
        {
            this.Loai = Keu;
        }
        public DongVat()
        {

        }
        private string loai;

        public string Loai { get => loai; set => loai = value; }
        public virtual void Talk()
        {
            if (Loai.Equals("gau gau"))
                MessageBox.Show("Dog said " + this.Loai);
            else if (Loai.Equals("meo meo"))
                MessageBox.Show("Cat said " + this.Loai);
        }
    }
}

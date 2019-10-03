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
        public DongVat(string maulong)
        {
            this.Keu= maulong;
        }
        public DongVat()
        {

        }
        private string keu;

        public string Keu { get => keu; set => keu = value; }

        public virtual void Talk()
        {
            if (Keu.Equals("gau gau"))
                MessageBox.Show("Dog said " + this.Keu);
            else if (Keu.Equals("meo meo"))
                MessageBox.Show("Cat said " + this.Keu);
        }
    }
}

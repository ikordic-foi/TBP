using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_IvaKordic
{
    public partial class pacijent
    {
        public override string ToString()
        {
            return this.ime + " " + this.prezime;
        }
    }
}

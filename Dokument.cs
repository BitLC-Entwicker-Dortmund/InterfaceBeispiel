using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBeispiel {
    class Dokument {
        private string name;

        public void SetName ( string n ) {
            name = n;
        }

        public string GetName ( ) {
            return name;
        }
    }
}

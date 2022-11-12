using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBeispiel {
    class ExcelDokument : Dokument, IDruckbar {
        public void Drucken ( ) {
            Console.WriteLine ( "Excel" );
        }

        public void Erinnern ( ) {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBeispiel {
    class Program {
        static void Main ( string [ ] args ) {
            ExcelDokument d = new ExcelDokument ( );

            d.SetName ( "Mein Excel Wochenbericht" );
            Console.WriteLine ( d.GetName ( ) );
            d.Drucken ( );

            WordDokument wd = new WordDokument ( );
            wd.SetName ( "Word Dokument" );

            wd.Drucken ( );


            Console.ReadLine ( );
        }
    }
}

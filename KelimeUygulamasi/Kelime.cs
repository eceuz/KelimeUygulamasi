using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeUygulamasi
{
    //veritabanından çekilen kelimeleri uygulamada tutabilmek için bu sınıfı oluşturduk.
    internal class Kelime
    {
       
   
            public int Id { get; set; }
            public string Ingilizce { get; set; }
            public string Turkce { get; set; }
            public string GorselURL { get; set; }
        

    }
}

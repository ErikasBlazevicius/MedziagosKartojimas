using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas.Interface
{
    public interface IZodisKitaip
    {
        public string ZodisBeBalsiu();
        public string ZodisBePriebalsiu();
        public string ZodisSuPakeistomisBalsemis( char z);
        public string ZodisSuPakeistomisPriebalsemis( int x);

    }
}

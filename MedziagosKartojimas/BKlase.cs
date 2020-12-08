using MedziagosKartojimas.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
   
    public class BKlase : AKlase, IZodisKitaip
    {
        readonly List<char> balses = new List<char> { 'a', 'e', 'i', 'y', 'o', 'u' };
        public BKlase(string name) : base(name)
        {

        }

        public string ZodisBeBalsiu()
        {
            var str = new StringBuilder();
            foreach (var raide in Name) 
            {
                if (!balses.Contains(raide)) str.Append(raide);
            }
            return str.ToString();
        }
        

        public string ZodisBePriebalsiu()
        {
            throw new NotImplementedException();
        }

        public string ZodisSuPakeistomisBalsemis(char z)
        {
            throw new NotImplementedException();
        }

        public string ZodisSuPakeistomisPriebalsemis(int x)
        {
            throw new NotImplementedException();
        }
    }
}

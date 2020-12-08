using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MedziagosKartojimas
{
    public class AKlase : BaseClass
    {
       
        public AKlase(string name) : base(name)
        {

        }
        public override string NameMetodas()
        {
            var sb = new StringBuilder();
            List<char>balses = new List<char>{ 'a', 'e', 'i', 'y', 'o', 'u'};
            
            foreach (var raide in Name)
            {
                sb.Append(balses.Contains(raide) ? (int)raide : raide);
            }

            return sb.ToString();

        }


        public override int NameKodas(int a)
        {
            
        }
    }
}

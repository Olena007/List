using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHT.Models
{
    internal class Olivier : IEnumerable
    {
        string[] olivier = { "potatoes", "carrot", "eggs", "pickles", "peas", "mayonnais", "chiken" };

        public IEnumerator GetEnumerator()
        {
            return new Service.SalatEnumerator(olivier);
        }
    }
}

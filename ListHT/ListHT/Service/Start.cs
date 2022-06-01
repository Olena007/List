using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHT.Service
{
    internal class Start : Interface.IStart
    {
        public void Run()
        {
            List<string> list = new List<string>();
            var action = new Actions();

            action.Fill(list);
            action.Delete(list, "carrot");
            action.DelIndex(list, 1);
            action.SortList(list);

        }
    }
}

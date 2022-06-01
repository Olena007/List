using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHT.Service
{
    internal class Actions
    {
        public void Fill(List<string> list)
        {
            Models.Olivier olivier = new Models.Olivier();

            foreach (var item in olivier)
            {
                list.Add(item.ToString());
            }

            list.AddRange(new[] { "salt", "pepper" });
        }

        public bool Delete(List<string> list, string product)
        {
            if (list.Count != 0)
            {
                if (list.Contains(product))
                {
                    list.Remove(product);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void DelIndex(List<string> list, int i)
        {
            if (list.Count != 0 && i >= 0 && i < list.Count)
            {
                list.RemoveAt(i);
            }
        }

        public void SortList(List<string> list)
        {
            if (list.Count != 0)
            {
                list.Sort();
            }
        }
    }
}

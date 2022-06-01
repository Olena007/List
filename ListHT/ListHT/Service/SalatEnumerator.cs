using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHT.Service
{
    internal class SalatEnumerator : IEnumerator<string>
    {
        string[] ingredients;
        int position = -1;

        public SalatEnumerator(string[] ingredients)
        {
            this.ingredients = ingredients;
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= ingredients.Length)
                    throw new ArgumentException();
                return ingredients[position];
            }
        }

        string IEnumerator<string>.Current => throw new NotImplementedException();

        public void Dispose() { }

        public bool MoveNext()
        {
            if (position < ingredients.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset() => position = -1;
    }
}

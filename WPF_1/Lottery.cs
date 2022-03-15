using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_1
{
    class Lottery
    {
        private Random random = new Random();
        private List<string> list = new List<string>();

        public Lottery()
        {
            list.Add("rower");
            list.Add("samochod");
            list.Add("dom");
            list.Add("łopata");
        }

        public void Insert (String word)
        {
            list.Add(word);
        }
        public string TakeOutAndDelete()
        {

            int index = random.Next(0, list.Count);
            string word = list[index];
            list.RemoveAt(index);
            return word;
        }
        public bool IsEmpty()
        {
            if (list.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

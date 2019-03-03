using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._19
{
    class MyStack
    {
        private List<Mobile> mobiles1 = new List<Mobile>();
        public MyStack()
        {

        }
        public Mobile Pop ()
        {
            Mobile res = mobiles1[0];
            mobiles1.RemoveAt(0);
            return res;
        }
        public void push(Mobile mobile)
        {
            mobiles1.Add(mobile);
        }
        public int Size
        {
            get
            {
                return mobiles1.Count;
            }
        }
        public  void Clear()
        {
            mobiles1.Clear();
        }
        public void Init(List<Mobile> list)
        {
            mobiles1 = list;
        }
        public void Sort ()
        {
            mobiles1.Sort();
        }
        public Mobile Peap()
        {
            return mobiles1[0];
        }
    }
}

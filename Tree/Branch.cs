using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    //Rather a node then a branch but whatever
    internal class Branch
    {
        public List<Branch> branches { get; set; }
        public int data { get; set; }

        public Branch(int number)
        {
            this.data = number;
        }

        public void addBranch(int number)
        {
            if (branches == null) { branches = new List<Branch>(); }
            branches.Add(new Branch(number));
        }


        public void traverse()
        {
            Console.WriteLine(data);
            if(branches != null)
            {
                foreach (Branch b in branches)
                {
                    b.traverse();
                }
            }
        }
    }
}

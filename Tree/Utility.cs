using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal static class Utility
    {
        public static int getTreeDepth(Branch branch, int depth)
        {
            int result = depth;
            if(branch.branches != null)
            {
                foreach (Branch b in branch.branches)
                {
                    result = Math.Max(result, getTreeDepth(b, depth + 1));
                }
            }

            return result;
        }
    }
}

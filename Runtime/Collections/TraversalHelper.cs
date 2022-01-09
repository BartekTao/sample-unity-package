using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLib.Collections
{
    public static class TraversalHelper
    {
        public static List<T> PreOrder<T>(this TreeNode<T> treeNode)
        {
            var res = new List<T>();

            void preOrder(TreeNode<T> root)
            {
                if(root != null)
                {
                    res.Add(root.Value);
                    preOrder(root.Left);
                    preOrder(root.Right);
                }
            }
            preOrder(treeNode);
            return res;
        }

    }
}

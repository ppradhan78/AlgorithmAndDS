using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.BinaryTree.Generic
{
    public class Node<T>
    {
        public T data;
        public Node<T> left, right;

        public Node(T item)
        {
            data = item;
            left = right = null;
        }

    }
    public class BinaryTree<T>
    {
        public Node<T> root;
        public int MaxDepth(Node<T> node)
        {
            if (node == null)
                return -1;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = MaxDepth(node.left);
                int rDepth = MaxDepth(node.right);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.BinaryTree
{
    public class BinaryTreeNode
    {
        public int key;
        public BinaryTreeNode left, right;

        public BinaryTreeNode(int item)
        {
            key = item;
            left = right = null;
        }
    }
    public class BinaryTreeSimpleExample
    {
        public BinaryTreeNode root;

        // Constructors
        public BinaryTreeSimpleExample(int key)
        {
            root = new BinaryTreeNode(key);
        }

        public BinaryTreeSimpleExample()
        {
            root = null;
        }
    }
}

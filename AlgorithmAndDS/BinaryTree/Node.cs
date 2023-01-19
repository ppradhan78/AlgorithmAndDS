using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.BinaryTree
{
   public  class Node
    {
      public  int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
    public class BinaryTreeExample
    {
        // Root of Binary Tree
        Node root;

        // Constructors
        BinaryTreeExample(int key)
        {
            root = new Node(key);
        }

        public BinaryTreeExample()
        {
            root = null;
        }
        public  void TreeTrav()
        {
            BinaryTreeExample tree = new BinaryTreeExample();

            /*create root*/
            tree.root = new Node(1);

            /* following is the tree after above statement

                 1
                / \
             null null     */
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);

            /* 2 and 3 become left and right children of 1
                    1
                 /     \
               2        3
             /  \     /   \
           null null null null */
            tree.root.left.left = new Node(4);

            /* 4 becomes left child of 2
                    1
                 /     \
               2        3
             /  \     /   \
             4 null null null
            / \
         null null
            */
        }
        // Driver Code
     
    }
}

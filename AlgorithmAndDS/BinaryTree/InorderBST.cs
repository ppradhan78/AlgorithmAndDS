using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.BinaryTree
{

    public class InorderBST
    {
        // Root of BST
        Node root;

        // Constructor
        public InorderBST()
        {
            root = null;
        }

        public InorderBST(int value)
        {
            root = new Node(value);
        }

        // This method mainly calls insertRec()
        public void insert(int key)
        {
            root = insertRec(root, key);
        }

        // A recursive function to insert
        // a new key in BST
        public static Node insertRec(Node root, int key)
        {

            // If the tree is empty,
            // return a new node
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            // Otherwise, recur down the tree
            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);

            // Return the (unchanged) node pointer
            return root;
        }
        public static Node InsertToTree(Node root, int val)
        {

            // If the tree is empty,
            // return a new node
            if (root == null)
            {
                root = new Node(val);
                return root;
            }
            if (root.key > val)
            {
                //Left sub tree
                root.left = InsertToTree(root.left, val);
            }
            else
            {
                //right
                root.right = InsertToTree(root.right, val);

            }
            return root;
        }
        public static void inorderTravals(Node root)
        {
            if (root==null)
            {
                return;
            }
            inorderTravals(root.left);
            Console.WriteLine(root.key + "  ");
            inorderTravals(root.right);
        }

        public static bool Search(Node root,int data)
        {
            if (root==null)
            {
                Console.WriteLine("Not Found " +data);
                return false;
            }
            else if  (root.key ==data)
            {
                Console.WriteLine("Found  "+ data);
                return true;
            }
            else if (root.key > data)
            {
                return Search(root.left, data);
            }
            else
            {
                return Search(root.right, data);
            }

        }
        // This method mainly calls InorderRec()
        public void inorder()
        {
            inorderRec(root);
        }

        // A utility function to
        // do inorder traversal of BST
        void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.WriteLine(root.key);
                inorderRec(root.right);
            }
        }
    }

}

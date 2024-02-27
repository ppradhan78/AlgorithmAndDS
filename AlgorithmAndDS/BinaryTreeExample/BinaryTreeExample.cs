namespace AlgorithmAndDS.BinaryTreeExample
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }
    public class BinaryTree
    {
        public Node root;
        public Node root1, root2;
        public int maxDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                int lDepth = maxDepth(node.left);
                int rDepth = maxDepth(node.right);

                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }
        public bool identicalTrees(Node a, Node b)
        {
            /*1. both empty */
            if (a == null && b == null)
            {
                return true;
            }

            /* 2. both non-empty -> compare them */
            if (a != null && b != null)
            {
                return (a.data == b.data
                        && identicalTrees(a.left, b.left)
                        && identicalTrees(a.right, b.right));
            }

            /* 3. one empty, one not -> false */
            return false;
        }
        public int height(Node node)
        {
            /* base case tree is empty */
            if (node == null)
            {
                return 0;
            }

            /* If tree is not empty then height = 1 + max of
            left height and right heights */
            return 1
                + Math.Max(height(node.left),
                           height(node.right));
        }
    }
}

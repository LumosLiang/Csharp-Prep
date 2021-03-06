namespace LeetCode
{
   
    public class Leetcode_226_Invert_Binary_Tree

    {
        public TreeNode InvertTree(TreeNode root)
        {

            if (root is null) return null;

            TreeNode left = InvertTree(root.left);
            TreeNode right = InvertTree(root.right);

            root.left = right;
            root.right = left;
            return root;
        }
    }
}
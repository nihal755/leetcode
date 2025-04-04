public class Solution {
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        return DFS(root).node;
    }

    private (TreeNode node, int depth) DFS(TreeNode root) {
        if (root == null) return (null, 0);

        var left = DFS(root.left);
        var right = DFS(root.right);

        if (left.depth > right.depth)
            return (left.node, left.depth + 1);
        else if (right.depth > left.depth)
            return (right.node, right.depth + 1);
        else
            return (root, left.depth + 1);
    }
}

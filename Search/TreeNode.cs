using System;

namespace Tree;

class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    public TreeNode Root;

    public TreeNode Search(int target)
    {
        return SearchRecursively(Root, target);
    }

    private TreeNode SearchRecursively(TreeNode node, int target)
    {
        if (node == null || node.Value == target)
            return node;

        if (target < node.Value)
            return SearchRecursively(node.Left, target);

        return SearchRecursively(node.Right, target);
    }
}

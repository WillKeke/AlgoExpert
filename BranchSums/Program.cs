// See https://aka.ms/new-console-template for more information
using static System.Console;



List<int> BranchSums(BinaryTree root)
{
    List<int> sums = new List<int>();
    calculateBranchSums(root, 0, sums);
    return sums;
}


void calculateBranchSums(BinaryTree node, int runningSum, List<int> sums)
{
    if (node == null) return;

    int newRunningSum = runningSum + node.value;
    if (node.left == null && node.right == null)
    {
        sums.Add(newRunningSum);
        return;
    }
    calculateBranchSums(node.left, newRunningSum, sums);
    calculateBranchSums(node.right, newRunningSum, sums);
}

public class BinaryTree
{
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
}
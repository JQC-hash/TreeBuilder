using LeetCode.Models.TreeNode;

public class Application {
    public static void Main(){
        //Example Tree 1, sourced from https://leetcode.com/problems/maximum-binary-tree/
        TreeNode? root1 = TreeNode.BuildTree(new int?[] {6,3,5,null,2,0,null,null,1});

        //Example Tree 2, sourced from https://leetcode.com/problems/deepest-leaves-sum/
        TreeNode? root2 = TreeNode.BuildTree(new int?[] {1,2,3,4,5,null,6,7,null,null,null,null,8});
    }    
}

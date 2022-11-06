namespace YourProjectFolder.YourModelFolder.TreeNode{
    public class TreeNode {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static TreeNode? BuildTree(int?[] arr){
            if (arr is null || arr.Length == 0 || arr[0] is null)
                return null;

            Queue<TreeNode> q = new Queue<TreeNode>();
            TreeNode root = new TreeNode(arr[0]!.Value);
            q.Enqueue(root);

            int index = 1;
            
            while (q.Count > 0 && index < arr.Length){
                TreeNode node = q.Dequeue();

                if (arr[index] is not null){
                    node.left = new TreeNode(arr[index]!.Value);
                    q.Enqueue(node.left);
                }
                index++;

                if (index < arr.Length && arr[index] is not null){
                    node.right = new TreeNode(arr[index]!.Value);
                    q.Enqueue(node.right);
                }
                index++;
            }

            return root;
        }
    }
}

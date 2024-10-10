namespace Programming101CS.OOP {
    internal class BinaryTree<T> {
        public BinaryTreeNode<T> Root { get; private set; }

        public BinaryTree(BinaryTreeNode<T> root) {
            Root = root;
        }

        public void AddChild(BinaryTreeNode<T> newNode) {
            var node = GetWideFirstChildEmptyNode();
            if (node != null)
                if (node.LeftChild == null) node.LeftChild = newNode;
                else node.RightChild = newNode;
        }

        private BinaryTreeNode<T> GetWideFirstChildEmptyNode() {
            if (Root == null)
                return null;

            var queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0) {
                var currentNode = queue.Dequeue();

                if (currentNode == null)
                    return null;

                if (currentNode.LeftChild == null || currentNode.RightChild == null)
                    return currentNode;

                if (currentNode.LeftChild != null)
                    queue.Enqueue(currentNode.LeftChild);

                if (currentNode.RightChild != null)
                    queue.Enqueue(currentNode.RightChild);
            }

            return null;
        }

        public void PrintTree() {
            if (Root != null) {
                var queue = new Queue<BinaryTreeNode<T>>();
                queue.Enqueue(Root);

                while (queue.Count > 0) {
                    var currentNode = queue.Dequeue();
                    if (currentNode == null)
                        continue;

                    if (currentNode.LeftChild != null)
                        queue.Enqueue(currentNode.LeftChild);
                    if (currentNode.RightChild != null)
                        queue.Enqueue(currentNode.RightChild);

                    Console.WriteLine($"{currentNode}");
                }
            }
        }
    }
}

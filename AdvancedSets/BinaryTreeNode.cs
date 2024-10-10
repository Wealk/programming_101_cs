namespace Programming101CS.OOP {
    internal class BinaryTreeNode<Z> {
        public Z Value { get; private set; }
        public BinaryTreeNode<Z> LeftChild { get; set; }
        public BinaryTreeNode<Z> RightChild { get; set; }

        public BinaryTreeNode(Z value) {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }

        public override string ToString() {
            var left = "null";
            if (LeftChild != null) left = LeftChild.Value.ToString();

            var right = "null";
            if (RightChild != null) right = RightChild.Value.ToString();

            return $"Node value: {Value}\n- Left node: {left}\n- Right node: {right}";
        }
    }
}

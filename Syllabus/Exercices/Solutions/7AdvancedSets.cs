using Programming101CS.OOP;

namespace Programming101CS.Syllabus.Exercices.Solutions {
    internal class AdvancedSets {
        public static void Solution() {
            Console.WriteLine("a) Declara una variable mediante BinaryTree<char>(new BinaryTreeNode<char>('H')) y añade los nodos BinaryTreeNode<char>('o'), BinaryTreeNode<char>('l'), BinaryTreeNode<char>('a') mediante tree.AddChild(...):");
            var tree = new BinaryTree<char>(new BinaryTreeNode<char>('H'));
            tree.AddChild(new BinaryTreeNode<char>('o'));
            tree.AddChild(new BinaryTreeNode<char>('l'));
            tree.AddChild(new BinaryTreeNode<char>('a'));

            tree.PrintTree();
        }
    }
}

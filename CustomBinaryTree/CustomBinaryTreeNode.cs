using System;

namespace CustomBinaryTree
{
    public class CustomBinaryTreeNode<T> where T : IComparable
    {
        public CustomBinaryTreeNode<T> LeftNode { get; set; }
        public CustomBinaryTreeNode<T> RightNode { get; set; }
        public T Data { get; set; }

        public CustomBinaryTreeNode (T data, CustomBinaryTreeNode<T> left, CustomBinaryTreeNode<T> right)
        {
            this.Data = data;
            this.LeftNode = left;
            this.RightNode = right;
        }

        public CustomBinaryTreeNode(T data)
        {
            this.Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
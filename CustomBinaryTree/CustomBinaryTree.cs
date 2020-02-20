using System;
using System.Collections.Generic;

namespace CustomBinaryTree
{
    public class CustomBinaryTree<T> where T : IComparable
    {
        public CustomBinaryTreeNode<T> Root { get; private set; }

        public CustomBinaryTree()
        {
            Root = null;
        }

        public void Add(T data)
        {
            CustomBinaryTreeNode<T> previous = null, current = Root;

            while (current != null)
            {
                previous = current;
                if (current.Data.CompareTo(data) > 0)
                {
                    current = current.LeftNode;
                }
                else if (current.Data.CompareTo(data) < 0)
                {
                    current = current.RightNode;
                }
                else return;
            }

            CustomBinaryTreeNode<T> node = new CustomBinaryTreeNode<T>(data);
            if (previous == null)
            {
                Root = node;
            }
            else
            {
                if (previous.Data.CompareTo(data) > 0)
                {
                    previous.LeftNode = node;
                }
                else
                    previous.RightNode = node;
            }
        }

        public void Delete(T data)
        {
            Delete(Root, data);
        }

        private CustomBinaryTreeNode<T> Delete(CustomBinaryTreeNode<T> node, T data)
        {
            if (node == null)
            {
                return node;
            }

            if (node.Data.CompareTo(data) > 0)
            {
                node.LeftNode = Delete(node.LeftNode, data);
            }
            else if (node.Data.CompareTo(data) < 0)
            {
                node.RightNode = Delete(node.RightNode, data);
            }
            else
            {
                if (node.LeftNode == null)
                {
                    return node.RightNode;
                }
                else if (node.RightNode == null)
                {
                    return node.LeftNode;
                }

                T tempData = node.RightNode.Data;
                while (node.RightNode.LeftNode != null)
                {
                    tempData = node.RightNode.LeftNode.Data;
                    node.RightNode = node.RightNode.LeftNode;
                }

                node.Data = tempData;
                node.RightNode = Delete(node.RightNode, node.Data);
            }

            return node;
        }

        public CustomBinaryTreeNode<T> Search(T data)
        {
            return Search(Root, data);
        }

        private CustomBinaryTreeNode<T> Search(CustomBinaryTreeNode<T> node, T data)
        {
            if (node == null || node.Data.CompareTo(data) == 0)
            {
                return node;
            }
            if (node.Data.CompareTo(data) > 0)
            {
                return Search(node.LeftNode, data);
            }
            return Search(node.RightNode, data);
        }

        public void Print()
        {
            Print(Root);
        }

        private void Print(CustomBinaryTreeNode<T> node)
        {
            if (node != null)
            {
                Print(node.LeftNode);
                Console.WriteLine(node.Data);
                Print(node.RightNode);
            }
        }
    }
}
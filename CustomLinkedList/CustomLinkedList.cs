using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class CustomLinkedList<T> : IEnumerable, IEnumerable<T>
    { 
        
        private CustomLinkedListNode<T> firstNode;
        private CustomLinkedListNode<T> lastNode;

        public int Length { get; private set; }
        
        //implemented methods
        public IEnumerator<T> GetEnumerator()
        {
            return new CustomLinkedListEnumerator<T>(this.firstNode, this.lastNode, this.Length);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        //custom implementation
        public CustomLinkedList()
        {
            this.firstNode = null;
            this.lastNode = null;
            this.Length = 0;
        }

        public void AddLast(T item)
        {
            if (firstNode == null)
            {
                this.firstNode = new CustomLinkedListNode<T>(item, null, null);
                this.lastNode = firstNode;
                this.Length++;
            }
            else
            {
                CustomLinkedListNode<T> newNode = new CustomLinkedListNode<T>(item, null, this.lastNode);
                this.lastNode.NextNode = newNode;
                this.lastNode = newNode;
                this.Length++;
            }
        }

        public void AddFirst(T item)
        {
            if (firstNode == null)
            {
                this.firstNode = new CustomLinkedListNode<T>(item, null, null);
                this.lastNode = firstNode;
                this.Length++;
            }
            else
            {
                CustomLinkedListNode<T> newLink = new CustomLinkedListNode<T>(item, this.firstNode, null);
                this.firstNode.PreviousNode = newLink;
                this.firstNode = newLink;
                this.Length++;
            }
        }

        public void RemoveFirst()
        {
            if (firstNode != null)
            {
                if (this.Length == 1)
                {
                    this.firstNode = null;
                    this.lastNode = null;
                    this.Length--;
                }
                else
                {
                    this.firstNode.NextNode.PreviousNode = null;
                    this.firstNode = this.firstNode.NextNode;
                    this.Length--;
                }
            }
        }

        public void RemoveLast()
        {
            if (firstNode != null)
            {
                if (this.Length == 1)
                {
                    this.firstNode = null;
                    this.lastNode = null;
                    this.Length--;
                }
                else
                {
                    this.lastNode.PreviousNode.NextNode = null;
                    this.lastNode = this.lastNode.PreviousNode;
                    this.Length--;
                }
            }
        }

        public T PeekFirst()
        {
            if (this.firstNode == null)
            {
                throw new Exception("No items to peek at");
            }

            return this.firstNode.Data;
        }

        public T PeekLast()
        {
            if (this.firstNode == null)
            {
                throw new Exception("No items to peek at");
            }

            return this.lastNode.Data;
        }

        public void ReverseList()
        {
            CustomLinkedListNode<T> temporaryNode = null;
            CustomLinkedListNode<T> currentNode = this.firstNode;

            while (currentNode != null)
            {
                temporaryNode = currentNode.PreviousNode;
                currentNode.PreviousNode = currentNode.NextNode;
                currentNode.NextNode = temporaryNode;
                currentNode = currentNode.PreviousNode;
            }

            if (temporaryNode != null)
            {
                this.firstNode = temporaryNode.PreviousNode;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("[").Append(this.Length).Append("] ");

            for (CustomLinkedListNode<T> node = this.firstNode; node != null; node = node.NextNode)
            {
                result.Append(":").Append(node.Data.ToString()).Append(":");
            }

            return result.ToString();
        }
    }
}
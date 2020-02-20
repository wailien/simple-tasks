using System.Collections;
using System.Collections.Generic;

namespace CustomLinkedList
{
    public class CustomLinkedListEnumerator<T> : IEnumerator, IEnumerator<T>
    {
        private CustomLinkedListNode<T> firstNode;
        private CustomLinkedListNode<T> lastNode;
        private CustomLinkedListNode<T> currentNode;
        private int length;
        private bool enumerationStarted;

        public CustomLinkedListEnumerator(CustomLinkedListNode<T> first, CustomLinkedListNode<T> last, int len)
        {
            this.firstNode = first;
            this.lastNode = last;
            this.currentNode = null;
            this.length = len;
            this.enumerationStarted = false;
        }

        public bool MoveNext()
        {
            if (this.enumerationStarted == false)
            {
                this.currentNode = this.firstNode;
                this.enumerationStarted = true;
            }
            else
            {
                this.currentNode = this.currentNode.NextNode;
            }
            
            return this.currentNode != null;
        }

        public void Reset()
        {
            this.currentNode = this.firstNode;
        }

        public T Current
        {
            get { return this.currentNode.Data; }
        }

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            this.firstNode = null;
            this.lastNode = null;
            this.currentNode = null;
        }
    }
}
//     public struct LinkedListEnumerator : IEnumerator<T>, IEnumerator
//     {
//         private Link<T> head;
//         private Link<T> tail;
//         private Link<T> currentLink;
//         private int length;
//         private bool startedFlag;
//
//         public LinkedListEnumerator(Link<T> head, Link<T> tail, int length)
//         {
//             this.head = head;
//             this.tail = tail;
//             this.currentLink = null;
//             this.length = length;
//             this.startedFlag = false;
//         }
//
//         public T Current
//         {
//             get { return this.currentLink.Data; }
//         }
//
//         public void Dispose()
//         {
//             this.head = null;
//             this.tail = null;
//             this.currentLink = null;
//         }
//
//         object IEnumerator.Current
//         {
//             get { return this.currentLink.Data; }
//         }
//
//         public bool MoveNext()
//         {
//             if (this.startedFlag == false)
//             {
//                 this.currentLink = this.head;
//                 this.startedFlag = true;
//             }
//             else
//             {
//                 this.currentLink = this.currentLink.Next;
//             }
//
//             return this.currentLink != null;
//         }
//
//         public void Reset()
//         {
//             this.currentLink = this.head;
//         }
//     }
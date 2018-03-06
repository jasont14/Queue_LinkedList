/*
*****************************************
* LinkedListQueue.cs           2018     *
*                                       *
* Simple example of Queue using         *
* LinkedList                            *
*                                       *
* Jason Thatcher                        *
*****************************************
*/

using System;

namespace LinkedListQueue
{
    class LinkedListQueue<T>
    {
        protected class Node
        {
            public Node next;
            public T value;
        }

        Node head;
        Node tail;

        public LinkedListQueue()
        {

        }

        public void Enqueue(T value)
        {
            Node n = new Node();
            n.value = value;

            n.next = head;
            head = n;
        }

        public T Dequeue()
        {
            Node temp = head;
            T result;

            if (head == null)
            {
                throw new LinkedListQueueEmptyException("Cannot Dequeue() because Queue is empty");
            }

            else if (head.next == tail)
            {
                result = tail.value;
                head.next = null;
                tail = head;
            }
            else if (head.next == null)
            {
                result = head.value;
                head = null;
            }
            else
            {
                //find penultimate
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

                result = temp.next.value;

                temp.next = null;
                tail = temp;
            }

            return result;
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

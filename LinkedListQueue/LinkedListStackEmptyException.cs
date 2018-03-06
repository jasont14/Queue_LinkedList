/*
*****************************************
* LinkedListQueueException.cs  2018     *
*                                       *
* Exception class to deal with empty    *
*                                       *
* Jason Thatcher                        *
*****************************************
*/

using System;

namespace LinkedListQueue
{
    [Serializable]
    public class LinkedListQueueEmptyException : Exception
    {
        public LinkedListQueueEmptyException() { }
        public LinkedListQueueEmptyException(string message) : base(message) { }
        public LinkedListQueueEmptyException(string message, Exception inner) : base(message, inner) { }
        protected LinkedListQueueEmptyException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}

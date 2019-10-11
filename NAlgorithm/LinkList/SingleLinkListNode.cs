using System;
using System.Collections.Generic;
using System.Text;

namespace NAlgorithm.LinkList
{
    public class SingleLinkListNode
    {
        public SingleLinkListNode(string data)
        {
            this.Data = data;
        }

        public string Data { get; set; }

        public SingleLinkListNode Next { get; set; }

        public bool HasNext => Next != null;
    }
}

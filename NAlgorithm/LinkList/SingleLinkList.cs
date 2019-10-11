using System;
using System.Collections.Generic;
using System.Text;

namespace NAlgorithm.LinkList
{
    public class SingleLinkList
    {
        public SingleLinkList(SingleLinkListNode head = null)
        {
            this.Head = head;
        }

        public SingleLinkListNode Head { get; set; }

        /// <summary>
        /// 向链表添加新的结点
        /// </summary>
        /// <param name="newElement"></param>
        public void Append(SingleLinkListNode newElement)
        {
            // 将头部结点指向临时变量 current
            var current = this.Head;

            if (current != null)
            {
                // 循环遍历到链表的最后一个元素
                while (current.HasNext)

                    current = current.Next;

                current.Next = newElement;
            }
            else
            {
                this.Head = newElement;
            }
        }

        public bool IsEmpty => this.Head == null;

        public int GetLength()
        {
            var temp = this.Head;
            var length = 0;

            while (temp.HasNext)
                length++;

            return length;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="position">位置</param>
        /// <param name="newElement">节点</param>
        public void Insert(int position, SingleLinkListNode newElement)
        {
            if (position < 0 || position > this.GetLength())
                throw new Exception("insert 插入时超出了范围");

            var temp = this.Head;


            // 遍历找到索引值为 position 的结点后, 在其后面插入结点
            if (position == 0)
            {
                newElement.Next = temp;
                this.Head = newElement;
                return;
            }

            // 遍历找到索引值为 position 的结点后, 在其后面插入结点
            var i = 0;
            var pre = temp;

            while (i < position)
            {
                pre = temp;
                temp = temp.Next;
                i++;
            }

            pre.Next = newElement;
            newElement.Next = temp;
        }

        public void Remove(int position)
        {
            if (position < 0 || position > this.GetLength() - 1)
                throw new Exception("insert 插入时超出了范围");

            var i = 0;
            var temp = this.Head;

            while(temp != null)
            {
                if(position == 0)
                {
                    this.Head = temp.Next;
                    //temp.Next = null;

                    return;
                }

                var pre = temp;

                temp = temp.Next;

                i++;

                if(i == position)
                {
                    pre.Next = temp.Next;

                    return;
                }
            }
        }
    }
}

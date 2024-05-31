using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_WindowsFomsApp
{
    public class LinkedList
    {
        public Node head;
        public Node tail;
        public int count;

        public LinkedList(Point p)
        {
            head = new Node();
            tail = new Node();
            tail.next = null;
            tail.prew = head;
            head.next = tail;
            head.prew = null;
            head.data = p;
            tail.data = p;
            count = 1;
        }
        public void Add(Point p)
        {
            Node newNode = new Node();
            newNode.data = p;
            newNode.prew = null;
            newNode.next = head;
            head = newNode;
            count++;
        }
        public void Remove()
        {
            Node tempNode = tail.prew;
            tempNode.next = null;
            count--;
        }
    }
}

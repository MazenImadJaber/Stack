using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {

        static int CAPACITY = 10;
        private int capacity;
        private int numElements;
        private int[] data;


        /// constructor initializes stack
        public Stack() {
            capacity = CAPACITY;
            numElements = 0;
            data = new int[CAPACITY];
        }
        /// frees any dynamic storage
        ~Stack()
        {
            data = null;
            Console.WriteLine("stack destructor has been called");
        }

        /// returns number of elements in the stack
        public int size()
        {
            return numElements;
        }

        /// return true if the stack is empty
        public bool empty()
        {
            if (numElements == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// adds an element to the top of the stack
        public void push(int value)
        { //ensure to check if stack is full
            if (numElements < capacity)
            {
                data[numElements] = value;
                numElements++;
            }
        }

        /// returns the element from the top of the stack and removes it
        public int pop()
        {
            int value = -1;
            if (!empty())
            {
                value = data[numElements - 1];
                Array.Clear(data, numElements - 1, 1);
                numElements--;
                
            }
            return value;
        }

        /// returns the element from the top of the stack
        public int peek()
        {
            return data[numElements - 1];
        }

    }
}

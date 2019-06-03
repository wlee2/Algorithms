using System;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Que a = new Que();
            for(int i = 1; i < 12; i++)
            {
                a.pushBack(i);
            }
            a.printer();

            for(int j = 0; j < 5; j++)
            {
                a.pop();
            }
            a.printer();

            for (int i = 12; i < 25; i++)
            {
                a.pushBack(i);
            }
            a.printer();

            for (int j = 0; j < 4; j++)
            {
                a.pop();
            }
            a.printer();

            for (int i = 25; i < 27; i++)
            {
                a.pushBack(i);
            }
            a.printer();

            for (int i = 27; i < 37; i++)
            {
                a.pushBack(i);
            }
            a.printer();

            for (int j = 0; j < 30; j++)
            {
                a.pop();
            }
            a.printer();

            for (int i = 37; i < 48; i++)
            {
                a.pushBack(i);
            }
            a.printer();

            for (int i = 48; i < 52; i++)
            {
                a.pushBack(i);
            }
            a.printer();
        }
    }

    class Que
    {
        int[] container;
        int startPoint;
        int topBufferSize;
        int currentPoint;

        public Que()
        {
            this.topBufferSize = 10;
            this.container = new int[topBufferSize];
            this.startPoint = 0;
            this.currentPoint = 0;
        }

        public void pushBack(int element)
        {
            if(currentPoint == topBufferSize)
            {
                this.topBufferSize += 10;
                int[] temp = new int[topBufferSize];
                int count = 0;
                for(int i = this.startPoint; i < this.currentPoint; i++)
                {
                    temp[count++] = this.container[i];
                }
                this.container = temp;
                this.currentPoint -= this.startPoint;
                this.startPoint = 0;
            }
            this.container[this.currentPoint++] = element;
        }
        public void pop()
        {
            if(this.startPoint != currentPoint)
                this.startPoint++;

        }

        public void printer()
        {
            for(int i = 0; i < this.container.Length; i++)
            {
                if (this.container?[i] != null)
                    Console.Write(container[i] + " ");
                //
                if (i == this.startPoint)
                {
                    Console.Write(" <- start point ");
                }
                if( i == this.currentPoint)
                {
                    Console.Write(" <- current point ");
                }

            }
            Console.WriteLine();
        }
    }
}

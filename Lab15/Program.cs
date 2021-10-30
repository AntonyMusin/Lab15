using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка работы класса ArithProgression");
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(1);
            arithProgression.step = 10;
            arithProgression.getNext();
            int A = arithProgression.nextx;
            Console.WriteLine(A);
            arithProgression.getNext();
            int B = arithProgression.nextx;
            Console.WriteLine(B);
            arithProgression.getNext();
            int C = arithProgression.nextx;
            Console.WriteLine(C);
            arithProgression.reset();

            Console.WriteLine("Проверка работы класса GeomProgression");
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(10);
            geomProgression.step = 2;
            geomProgression.getNext();
            int E = geomProgression.nextx;
            Console.WriteLine(E);
            geomProgression.getNext();
            int F = geomProgression.nextx;
            Console.WriteLine(F);
            geomProgression.getNext();
            int G = geomProgression.nextx;
            Console.WriteLine(G);
            geomProgression.reset();

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public void setStart(int x)
        {
            this.FirstX = x;
            Console.WriteLine(FirstX);
            a = x;//Инициализация переменной для хранения первого члена прогрессии 
        }
        int FirstX { get; set; }
        int a;
        public int firstx
        {
            get 
            {
                return FirstX;
            }
            set 
            {
                this.FirstX = FirstX;
            }
        }
        int Step { get; set; }
        public int step
        {
            get 
            {
                return Step;
            }
            set
            {
                Step = value;
            }

        }
        int NextX { get; set; }
        public int nextx 
        {
            get
            {
                return NextX;
            }
            set 
            {
                NextX=value;
            }
        }

        public int getNext()
        {
            NextX = FirstX+=Step;
            return NextX;
        }

        public void reset()
        {
            NextX = a;
            Console.WriteLine(NextX);
        }
    }

    class GeomProgression : ISeries
    {
        public void setStart(int x)
        {
            this.FirstX = x;
            Console.WriteLine(FirstX);
            a = x;//Инициализация переменной для хранения первого члена прогрессии 
        }
        int FirstX { get; set; }
        int a;
        public int firstx
        {
            get
            {
                return FirstX;
            }
            set
            {
                this.FirstX = FirstX;
            }
        }
        int Step { get; set; }
        public int step
        {
            get
            {
                return Step;
            }
            set
            {
                Step = value;
            }

        }
        int NextX { get; set; }
        public int nextx
        {
            get
            {
                return NextX;
            }
            set
            {
                NextX = value;
            }
        }
        public int getNext()
        {
            NextX = FirstX *= Step;
            return NextX;
        }

        public void reset()
        {
            NextX = a;
            Console.WriteLine(NextX);
        }
    }
}


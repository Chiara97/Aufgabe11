using System;

namespace Observer
{
    delegate void ReportProgressMethod(int progress);
    class Calculator
    {
        public event ReportProgressMethod ProgressMethod;
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.CalculateSomething();
        }
        public Calculator()
        {
            ProgressMethod += ProzentAusgabe;
            ProgressMethod += Ausgabe;
        }
        
        public void CalculateSomething()
        {
            int i = 0;
            while(i <= 100)
            {
                if(i == 25 || i == 50 || i == 75 || i == 100)
                {
                    ProgressMethod(i);
                }
                i++;
            }
        }
        public void ProzentAusgabe(int _progress)
        {
            Console.WriteLine(_progress + " %");
        }
        public void Ausgabe(int _progress)
        {
            if(_progress == 100)
            {
                Console.WriteLine("Fertig");
            }
            else
            {
                Console.WriteLine("Lädt");
            }
        }
    }
}

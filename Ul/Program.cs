namespace Ul
{
    abstract class pszczola
    {

    }
    interface Iatak
    {
        void atak();
    }
    class krolowa : pszczola 
    {
        pszczola[] pszczoly;
        public void przydzielZad()
        {
            
        }
        void bronUla(ochrona p)
        {
            p.atak();
        }
    }
    class trutnie : pszczola
    {

    }
    abstract class robotnice : pszczola, Iatak
    {
        public abstract void atak();
    }
    class miodne : robotnice
    {
        void przyniesNektar()
        {
            Console.WriteLine("mam kwiat");
            Console.WriteLine("mam nektar");
            Console.WriteLine("wracam do ula");
        }
        public override void atak()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("atakuje");
        }
    }
    class opieka : robotnice
    {
        public override void atak()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("atakuje");
        }
    }
    class ochrona : robotnice
    {
        void patroluj()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Patroluje");
        }
        public override void atak()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("atakuje");
        }
        void alarm()
        {
            krolowa.alarm(this, "osa");
        }
    }
    interface Ibron
    {

    }

    internal class Program
    {
        
    }
}
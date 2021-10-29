using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon9
{
    enum Color
    {
        Red,
        Green,
        White,
        Black
    }
    class Dragon2
    {
        
        //1.2 Реализовать не менее пяти закрытых полей (различных типов),
        //представляющих основные характеристики рассматриваемого класса.
        private DateTime presentation = new DateTime(2014, 5, 30);        
        private DateTime certified = new DateTime(2020, 11, 11);
        private int Useful_ISS_load = 6000;
        private int Useful_load_from_ISS = 0;
        private Color color;
        private string Design;

        public string falconName;

        //1.3 Создать не менее трех методов управления классом и
        //методы доступа к его закрытым полям.
        public void PrintInfo()
        {
           // DateTime now = presentation;

            Console.WriteLine($"Имя: {consoleName}\n" +
                $"Дата презентации: {presentation.ToString("D")}\n" +
                $"Дата сертификации: {certified.ToString("D")}\n" +
                $"Использовать Dragon V2 для туристических полётов: {forTouristFlights}\n" +
                $"Полезная нагрузка на МКС {Useful_ISS_load}\n" +
                $"Полезная нагрузка с МКС {Useful_load_from_ISS}\n" +
                $"Цвет ракеты: {(Design == null ? "цвет не задан" : Design)}\n");
        }

        public void DatePresentationInfo()
        {
            Console.WriteLine(presentation.ToString("dd.MM.yyyy"));
        }

        public int Get_Useful_ISS_load()
        {
            return Useful_ISS_load;
        }

        public int PUseful_ISS_load
        {
            get { return Useful_load_from_ISS; }
            set { Useful_load_from_ISS = value; }
        }

        public void GetColor()
        {
            Console.WriteLine(Design);
        }

        public void SetColor(Color color)
        {
            this.Design = color.ToString();
        }

        //1.4 Создать метод, в который передаются аргументы по ссылке.



       // 1.5 Создать не менее двух статических полей(различных типов),
       // представляющих общие характеристики объектов данного класса.

        public static string consoleName;
        private static bool forTouristFlights;

        //1.6 Обязательным требованием является реализация нескольких перегруженных конструкторов,
        //аргументы которых определяются студентом, исходя из специфики реализуемого класса,
        //а так же реализация конструктора по умолчанию.

        public Dragon2()
        {
            falconName = null;
        }

        public Dragon2(string falconName)
        {
            this.falconName = falconName;
        }

        public Dragon2(string falconName, int Useful_load_from_ISS)
        {
            this.falconName = falconName;
            this.Useful_load_from_ISS = Useful_load_from_ISS;
        }

        //1.7 Создать статический конструктор.

        static Dragon2()
        {
            consoleName = "Dragon2";
            forTouristFlights = true;
        }

        //1.8 Создать массив(не менее 5 элементов) объектов созданного класса.

        //1.9 Создать дополнительный метод для данного класса в другом файле, используя ключевое слово partial.

    }
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.Title = Dragon2.consoleName;

            Console.SetWindowSize(100, 50);
            Console.SetBufferSize(100, 100);

            Dragon2 Crew_Dragon = new Dragon2();

            Console.WriteLine("Общая информация PrintInfo():");
            Crew_Dragon.PrintInfo();

            Console.WriteLine("Методы:");
            Console.Write("Дата презентации: ");
            Crew_Dragon.DatePresentationInfo();

            Console.WriteLine($"Полезная нагрузка на МКС: {Crew_Dragon.Get_Useful_ISS_load()} кг.");

            Crew_Dragon.SetColor(Color.White);

            Console.Write("Цвета ракеты: ");
            Crew_Dragon.GetColor();
            Console.Write("\n");

            Dragon2 Crew_Dragon2 = new Dragon2("Crew_Dragon2");
            Dragon2 Crew_Dragon3 = new Dragon2("Crew_Dragon3", 3307);

            Crew_Dragon2.SetColor(Color.Black);
            Crew_Dragon3.SetColor(Color.Green);

            Crew_Dragon2.PUseful_ISS_load = 3310;

            Dragon2[] Dragon2Array = { Crew_Dragon, Crew_Dragon2, Crew_Dragon3 };

            for (int i = 0; i < Dragon2Array.Length; i++)
            {
                Console.Write("\n");
                Console.WriteLine($"Космический корабль: {(Dragon2Array[i].falconName == null ? "No Name" : Dragon2Array[i].falconName)}");
                Console.Write("Цвет корабля: ");
                Dragon2Array[i].GetColor();               
                Console.Write($"Полезная нагрузка с МКС {Dragon2Array[i].PUseful_ISS_load}");           
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}

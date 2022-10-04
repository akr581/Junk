using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{


    class Program
    {



        public enum Test
        {
            A = 0,
            B,
            C
        }

        static void Main(string[] args)
        {

            decimal curNom = 14;

            decimal.TryParse("ad", out decimal curVal);

            Console.WriteLine(curVal/curNom);

            Console.ReadLine();

            DateTime dddd;

            Console.WriteLine("Hello World");

            DateTime.TryParse("2022-01-01", out dddd);

            int result = DateTime.Today >= new DateTime(2022, 09, 29) ? 45 : 25;


            List<string> sdasda = null;// = new List<string>();// { "abc", "abc" };

            if (sdasda.Any(x => x.Equals("abc")))
            {
                Console.WriteLine("Hoooray");
                Console.ReadLine();
                return;
            }

            sdasda = sdasda.Distinct().ToList();

            string targetString = "Hello my dear World! I'm very exciting of coding. Hello my dear2 World!";

            string firstString = "Hello my";
            string secondString = "World";
            string pattern = $"(?<={firstString}).*?(?={secondString})";


            Regex regex = new Regex(pattern);

            foreach (Match match in regex.Matches(targetString))
            {
                Console.WriteLine(match.Value.Trim());
            }


            string[] asdasda = { firstString, secondString };

            var qweqweqw = targetString.Split(asdasda, StringSplitOptions.RemoveEmptyEntries);

            string bcd = null;
            string cde = null;
            string ressss = string.Join(" ", cde, bcd).Trim();

            Console.WriteLine(int.MaxValue);

            Console.WriteLine($"A: {Test.A}");

            decimal vvv = 2.356m;

            Console.WriteLine(string.Format("{0:#.##}", vvv));
            Console.ReadLine();

            return;
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "1", "A" }
                ,{ "2", "B" }
                ,{ "3", "C" }
                ,{ "4", "D" }
            };

            string res = string.Empty;

            dict.TryGetValue("5", out res);



            Console.WriteLine(Math.Ceiling(26864m / 4));
            Console.ReadLine();

            return;

            string par = "5";

            string vaaal = dict.ContainsKey(par) ? dict[par] : "nothing";
            Console.WriteLine($"Founded: {vaaal}");
            Console.WriteLine($"Date: {DateTime.Now.ToString("yyyy-MM-dd")}");

            Контрагент contr = new Контрагент
            {
                crm_new_num1c = "123"
                ,
                ГоловнойКонтрагент = ""
                ,
                ДатаРегистрации = DateTime.Today.ToString()
                ,
                иас_СистемаНалогообложения = "0"
            };

            Информация инф1 = new Информация
            {
                ДоменноеИмяСервера = "asdasda"
                ,
                Город = "Саратов"
            };

            Информация эп = new Информация
            {
                АдресЭП = ""
            };

            Информация тел = new Информация
            {
                НомерТелефона = "123"
            };

            contr.КонтактнаяИнформация = new List<Информация>
            {
                инф1
                ,эп
                ,тел
            };

            var settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true
            };


            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                var ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
                XmlSerializer xx = new XmlSerializer(contr.GetType());

                xx.Serialize(writer, contr, ns);
                Console.WriteLine(stream.ToString());
            }
            Console.WriteLine(эп.Тип);
            Console.ReadLine();

            return;

            decimal qwe = 0;
            decimal ewq = 0;


            string[] strArray =
            {
                "1"
                ,"2"
                ,"3"
                ,"4"
                ,"5"
                ,"6"
                ,"7"
            };


            string[] strValues =
            {
                "A"
                ,"B"
                ,"C"
                ,"D"
                ,"E"
                ,"F"
                ,"G"
            };

            //string delimeter = string.Empty;
            ////StringBuilder sb = new StringBuilder();
            //string ressssss = string.Empty;
            //foreach (var item in strArray)
            //{
            //    foreach (var val in strValues)
            //    {
            //        ressssss += delimeter;
            //        ressssss += $"{item} - {val}";
            //        //sb.Append(delimeter);
            //        //sb.Append($"{item} - {val}");
            //        delimeter = Environment.NewLine;
            //    }
            //}

            //Console.WriteLine(sb.ToString());

            string rty = "dssdfsd";
            string text = "12";

            Console.WriteLine(string.Format(rty, text));
            Console.ReadKey();

            return;


            if (qwe == ewq)
            {
                Console.WriteLine("sdfsdfs");
            }

            Console.WriteLine(decimal.Compare(100M, 10M));
            Console.ReadLine();
            return;

            Guid g;

            if (!Guid.TryParse(null, out g))
            {
                Console.WriteLine("We're have the problem");
            }

            string dsfsdfsd = null;

            Console.WriteLine("A".Equals(dsfsdfsd?.ToString().ToUpper()));
            Console.ReadLine();
            return;

            string[] arr = new string[0];
            string[] arr2 = Array.Empty<string>();

            string abc = null;
            int xxxx = 0;

            Console.WriteLine($"abc:{abc is null}");
            //Console.WriteLine($"x:{x is null}");








            int minutes = DateTime.Now.Minute;

            var resssss = minutes % 2;
            resssss = minutes / 2;

            return;

            string queryString = @"http://localhost:57564/api/Values";
            WebRequest request = WebRequest.Create(queryString);

            WebResponse response = request.GetResponse();
            string filePath = @"c:\Temp\RespFile.txt";
            using (Stream output = File.OpenWrite(filePath))
            {
                response.GetResponseStream().CopyTo(output);
            }

            return;
            //Console.WriteLine($"{short.MaxValue}");
            //Console.WriteLine(ushort.MaxValue);
            //Console.WriteLine(ushort.MaxValue);
            //Console.WriteLine(ushort.MaxValue);
            //Console.WriteLine(ushort.MaxValue);
            //Console.WriteLine(ushort.MaxValue);

            //Console.WriteLine(Decode("1..02.6"));
            //Console.ReadLine();
            return;

            Days[] d = { Days.Sunday, Days.Tuesday };
            var allDays = Enum.GetValues(typeof(Days));
            var values = d.Select(x => x.ToString()).ToArray();

            //var days = Enum.GetValues(typeof(Days));
            //var days2 = days.Cast<Days>();
            //                //.ToList();

            //Console.WriteLine(string.Join(Environment.NewLine, days));
            //Console.WriteLine(string.Join(Environment.NewLine, days2));
            foreach (var item in allDays)
            {
                if (values.Contains(item.ToString())) Console.WriteLine(item);
            }
            //Console.WriteLine(values);

            //var allDays = Enum.GetValues(typeof(Days)).;

            //foreach (var asd in allDays)
            //{
            //    if (Enum.) Console.WriteLine("Whoooooo, Values: " + asd); ;

            //}

            //var daysNames = Enum.GetNames(typeof(days));

            //var values = Enum.GetNames(typeof(Days)).Where(x => !x.Equals("None"));

            //foreach (var val in values)
            //{
            //    Console.WriteLine(val);
            //}

            Console.ReadLine();
            return;
            string asddsa = "aaa";

            string qweqwe = asddsa ?? "sad";
            Console.ReadLine();
            return;


            string doubleNumber = "894376.243643";
            double number = double.Parse(doubleNumber, CultureInfo.InvariantCulture); // Вася уверен, что ошибка где-то тут
            Console.WriteLine(number + 1);



            Console.ReadLine();
            //Human h = new Human();

            //var method = System.Reflection.MethodBase.GetCurrentMethod();

            //Actions.MakeMagic();

            //string mName = System.Reflection.MethodBase.GetCurrentMethod().Module.Name;


        }

        static string Decode(string input)
        {
            int.TryParse(input.Replace(".", ""), out int tmpRes);
            return ((ushort)tmpRes).ToString();
        }

        public class Human
        {
            public Description Description { get; set; }
        }

        public class Description
        {
            public int Age { get; set; }
        }



    }

    public static class Actions
    {
        public static void MakeMagic()
        {
            var method = System.Reflection.MethodBase.GetCurrentMethod();
            Console.WriteLine("Magic");
        }
    }

    public enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
        None = 0
    }

    public class Контрагент
    {
        public string crm_new_num1c;
        public string Наименование;
        public string НаименованиеПолное;
        public string ЮридическоеФизическоеЛицо;
        public string СтранаРегистрации;
        public string ГоловнойКонтрагент;
        public string ИНН;
        public string КПП;
        public string ЮрФизЛицо;
        public string КодПоОКПО;
        public string НаименованиеМеждународное;
        public string иас_СистемаНалогообложения;
        public string лиз_ОГРН;
        public string ДатаРегистрации;
        public string Клиент;
        public string Поставщик;
        public string кд_ГИБДД;
        public string ОсновнойМенеджер;
        public string Конкурент;
        public string ПрочиеОтношения;
        public string ПартнерЮрФизЛицо;
        public List<Информация> КонтактнаяИнформация;
    }

    public class Информация
    {
        public string Тип;
        public string Вид;
        public string Представление;
        public string ВидДляСписка;
        public string Страна;
        public string Регион;
        public string Город;
        public string АдресЭП;
        public string ДоменноеИмяСервера;
        public string НомерТелефона;
    }

    //public class Адрес : Информация
    //{


    //}

    //public class ЭлектроннаяПочта : Информация
    //{
    //    public string АдресЭП;
    //    public string ДоменноеИмяСервера;

    //    public ЭлектроннаяПочта() : base(тип: "АдресЭлектроннойПочты", вид: "EmailКонтрагента")
    //    {
    //    }
    //}

    //public class Телефон : Информация
    //{
    //    public string НомерТелефона;

    //    public Телефон() : base(тип: "Телефон", вид: "ТелефонКонтрагента")
    //    {
    //    }
    //}
}

using System;
using System.Globalization;

namespace ExerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Sistema de Exerciços C#");
            Console.WriteLine("1- Aluguel de quartos");
            Console.WriteLine("2 - Calculadora com Vector");
            Console.WriteLine("3 - Calculadora usando Params");
            Console.WriteLine("4 - Funções interesssantes para String");
            Console.WriteLine("5 - Representando Data e Hora");
            Console.WriteLine("6 - Representando Durações");
            Console.WriteLine("7 - Diferentes formatos com DateTime");
            Console.WriteLine("8 - Operações com DateTime");
            Console.WriteLine("9 - Propiedades com TimeSpan");
            Console.WriteLine("10 - Operações com TimeSpan");
            Console.WriteLine("11 - DateTimeKind");
            Console.WriteLine("12 - Padrão ISO 8601");

            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    {
                        // Alugiel de quartos usando vector
                        Console.WriteLine("Aluguel de Quartos");

                        Estudante[] vect = new Estudante[10];
                        string email = "";
                        string nome = "";
                        int quarto = 0;
                        Console.Write("Quantos quartos serão alugados? ");
                        int n = int.Parse(Console.ReadLine());

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Aluguel #{i}:");
                            Console.Write("Nome: ");
                            nome = Console.ReadLine();
                            Console.Write("Email: ");
                            email = Console.ReadLine();
                            Console.Write("Quarto número: ");
                            quarto = int.Parse(Console.ReadLine());
                            vect[quarto] = new Estudante(nome, email);
                        }

                        Console.WriteLine("Quartos ocupados: ");
                        for (int i = 0; i < 10; i++)
                        {
                            if (vect[i] != null)
                            {
                                Console.WriteLine(i + ": " + vect[i]);
                            }
                        }
                        break;
                    }

                case 2:
                    {
                        // Soma usando Vector só
                        int k = Calculator.Sum(new int[] { 10, 20, 30, 40 });
                        Console.WriteLine("Soma = " + k);
                        int k2 = Calculator.Sum(new int[] { 2, 4, 6, 8 });
                        Console.WriteLine("Soma = " + k2);
                        break;
                    }
                case 3:
                    {
                        // Soma usando Vector e params na Classe Calculator
                        int result = Calculator.Sum(10, 20, 30, 40);
                        Console.WriteLine("Soma = " + result);
                        int result2 = Calculator.Sum(2, 4, 6, 8);
                        Console.WriteLine("Soma = " + result2);
                        break;
                    }
                case 4:
                    {
                        string original = "abcde FGHIJ ABC abc DEFG     ";
                        string s1 = original.ToUpper();
                        string s2 = original.ToLower();
                        string s3 = original.Trim();
                        int n1 = original.IndexOf("bc");
                        int n2 = original.LastIndexOf("bc");

                        string s4 = original.Substring(3);
                        string s5 = original.Substring(3,5);
                        string s6 = original.Replace('a', 'x');
                        string s7 = original.Replace("abc", "xy");

                        bool b1 = String.IsNullOrEmpty(original);
                        bool b2 = String.IsNullOrWhiteSpace(original);

                        Console.WriteLine("Original: -"  + original + "-");
                        Console.WriteLine("ToUpper: -" + s1 + "-");
                        Console.WriteLine("ToLower: -" + s2 + "-");
                        Console.WriteLine("Trim: -" + s3 + "-");
                        Console.WriteLine("IndexOf: " + n1 + "-");
                        Console.WriteLine("LastIndexOf: " + n2 + "-");
                        Console.WriteLine("Substring(3): " + s4);
                        Console.WriteLine("Substring(3,5): " + s5);
                        Console.WriteLine("Replace('a', 'x'): " + s6);
                        Console.WriteLine("Replace('abc', 'xy'): " + s7);
                        Console.WriteLine("IsNullOrEmpty: " + b1);
                        Console.WriteLine("IsNullOrWhiteSpace(original): " + b2);

                        break;
                    }
                case 5:
                    {
                        // Um objeto DateTime internamente armazena o número de "TICKS" (100 nanosegundos)
                        // desde a meia noite do dia 1 de janeiro do ano 1 da era comum
                        // Representa um Instante
                        DateTime d0 = DateTime.Now;
                        Console.WriteLine(d0);
                        Console.WriteLine(d0.Ticks); // desse jeito fica armazenada a data e logo é convertida 
                                                     // ao formato desejado (x ex. dd/mm/aa)

                        // Construtores mais utilizados (d1, d2, d3)

                        DateTime d1 = new DateTime(2021, 11, 15);
                        DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);

                        // Esse formato não imprime os milisegundos. Precisa fazer uma outra coisa para isso.
                        DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

                        // Hora local: se usa DateTime.kind 

                        // Builders básicos:
                        DateTime d4 =  DateTime.Now;
                        DateTime d5 = DateTime.Today;
                        DateTime d6 = DateTime.UtcNow;  // Horario Universal. Deve dar umas 2 ou 3 horas a mais
                                                        // do horario de Brasil, dependendo se for verão ou inverno

                        // Conversiones:
                        DateTime d7 = DateTime.Parse("2000-08-13");
                        DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
                        DateTime d9 = DateTime.Parse("21/02/2021");
                        DateTime d10 = DateTime.Parse("21/02/2021 14:25:33");
                        DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        DateTime d12 = DateTime.ParseExact("15/08/2001 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                        Console.WriteLine(d1);
                        Console.WriteLine(d2);
                        Console.WriteLine(d3);
                        Console.WriteLine(d4);
                        Console.WriteLine(d5);
                        Console.WriteLine(d6);
                        Console.WriteLine(d7);
                        Console.WriteLine(d8);
                        Console.WriteLine(d9);
                        Console.WriteLine(d10);
                        Console.WriteLine(d11);
                        Console.WriteLine(d12);

                        break;
                    }
                case 6:
                    {
                        // Objeto TimeSpan: armazena internamente uma duração na forma de TICKS (100 nanosegundos)
                        // Representa um LAPSO de tempo

                        TimeSpan t1 = new TimeSpan(0, 1, 30);
                        TimeSpan t2 = new TimeSpan(900000000L);
                        TimeSpan t3 = new TimeSpan(2, 11, 21);
                        TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
                        TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

                        TimeSpan t6 = TimeSpan.FromDays(1.5); // rango de 1 dia y medio da 1 dia y 12 horas :-)
                        TimeSpan t7 = TimeSpan.FromHours(1.5);
                        TimeSpan t8 = TimeSpan.FromMinutes(1.5);
                        TimeSpan t9 = TimeSpan.FromSeconds(1.5);
                        TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
                        TimeSpan t11 = TimeSpan.FromTicks(900000000L);

                        Console.WriteLine(t1);
                        Console.WriteLine(t1.Ticks);
                        Console.WriteLine(t2);
                        Console.WriteLine(t3);
                        Console.WriteLine(t4);
                        Console.WriteLine(t5);
                        Console.WriteLine(t6);
                        Console.WriteLine(t7);
                        Console.WriteLine(t8);
                        Console.WriteLine(t9);
                        Console.WriteLine(t10);
                        Console.WriteLine(t11);

                        break;
                    }
                case 7:
                    {
                        DateTime d = new DateTime(2021, 12, 27, 13, 45, 58, 275);

                        Console.WriteLine(d);
                        Console.WriteLine("1) Date: " + d.Date);
                        Console.WriteLine("2) Day: " + d.Day);
                        Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
                        Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
                        Console.WriteLine("5) Hour: " + d.Hour);
                        Console.WriteLine("6) Kind: " + d.Kind);        // Local o Universal
                        Console.WriteLine("7) Milliseconds: " + d.Millisecond);
                        Console.WriteLine("8) Minute: " + d.Minute);
                        Console.WriteLine("9) Month: " + d.Month);
                        Console.WriteLine("10) Second: " + d.Second);
                        Console.WriteLine("11) Ticks: " + d.Ticks);
                        Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
                        Console.WriteLine("13) Year: " + d.Year);

                        Console.WriteLine(d.ToLongDateString());
                        break;
                    }
                case 8:
                    {
                        // Operações com DateTime
                        DateTime d = DateTime.Now;
                        DateTime d2 = d.AddHours(2);
                        DateTime d3 = d.AddMinutes(10);
                        DateTime d4 = d.AddDays(7);
                        DateTime d5 = new DateTime(1933, 06, 19);
                        DateTime d6 = new DateTime(1928, 06, 19);

                        TimeSpan t1 = d5.Subtract(d6);  // Da o nro de dias entre ambas datas
                        Console.WriteLine(d);
                        Console.WriteLine(d2);
                        Console.WriteLine(d3);
                        Console.WriteLine(d4);
                        Console.WriteLine(t1);

                        break;
                    }
                case 9:
                    {
                        // Propiedades com TimeSpan
                        TimeSpan t1 = TimeSpan.MaxValue;
                        TimeSpan t2 = TimeSpan.MinValue;
                        TimeSpan t3 = TimeSpan.Zero;

                        TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

                        Console.WriteLine(t1);
                        Console.WriteLine(t2);
                        Console.WriteLine(t3);
                        Console.WriteLine(t4);
                        Console.WriteLine("Days: " + t4.Days);
                        Console.WriteLine("Hours: " + t4.Hours);
                        Console.WriteLine("Minutes: " + t4.Minutes);
                        Console.WriteLine("Seconds: " + t4.Seconds);
                        Console.WriteLine("Milliseconds: " + t4.Milliseconds);
                        Console.WriteLine("Ticks: " + t4.Ticks);

                        Console.WriteLine("TotalDays: " + t4.TotalDays);
                        Console.WriteLine("TotalHours: " + t4.TotalHours);
                        Console.WriteLine("TotalMinutes: " + t4.TotalMinutes);
                        Console.WriteLine("TotalSeconds: " + t4.TotalSeconds);
                        Console.WriteLine("TotalMilliseconds: " + t4.TotalMilliseconds);

                        break;
                    }
                case 10:
                    {
                        // Operações com TimeSpan
                        TimeSpan t1 = new TimeSpan(1, 30, 10);
                        TimeSpan t2 = new TimeSpan(0, 10, 5);
                        

                        TimeSpan sum = t1.Add(t2);
                        TimeSpan dif = t1.Subtract(t2);
                        TimeSpan mult = t2.Multiply(4.0);
                        TimeSpan div = t1.Divide(2.0);

                        Console.WriteLine("Sum : " + sum);
                        Console.WriteLine("Diferença: " + dif);
                        Console.WriteLine("Multiplicação: " + mult);
                        Console.WriteLine("Divisão: " + div);

                        break;
                    }
                case 11:
                    {
                        // Fuso Horário

                        DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
                        DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
                        DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
                        
                        Console.WriteLine("==================================================");
                        Console.WriteLine("d1: " + d1);
                        Console.WriteLine("d1 Kind: " + d1.Kind); 
                        Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
                        Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());

                        Console.WriteLine("==================================================");
                        Console.WriteLine(d2);
                        Console.WriteLine("d2 Kind: " + d2.Kind);
                        Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
                        Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime());

                        Console.WriteLine("==================================================");
                        Console.WriteLine(d3);
                        Console.WriteLine("d3 Kind: " + d3.Kind);
                        Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
                        Console.WriteLine("d3 to UTC: " + d3.ToUniversalTime());

                        break;
                    }

                case 12:
                    {
                        // Padrão ISO 8601
                        // • https://www.iso.org/iso-8601-date-and-time-format.html
                        // • https://en.wikipedia.org/wiki/ISO_8601
                        // • Formato:
                        // yyyy - MM - ddTHH:mm: ssZ
                        //     * Z indica que a data/ hora está em Utc

                        DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
                        DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

                        Console.WriteLine(d1);

                        Console.WriteLine(d2);

                        break;
                    }

            }

            

            

            
        }
    }
}

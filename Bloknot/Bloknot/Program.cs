using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bloknot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Путь к директории, в которой создаём файл и записываем текст; новый файл находится в той же папке, что и исполняемый 
            String put1 = AppDomain.CurrentDomain.BaseDirectory + "Text1.txt";
 
            Write(put1); //Запись данных
            Read(put1); //Вывод данных

            //Путь к директории, в которой находится файл, который предназначен только для чтения
            String put2 = AppDomain.CurrentDomain.BaseDirectory + "Text.txt";            
            Read(put2);
               
        }

        static void Read(String put)
        {
            String line;
            try
            {
                //Указываем путь для конструктора StreamReader
                StreamReader sr = new StreamReader(put);
                //Чтение первой строки техта
                line = sr.ReadLine();
                //Продолжаем читать строки файла
                while (line != null)
                {
                    //Вывод строки на консоль
                    Console.WriteLine(line);
                    //Чтение следующей строки
                    line = sr.ReadLine();
                }

                //Закрытие файла
                sr.Close();
                Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.ReadLine();
            }

            /*finally
            {
                Console.WriteLine("Executing finally block.");
            }*/
        }

        static void Write(String put)
        {
            try
            {
                //Указываем путь к исходному файлу
                StreamWriter sw = new StreamWriter(put, false);
                //Записываем строку текста для записи
                sw.WriteLine("Hello from America!!!");
                //Записываем вторую строку текста в файл
                sw.WriteLine("From the StreamWriter method");
                //Закрываем файл
                sw.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            /*finally
            {
                Console.WriteLine("Excecuting finally block.");
                Console.ReadLine();
            }*/
        }
    }

}

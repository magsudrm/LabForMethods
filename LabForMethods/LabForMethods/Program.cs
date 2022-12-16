using System;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace LabForMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            //int[] arr = { 1, -4, 2, 8, -3, 12, 33, -44, 166, -266, 173, 90 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Console.WriteLine("New Array:");
            //Makenewarrray(ref arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //Task-2
            //string text = "salam amrah bay";
            //LetterE(ref text);
            //Console.WriteLine(text);

            //Task-3
            //int[] arr = { 3, 6, 44, 171, 265, 382 };
            //NumModule2( ref arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //Task - 4
            //Verilmiş sözün ilk hərfinin böyük olub olmadığını yoxlayan proqram yazın
            //string name = "kest";
            //if (Char.IsUpper(name[0]))
            //{
            //    Console.WriteLine("boyukdur");
            //}
            //else { 
            //Console.WriteLine("kicikdr");
            //}

            //Task - 5
            //verilmiş sözdə rəqəm olub olmadığını yoxlayan proqram yazın
            //string text = "salam";
            //bool check = false;
            //for (int i=0; i < text.Length; i++)
            //{
            //    if (char.IsDigit(text[i]))
            //    {
            //        check= true;
            //    }

            //}
            //Console.WriteLine(check);


            //Task-6
            //string txt=Console.ReadLine();
            //var charStr=Console.ReadLine();

            //char c=Convert.ToChar(charStr);
            //Console.WriteLine(ShowIndex(txt,c));



            //Task - 7
            //İstifadəçi username daxil edir. username dəyəri minimum əvvəlcə onun hər
            //iki tərəfindəki bosluqlari silinmelidir. 8 simvoldan ibarət olmalıdır
            //əvvəlcə onun hər iki tərəfindəki bosluqlari silinmelidir.içərisində minimum 1 böyük hərf,
            //1 kiçik hərf, 1 rəqəm olmalıdır. əgər düzgün daxil etməyibsə yenudən daxil etməyi tələb edin

            bool check = false;
            bool isupper=false;
            bool islover=false;
            bool isdigit=false;
            do
            {
                Console.WriteLine("username daxil edin: ");
                string name = Console.ReadLine();
                name=name.Trim();
                if (name.Length>8)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (char.IsUpper(name[i]))
                        {
                            isupper = true;
                        }
                        else if (char.IsLower(name[i]))
                        {
                            islover = true;
                        }
                        else if (char.IsDigit(name[i]))
                        {
                            isdigit= true;
                        } 
                    }

                    if (isupper&&islover&&isdigit)
                    {
                        Console.WriteLine("duzgundur");
                        return;
                    }
                    else
                    {
                        check= true;
                    }
                }
                else
                {
                    check= true;
                }
            } while (check);

            




        }

        //Task-1
        //Verilmiş ədədlər siyahısındakı müsbət və cütlər şəklində qaytaran metod yazmalı
        //int[] arr = { 1, -4, 2, 8, -3, 12, 33, -44, 166, -266, 173, 90 };
        static void Makenewarrray(ref int[] arr)
        {
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] makenewarray = new int[count];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] % 2 == 0)
                {
                    makenewarray[j] = arr[i];
                    j++;
                }
            }
            arr = makenewarray;
        }

        //Task-2
        //Verilmiş stringdə "a" hərflərini "e" yə çevirən metod yazmalı
        //string txt = "salam amrah bay";

        static void LetterE(ref string txt)
        {
            string NewStr = "";
            for(int i=0;txt.Length>i;i++)
            {
                if (txt[i] == 'a')
                {
                    NewStr += 'e';
                }
                else
                {
                    NewStr+= txt[i];
                }
            }
            txt= NewStr;
        }


        //Task-3
        //Verilmiş arraydakı rəqəmlərin təklərini cütə çevirən metod yazmalı
        //int[] arr = { 3, 6, 44, 171, 265, 382 };

        static void NumModule2( ref int[] arr)
        {
            int[]newArr= new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2!=0)
                {
                    newArr[i] = arr[i] + 1;
                }
                else
                {
                    newArr[i] = arr[i];
                }

            }
            arr= newArr;
        }

        //Task-6
        //"elektrik" sözsndə daxil edilən simvolun olduğu indeksi
        //qaytaran metod yazın. olmazsa -1 qaytarsin

        static int ShowIndex(string txt ,char c)
        {
                return txt.IndexOf(c); 
        }


    }
}

using System;
using System.Collections.Generic;

namespace DictonaryClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string, string> metallicaList = new MyDictonary<string, string>();
            
            metallicaList.Add("Vocal and Rhythm Guitar","James Hetfield");
            metallicaList.Add("Drummer","Lars Ulrich");
            metallicaList.Add("Lead Guitar","Kirk Hammet");
            metallicaList.Add("Bass Guitar and Back Vocals","Robert Trujillo");
            metallicaList.List();

            Console.WriteLine("-------------------------------------------------");

            MyDictonary<int, string> studentList = new MyDictonary<int, string>();
            studentList.Add(1,"Armağan Şahin");
            studentList.Add(2,"Anıl Şahin");
            studentList.Add(3,"Zeynep Öztürk");

            studentList.List();

        }
    }
}

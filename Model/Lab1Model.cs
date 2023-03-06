using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1_updated
{
    internal class Lab1Model
    {
         public Lab1Model() { }

         static Companion Rose = new Companion("Роза Тайлер", "Билли Пайпер", new List<int> { 1, 2 }, 0, Environment.CurrentDirectory + "/Stuff/Rose.jpg");
         static Companion Marta = new Companion("Марта Джонс", "Фрима Аджимен", new List<int> { 3, 4 }, 1, Environment.CurrentDirectory + "/Stuff/Martha.jpg");
         static Companion Amy = new Companion("Эми Понд", "Карен Гиллан", new List<int> { 5, 6 }, 2, Environment.CurrentDirectory + "/Lab1/Stuff/Emy.jpg");
         static Companion Clara = new Companion("Клара Освальд", "Дженна Коулман", new List<int> { 7, 8, 9 }, 3, Environment.CurrentDirectory + "/Lab1/Stuff/Clara.jpg");
         static Companion Bill = new Companion("Билл Поттс", "Пёрл Маки", new List<int> { 9, 10 }, 4, Environment.CurrentDirectory + "/Stuff/Bill.jpgg");
         static Companion Yasmin = new Companion("Ясмин Хан", "Мандип Гилл", new List<int> { 11, 12, 13 }, 5, Environment.CurrentDirectory + "/Stuff/Yasmin.jpg");
        
         
        
        public Dictionary<int, Doctor> DoctorsDic = new Dictionary<int, Doctor>()
        {
            [9] = new Doctor("Девятый Доктор", "Кристофер Экклстон", new List<int> { 1 }, 9, new List<Companion> {Rose}, Environment.CurrentDirectory + "/Stuff/Ninth_Doctor.jpg"),
            [10] = new Doctor("Десятый Доктор", "Дэвид Теннант", new List<int> { 2, 3, 4 }, 10, new List<Companion> { Rose, Marta }, Environment.CurrentDirectory + "/Stuff/Tenth_Doctor.jpg"),
            [11] = new Doctor("Одиннадцатый Доктор", "Мэтт Смит", new List<int> { 5, 6, 7 }, 11, new List<Companion> { Amy, Clara }, Environment.CurrentDirectory + "/Stuff/Eleventh_Doctor.jpg"),
            [12] = new Doctor("Двенадцатый Доктор", "Питер Капальди", new List<int> { 8, 9, 10 }, 12, new List<Companion> { Clara, Bill }, Environment.CurrentDirectory + "/Stuff/Twelfth_Doctor.jpg"),
            [13] = new Doctor("Тринадцатый Доктор", "Джоди Уиттакер", new List<int> { 11, 12, 13 }, 13, new List<Companion> { Yasmin }, Environment.CurrentDirectory + "/Stuff/Thirteenth_Doctor.jpg"),
            [14] = new Doctor("Четырнадцатый Доктор", "Дэвид Теннант", new List<int> { 14 }, 14, Environment.CurrentDirectory + "/Stuff/Fourteenth_Doctor.jpg"),
            [15] = new Doctor("Пятнадцатый Доктор", "Шути Гатва", new List<int> { 14 }, 15, Environment.CurrentDirectory + "/Stuff/Fifteenth_Doctor.jpg")
        };

        public void DocAdd(string name, string actor, List<int> seasons, int number, List<Companion> companions, string way)
        {
            DoctorsDic.Add(number, new Doctor(name, actor, seasons, number, way));

        }

        public bool IsDocHasCompanion(int ID)
        {
            if (DoctorsDic[ID].Companions == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }



        public void DocDel(int number)
        {
            DoctorsDic.Remove(number);

        }

        public string DocInfo(int number) 
        {
            string comma = ", ";
            return $"{DoctorsDic[number].Name} \nАктер: {DoctorsDic[number].Actor} \nСезоны: {String.Join(comma, DoctorsDic[number].Seasons)} ";
        }

        public List<Companion> CompanionsList(int number)
        {
            return DoctorsDic[number].Companions;
        }

        public string TheWay(int number)
        {
            return DoctorsDic[number].ImageWay;

        }
    }




}


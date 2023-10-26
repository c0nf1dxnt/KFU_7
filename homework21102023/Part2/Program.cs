using System;
using System.Text;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Employee semen = new Employee("Семён");
            Employee rashid = new Employee("Рашид");
            Employee ilham = new Employee("Ильхам");
            Employee lucas = new Employee("Лукас");
            Employee orkadiy = new Employee("Оркадий");
            Employee volodya = new Employee("Володя");
            Employee ilshat = new Employee("Ильшат");
            Employee ivanych = new Employee("Иваныч");
            Employee ilya = new Employee("Илья");
            Employee vitia = new Employee("Витя");
            Employee zhenya = new Employee("Женя");
            Employee sergay = new Employee("Сергей");
            Employee lyaysan = new Employee("Ляйсан");
            Employee marat = new Employee("Марат");
            Employee Dina = new Employee("Дина");
            Employee ildar = new Employee("Ильдар");
            Employee anton = new Employee("Антон");

            semen.directSupervisor = null;
            rashid.directSupervisor = semen;
            ilham.directSupervisor = semen;
            lucas.directSupervisor = rashid;
            orkadiy.directSupervisor = ilham;
            volodya.directSupervisor = ilham;
            ilshat.directSupervisor = ilham;
            ivanych.directSupervisor = ilshat;
            ilya.directSupervisor = ilshat;
            vitia.directSupervisor = ivanych;
            zhenya.directSupervisor = ivanych;
            sergay.directSupervisor = orkadiy;
            lyaysan.directSupervisor = orkadiy;
            marat.directSupervisor = sergay;
            Dina.directSupervisor = lyaysan;
            ildar.directSupervisor = lyaysan;
            anton.directSupervisor = sergay;

            Console.ReadKey();
        }
    }
}

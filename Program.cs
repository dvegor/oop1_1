/*
1 задача.
Спроектируйте программу для построения генеалогического дерева.
Учтите, что у нас есть члены семьи у ого нет детей(де).
Есть члены семти у кого дети есть (взрослые)
Есть мужчины и женщины.

2 задача.
Доработать предыдущий класс реализовав методы вывода родителей, детей, братьев сестер (включая двоюродных), бабушек и дедушек.
Подумайте, как лучше реализовать данные методы.

3 задача.
Получив ссылку на самого старшего члена семьи вывести на экран его генеалогическое древо

Домашнее задание.
Доработайте приложение генеалогического дерева таким образом чтобы программа выводила на экран близких родственников (жену/мужа).
Продумайте способ более красивого вывода с использованием горизонтальных и вертикальных черточек.
 */

using System.Reflection;
using System.Security.Cryptography;
using static ConsoleApp1.Human;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var grandpa1 = new Human() { Name = "Дед1", Sex = Gender.Male };
            var grandma1 = new Human() { Name = "Бабушка1", Sex = Gender.Female };
            Family family1 = new Family { Husband = grandpa1, Wife = grandma1 };

            var grandpa2 = new Human() { Name = "Дед2", Sex = Gender.Male };
            var grandma2 = new Human() { Name = "Бабушка2", Sex = Gender.Female };
            Family family2 = new Family { Husband = grandpa2, Wife = grandma2 };

            var father = new Human() { Name = "Папа", Parents = family1, Sex = Gender.Male };
            var mother = new Human() { Name = "Мама", Parents = family2, Sex = Gender.Female };
            Family family3 = new Family { Husband = father, Wife = mother };

            var son = new Human() { Name = "Сын", Parents = family3, Sex = Gender.Male };
            var dautherInLaw = new Human() { Name = "ЖенаCына", Parents = null, Sex = Gender.Female };
            Family family4 = new Family { Husband = son, Wife = dautherInLaw };

            var grandSon = new Human() { Name = "Внук", Parents = family4, Sex = Gender.Male };
            var grandDother = new Human() { Name = "Внучка", Parents = family4, Sex = Gender.Female };


            grandDother.Print();


        }

    }
}


using System;
using System.Collections.Generic;
using System.Reflection;

namespace Quiz008
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string HP { get; set; }

        public Person(int id, string name, string hp)
        {
            ID = id;
            Name = name;
            HP = hp;
        }
    }
    internal class Program
    {
        static int N = 0;
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            while (true)
            {
                int id;
                string name, hp;
                UIinit();
                switch (N)
                {
                    case 1:
                        Console.WriteLine("ID를 입력해주세요");
                        id = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("이름을 입력해주세요");
                        name = Console.ReadLine();
                        Console.WriteLine("HP를 입력해주세요");
                        hp = Console.ReadLine();
                        list.Add(new Person(id, name, hp));
                        Console.WriteLine("데이터를 입력하였습니다.");
                        break;
                    case 2:
                        Console.WriteLine("ID를 입력해주세요");
                        id = Int32.Parse(Console.ReadLine());
                        Person personToRemove = list.Find(p => p.ID == id);
                        if (personToRemove != null)
                        {
                            list.Remove(personToRemove);
                            Console.WriteLine("데이터를 삭제하였습니다.");
                        }
                        else
                        {
                            Console.WriteLine("일치하는 데이터를 찾을 수 없습니다.");
                        }
                        break;
                    case 3:
                        foreach (Person p in list)
                        {
                            Console.WriteLine($"ID: "+" "+p.ID +" "+ $"이름: " + " " + p.Name +" "+ $"HP: " + " " + p.HP);
                        }
                        break;
                    case 4:
                        Console.WriteLine("ID를 입력해주세요");
                        int idToUpdate = Int32.Parse(Console.ReadLine());
                        Person personToUpdate = list.Find(p => p.ID == idToUpdate);
                        if (personToUpdate != null)
                        {
                            Console.WriteLine("새로운 ID를 입력해주세요");
                            int newID = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("새로운 이름을 입력해주세요");
                            string newName = Console.ReadLine();
                            Console.WriteLine("새로운 HP를 입력해주세요");
                            string newHP = Console.ReadLine();

                            personToUpdate.ID = newID;
                            personToUpdate.Name = newName;
                            personToUpdate.HP = newHP;

                            Console.WriteLine("데이터를 수정하였습니다.");
                        }
                        else
                        {
                            Console.WriteLine("일치하는 데이터를 찾을 수 없습니다.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\n프로그램을 종료합니다.\n");
                        Console.WriteLine("안녕히 계세요. 수고하셨습니다.\n");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n잘못된 메뉴를 입력하셨습니다. \n\n다시 입력 해 주세요.\n");
                        break;
                }
            }

        }
        static void UIinit()
        {
            Console.WriteLine("1. 데이터 삽입");
            Console.WriteLine("2. 데이터 삭제");
            Console.WriteLine("3. 데이터 조회");
            Console.WriteLine("4. 데이터 수정");
            Console.WriteLine("5. 프로그램 종료");

            Console.Write("메뉴 : ");
            N = Int32.Parse(Console.ReadLine());
        }
    }
}

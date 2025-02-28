using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    //마린 클래스
    //이름, 미네랄 =50
    //기본생성자, 인자 있는 생성자
    //SCV 클래스
    //이름, 미네랄 =50
    //기본생성자, 인자 있는 생성자
    /*class Person
    {
        public string Name;
        public int Age;
        //기본생성자
        //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
        //메서드는 곧 함수
        //클래스와 같은 이름을 가지며, 반환형이 없다(void도 사용하지않음)
        //객체를 만들때 필요한 초기값을 설정할때 사용많이한다.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("기본 생성자가 실행됨");
        }
        public void ShowInfo()
        {
            Console.WriteLine("이름 : "+ Name +" "+ "나이 : " + Age);
        }
    }*/
    class Marin
    {
        public string Name;
        public int Mineral;
        public Marin(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine("이름 : " + Name + " " + "미네랄 : " + Mineral);
        }
    }
    class SCV
    {
        public string Name;
        public int Mineral;
        public SCV(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine("이름 : " + Name + " " + "미네랄 : " + Mineral);
        }
    }
    //배럭 클래스
    //Barrack 150
    //this 키워드를 이용해보자
    //this 자기자신을 가르킨다.
    class Barrack
    {
        public string name;
        public int mineral;
        public Barrack(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine("이름 : " + name + " " + "미네랄 : " + mineral);
        }
    }
    //배열사용 X
    class Mineral
    {
        public int Point = 0;
        public int Count = 0;

        public Mineral(int point, int count)
        {
            Point = point;
            Count = count;
        }
        public void ShowInfo()
        {
            Console.WriteLine("미네랄 량 : " + Point + " " + "미네랄 갯수 : " + Count);
        }
    }
    //배열 사용 O
    class Mineral2
    {
        public int Point;

        public Mineral2(int point)
        {
            Point = point;
        }
        public void ShowInfo()
        {
            Console.WriteLine("미네랄 량 : " + Point);
        }
    }
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int cp;
        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 : {mineral} 가스 : {gas} 인구수 : {cp}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.cp = 4;
            Game.ShowInfo();
            //스타크래프트내용 클래스생성
            Marin m2 = new Marin("마린", 50);
            SCV s2 = new SCV("SCV", 50);
            Barrack b2 = new Barrack("배럭", 150);
            Mineral Mi2 = new Mineral(1500, 7);
            Mineral2[] Me2 = new Mineral2[7];
            for(int i = 0; i<Me2.Length; i++)
            {
                Me2[i] = new Mineral2(1500);
                Me2[i].ShowInfo();
            }
            m2.ShowInfo();
            s2.ShowInfo();
            b2.ShowInfo();
            Mi2.ShowInfo();
            /*//클래스
            //
            Person p1 = new Person("홍길동", 12); //객체 생성 instance
            p1.ShowInfo();
            Person p2 = new Person("홍길순", 32);
            p2.ShowInfo();*/
            /*//현재시간 체크
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time : {now}");
            // 시간 설정
            TimeSpan duration = new TimeSpan(1, 30, 0);
            Console.WriteLine($"Duration : {duration}");*/


        }
    }
}

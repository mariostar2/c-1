using System;


// 모든것은 namespae로 구분된다.

namespace ConsoleApp1
{
    //c++ c#의 차이점 
    // c#에는 전역 변수가 없다.
    // c#에는 해더 파일이 없다.
    // c#에는 '포인터'가없다. (따라서 ->에로우 연산자가 없다
    
    //클래스
    //=>기본적으로 private이며 참조타입이다
    
    // person의 class 
    class Person
    {
        //person클래스의 맴버 변수 
        string name;
        int age;
        string phone;

        public Person()
        {
            name = string.Empty;
            age = 0;
            phone = string.Empty;
               
        }
        public void GetInput()
        {
            Console.WriteLine("사용자 정보입력");
            Console.Write("이름:");
            name = Console.ReadLine();

            Console.Write("나이:");
            age = int.Parse(Console.ReadLine());

            Console.Write("휴대폰번호:");
            phone = Console.ReadLine();


            Console.Clear();



            
            
        }
        public void Print()
        {
            Console.Clear();
            Console.WriteLine();
            


        }

        //오버라이딩
        //부모가 자식으로부터 데이터 값을 받아 오는것  
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("이름:{0},나이:{1},번호:{2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //c#에서 변수는 객체다. 
            int number = 10;         //정수형
            float height = 10.5f;    //실수형
            double pi = 3.1415;      //실수형(부동소수)
            char c = 'A';            //문자형
            string str = "ABCD";     //문자열 



            //출력
            Console.WriteLine("number:{0}{0}, height:{1} {0}", number, height);

            //object 자료형
            //= c#의 모든 자료형이 상속하는 기본 클래스.
            object obj = number;
            obj = height;
            obj = pi;
            obj = c;
            obj = str;

            //string ToString()
            // => object 내부에 있는 가상함수이며 어떠한 변수라도 사용할 수 있다.
            string name = number.ToString();
            name = height.ToString();
            name = pi.ToString();

            Console.WriteLine(name);

            //입력
            Console.Write("값을 입력하세요:");
            string input = Console.ReadLine();
            Console.WriteLine("입력 값은 :{0}", input);


            //Parse(분석?)
            // ->문자열을 숫자로 가는 함수 
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input);

            //실습
            //나의 이름 나의 주소 휴대폰 번호 실행하기
            

          
        static void Main2(string[] args)
        {
            if(false)

            //입력단 
            Console.Write("이름:");
            string name2 = Console.ReadLine();
            Console.Write("나이:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("주소:");
            string address = Console.ReadLine();
            Console.Write("번호:");
            string phone = Console.ReadLine();


            //한줄 지우기 .console(창)에 관련된 것은 console안에 다있다.
            Console.Clear();
            Console.WriteLine("이름:{0}\n 나이\n{1}:\n주소{2}\n번호:{3}",
                name2, age, address, phone);

        }
            
        




        }
        
    }
}
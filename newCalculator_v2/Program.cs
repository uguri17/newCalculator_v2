// 필드
// 생성자
// 메서드
// 종료자
// 객체 생성 및 호출

// 실제로 사용 구현해보기
// 날코딩 보다는 전체적인 흐름이 중요

using System;

namespace newCalculator_v2
{
    class Calculator
    {
        // 필드 선언
        double num1, num2, result;

        /* :기본 생성자 생성 by compiler                                
        public Calculator() 
        { 

        }
        */

        // 소멸자 생성
        ~Calculator()
        {
            Console.WriteLine("소멸자");
        }

        // 메서드 선언
        public void Plus(double num1, double num2)
        {
            result = num1 + num2;
            Console.WriteLine($"+: {result}\n");
        }

        public void Minus(double num1, double num2)
        {
            result = num1 - num2;
            Console.WriteLine($"-: {result}\n");
        }

        public void Multiply(double num1, double num2)
        {
            result = num1 * num2;
            Console.WriteLine($"×: {result}\n");
        }

        public void Divide(double num1, double num2)
        {
            result = num1 / num2;
            Console.WriteLine($"÷: {result}");
        }
    }

    // 각기 다른 피연산자들의 각각의 사칙연산 값을 보고 싶은 user

    class MainApp
    {        
        static void Main(string[] args)
        {
            // 객체 생성
            Calculator calculator = new Calculator();

            // 메서드 호출
            calculator.Plus(10, 20);

            calculator.Minus(3.3, 2.3);

            calculator.Multiply(2, 4);

            calculator.Divide(10, 5);
        }
    }
}
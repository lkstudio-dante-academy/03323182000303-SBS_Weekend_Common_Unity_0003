#define E08_METHOD_01
#define E08_METHOD_02
#define E08_METHOD_03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 메서드 (함수) 란?
 * - 명령문의 일부 또는 전체를 따로 때어내서 재사용 할 수 있는 기능을 
 * 의미한다. (즉, 메서드를 활용하면 중복적으로 발생하는 명령문을 줄이는
 * 것이 가능하다.)
 * 
 * 메서드는 내부적으로 메서드가 호출 될 때 실행되는 명령문을 포함하고
 * 있으며 필요에 따라 메서드가 동작하기 위해서 필요한 데이터를 외부로부터
 * 입력 받는 것이 가능하다. (즉, 프로그래밍의 메서드 (함수) 는 수학의
 * 함수와 조금 다르다는 것을 알 수 있다.)
 * 
 * C# 메서드 유형
 * - 입력 O, 출력 O		<- int SomeMethod(int a_nVal);
 * - 입력 O, 출력 X		<- void SomeMethod(int a_nVal);
 * - 입력 X, 출력 O		<- int SomeMethod();
 * - 입력 X, 출력 X		<- void SomeMethod();
 * 
 * 위와 같이 메서드는 입력 데이터와 출력 데이터의 존재 여부에 따라
 * 크게 4 가지 유형으로 구분된다는 것을 알 수 있다.
 * 
 * C# 메서드 구현 방법
 * - 반환 형 (출력) + 메서드 이름 + 매개 변수 (입력) + 메서드 몸체
 * 
 * Ex)
 * void SomeMethod(int a_nValA, int a_nValB)
 * {
 *		// 메서드가 호출 될 때 실행 될 명령문
 * }
 */
namespace Example.Classes.Example_08
{
	class CExample_08
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if E08_METHOD_01
			Console.Write("수식 입력 : ");
			var oTokens = Console.ReadLine().Split();

			int.TryParse(oTokens[0], out int nValA);
			int.TryParse(oTokens[2], out int nValB);

			char.TryParse(oTokens[1], out char chOperator);

			decimal dmResult = GetResultCalc(nValA, 
				chOperator, nValB);

			Console.WriteLine("결과 : {0}", dmResult);
#elif E08_METHOD_02

#elif E08_METHOD_03

#endif
		}

#if E08_METHOD_01
		/** 수식 결과를 반환한다 */
		private static decimal GetResultCalc(int a_nValA,
			char a_chOperator, int a_nValB)
		{
			switch(a_chOperator)
			{
				case '+':
					return a_nValA + a_nValB;
				
				case '-':
					return a_nValA - a_nValB;
				
				case '*':
					return a_nValA * a_nValB;
				
				case '/':
					return a_nValA / (decimal)a_nValB;
			}

			/*
			 * return 키워드란?
			 * - 프로그램의 흐름을 중단하고 해당 메서드를 호출한
			 * 곳으로 되돌리는 역할을 수행하는 키워드를 의미한다.
			 * (즉, 해당 키워드를 활용하면 특정 메서드의 실행을
			 * 중지시키는 것이 가능하다.)
			 * 
			 * 또한, 메서드가 반환 값이 존재 할 경우 return 키워드에
			 * 반환 값을 반드시 명시해야되며 명시 된 반환 값은
			 * 메서드를 호출한 곳으로 전달 된다는 특징이 존재한다.
			 * (즉, 메서드가 반환 값이 존재 할 경우 반드시 return
			 * 키워드를 사용해서 반환 값을 명시해 줄 필요가 있다.)
			 */
			return 0;
		}
#elif E08_METHOD_02

#elif E08_METHOD_03

#endif
	}
}

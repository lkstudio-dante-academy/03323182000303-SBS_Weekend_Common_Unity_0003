/*
 * 전처리기 명령어란?
 * - 전처리기 단계에서 실행되는 명령어로서 C# 코드로
 * 작성 된 명령문을 컴파일하기 전에 코드 한번 튜닝하는
 * 역할을 수행한다.
 * 
 * 전처리기 명령어는 모두 # 으로 시작하는 특징이 
 * 존재하며 C# 의 기능이 아니기 때문에 C# 과는 전혀 
 * 다른 문법을 지니고 있다.
 * 
 * 또한, 해당 단계는 전처리기에 의해서 처리 된다는
 * 특징이 존재한다.
 * 
 * C# 주요 전처리기 명령어
 * - define
 * - if ~ else ~ endif
 * 
 * define 명령어는 특정 기호 (심볼) 를 정의하는 역할
 * 을 수행하며 해당 명령어로 정의 된 심볼을 조건문을
 * 통해 특정 코드를 활성화하거나 비활성화하는 것이
 * 가능하다.
 * 
 * Ex)
 * #if MOBILE_PLATFORM
 *      // 모바일 플랫폼 명령문
 * #else
 *      // 기타 플랫폼 명령문
 * #endif
 */
//#define E04_IF_ELSE
#define E04_SWITCH_CASE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 조건문이란?
 * - 특정 조건에 따라 프로그램의 흐름을 분산시키는 기능을 의미한다. (즉,
 * 조건문을 활용하면 다양한 결과를 만들어내는 프로그램을 제작하는 것이
 * 가능하다.)
 * 
 * C# 조건문 종류
 * - if ~ else
 * - switch ~ case
 * 
 * Ex)
 * if(조건식 A)
 * {
 *      // 조건식 A 를 만족 할 경우 실행 할 명령문
 * }
 * else if(조건식 B)
 * {
 *      // 조건식 B 를 만족 할 경우 실행 할 명령문
 * }
 * else
 * {
 *      // 조건식 A 와 B 를 모두 만족하지 않았을 경우 실행 할 명령문
 * }
 * 
 * switch(조건 값)
 * {
 *     case 조건 A:
 *          // 조건 A 를 만족 할 경우 실행 할 명령문
 *          
 *     case 조건 B:
 *          // 조건 B 를 만족 할 경우 실행 할 명령문
 *          
 *     default:
 *          // 조건 A 와 조건 B 를 모두 만족하지 않았을 경우 실행 할 명령문
 * }
 */
namespace Example.Classes.Example_04
{
	class CExample_04
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if E04_IF_ELSE
			int nScore = 0;

			Console.Write("점수 입력 : ");
			int.TryParse(Console.ReadLine(), out nScore);

			// F 학점 일 경우
			if(nScore < 60)
			{
				Console.WriteLine("F 학점입니다.");
			}
			else
			{
				// A 학점 일 경우
				if(nScore >= 90)
				{
					Console.WriteLine("A 학점입니다.");
				}
				// B 학점 일 경우
				else if(nScore >= 80)
				{
					Console.WriteLine("B 학점입니다.");
				}
				// C 학점 일 경우
				else if(nScore >= 70)
				{
					Console.WriteLine("C 학점입니다.");
				}
				// D 학점 일 경우
				else
				{
					Console.WriteLine("D 학점입니다.");
				}
			}
#elif E04_SWITCH_CASE
			int nScore = 0;

			Console.Write("점수 입력 : ");
			int.TryParse(Console.ReadLine(), out nScore);

			switch(nScore / 10)
			{
				case 9:
				case 10:
					Console.WriteLine("A 학점입니다.");
					break;

				case 8:
					Console.WriteLine("B 학점입니다.");
					break;

				case 7:
					Console.WriteLine("C 학점입니다.");
					break;

				case 6:
					Console.WriteLine("D 학점입니다.");
					break;

				default:
					Console.WriteLine("F 학점입니다.");
					break;
			}
#endif
		}
	}
}

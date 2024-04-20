#define E10_CLASS_01
#define E10_CLASS_02
#define E10_CLASS_03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 클래스란?
 * - 변수 및 메서드 등을 하나로 묶어서 관리 할 수 있는 기능을 의미한다. (즉,
 * 클래스를 활용하면 연관 된 데이터와 메서드를 하나의 데이터를 묶어서 
 * 제어하는 것이 가능하다.)
 * 
 * C# 은 객체 지향 프로그래밍 패러다임을 지원하며 객체 지향 프로그램의
 * 핵심이 되는 사물 (객체) 을 클래스를 통해서 표현하는 것이 가능하다. (즉,
 * 사물이 지니고 있는 특징을 크게 속성과 행위로 나누어서 사물의 속성은
 * 변수를 통해서 표현하고 사물의 행위는 메서드를 통해서 표현하는 것이
 * 가능하다.)
 * 
 * C# 클래스 정의 방법
 * - class + 클래스 이름 + 클래스 멤버 (변수, 메서드 등등...)
 * 
 * Ex)
 * class CSomeClass
 * {
 *		int m_nVal;
 *		
 *		void SomeMethod()
 *		{
 *				// Do Something
 *		}
 * }
 * 
 * CSomeClass oSomeObj = new CSomeClass();
 * 
 * 위와 같이 정의 된 클래스는 자료형처럼 사용하는 것이 가능하며 new 키워드를
 * 통해 사물 (객체) 을 생성하는 것이 가능하다. (즉, 클래스는 사물을 생성하기
 * 위한 틀처럼 활용된다는 것을 알 수 있다.)
 * 
 * 객체 지향 프로그래밍이란?
 * - 프로그램의 구조를 설계하기 위한 방법 중 하나로서 특정 역할을 수행하는
 * 사물을 정의하고 사물과 사물 간에 상호 작용을 통해서 프로그램의 목적을
 * 달성하는 설계 방법을 의미한다. (즉, 객체 지향 프로그래밍은 사물을 
 * 정의하는 것이 가장 중요하다는 것을 알 수 있다.)
 */
namespace Example.Classes.Example_10
{
	class CExample_10
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if E10_CLASS_01
			/*
			 * 사물 하위에 존재하는 멤버에 접근하고 싶다면 . (멤버 접근 연산자) 를
			 * 활용하면 된다. (즉, 해당 연산자를 활용하면 특정 사물이 지니고 있는
			 * 변수 및 메서드 등에 접근하는 것이 가능하다.)
			 */
			CCharacter oCharacterA = new CCharacter();
			oCharacterA.m_nLV = 1;
			oCharacterA.m_nHP = 25;
			oCharacterA.m_nATK = 5;

			CCharacter oCharacterB = new CCharacter();
			oCharacterB.m_nLV = 20;
			oCharacterB.m_nHP = 250;
			oCharacterB.m_nATK = 100;

			Console.WriteLine("=====> 캐릭터 A <=====");
			oCharacterA.ShowInfo();

			Console.WriteLine("\n=====> 캐릭터 B <=====");
			oCharacterB.ShowInfo();
#elif E10_CLASS_02

#elif E10_CLASS_03

#endif
		}

#if E10_CLASS_01
		/** 캐릭터 */
		private class CCharacter
		{
			public int m_nLV = 0;
			public int m_nHP = 0;
			public int m_nATK = 0;

			/** 정보를 출력한다 */
			public void ShowInfo()
			{
				Console.WriteLine("LV : {0}", m_nLV);
				Console.WriteLine("HP : {0}", m_nHP);
				Console.WriteLine("ATK : {0}", m_nATK);
			}
		}
#elif E10_CLASS_02

#elif E10_CLASS_03

#endif
	}
}

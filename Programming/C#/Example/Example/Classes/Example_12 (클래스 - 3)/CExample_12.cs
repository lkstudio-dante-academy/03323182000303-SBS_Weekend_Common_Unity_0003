#define E12_CLASS_01
#define E12_CLASS_02
#define E12_CLASS_03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 객체 지향 프로그래밍 3 대 요소
 * - 캡슐화 (정보 은닉)
 * - 상속
 * - 다형성
 * 
 * 캡슐화란?
 * - 객체가 지니는 멤버를 외부로부터 안전하게 보호하는 개념을 의미한다. (즉,
 * 캡슐화는 접근 제어 지시자를 통해서 구현하는 것이 가능하다.)
 * 
 * 일반적으로 객체가 사용하는 데이터 중 민감한 데이터를 가능하면 외부로부터
 * 안전하게 보호하는 것이 객체를 좀 더 안전하게 사용하는 개념이라는 것을
 * 알 수 있다.
 * 
 * 상속이란?
 * - 클래스 간에 부모/자식 관계를 형성시키는 개념을 의미한다. (즉, 특정 
 * 클래스가 상속 관계에 놓여있다면 클래스가 간에 상/하 관계가 형성된다는 
 * 것을 알 수 있다.)
 * 
 * 자식 클래스는 부모 클래스에 존재하는 멤버를 사용하는 것이 가능하기 때문에
 * 상속을 활용하면 클래스 간에 발생하는 중복적인 멤버를 줄이는 것이 가능하다.
 * 
 * Ex)
 * class CBase
 * {
 *		// Do Something
 * }
 * 
 * class CDerived : CBase
 * {
 *		// Do Something
 * }
 * 
 * 위와 CDerived 클래스는 CBase 클래스를 상속하고 있기 때문에 해당 클래스는
 * CBase 클래스에 존재하는 멤버를 사용하는 것이 가능하다.
 * 
 * 단, 상속은 단방향이기 때문에 두 클래스가 서로를 상속하는 것이 불가능하다.
 * (즉, 양방향 상속은 지원하지 않는다.)
 */
namespace Example.Classes.Example_12
{
	class CExample_12
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if E12_CLASS_01
			CBase oBase = new CBase();
			oBase.m_nVal = 10;
			oBase.m_fVal = 3.14f;

			CDerived oDerived = new CDerived();
			oDerived.m_nVal = 20;
			oDerived.m_fVal = 3.14f;
			oDerived.m_oStr = "ABC";

			Console.WriteLine("=====> 부모 클래스 <=====");
			oBase.ShowInfo();

			Console.WriteLine("\n=====> 자식 클래스 <=====");
			oDerived.ShowInfo();
#elif E12_CLASS_02

#elif E12_CLASS_03

#endif
		}

#if E12_CLASS_01
		/** 부모 클래스 */
		private class CBase
		{
			public int m_nVal = 0;
			public float m_fVal = 0.0f;

			/** 정보를 출력한다 */
			public void ShowInfo()
			{
				Console.WriteLine("정수 : {0}", m_nVal);
				Console.WriteLine("실수 : {0}", m_fVal);
			}
		}

		/** 자식 클래스 */
		private class CDerived : CBase
		{
			public string m_oStr = string.Empty;

			/*
			 * 부모 클래스와 자식 클래스에 동일한 이름의 멤버가 존재 할 경우 C# 
			 * 컴파일러에 의해서 경고가 발생한다.
			 * 
			 * 따라서, 해당 경고를 제거하기 위해서는 new 키워드를 사용해야한다. (즉, new
			 * 키워드를 사용하면 C# 컴파일러에게 의도적으로 동일한 이름의 멤버를 정의했다는
			 * 것을 알리는 의미라는 것을 알 수 있다.)
			 */
			/** 정보를 출력한다 */
			public new void ShowInfo()
			{
				/*
				 * base 키워드는 부모 클래스를 지칭하는 역할을 수행한다. (즉, 해당 키워드를
				 * 활용하면 부모 클래스에 존재하는 멤버에 접근하는 것이 가능하다.)
				 * 
				 * C# 클래스는 동일한 이름의 멤버를 부모 클래스와 자식 클래스에 모두 정의하는
				 * 것이 가능하기 때문에 이 경우 우선 순위는 자식 클래스 더 높다. (즉, 해당
				 * 경우 base 키워드를 생략하면 항상 자식에 존재하는 멤버에 접근한다는 것을
				 * 알 수 있다.)
				 */
				base.ShowInfo();
				Console.WriteLine("문자열 : {0}", m_oStr);
			}
		}
#elif E12_CLASS_02

#elif E12_CLASS_03

#endif
	}
}

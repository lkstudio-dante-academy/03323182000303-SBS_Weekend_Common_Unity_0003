//#define E06_ARRAY
#define E06_LIST
#define E06_STACK_QUEUE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 컬렉션이란?
 * - 여러 데이터를 관리 할 수 있는 기능을 의미한다. (즉, 컬렉션을
 * 활용하면 여러 데이터를 좀 더 효율적으로 제어하는 것이 가능하다.)
 * 
 * C# 은 크게 선형 컬렉션과 비선형 컬렉션을 지원한다.
 * 
 * 선형 컬렉션 vs 비선형 컬렉션
 * - 두 컬렉션 모두 여러 데이터를 관리하는 기능을 의미한다.
 * 
 * 선형 컬렉션은 내부적으로 1 차원의 형태로 데이터를 관리하기 때문에
 * 비교적 구현 난이도가 쉽다는 장점이 존재한다. 
 * 
 * 반면, 비선형 컬렉션은 선형 컬렉션에 비해 복잡한 형태로 데이터를
 * 관리하지만 데이터의 개수가 많아질수록 선형 컬렉션에 비해 성능이
 * 뛰어나다는 장점이 존재한다. (즉, 적은 데이터를 관리 할 때는
 * 선형 컬렉션과 비선형 컬렉션간에 성능 차이가 거의 없다는 것을 
 * 알 수 있다.)
 * 
 * C# 주요 선형 컬렉션 종류
 * - 배열
 * - 리스트
 * - 스택 / 큐
 * 
 * 배열이란?
 * - 동일한 자료형의 데이터를 여러개 관리 할 수 있는 컬렉션을 의미한다.
 * 
 * 또한, 배열은 데이터의 순서가 존재하기 때문에 관리 되고 있는 특정
 * 데이터에 접근하기 위해서는 [] (인덱스 연산자) 와 인덱스 번호를
 * 조합하면 된다.
 * 
 * 인덱스 번호 범위
 * - 0 ~ 컬렉션 길이 - 1
 * 
 * C# 배열 선언 방법
 * - 자료형 + [] (배열 기호) + 배열 이름
 * 
 * Ex)
 * int[] oValsA = new int[5];
 * float[] oValsB = new float[5];
 * 
 * 리스트란?
 * - 관리되는 데이터에 순서가 존재하는 컬렉션을 의미한다. (즉, 리스트는
 * 배열과 같이 데이터의 순서가 존재하기 때문에 특정 위치에 데이터를
 * 가져오기 위해서는 [] (인덱스 연산자) 와 인덱스 번호가 사용 된다는
 * 것을 알 수 있다.)
 * 
 * 단, 배열은 처음 생성되었때 명시된 길이를 초과하는 데이터는 관리
 * 할 수 없는 반면 리스트는 길이 제한이 없기 때문에 원하는만큼
 * 데이터를 추가하거나 제거하는 것이 가능하다.
 * 
 * C# 리스트 선언 방법
 * - List + 자료형 + 리스트 이름
 * 
 * Ex)
 * List<int> oValListA = new List<int>();
 * List<float> oValListB = new List<float>();
 * 
 * C# 주요 비선형 컬렉션 종류
 * - 셋
 * - 딕셔너리
 */
namespace Example.Classes.Example_06
{
	class CExample_06
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if E06_ARRAY
			int[] oValsA = new int[5];
			oValsA[0] = 1;
			oValsA[1] = 2;
			oValsA[2] = 3;

			int[] oValsB = new int[5]
			{
				1, 2, 3, 4, 5
			};

			int[] oValsC = new int[]
			{
				1, 2, 3
			};

			int[,] oMatrixA = new int[3, 3];
			oMatrixA[0, 0] = 1;
			oMatrixA[0, 1] = 2;
			oMatrixA[0, 2] = 3;

			int[,] oMatrixB = new int[3, 3]
			{
				{ 1, 2, 3 },
				{ 4, 5, 6 },
				{ 7, 8, 9 }
			};

			int[,] oMatrixC = new int[,]
			{
				{ 1, 2 },
				{ 4, 5 },
				{ 7, 8 }
			};

			Console.WriteLine("=====> 1 차원 배열 A <=====");

			for(int i = 0; i < oValsA.Length; ++i)
			{
				Console.Write("{0}, ", oValsA[i]);
			}

			Console.WriteLine("\n\n=====> 1 차원 배열 B <=====");

			for(int i = 0; i < oValsB.Length; ++i)
			{
				Console.Write("{0}, ", oValsB[i]);
			}

			Console.WriteLine("\n\n=====> 1 차원 배열 C <=====");

			for(int i = 0; i < oValsC.Length; ++i)
			{
				Console.Write("{0}, ", oValsC[i]);
			}

			Console.WriteLine("\n\n=====> 2 차원 배열 A <=====");

			for(int i = 0; i < oMatrixA.GetLength(0); ++i)
			{
				for(int j = 0; j < oMatrixA.GetLength(1); ++j)
				{
					Console.Write("{0}, ", oMatrixA[i, j]);
				}

				Console.WriteLine();
			}

			Console.WriteLine("\n=====> 2 차원 배열 B <=====");

			for(int i = 0; i < oMatrixB.GetLength(0); ++i)
			{
				for(int j = 0; j < oMatrixB.GetLength(1); ++j)
				{
					Console.Write("{0}, ", oMatrixB[i, j]);
				}

				Console.WriteLine();
			}

			Console.WriteLine("\n=====> 2 차원 배열 C <=====");

			for(int i = 0; i < oMatrixC.GetLength(0); ++i)
			{
				for(int j = 0; j < oMatrixC.GetLength(1); ++j)
				{
					Console.Write("{0}, ", oMatrixC[i, j]);
				}

				Console.WriteLine();
			}

			Console.WriteLine();
#elif E06_LIST
			/*
             * 배열 기반 리스트 vs 연결 기반 리스트
             */
			List<int> oListA = new List<int>();
			oListA.Add(1);
			oListA.Add(2);
			oListA.Add(3);

			//oListA[0] = 1;
			//oListA[0] = 100;

			List<int> oListB = new List<int>()
			{
				1, 2, 3, 4, 5
			};

			Console.WriteLine("=====> 리스트 A <=====");

			for(int i = 0; i < oListA.Count; ++i)
			{
				Console.Write("{0}, ", oListA[i]);
			}

			Console.WriteLine("\n\n=====> 리스트 B <=====");

			for(int i = 0; i < oListB.Count; ++i)
			{
				Console.Write("{0}, ", oListB[i]);
			}

			Console.WriteLine();
#elif E06_STACK_QUEUE

#endif
		}
	}
}

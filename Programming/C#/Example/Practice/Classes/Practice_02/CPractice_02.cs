//#define P02_PRACTICE_01
//#define P02_PRACTICE_02
#define P02_PRACTICE_03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes.Practice_02
{
	class CPractice_02
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if P02_PRACTICE_01
			Console.Write("구구단 범위 입력 : ");
			string[] oTokens = Console.ReadLine().Split();

			int.TryParse(oTokens[0], out int nNumA);
			int.TryParse(oTokens[1], out int nNumB);

			// 순서 보정이 필요 할 경우
			if(nNumA > nNumB)
			{
				int nTemp = nNumA;
				nNumA = nNumB;
				nNumB = nTemp;
			}

			for(int i = 1; i < 10; ++i)
			{
				for(int j = nNumA; j <= nNumB; ++j)
				{
					Console.Write("{0} * {1} = {2}\t",
						j, i, j * i);
				}

				Console.WriteLine();
			}

			Console.WriteLine();
#elif P02_PRACTICE_02
			Console.Write("라인 수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nNumLines);

			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = 0; j <= i; ++j)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
#elif P02_PRACTICE_03
			Console.Write("라인 수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nNumLines);

			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = 0; j < nNumLines; ++j)
				{
					Console.Write("{0}", (j <= i) ? '*' : ' ');
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = nNumLines - 1; i >= 0; --i)
			{
				for(int j = 0; j < nNumLines; ++j)
				{
					Console.Write("{0}", (j <= i) ? '*' : ' ');
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = nNumLines - 1; j >= 0; --j)
				{
					Console.Write("{0}", (j <= i) ? '*' : ' ');
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = nNumLines - 1; i >= 0; --i)
			{
				for(int j = nNumLines - 1; j >= 0; --j)
				{
					Console.Write("{0}", (j <= i) ? '*' : ' ');
				}

				Console.WriteLine();
			}

			Console.WriteLine();
#endif
		}
	}
}

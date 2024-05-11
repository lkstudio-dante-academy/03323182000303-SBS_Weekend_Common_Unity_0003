#define P04_USE_SET

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes.Practice_04
{
	class CPractice_04
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			Random oRandom = new Random();
			List<int> oAnswer = new List<int>();

#if P04_USE_SET
			HashSet<int> oSetValues = new HashSet<int>();

			while(oSetValues.Count < 4)
			{
				oSetValues.Add(oRandom.Next(1, 10));
			}

			foreach(int nVal in oSetValues)
			{
				oAnswer.Add(nVal);
			}
#else
			while(oAnswer.Count < 4)
			{
				int i = 0;
				int nVal = oRandom.Next(1, 10);

#if DISABLE
				for(i = 0; i < oAnswer.Count; ++i)
				{
					// 동일한 값이 존재 할 경우
					if(oAnswer[i] == nVal)
					{
						break;
					}
				}

				// 중복되지 않을 경우
				if(i >= oAnswer.Count)
				{
					oAnswer.Add(nVal);
				}
#endif

				// 중복되지 않을 경우
				if(!oAnswer.Contains(nVal))
				{
					oAnswer.Add(nVal);
				}
			}
#endif

			Console.Write("정답 : ");

			for(int i = 0; i < oAnswer.Count; ++i)
			{
				Console.Write("{0}, ", oAnswer[i]);
			}

			Console.WriteLine("\n");

			int nNumBalls = 0;
			int nNumStrikes = 0;

			do
			{
				Console.Write("정수 (4 개) 입력 : ");
				string[] oTokens = Console.ReadLine().Split();

				// 값이 유효하지 않을 경우
				if(oTokens.Length != 4)
				{
					continue;
				}

				nNumBalls = 0;
				nNumStrikes = 0;

				for(int i = 0; i < oTokens.Length; ++i)
				{
					int j = 0;
					int.TryParse(oTokens[i], out int nVal);

					// 값이 없을 경우
					if(!oAnswer.Contains(nVal))
					{
						continue;
					}

					int nIdx = oAnswer.IndexOf(nVal);

					nNumBalls += (i != nIdx) ? 1 : 0;
					nNumStrikes += (i == nIdx) ? 1 : 0;

#if DISABLE
					for(j = 0; j < oAnswer.Count; ++j)
					{
						// 값이 동일 할 경우
						if(oAnswer[j] == nVal)
						{
							break;
						}
					}

					// 값이 없을 경우
					if(j >= oAnswer.Count)
					{
						continue;
					}

					nNumBalls += (i != j) ? 1 : 0;
					nNumStrikes += (i == j) ? 1 : 0;
#endif
				}

				Console.WriteLine("결과 : {0} 스트라이크, {1} 볼\n",
					nNumStrikes, nNumBalls);
			} while(nNumStrikes < 4);
		}
	}
}

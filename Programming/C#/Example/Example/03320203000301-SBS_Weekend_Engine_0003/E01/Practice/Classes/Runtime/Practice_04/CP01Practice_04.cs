using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._03320203000301_SBS_Weekend_Engine_0003.E01.Practice.Classes.Runtime.Practice_04
{
	class CP01Practice_04
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			Random oRandom = new Random();
			List<int> oAnswer = new List<int>();
			HashSet<int> oSetValues = new HashSet<int>();

			while(oSetValues.Count < 4)
			{
				oSetValues.Add(oRandom.Next(1, 10));
			}

			foreach(int nVal in oSetValues)
			{
				oAnswer.Add(nVal);
			}

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
					int.TryParse(oTokens[i], out int nVal);

					// 값이 없을 경우
					if(!oAnswer.Contains(nVal))
					{
						continue;
					}

					int nIdx = oAnswer.IndexOf(nVal);

					nNumBalls += (i != nIdx) ? 1 : 0;
					nNumStrikes += (i == nIdx) ? 1 : 0;
				}

				Console.WriteLine("결과 : {0} 스트라이크, {1} 볼\n",
					nNumStrikes, nNumBalls);
			} while(nNumStrikes < 4);
		}
	}
}

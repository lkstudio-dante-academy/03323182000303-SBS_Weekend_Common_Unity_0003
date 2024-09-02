using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._03010201000301_SBS_Weekend_Engine_0003.E01.Practice.Classes.Runtime.Practice_01
{
	class CP01Practice_01
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			Random oRandom = new Random();
			int nAnswer = oRandom.Next(1, 101);

			Console.WriteLine("정답 : {0}\n", nAnswer);

			do
			{
				Console.Write("숫자 입력 : ");
				int.TryParse(Console.ReadLine(), out int nNum);

				// 정답 일 경우
				if(nNum == nAnswer)
				{
					Console.WriteLine("정답입니다.");
					break;
				}
				else
				{
					string oHint = (nNum < nAnswer) ?
						"큽니다." : "작습니다.";

					Console.WriteLine("정답은 {0} 보다 {1}\n",
						nNum, oHint);
				}
			} while(true);

			Console.WriteLine("\n게임을 종료합니다.");
		}
	}
}

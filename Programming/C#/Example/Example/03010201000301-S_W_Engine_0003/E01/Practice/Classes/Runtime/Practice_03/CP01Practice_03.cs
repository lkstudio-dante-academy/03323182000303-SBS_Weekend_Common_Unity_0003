using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._03010201000301_S_W_Engine_0003.E01.Practice.Classes.Runtime.Practice_03
{
	class CP01Practice_03
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			char[,] oMap = new char[7, 7]
			{
				{ '#', '#', '#', 'S', '#', '#', '#' },
				{ '#', '#', '#', ' ', '#', '#', '#' },
				{ '#', '#', '#', ' ', '#', '#', '#' },
				{ ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
				{ ' ', '#', ' ', '#', '#', ' ', '#' },
				{ ' ', ' ', ' ', ' ', '#', ' ', '#' },
				{ ' ', 'E', '#', ' ', '#', ' ', '#' }
			};

			Console.WriteLine("=====> 탐색 전 <=====");
			PrintMap(oMap);

			FindPath(oMap, 3, 0);

			Console.WriteLine("\n=====> 탐색 후 <=====");
			PrintMap(oMap);
		}

		/** 맵을 출력한다 */
		private static void PrintMap(char[,] a_oMap)
		{
			for(int i = 0; i < a_oMap.GetLength(0); ++i)
			{
				for(int j = 0; j < a_oMap.GetLength(1); ++j)
				{
					Console.Write("{0}", a_oMap[i, j]);
				}

				Console.WriteLine();
			}
		}

		/** 경로를 탐색한다 */
		private static bool FindPath(char[,] a_oMap,
			int a_nX, int a_nY)
		{
			int nNumRows = a_oMap.GetLength(0);
			int nNumCols = a_oMap.GetLength(1);

			// 맵을 벗어났을 경우
			if(a_nX < 0 || a_nX >= nNumCols ||
				a_nY < 0 || a_nY >= nNumRows)
			{
				return false;
			}

			char chPrevLetter = a_oMap[a_nY, a_nX];

			a_oMap[a_nY, a_nX] = (chPrevLetter != '#') ?
				'*' : chPrevLetter;

			// 목적지에 도달했을 경우
			if(chPrevLetter == 'E')
			{
				a_oMap[a_nY, a_nX] = chPrevLetter;
				return true;
			}

			// 이동이 불가능 할 경우
			if(chPrevLetter == '#' || chPrevLetter == '*')
			{
				return false;
			}

			List<int> oListOffsetsX = new List<int>()
			{
				0, 0, -1, 1
			};

			List<int> oListOffsetsY = new List<int>()
			{
				-1, 1, 0, 0
			};

			for(int i = 0; i < oListOffsetsX.Count; ++i)
			{
				int nNextX = a_nX + oListOffsetsX[i];
				int nNextY = a_nY + oListOffsetsY[i];

				// 탐색에 성공했을 경우
				if(FindPath(a_oMap, nNextX, nNextY))
				{
					// 시작 위치 일 경우
					if(chPrevLetter == 'S')
					{
						a_oMap[a_nY, a_nX] = chPrevLetter;
					}

					return true;
				}
			}

			a_oMap[a_nY, a_nX] = chPrevLetter;
			return false;
		}
	}
}

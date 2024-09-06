using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._03010201000301_S_W_Engine_0003.E01.Practice.Classes.Runtime.Practice_05
{
	class CP01Practice_05
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			char[,] oWorld = new char[15 + 2, 35 + 2];

			int nPosX = oWorld.GetLength(1) / 2;
			int nPosY = oWorld.GetLength(0) / 2;

			int nDirectionX = 1;
			int nDirectionY = 0;

			var stPrevTime = DateTime.Now;
			Console.CursorVisible = false;

			while(true)
			{
				var stCurTime = DateTime.Now;
				var stDeltaTime = stCurTime - stPrevTime;

				stPrevTime = stCurTime;
				ClearWorld(oWorld);

				UpdateSnake(oWorld,
					stDeltaTime.TotalSeconds, ref nPosX, ref nPosY, ref nDirectionX, ref nDirectionY);

				DrawOutline(oWorld);
				DrawSnake(oWorld, nPosX, nPosY);

				PresentWorld(oWorld);
			}
		}

		/** 월드를 클리어한다 */
		private static void ClearWorld(char[,] a_oWorld)
		{
			for(int i = 0; i < a_oWorld.GetLength(0); ++i)
			{
				for(int j = 0; j < a_oWorld.GetLength(1); ++j)
				{
					a_oWorld[i, j] = ' ';
				}
			}
		}

		/** 월드를 그린다 */
		private static void PresentWorld(char[,] a_oWorld)
		{
			Console.SetCursorPosition(0, 0);

			for(int i = 0; i < a_oWorld.GetLength(0); ++i)
			{
				for(int j = 0; j < a_oWorld.GetLength(1); ++j)
				{
					Console.Write("{0}", a_oWorld[i, j]);
				}

				Console.WriteLine();
			}
		}

		private static double m_dblSkipTime = 0.0;

		/** 스네이크를 갱신한다 */
		private static void UpdateSnake(char[,] a_oWorld,
			double a_dblDeltaTime, ref int a_nPosX, ref int a_nPosY, ref int a_nDirectionX, ref int a_nDirectionY)
		{
			m_dblSkipTime += a_dblDeltaTime;
			UpdateSnakeDirection(a_oWorld, ref a_nDirectionX, ref a_nDirectionY);

			// 일정 시간이 지났을 경우
			if(m_dblSkipTime >= 0.1)
			{
				m_dblSkipTime = 0.0;

				a_nPosX += a_nDirectionX;
				a_nPosY += a_nDirectionY;
			}

			a_nPosX = Math.Max(1, a_nPosX);
			a_nPosX = Math.Min(a_oWorld.GetLength(1) - 2, a_nPosX);

			a_nPosY = Math.Max(1, a_nPosY);
			a_nPosY = Math.Min(a_oWorld.GetLength(0) - 2, a_nPosY);
		}

		/** 스네이크 방향을 갱신한다 */
		private static void UpdateSnakeDirection(char[,] a_oWorld,
			ref int a_nDirectionX, ref int a_nDirectionY)
		{
			// 방향 갱신이 불가능 할 경우
			if(!Console.KeyAvailable)
			{
				return;
			}

			var stKeyInfo = Console.ReadKey();

			switch(stKeyInfo.Key)
			{
				case ConsoleKey.UpArrow:
					a_nDirectionX = 0;
					a_nDirectionY = -1;

					break;

				case ConsoleKey.DownArrow:
					a_nDirectionX = 0;
					a_nDirectionY = 1;

					break;

				case ConsoleKey.LeftArrow:
					a_nDirectionX = -1;
					a_nDirectionY = 0;

					break;

				case ConsoleKey.RightArrow:
					a_nDirectionX = 1;
					a_nDirectionY = 0;

					break;
			}
		}

		/** 외곽선을 그린다 */
		private static void DrawOutline(char[,] a_oWorld)
		{
			for(int i = 0; i < a_oWorld.GetLength(0); ++i)
			{
				for(int j = 0; j < a_oWorld.GetLength(1); ++j)
				{
					// 위쪽 or 아래쪽 외곽선 일 경우
					if(i == 0 || i == a_oWorld.GetLength(0) - 1)
					{
						a_oWorld[i, j] = '#';
					}
					// 왼쪽 or 오른쪽 외곽선 일 경우
					else if(j == 0 || j == a_oWorld.GetLength(1) - 1)
					{
						a_oWorld[i, j] = '#';
					}
				}
			}
		}

		/** 스네이크를 그린다 */
		private static void DrawSnake(char[,] a_oWorld,
			int a_nPosX, int a_nPosY)
		{
			a_oWorld[a_nPosY, a_nPosX] = '@';
		}
	}
}

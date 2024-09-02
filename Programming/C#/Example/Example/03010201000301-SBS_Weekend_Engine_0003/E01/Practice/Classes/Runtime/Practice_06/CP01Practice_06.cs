using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._03010201000301_SBS_Weekend_Engine_0003.E01.Practice.Classes.Runtime.Practice_06
{
	class CP01Practice_06
	{
		/** 메뉴 */
		private enum EMenu
		{
			NONE = -1,
			ADD_LINE,
			ADD_TRIANGLE,
			ADD_RECTANGLE,
			DRAW_ALL_SHAPES,
			EXIT,
			MAX_VAL
		}

		/** 초기화 */
		public static void Start(string[] args)
		{
			EMenu eMenu = EMenu.NONE;
			CP01Canvas_06 oCanvas = new CP01Canvas_06();

			do
			{
				PrintMenu();
				int.TryParse(Console.ReadLine(), out int nMenu);

				eMenu = (EMenu)(nMenu - 1);

				switch(eMenu)
				{
					case EMenu.ADD_LINE:
					case EMenu.ADD_TRIANGLE:
					case EMenu.ADD_RECTANGLE:
						CP01Shape_06 oShape = CreateShape(eMenu);
						oCanvas.AddShape(oShape);

						break;

					case EMenu.DRAW_ALL_SHAPES:
						oCanvas.DrawAllShapes();
						break;
				}

				Console.WriteLine();
			} while(eMenu != EMenu.EXIT);
		}

		/** 메뉴를 출력한다 */
		private static void PrintMenu()
		{
			Console.WriteLine("=====> 메뉴 <=====");
			Console.WriteLine("1. 선 추가");
			Console.WriteLine("2. 삼각형 추가");
			Console.WriteLine("3. 사각형 추가");
			Console.WriteLine("4. 모든 도형 그리기");
			Console.WriteLine("5. 종료");

			Console.Write("\n선택 : ");
		}

		/** 도형을 생성한다 */
		private static CP01Shape_06 CreateShape(EMenu a_eMenu)
		{
			var oColors = new ConsoleColor[]
			{
				ConsoleColor.Red,
				ConsoleColor.Green,
				ConsoleColor.Blue
			};

			var oRandom = new Random();
			var eColor = oColors[oRandom.Next(0, oColors.Length)];

			switch(a_eMenu)
			{
				case EMenu.ADD_LINE:
					return new CP01Line_06(eColor);

				case EMenu.ADD_TRIANGLE:
					return new CP01Triangle_06(eColor);

				case EMenu.ADD_RECTANGLE:
					return new CP01Rectangle_06(eColor);
			}

			return null;
		}
	}
}

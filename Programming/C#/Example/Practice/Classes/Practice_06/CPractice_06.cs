using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes.Practice_06
{
	class CPractice_06
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
			CCanvas oCanvas = new CCanvas();

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
						CShape oShape = CreateShape(eMenu);
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
		private static CShape CreateShape(EMenu a_eMenu)
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
					return new CLine(eColor);

				case EMenu.ADD_TRIANGLE:
					return new CTriangle(eColor);

				case EMenu.ADD_RECTANGLE:
					return new CRectangle(eColor);
			}

			return null;
		}
	}
}

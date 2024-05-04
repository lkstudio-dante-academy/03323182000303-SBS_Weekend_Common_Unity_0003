using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes.Practice_06
{
	/** 도형 */
	public class CShape
	{
		private ConsoleColor m_eColor = ConsoleColor.White;

		/** 생성자 */
		public CShape(ConsoleColor a_eColor)
		{
			m_eColor = a_eColor;
		}

		/** 도형을 그린다 */
		public void Draw()
		{
			Console.ForegroundColor = m_eColor;
			this.DoDraw();

			Console.ResetColor();
		}

		/** 도형을 그린다 */
		protected virtual void DoDraw()
		{
			// Do Something
		}
	}

	/** 선 */
	public class CLine : CShape
	{
		/** 생성자 */
		public CLine(ConsoleColor a_eColor) : base(a_eColor)
		{
			// Do Something
		}

		/** 도형을 그린다 */
		protected override void DoDraw()
		{
			base.DoDraw();
			Console.WriteLine("선을 그렸습니다.");
		}
	}

	/** 삼각형 */
	public class CTriangle : CShape
	{
		/** 생성자 */
		public CTriangle(ConsoleColor a_eColor) : base(a_eColor)
		{
			// Do Something
		}

		/** 도형을 그린다 */
		protected override void DoDraw()
		{
			base.DoDraw();
			Console.WriteLine("삼각형을 그렸습니다.");
		}
	}

	/** 사각형 */
	public class CRectangle : CShape
	{
		/** 생성자 */
		public CRectangle(ConsoleColor a_eColor) : base(a_eColor)
		{
			// Do Something
		}

		/** 도형을 그린다 */
		protected override void DoDraw()
		{
			base.DoDraw();
			Console.WriteLine("사각형을 그렸습니다.");
		}
	}
}

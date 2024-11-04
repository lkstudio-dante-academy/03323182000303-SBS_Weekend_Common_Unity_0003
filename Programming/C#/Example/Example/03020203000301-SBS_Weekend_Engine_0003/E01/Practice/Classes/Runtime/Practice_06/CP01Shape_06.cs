using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._03020203000301_SBS_Weekend_Engine_0003.E01.Practice.Classes.Runtime.Practice_06
{
	/** 도형 */
	public class CP01Shape_06
	{
		private ConsoleColor m_eColor = ConsoleColor.White;

		/** 생성자 */
		public CP01Shape_06(ConsoleColor a_eColor)
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
	public class CP01Line_06 : CP01Shape_06
	{
		/** 생성자 */
		public CP01Line_06(ConsoleColor a_eColor) : base(a_eColor)
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
	public class CP01Triangle_06 : CP01Shape_06
	{
		/** 생성자 */
		public CP01Triangle_06(ConsoleColor a_eColor) : base(a_eColor)
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
	public class CP01Rectangle_06 : CP01Shape_06
	{
		/** 생성자 */
		public CP01Rectangle_06(ConsoleColor a_eColor) : base(a_eColor)
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

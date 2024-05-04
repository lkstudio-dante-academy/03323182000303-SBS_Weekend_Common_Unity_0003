using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes.Practice_06
{
	/** 캔버스 */
	public class CCanvas
	{
		private List<CShape> m_oListShapes = new List<CShape>();

		/** 도형을 추가한다 */
		public void AddShape(CShape a_oShape)
		{
			m_oListShapes.Add(a_oShape);
		}

		/** 모든 도형을 그린다 */
		public void DrawAllShapes()
		{
			for(int i = 0; i < m_oListShapes.Count; ++i)
			{
				m_oListShapes[i].Draw();
			}
		}
	}
}

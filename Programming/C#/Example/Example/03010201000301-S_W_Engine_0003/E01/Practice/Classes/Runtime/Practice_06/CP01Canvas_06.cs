using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._03010201000301_S_W_Engine_0003.E01.Practice.Classes.Runtime.Practice_06
{
	/** 캔버스 */
	public class CP01Canvas_06
	{
		private List<CP01Shape_06> m_oListShapes = new List<CP01Shape_06>();

		/** 도형을 추가한다 */
		public void AddShape(CP01Shape_06 a_oShape)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Example 1
 */
public class CExample_01 : MonoBehaviour
{
	[SerializeField] private GameObject m_oObjects = null;
	[SerializeField] private GameObject m_oPrefabCube = null;

	/** 초기화 */
	public void Awake()
	{
		Physics.gravity = new Vector3(0.0f, -9.81f * 100.0f, 0.0f);

#if DISABLE_THIS
        float fAngle = 45.0f / 2.0f;
        float fHeight = 720.0f / 2.0f;

        float fDistance = fHeight / Mathf.Tan(fAngle * Mathf.Deg2Rad);
#endif // #if DISABLE_THIS
	}

	/** 상태를 갱신한다 */
	public void Update()
	{
		// 스페이스 키를 눌렀을 경우
		if(Input.GetKeyDown(KeyCode.Space))
		{
			var oCloneGameObj = Instantiate(m_oPrefabCube,
				Vector3.zero, Quaternion.identity);

			oCloneGameObj.transform.SetParent(m_oObjects.transform,
				false);

			oCloneGameObj.transform.localScale = new Vector3(Random.Range(100.0f, 150.0f),
				Random.Range(100.0f, 150.0f), Random.Range(100.0f, 150.0f));
		}
	}
}

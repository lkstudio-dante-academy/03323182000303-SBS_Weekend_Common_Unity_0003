using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Example 1
 */
public class CExample_01 : MonoBehaviour
{
    public GameObject m_oPrefabCube = null;

    /** 초기화 */
    public void Awake()
    {
        Debug.Log("Hello, World!");
    }

    /** 상태를 갱신한다 */
    public void Update()
    {
        // 스페이스 키를 눌렀을 경우
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(m_oPrefabCube, 
                Vector3.zero, Quaternion.identity);
        }
    }
}

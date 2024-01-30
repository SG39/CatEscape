using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App1 : MonoBehaviour
{

    [SerializeField]
    private Transform a;

    [SerializeField]
    private Transform b;

    private void Awake() 
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("a : {0}", a);  // Transform의 인스턴스
        // Debug.LogFormat("a.gameObject : {0}", a.gameObject);
        Debug.LogFormat("b : {0}", b);

        //? 벡터의 뺄샘 (뺴는 순서에 따라 방향이 바뀐다.)
        // 연산결과 : 방향백터 (새로운 백터)
        Vector3 c = b.position - a.position;
        Debug.LogFormat("c : {0}", c); // 방향

        //DrawArrow.ForDebug(a.position, c, 10, Color.cyan, ArrowType.Solid);

        Vector3 c1 = a.position - b.position;
        Debug.LogFormat("c : {0}", c); // 방향

        DrawArrow.ForDebug(a.position, c, 10, Color.cyan, ArrowType.Solid);

        // Debug.LogFormat("c1.magnitude : {0}", c1.magnitude); // 백터의 길이 반환
        // Vector3 nomal = c1.normalized; // 단위백터 생성

        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

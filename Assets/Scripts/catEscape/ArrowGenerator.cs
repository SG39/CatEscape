using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class ArrowGenerator : MonoBehaviour
{
    //? 프리팹의 인스턴스 제작
    [SerializeField] private GameObject arrowPrefab;
    private float delta;
    private CatEscapeGameDirector gameDirector;
    private List<GameObject> arrowList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        this.gameDirector = GameObject.FindAnyObjectByType<CatEscapeGameDirector>();
    }

    // Update is called once per frame
    void Update()
    {

        if(gameDirector.GetHp()>0)
        {
            delta += Time.deltaTime;// 이전 프레임과 현제 프레임의 사이 시간
            Debug.Log(delta);
            if(delta > 3)
            {
                // 생성
                GameObject go;
                
                // 배열에 저장
                arrowList.Add(go = UnityEngine.Object.Instantiate(this.arrowPrefab));

                // 위치 재설정
                float randX = UnityEngine.Random.Range(-8, 9);
                go.transform.position = new Vector3(randX, go.transform.position.y, go.transform.position.z);
                delta = 0; // 초기화
            }
        }

        // Hp가 0이면 리스트에 저장된 프리펩 전부 삭제
        if(gameDirector.GetHp() <= 0)
        {
            foreach(GameObject go in arrowList)
            {
                Destroy(go);
            }
        }

        
    }

}

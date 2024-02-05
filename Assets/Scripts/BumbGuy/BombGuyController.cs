using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BombGuyController : MonoBehaviour
{
    [SerializeField] Transform flagTransform;
    // BonbGuyController가 animator컴포넌트를 알아야한다.
    // animator컴포넌트는 자식오브젝트에 붙어있다.
    // 자식 컴포넌트는 어떻게 가져올까?
    [SerializeField] Animator anime;

    private float dirction = 0;
    private Coroutine coroutine;

    private enum status
    {
        Idle, Run
    }

    private void Start() 
    {
        // Transform animeTransform = this.transform.Find("anime");
        // GameObject animeGo = animeTransform.gameObject;
        // this.anime = animeGo.GetComponent<Animator>();

        // 코루틴 함수 사용시
        this.coroutine = this.StartCoroutine(CoMove( () => { Debug.LogFormat("이동을 모두 종료했습니다."); } ));
    }

    IEnumerator CoMove(Action callback)
    {
        // 매 프레임 마다 이동
        while(true)
        {
            this.transform.Translate(transform.right * 1f * Time.deltaTime);
            float length = this.flagTransform.position.x - this.transform.position.x;
            if(length<1)
            {
                break;
            }
            yield return null; // 다음 프레임으로 넘어간다.
        }
        yield return null;
        yield return null;
        yield return null; // 가능

        callback();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StopCoroutine(coroutine);
        }

        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            Debug.Log("Idle");    

            // 애니메이션 전환
            // 전환시 파라메터 변환
            this.anime.SetInteger("State", 0);
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Run");
            this.anime.SetInteger("State", 1);    
        }

        MovePlayer();

        
    }

    private void MovePlayer()
    {
        dirction = 0;
        
        float scaleY = this.anime.transform.localScale.y;
        float scaleZ = this.anime.transform.localScale.z;

        if(Input.GetKeyDown(KeyCode.LeftArrow)) // 왼쪽
        {
            dirction = -1; 
            this.anime.transform.localScale = new Vector3(-3 ,scaleY, scaleZ);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)) // 오른쪽
        {
            dirction = 1;
            this.anime.transform.localScale = new Vector3(3 ,scaleY, scaleZ);
        }

        // this.transform.Translate(dirction * 1f * Time.deltaTime);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float radius = 0.5f;
    [SerializeField] private float attackDamege = 5;
    private CatEscapeGameDirector gameDirector; // 동적으로 생성되는 애는 어사인 불가
    private GameObject playerGo;


    // Start is called before the first frame update
    void Start()
    {
        // 이름으로 컴포넌트 찾기
        this.playerGo = GameObject.Find("player");
        // 타입으로 컴포넌트 찾기
        this.gameDirector = GameObject.FindObjectOfType<CatEscapeGameDirector>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // 방향 * 속도 * 시간
        Vector3 movement = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movement);
        // Debug.LogFormat("y : {0}", this.transform.position.y);
        

        // 현재좌표가 -3보다 작아졌을때 삭제(바닥에 닿았을 때)
        if(this.transform.position.y <= -3.0f)
        {
            // Debug.LogError("distroy");
            // Destroy(this); => ArrowController 컴포넌트가 제거된다.
            Destroy(this.gameObject);
        }

        //? 고양이와 충돌시 삭제
        // 거리
        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.playerGo.transform.position;
        Vector2 dir = p1 -p2; // 방향
        float distacce = dir.magnitude;// 거리

        float r1 = this.radius;
        playerController playerCont = this.playerGo.GetComponent<playerController>();
        float r2 = playerCont.radius;
        float sumRadius = r1 + r2;

        if(distacce < sumRadius) // 충돌함
        {
            playerController playerController = this.playerGo.GetComponent<playerController>();
            playerController.SetHp(attackDamege);
            this.gameDirector.DecreaseHp();
            Destroy(this.gameObject);
        }
        

    }

    // event methosd
    private void OnDrawGizmos() // 기즈모 그리기
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }


}

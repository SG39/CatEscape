using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float jumpForce = 680f;
    [SerializeField] private float moveForce = 500f;
    [SerializeField] private float animeSpeed = 1f;
    private ClimbClouldGameDirector gameDirector;
    private Animator animator;
    private bool isTouch = false;
    private int dirX = 0; // 방향 움직는 방향

    private void Start() 
    {
        this.gameDirector = GameObject.FindAnyObjectByType<ClimbClouldGameDirector>();
        this.animator = this.gameObject.GetComponent <Animator>();
    }
    
    void Update()
    {
        JampCat();   

        MoveCat();


        this.gameDirector.UpdateVelocityText(this.rbody.velocity); // velocity표기


    }

    private void JampCat()// 점프
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jamp : False");
            if(this.rbody.velocity.y == 0)
            {
                Debug.Log("Jamp : True");
                this.rbody.AddForce(this.transform.up * this.jumpForce); // 로컬좌표와 유사 // this.rbody.AddForce(Vector3.up * this.force); // 월드좌표상  
            }        
        }
    }

    private void MoveCat()
    {
        float posX = Mathf.Clamp(this.transform.position.x, -2.7f, 2.7f);
        this.transform.position = new Vector3(posX, this.transform.position.y, this.transform.position.z);

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            dirX = -1;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            dirX = 1;
        }

        if(Mathf.Abs(this.rbody.velocity.x) < 3) // 속도 한정하기
        {
            this.rbody.AddForce((this.transform.right*dirX) * this.moveForce);
            animator.speed = animeSpeed * Mathf.Abs(this.rbody.velocity.x);
            // Debug.Log(animator.speed);
        }

        if(dirX != 0) // 고양이 회전
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }

        dirX = 0;
    }

    // 최초 충돌
    private void OnTriggerEnter2D(Collider2D other) // Triger 모드일 경우 충돌판정
    {
        if(isTouch == false)
        {
            Debug.LogFormat("OnTriggerEnter2D : {0}", other);
            isTouch = true;
        }

        // 장면전환
        SceneManager.LoadScene(1);

    }

    // private void OnTriggerExit2D(Collider2D other) 
    // {
    //     // 충돌에서 벋어날때
    //     Debug.LogFormat("OnTriggerExit2D : {0}", other);
    // }

    // private void OnTriggerStay2D(Collider2D other) 
    // {
    //     // 계속 충돌시
    //     Debug.LogFormat("OnTriggerStay2D : {0}", other);
    // }

}

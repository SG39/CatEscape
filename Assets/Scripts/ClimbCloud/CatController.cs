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

    private void Start() 
    {
        this.gameDirector = GameObject.FindAnyObjectByType<ClimbClouldGameDirector>();
        this.animator = this.gameObject.GetComponent <Animator>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // 점프
            // this.rbody.AddForce(Vector3.up * this.force); // 월드좌표상            
            this.rbody.AddForce(this.transform.up * this.jumpForce); // 로컬좌표와 유사
        }

        int dir = 0;


        if(Input.GetKey(KeyCode.LeftArrow))
        {
            dir = -1;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            dir = 1;
        }

        ReversCat(dir); // 회전

        if(Mathf.Abs(this.rbody.velocity.x) < 3)
        {
            this.rbody.AddForce((this.transform.right*dir) * this.moveForce);
            animator.speed = animeSpeed * Mathf.Abs(this.rbody.velocity.x);
            // Debug.Log(animator.speed);
        }

        this.gameDirector.UpdateVelocityText(this.rbody.velocity);


    }

    private void ReversCat(int dir)
    {
        if(dir != 0)
        {
            this.transform.localScale = new Vector3(dir, 1, 1);
        }
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

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CatController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float jumpForce = 680f;
    [SerializeField] private float moveForce = 500f;
    private ClimbClouldGameDirector gameDirector;

    private void Start() 
    {
        this.gameDirector = GameObject.FindAnyObjectByType<ClimbClouldGameDirector>();
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
}

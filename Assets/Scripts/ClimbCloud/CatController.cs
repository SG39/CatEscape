using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float jumpForce = 680f;
    [SerializeField] private float moveForce = 500f;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // 점프
            this.rbody.AddForce(this.transform.up * this.jumpForce); // 로컬좌표와 유사
            // this.rbody.AddForce(Vector3.up * this.force); // 월드좌표상            
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.rbody.AddForce(-(this.transform.right) * this.moveForce);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rbody.AddForce(this.transform.right * this.moveForce);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 10;
    private float horizontalMove;
    private float VerticalMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       MoveShip();
    }

    private void MoveShip()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirY = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * dirX;
        Vector3 moveVertical = transform.up * dirY;

        Vector3 moveship = (moveHorizontal+moveVertical).normalized * MoveSpeed;

        Debug.Log(moveship);
        this.transform.Translate(moveship * Time.deltaTime);
    }
}

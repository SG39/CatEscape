using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // 1. 마우스 왼클릭
    // 2. 회전
    // Start is called before the first frame update

    // [SerializeField]
    // private GameObject rouletteGo;

    [SerializeField] private float maxSpeed = 2.0f;
    [SerializeField] private float attenuationSpeed = 0.995f;
    private float speed = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Start!");
            speed = maxSpeed;
        }
        this.gameObject.transform.Rotate(0, 0, speed);

        speed *= attenuationSpeed;
    }
}

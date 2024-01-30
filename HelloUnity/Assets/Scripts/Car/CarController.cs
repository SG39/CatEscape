using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 0.1f;
    [SerializeField] private float attenuation = 0.96f;
    [SerializeField] private float divied = 500f;
    private float speed = 0;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Torch Start");
            // 터치위치 가져오기
            Debug.Log(Input.mousePosition);
            this.startPosition = Input.mousePosition;
            // speed = maxSpeed;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("End");
            Debug.Log(Input.mousePosition);

            float length = Input.mousePosition.x - this.startPosition.x;
            Debug.Log(length);
            Debug.Log(length / divied);
            speed = length / divied;
            Debug.LogFormat("<color=yellow>speed : {0}</color>", speed);

            // 손을 땐 지점의 x축 - 터치한 지점의 x축
        }

        // 사운드 실행
        // 게임오브젝트에 붙어있는 컴포넌트 가져오기
        AudioSource audioSource =  this.gameObject.GetComponent<AudioSource>();
        audioSource.Play(0);

        // move 0.1 unite to frwam
        this.gameObject.transform.Translate(new Vector3(speed, 0, 0));

        speed *= attenuation; // 매프레임 마다 속도 감소

    }
}

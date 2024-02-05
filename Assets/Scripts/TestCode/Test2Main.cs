using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test2Main : MonoBehaviour
{
    [SerializeField] private Transform CubeTransform;

    void Update()
    {
        // 화면클릭시 Ray발사
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray1 = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray1.origin, ray1.direction * 20f, Color.green, 10);

            // 레이와 콜라이터의 충돌
            RaycastHit hit; // 충돌했다면 충돌정보를 담는 변수
            //Physics.Raycast(시작위치, 방향, out hit, 거리);
            if(Physics.Raycast(ray1.origin, ray1.direction, out hit, 20))
            {
                Debug.Log("충돌함");
                Debug.LogFormat(" => {0}", hit.point);
                this.CubeTransform.position = hit.point;
            }
            /*
                실수 원인
                1. 콜라이더가 없다.
                2. 레이의 길이가 짧아 충돌이 안되었다.
            */
        }
    }
}

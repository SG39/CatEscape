using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharactorController : MonoBehaviour
{
    private Coroutine coroutine;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 tpos = this.transform.position;


            RaycastHit hit;

            if(Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                tpos.x = hit.point.x;
                tpos.y = 0;
                tpos.z = hit.point.z;

                if(this.coroutine != null) // 코루틴은 분산실행되어 결과가 중첩된다. 이를 해결하기위해 코루틴 변수를 선언하고 코루틴이 실행되고 있는지 확인하고 중지시킨후 재시작 한다.
                {
                    StopCoroutine(this.coroutine);
                }
                this.coroutine = StartCoroutine(this.CoMove(tpos));
            }

        }
    }

    IEnumerator CoMove(Vector3 tPos)
    {
        this.transform.LookAt(tPos);
        while(true)
        {
            this.transform.Translate(Vector3.forward * 1f * Time.deltaTime);
            float distance = (tPos - this.transform.position).magnitude;
            if(distance <= 0.1f)
            {
                break;
            }
            yield return null;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoroutinTest : MonoBehaviour
{
    [SerializeField] private Transform flag;
    private int i=1;
    private Coroutine Co;
    // Start is called before the first frame update
    void Start()
    {
        this.Co = this.StartCoroutine(move());
        Debug.Log("start");

    }

    // Update is called once per frame
    void Update()
    {
        if(i == 1)
        {
            Debug.Log("Update");
            i--;
        }
        if(Input.GetMouseButtonDown(0))
        {
            StopCoroutine(Co);
            Debug.Log("StopCo");
        }

    }

    IEnumerator move()
    {
        while(true)
        {
            this.transform.Translate(transform.right* 1f * Time.deltaTime);
            float xLengns = this.flag.transform.position.x - this.transform.position.x;
            Debug.Log("move");
            if(xLengns < 1)
            {
                break;
            }
            yield return null;
        }
        Debug.Log("moveComp");
    }
}

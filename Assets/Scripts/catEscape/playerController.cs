using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] private float catHp = 100;
    public float radius = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp(transform.position.x, -8, 8);
        transform.position = new Vector3(x, this.transform.position.y, this.transform.position.z);

        // keybord inPut
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("move left 2 unit");
            // x축으로 -2 이동
            this.transform.Translate(-2, 0 ,0);
        
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("move right 2 unit");
            // x축으로 2 이동
            this.transform.Translate(2, 0, 0);

        }
    }

    // event methosd
    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }

    public float GetHp()
    {
        return this.catHp;
    }

    public void SetHp(float setHp)
    {
        catHp -= setHp;
    }
}

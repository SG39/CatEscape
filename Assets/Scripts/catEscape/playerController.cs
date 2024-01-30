using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    [SerializeField] private float catHp = 100;
    [SerializeField] private Button LButton;
    [SerializeField] private Button RButton;
    public float radius = 1f;
    // Start is called before the first frame update
    void Start()
    {
        // this.LButton.onClick.AddListener(this.LButtonClick);
        // this.LButton.onClick.AddListener(this.RButtonClick);

        this.LButton.onClick.AddListener( () => { 
            Debug.Log("LB Click");
            this.transform.Translate(-2, 0, 0); }); // 람다식 사용
        this.RButton.onClick.AddListener( () => { 
            Debug.Log("RB Click");
            this.transform.Translate(2, 0, 0); });
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

    public void LButtonClick()
    {
        Debug.Log("LB");
    }

    public void RButtonClick()
    {
        Debug.Log("RB");
    }
    
}

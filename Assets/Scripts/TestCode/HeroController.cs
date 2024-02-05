using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroController : MonoBehaviour
{
    [SerializeField] private Text textHp;
    private int MaxHp
    {
        get;set;
    }
    private int hp;
    private int Hp
    {
        get
        {
            return this.hp;
        }
         set
        {
            this.hp = value;
        }
    }
    public System.Action onHit;

    private void Start() 
    {
        this.MaxHp = 10;
        this.Hp = this.MaxHp;    
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.Hp -= 1;
            if(this.Hp <= 0) this.Hp = 0;

            this.onHit();
        }
    }


}

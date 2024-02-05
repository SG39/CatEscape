using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDataManager : MonoBehaviour
{
    public int heroHp = 0;
    public int heroMaxHp = 0;

    private void Awake() 
    {
        DontDestroyOnLoad(this.gameObject);    
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

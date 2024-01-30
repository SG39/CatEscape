using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UIElements;

public class App0 : MonoBehaviour
{

    [SerializeField] private Transform b;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("b.position : {0}", b.position); // world space
        Debug.LogFormat("b.localPosition : {0}", b.localPosition); // Local space
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

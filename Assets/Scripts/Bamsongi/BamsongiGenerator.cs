using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    [SerializeField]private GameObject BamsongiPrefab;    // Start is called before the first frame update
    void Start()
    {
        // BamsongiController bamsongiController = BamsongiPrefab.GetComponent
    }

    // Update is called once per frame
    void Update()
    {
        ShootBamsongi();
    }

    private void ShootBamsongi()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 direction = ray.direction.normalized;
            Debug.Log("Input");
            GameObject go;
            go = Instantiate(BamsongiPrefab);
            
        }
    }
}

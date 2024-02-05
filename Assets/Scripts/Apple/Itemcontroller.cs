using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemcontroller : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        if(this.transform.position.y <= 0 )
        {
            Destroy(this.gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbCloudCameraController : MonoBehaviour
{
    private GameObject PlayerCat;
    // Start is called before the first frame update
    void Start()
    {
        this.PlayerCat = GameObject.Find("cat"); 
    }

    // Update is called once per frame
    void Update()
    {
        TrackingCat();
    }

    private void TrackingCat()
    {
        float catPosY = PlayerCat.transform.position.y;
        float cameraPosY = this.transform.position.y;
        float worldPosY = 1f;

        if(catPosY > worldPosY)
        {
            this.transform.position = new Vector3(0, catPosY, -10);
        }
       

    }

}

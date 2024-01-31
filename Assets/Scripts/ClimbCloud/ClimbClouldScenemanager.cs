using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClimbClouldScenemanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ResetGame();
    }

    private void ResetGame()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("LodeScene");
            SceneManager.LoadScene(0);
        }
    }

}

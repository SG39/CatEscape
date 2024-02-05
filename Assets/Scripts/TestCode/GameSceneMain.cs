using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSceneMain : MonoBehaviour
{
    [SerializeField] private Button btnLoadScene;
    [SerializeField] Text textHp;
    [SerializeField] private GameObject heroPrefab;
    // Start is called before the first frame update
    void Start()
    {
        this.btnLoadScene.onClick.AddListener(() => {
            Debug.Log("씬전환");
            SceneManager.LoadScene(1); 
        });

        CreateHero();
    }

    private void CreateHero()
    {
        GameObject HeroPre = Instantiate(heroPrefab);
        HeroController heroController = HeroPre.GetComponent<HeroController>();
        heroController.onHit = () => { 
            // this.textHp = string.Format("{0}/{1}", heroController.Hp, heroController.MaxHP); 
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

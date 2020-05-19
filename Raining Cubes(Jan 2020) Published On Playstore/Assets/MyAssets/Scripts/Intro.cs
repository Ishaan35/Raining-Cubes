using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public Player1 playerscript;
    public Player playerscript2;

    public GameObject GameoverScreen;

    public Spawner1 spawner1;

    public Text score;


    public GameObject TaptoPlayObject;
    public GameObject GameScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawner1.TaptoPlay == false)
        {
            TaptoPlayObject.SetActive(false);
            score.enabled = true;
            
            
            
        }
        if (spawner1.TaptoPlay == true)
        {
            TaptoPlayObject.SetActive(true);
            score.enabled = false;
        }

        if (playerscript.GAMEOVER1 == true)
        {
            GameoverScreen.SetActive(true);
            GameScore.SetActive(false);
        }
        if (playerscript2.GAMEOVER == true)
        {
            GameoverScreen.SetActive(true);
            GameScore.SetActive(false);
        }
        

    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    
}

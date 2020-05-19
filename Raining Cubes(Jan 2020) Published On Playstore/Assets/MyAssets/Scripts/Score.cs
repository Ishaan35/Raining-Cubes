using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    

    public float time;
    public Spawner1 spawner1;
    public Text score;
    public Text scoreEnd;

    public Text HIGHSCORE;

    public AudioSource GameAudio;
    public GameObject Camera;
    bool play = true;


    public Player playerscript;
    public Player1 playerscript2;
    // Start is called before the first frame update
    void Start()
    {
        HIGHSCORE.text = PlayerPrefs.GetFloat("Highscore", 0).ToString("0");
        GameAudio = Camera.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawner1.TaptoPlay == false && playerscript.GAMEOVER == false && playerscript2.GAMEOVER1 == false)
        {
            time += Time.deltaTime;
            score.text = time.ToString("0");
        }

        scoreEnd.text = score.text;
        if (time > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", time);
            HIGHSCORE.text = time.ToString("0");
        }

        if (spawner1.TaptoPlay == false && playerscript.GAMEOVER == false && playerscript2.GAMEOVER1 == false)
        {
            if (play)
            {
                GameAudio.Play();
                play = false;
            }
            
        }
        else
        {
            GameAudio.Stop();
        }


    }

    
}

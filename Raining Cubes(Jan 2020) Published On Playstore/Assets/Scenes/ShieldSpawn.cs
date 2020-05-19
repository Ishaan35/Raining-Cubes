using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSpawn : MonoBehaviour
{
    public float preset;
    public Player1 playerscript;
    public Player origplayer;
    public GameObject Shield;
    private GameObject player;
    public Spawner1 spawner1;

    bool start = true;
    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
         

        
    }


    // Update is called once per frame
    void Update()
    {
        Shield.SetActive(true);
        if (start == true && playerscript.GAMEOVER1 == false && spawner1.TaptoPlay == false)
        {
            
            StartCoroutine(SpawnShield());
            start = false;
        }


    }
    IEnumerator SpawnShield()
    {
        while ((playerscript.GAMEOVER1 == false ||origplayer.GAMEOVER == false)&& spawner1.TaptoPlay == false)
        {
            GameObject clone = Instantiate(Shield, new Vector3(transform.position.x + (Random.Range(-preset, preset)), transform.position.y, transform.position.z), transform.rotation);
            Destroy(clone, 25);
            yield return new WaitForSeconds(40);
        }
    }
}

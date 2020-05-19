using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject Projectile;
    public float LocationNumber;
    public int NumberOfProjectiles;

    public float preset;

    public bool Spawn = false;
    public bool TaptoPlay = true;
    public GameObject Settings;


    public int MaxProjectiles;

    private GameObject player;

    // Add that if the players velocity is 0, the projectile spawns directly on top of the player to get the player moving again... no campers allowed

    
    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (Spawn)
        {
            InvokeRepeating("NumberGenerator", 0.01f, 0.01f);
            InvokeRepeating("BlockGenerator", 0.01f, 0.01f);
            StartCoroutine(spawn());
            StartCoroutine(SpawnOnPlayer());
            Spawn = false;
        }
    }

    void NumberGenerator()
    {
        LocationNumber = Random.Range(-preset, preset);
    }
    void BlockGenerator()
    {
        NumberOfProjectiles = Random.Range(0, MaxProjectiles);
    }
    IEnumerator spawn()
    {
        while (true)
        {
            for (int i = 0; i <= NumberOfProjectiles; i++)
            {
                GameObject clone = Instantiate(Projectile, new Vector3(transform.position.x + LocationNumber, transform.position.y, transform.position.z), Quaternion.identity);
                yield return new WaitForSeconds(0.4f);
                Destroy(clone, 4);
            }
            yield return new WaitForSeconds(1);
        }


    }
    IEnumerator SpawnOnPlayer()
    {
        while (true)
        {
            GameObject clone = Instantiate(Projectile, new Vector3(player.transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
    //Contains function with bools to do certain operations in intro script and score script
    public void playGame()
    {
        Spawn = true; // Instantiating objects (in this script)
        TaptoPlay = false; // Used in intro script and score script
        Settings.SetActive(false);
       
    }


}

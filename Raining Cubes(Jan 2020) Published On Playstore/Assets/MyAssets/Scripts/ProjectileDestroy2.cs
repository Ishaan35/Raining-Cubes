using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroy2 : MonoBehaviour
{
    private SphereCollider SC;
    private MeshRenderer MR;

    public ParticleSystem Ice;
    public ParticleSystem Player;

    private GameObject player;

    public Player1 playerscript;
  

    
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        

        SC = GetComponent<SphereCollider>();
        MR = transform.GetComponentInChildren<MeshRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector3(0, -1500 * Time.deltaTime, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            
            MR.enabled = false;
            Ice.Play();
            SC.enabled = false;

        }
        if (collision.gameObject.tag == "Player")
        {

            if (playerscript.health1 < 1)
            {
                playerscript.GAMEOVER1 = true;
                MR.enabled = false;
                Ice.Play();
                SC.enabled = false;

                player.GetComponent<MeshRenderer>().enabled = false;
                player.GetComponent<SphereCollider>().enabled = false;
                Player.Play();
            }
            else if(playerscript.health1 > 0)
            {
                MR.enabled = false;
                Ice.Play();
                SC.enabled = false;
                playerscript.health1--;
            }
            
        }




    }
}

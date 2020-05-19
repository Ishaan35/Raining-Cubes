using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile3 : MonoBehaviour
{
    private BoxCollider BC;
    private MeshRenderer MR;

    public ParticleSystem Crate;
    public ParticleSystem Player;

    private GameObject player;

    public Player playerscript;






    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();


        BC = GetComponent<BoxCollider>();
        MR = transform.GetComponentInChildren<MeshRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector3(0, -1500 * Time.deltaTime, 0);

        Physics.IgnoreLayerCollision(11, 12);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            MR.enabled = false;
            Crate.Play();
            BC.enabled = false;

        }
        if (collision.gameObject.tag == "Player")
        {
            if (playerscript.health < 1)
            {
                playerscript.GAMEOVER = true;
                MR.enabled = false;
                Crate.Play();
                BC.enabled = false;
                Player.Play();
                player.GetComponent<MeshRenderer>().enabled = false;
                player.GetComponent<SphereCollider>().enabled = false;
            }
            else if (playerscript.health > 0)
            {
                Crate.Play();
                MR.enabled = false;
                BC.enabled = false;
                playerscript.health--;
            }
            



        }



    }
}

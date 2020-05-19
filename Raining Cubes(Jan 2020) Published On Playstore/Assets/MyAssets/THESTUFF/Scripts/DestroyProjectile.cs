using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    private MeshCollider SC;
    private MeshRenderer MR;

    public ParticleSystem Ice;
    public ParticleSystem Player;

    private GameObject player;

    public Player playerscript;



    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();


        SC = GetComponent<MeshCollider>();
        MR = GetComponent<MeshRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector3(0, -1500 * Time.deltaTime, 0);
    }

    IEnumerator OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            MR.enabled = false;
            Ice.Play();
            SC.enabled = false;
            yield return new WaitForSeconds(3);
            Destroy(gameObject);

        }
        if (collision.gameObject.tag == "Player")
        {
            if (playerscript.health < 1)
            {
                playerscript.GAMEOVER = true;
                MR.enabled = false;
                Ice.Play();
                SC.enabled = false;
                Player.Play();
                player.GetComponent<MeshRenderer>().enabled = false;
                player.GetComponent<SphereCollider>().enabled = false;
            }
            else if (playerscript.health > 0)
            {
                MR.enabled = false;
                SC.enabled = false;
                Ice.Play();
                playerscript.health--;
            }
            



        }




    }
}

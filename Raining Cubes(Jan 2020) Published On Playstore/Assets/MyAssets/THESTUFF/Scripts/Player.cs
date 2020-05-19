using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody RB;
    public float Movespeed;

    public bool SpawnOnPlayer = true;

    public GameObject projectile;
    public Spawner1 spawner1;

    public bool GAMEOVER = false;

    public float speed;

    public GameObject Shield;
    public int health = 0;

    public GameObject Camera;

    public GameObject ShieldImage;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (GAMEOVER == false)
        {
            Movespeed = Input.acceleration.x;
        }
        if (health < 1)
        {
            Shield.SetActive(false);
            ShieldImage.SetActive(false);
        }
        if (GAMEOVER)
        {
            Camera.GetComponent<Camerafollow>().enabled = false;
        }



    }
    private void FixedUpdate()
    {
        RB.velocity = new Vector3(-Movespeed * speed, RB.velocity.y, 0);

       
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RB.velocity = new Vector3(50, RB.velocity.y, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RB.velocity = new Vector3(-50, RB.velocity.y, 0);
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ShieldItem")
        {
            health = 1;
            Destroy(other.gameObject);
            Shield.SetActive(true);
            ShieldImage.SetActive(true);

        }
    }




}


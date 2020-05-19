using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    //2.49
    public Rigidbody RB;
    public float Movespeed;

    public GameObject Projectile;


    public bool GAMEOVER1;

    public int health1;
    public GameObject Shield;

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
        if (GAMEOVER1 == false)
        {
            Movespeed = Input.acceleration.x;
        }
        if (health1 < 1)
        {
            Shield.SetActive(false);
            ShieldImage.SetActive(false);
        }
        if (health1 > 0)
        {
            Shield.SetActive(true);
            ShieldImage.SetActive(true);
        }

        if (GAMEOVER1)
        {
            Camera.GetComponent<Camerafollow>().enabled = false;
        }

    }
    private void FixedUpdate()
    {
        
        RB.velocity = new Vector3(Movespeed * 5, RB.velocity.y, 0);

        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RB.velocity = new Vector3(5, RB.velocity.y, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RB.velocity = new Vector3(-5, RB.velocity.y, 0);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ShieldItem")
        {
            health1 = 1;
            Destroy(other.gameObject);
            Shield.SetActive(true);
            
        }
    }




}


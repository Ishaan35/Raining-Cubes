using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    public Player1 playerscript;
    public Player playerscript2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (playerscript.GAMEOVER1 == false || playerscript2.GAMEOVER == false)
        {
            offset.x = player.transform.position.x;
            offset.y = (this.transform.position.y);
            offset.z = this.transform.position.z;
            this.transform.position = offset;
        }
       



        

    }

    
}

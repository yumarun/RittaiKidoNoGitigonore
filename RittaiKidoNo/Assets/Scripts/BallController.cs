﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    GameObject shootball;
    GameObject player;
    GameObject lm2;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.y <= -20)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "MainCamera")
        {
            lm2 = GameObject.Find("lineManager2");
            lm2.GetComponent<LineController2>().shootingBall = false;

            shootball = GameObject.Find("shootBall");
            player = GameObject.Find("player");
            shootball.GetComponent<AddPowerToPlayer>().collitionBall = true;
            player.GetComponent<SpringJoint>().spring = 10;
            

            foreach (ContactPoint contact in collision.contacts)
            {
                player.GetComponent<WireController>().connectedAnchorVec = contact.point;
                Debug.Log(contact.point);
            }


           
            Destroy(gameObject);
        }
    }
}

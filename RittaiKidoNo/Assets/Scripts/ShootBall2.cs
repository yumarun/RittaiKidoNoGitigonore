using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall2 : MonoBehaviour
{

    public GameObject ballPrefab;
    public GameObject player;
    public LineController2 lc2;


    float shootSpeed = 5000.0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lc2.shootingBall = true;

            GameObject ball = Instantiate(ballPrefab) as GameObject;
            ball.transform.position = transform.position + transform.forward * 2;
            ball.GetComponent<Rigidbody>().AddForce(transform.forward * shootSpeed);
        }
    }
}

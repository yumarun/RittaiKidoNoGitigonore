using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController2 : MonoBehaviour
{
    //TODO;
    //弾が発射するときのlinerenderを追加する


    public GameObject shootBall;
    GameObject ball;
    public bool shootingBall;

    void Start()
    {
        shootingBall = false;
    }

    void Update()
    {
        if (shootingBall)
        {
            GetComponent<LineRenderer>().enabled = true;

            ball = GameObject.Find("Bulett(Clone)");
            GetComponent<LineRenderer>().SetPosition(0, shootBall.transform.position);
            GetComponent<LineRenderer>().SetPosition(1, ball.transform.position);
        }    
        else
        {
            GetComponent<LineRenderer>().enabled = false;
        }

        if (Input.GetMouseButtonDown(1))
        {
            shootingBall = false;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform Player;
    public float MinX, MaxX;

    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        FollowingPlayer();
    }
    void FollowingPlayer()
    {
        if(Player!=null)
        {
            Vector3 temp = transform.position;
            temp.x= Player.position.x;

            if(temp.x< MinX) temp.x = MinX;
            if(temp.x>MaxX) temp.x=MaxX;

            transform.position= temp;
        }
    }
}

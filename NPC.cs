using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //NPC Health 
    public int health = 5;

    //NPC level
    public int level = 1;

    //NPC Speed 
    public float speed = 1.2f;

    

    void Start()
    {//NPC health update
        health += level;
        print("hearts:"+ health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y += speed * Time.deltaTime;
        transform.position=newPosition;

    }
}

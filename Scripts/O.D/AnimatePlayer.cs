using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]

public class AnimatePlayer : MonoBehaviour
{
    public static AnimatePlayer instance;
    
    Rigidbody rb;
    public float speed = 5;
    Vector3 stepPosition;
    GameObject player;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0, -500.0F, 0);
        player = GameObject.FindGameObjectWithTag("Player");
        print(Screen.currentResolution);

    }
    
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, speed);
        
    }

    public void PlayerPosUp()
    {
        Vector3 playerpos = transform.localPosition;
        playerpos.y += .5f;
        transform.localPosition = playerpos;
    }
    
    public void PlayerPosDown(float amount)
    {
        Vector3 playerpos = transform.localPosition;
        playerpos.y -= amount;
        transform.localPosition = playerpos;

    }
    
}

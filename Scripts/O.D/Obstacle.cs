using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public static Obstacle instance;
    private GameObject leftParent;
    private GameObject rightParent;

    private void Awake()
    {
        instance = this;
        leftParent = GameObject.FindGameObjectWithTag("LeftParent");
        rightParent = GameObject.FindGameObjectWithTag("RightParent");
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DeadPoint")
        {
            Dead();
        }
    }

    public void Dead()
    {
        for (int i = 0; i <= HeelController.heel; i++)
        {
            leftParent.transform.GetChild(i).gameObject.SetActive(false);
            rightParent.transform.GetChild(i).gameObject.SetActive(false);
        }
        AnimatePlayer.instance.speed = 0;
        PlayerController.instance._animator.SetBool("Walk", false);
        PlayerController.instance._animator.SetBool("Death", true);
    }

    
}

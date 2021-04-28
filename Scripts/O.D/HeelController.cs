using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeelController : MonoBehaviour
{
    public static HeelController instance;
    public GameObject leftParent, rightParent;
    private Vector3 obstaclePos;
    
    public GameObject[] heels;
    public static int heel = 1;
    
    
    
    void Awake()
    {
        instance = this;
        leftParent = GameObject.FindGameObjectWithTag("LeftParent");
        rightParent = GameObject.FindGameObjectWithTag("RightParent");
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 triggerPos = new Vector3(other.gameObject.transform.position.x,other.gameObject.transform.position.y,other.gameObject.transform.position.z-1);
        obstaclePos = triggerPos;
        if (other.gameObject.tag == "Heel")
        {
            other.GetComponent<BoxCollider>().enabled = false;
            leftParent.transform.GetChild(heel).gameObject.SetActive(true);
            rightParent.transform.GetChild(heel).gameObject.SetActive(true);
            Destroy(other.gameObject);
            AnimatePlayer.instance.PlayerPosUp();
            heel++;
            print(heel + "'a çıktı");
        }
        
        if (other.gameObject.tag == "Obstacle")
        {
           
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

            DropHeels(heel-1, 0);
        }
        
        if (other.gameObject.tag == "Obstacle2")
        {
            if (heel >= 2)
            {
                other.gameObject.GetComponent<BoxCollider>().enabled = false;

                DropHeels(heel-2, 1);
            }
            else
            {
                Obstacle.instance.Dead();
            }
            
        }
        
        if (other.gameObject.tag == "Obstacle3")
        {
            if (heel >= 3)
            {
                other.gameObject.GetComponent<BoxCollider>().enabled = false;

                DropHeels(heel-3, 2);
            }
            else
            {
                Obstacle.instance.Dead();
            }
           
            
        }
        
        if (other.gameObject.tag == "Obstacle4")
        {
            if (heel >= 4)
            {
                other.gameObject.GetComponent<BoxCollider>().enabled = false;

                DropHeels(heel-4, 3);
            }
            else
            {
                Obstacle.instance.Dead();
            }
            
        }
        if (other.gameObject.tag == "Obstacle5")
        {
            if (heel >= 5)
            {
                other.gameObject.GetComponent<BoxCollider>().enabled = false;

                DropHeels(heel-5, 4);
            }
            else
            {
                Obstacle.instance.Dead();
            }
            
        }
        if (other.gameObject.tag == "Obstacle6")
        {
            if (heel >= 6)
            {
                other.gameObject.GetComponent<BoxCollider>().enabled = false;

                DropHeels(heel-6, 5);
            }
            else
            {
                Obstacle.instance.Dead();
            }
            
        }

        if (other.gameObject.tag == "ObstacleExit")
        {
            AnimatePlayer.instance.PlayerPosDown(.5f);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        if (other.gameObject.tag == "ObstacleExit2")
        {
            AnimatePlayer.instance.PlayerPosDown(1);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        if (other.gameObject.tag == "ObstacleExit3")
        {
            AnimatePlayer.instance.PlayerPosDown(1.5f);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        if (other.gameObject.tag == "ObstacleExit4")
        {
            AnimatePlayer.instance.PlayerPosDown(2f);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        if (other.gameObject.tag == "ObstacleExit5")
        {
            AnimatePlayer.instance.PlayerPosDown(2.5f);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        if (other.gameObject.tag == "ObstacleExit6")
        {
            AnimatePlayer.instance.PlayerPosDown(3f);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    } 
    
    void DropHeels(int amount, int id)
    {
        Vector3 instantiatePos = new Vector3(leftParent.transform.position.x, 0.768f, obstaclePos.z);
        Instantiate(heels[id], instantiatePos, Quaternion.identity);
        for (int i = amount; i <= heel; i++)
        {
            leftParent.transform.GetChild(i).gameObject.SetActive(false);
            rightParent.transform.GetChild(i).gameObject.SetActive(false);
        }
        heel -= id+1;
        print(heel + "'a indi");
    }
}

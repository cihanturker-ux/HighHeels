using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeelController : MonoBehaviour
{
    private GameObject leftParent, rightParent;
    public static int heel = 1;
    void Awake()
    {
        leftParent = GameObject.FindGameObjectWithTag("LeftParent");
        rightParent = GameObject.FindGameObjectWithTag("RightParent");
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heel")
        {
            leftParent.transform.GetChild(heel).gameObject.SetActive(true);
            rightParent.transform.GetChild(heel).gameObject.SetActive(true);
            Destroy(other.gameObject);
            AnimatePlayer.instance.PlayerPosUp();


            heel++;
        }
    } 
}

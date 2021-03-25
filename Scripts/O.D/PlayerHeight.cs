using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeight : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heel")
        {
            other.GetComponent<BoxCollider>().enabled = false;
            HeelController.instance.leftParent.transform.GetChild(HeelController.heel).gameObject.SetActive(true);
            HeelController.instance.rightParent.transform.GetChild(HeelController.heel).gameObject.SetActive(true);
            Destroy(other.gameObject);
            AnimatePlayer.instance.PlayerPosUp();
            HeelController.heel++;
            print(HeelController.heel + "'a çıktı");
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
}

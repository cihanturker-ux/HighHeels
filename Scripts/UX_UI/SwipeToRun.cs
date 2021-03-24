using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeToRun : MonoBehaviour
{
    [SerializeField] private GameObject swipeToRun;
    void Update()
    {
        var fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
            }
        }
        if (fingerCount > 0)
        {
            fingerCount = 1;
            swipeToRun.SetActive(false);
            print("Game Has Started");
            //Oyunu Başlatacak kod buraya yazılacak
        }
    }
}

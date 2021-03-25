using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float followHeight = 4f;
    public float followDistance = 6f;
    public float followHeightSpeed = 0.9f;

    private Transform Player;

    private float targetHeight;
    private float currentHeight;
    private float currentRotation;
    
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        targetHeight = Player.position.y + followHeight;
        currentRotation = transform.eulerAngles.y;
        currentHeight = Mathf.Lerp(transform.position.y, targetHeight, followHeightSpeed * Time.deltaTime);
        Quaternion euler = Quaternion.Euler(0f, currentRotation, 0f);
        Vector3 targetPosition = Player.position - (euler * Vector3.forward) * followDistance;
        targetPosition.y = currentHeight;
        transform.position = targetPosition;
    }
}

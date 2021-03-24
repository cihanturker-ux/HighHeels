using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform parent;
    public Rigidbody rb;
    public List<GameObject> childs = new List<GameObject>();


    public Joystick joystick;

    private Vector3 movement;
    private int speed = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
         
    } 
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Heel")){
            parent.transform.position += new Vector3(0,0.2f,0);
            col.transform.SetParent(transform); // foot collider is required
            childs.Add(col.gameObject);
            col.transform.localPosition = new Vector3(0,col.transform.localPosition.y,0); // setting positions
            

        }
        if(col.gameObject.CompareTag("Obstacle")){
       
            float boxCountSize = col.transform.localScale.y/0.2f; // obstacle height
            
            
            
             if (boxCountSize<=childs.Count)
                {
                    for (int i = childs.Count-1; i>=boxCountSize ; i--)
            {
                 
                    childs[i].transform.SetParent(null);
                    childs[i].GetComponent<BoxCollider>().enabled=false;
                
                    childs.Remove(childs[i].gameObject);
                    
               
            }
            /*for (int i = childs.Count-1; i>=0 ; i--)
            {
                childs[i].transform.localPosition += new Vector3(0,0.2f,0);
            }
            */

                }
            else
            {
                //death then .....
            }
            
        }
    }

    
 void Update() {
    movement = new Vector3(joystick.Horizontal * 1f, rb.velocity.y , joystick.Vertical * 1f);
    movement = movement.normalized * speed * Time.deltaTime;
    rb.MovePosition (rb.position + movement);    
}
     void FixedUpdate()
    {
     rb.velocity = new Vector3 (0,0,3f); 
     
    }
}
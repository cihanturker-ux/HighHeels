using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform parent;
    public Rigidbody rb;
    public List<GameObject> childs = new List<GameObject>();
    public int heelNumber=1;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 

    } 
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Heel") && heelNumber==1){
            parent.transform.position += new Vector3(0,0.2f,0); // topuk boyuna göre ayarlanacak
            heelNumber=2;
        }
        if(col.gameObject.CompareTag("Obstacle")){
       
        }
    }
 void Update() {
   
}
    void FixedUpdate()
    {
      
    }
}

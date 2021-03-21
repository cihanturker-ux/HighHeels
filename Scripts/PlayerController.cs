using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform parent;
    public Rigidbody rb;
    public List<GameObject> childs = new List<GameObject>();
    public int heelNumber=1;

    protected Joystick joystick;
    protected JoyButton joyButton;

    private Vector3 movement;
    private int speed = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        joystick=FindObjectOfType<Joystick>();
        joyButton=FindObjectOfType<JoyButton>();


    } 
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Heel") && heelNumber==1){
            parent.transform.position += new Vector3(col.gameObject.transform.position.x,0.2f,col.gameObject.transform.position.z); // topuk boyuna göre ayarlanacak
            heelNumber=2;
        }
        if(col.gameObject.CompareTag("Obstacle")){
       
        }
    }
 void Update() {
    movement = new Vector3(joystick.Horizontal * 1f, rb.velocity.y , joystick.Vertical * 1f);
    movement = movement.normalized * speed * Time.deltaTime;
    rb.MovePosition (rb.position + movement);
}
     void FixedUpdate()
    {
     rb.velocity= new Vector3(0,0,2f); 
     
    }
}

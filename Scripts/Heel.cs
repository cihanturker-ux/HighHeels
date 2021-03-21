using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heel : MonoBehaviour
{  
        public Transform parent;
        public Rigidbody rb;
        private Joint theJoint;
        public GameObject personPlayer;
        private PlayerController playerControllerScript;
     void Start() {
        theJoint = GetComponent<FixedJoint>();
        playerControllerScript = personPlayer.GetComponent<PlayerController>();

    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Obstacle")){
            playerControllerScript.childs.Remove(gameObject);
            theJoint.connectedBody = null;
            rb.useGravity=true;
            
        }
        if (other.gameObject.CompareTag("Player")){
            theJoint.connectedBody = rb;
            playerControllerScript.childs.Add(gameObject);

        }
        if (other.gameObject.CompareTag("Heel")){
            rb.useGravity=false;
            parent.transform.position += new Vector3(0,0.2f,0);
            theJoint.connectedBody =rb;
            playerControllerScript.childs.Add(gameObject);        
        }


    }
}

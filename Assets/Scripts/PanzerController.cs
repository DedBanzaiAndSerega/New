using UnityEngine;
using System.Collections;

public class PanzerController : MonoBehaviour {
    public float maxSpeed = 10f;
    public float rotSpeed = 100f;
    
    // Use this for initialization
    
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        
        
        float moveH = Input.GetAxis("Horizontal");
        
        float moveV = Input.GetAxis("Vertical");

        
       
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveH * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = -new Vector2(GetComponent<Rigidbody2D>().velocity.x, moveV * maxSpeed);
        
        //Vector3 velocity = new Vector3(0, moveV * maxSpeed, 0);
        //Vector3 pos = transform.position;
        //pos += velocity;
      //  transform.position = pos;
        

    }
   
}

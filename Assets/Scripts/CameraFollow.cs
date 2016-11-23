using UnityEngine;
using System.Collections;
public class CameraFollow : MonoBehaviour {
    public Transform myTarget;
    public float speed = 3.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //comment
        //comment

        Vector3 temp = new Vector3(myTarget.position.x, myTarget.position.y, transform.position.z);
        //ransform.position = new Vector3(myTarget.position.x, myTarget.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, temp, Time.deltaTime *speed);
           
        
	}
}

using UnityEngine;
using System.Collections;
public class CameraFollow : MonoBehaviour {
    public Transform myTarget;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	

        transform.position = new Vector3(myTarget.position.x, myTarget.position.y, transform.position.z);
           
        
	}
}

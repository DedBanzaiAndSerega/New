using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float maxSpeed = 10f;
    public float rotSpeed = 350f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        // rotate
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= moveH * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;
        // move
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, moveV * maxSpeed * Time.deltaTime, 0);
        pos += rot * velocity;
        transform.position = pos;

    }
}

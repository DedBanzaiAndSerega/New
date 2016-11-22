using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {
    public float maxSpeed = 5f;
    public Object expl;
    public float dmg { get; set; }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;
        var velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);
        pos += transform.rotation * velocity;
        transform.position = pos;
	}
}

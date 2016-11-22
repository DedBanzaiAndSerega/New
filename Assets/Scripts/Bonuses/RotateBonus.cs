using UnityEngine;
using System.Collections;

public class RotateBonus : BaseBonus {

    public override void GetBonus(GameObject panzer)
    {
        panzer.GetComponent<PlayerController>().rotSpeed += 200f;
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

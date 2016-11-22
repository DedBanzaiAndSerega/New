using UnityEngine;
using System.Collections;

public class MoveBonus : BaseBonus {

    // Use this for initialization
    public override void GetBonus(GameObject panzer)
    {
        panzer.GetComponent<PlayerController>().maxSpeed += 5f;
    }
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   
}

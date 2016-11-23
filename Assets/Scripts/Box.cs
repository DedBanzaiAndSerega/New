using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {
    public GameObject Explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D item)
    {
        //comment
        //comment EldarBranch
        //comment Eldar commit

        GameObject temp = item.gameObject;
        if (temp.tag == "Weapon")
        {
            Vector3 offset = temp.gameObject.transform.position + new Vector3(0, 0, 1.0f);
            Instantiate(Explosion, offset, temp.gameObject.transform.rotation);
            Destroy(temp);
        }
       
       // Debug.Log("Trigger!");
    }
}

using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public GameObject bullet;
    public float fireDelay = 0.25f;
    float coolDawnTimer = 0;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        coolDawnTimer -= Time.deltaTime;
        if (Input.GetButton("Fire1") && coolDawnTimer <= 0)
        { 
            
            //Debug.Log("pew!");
            coolDawnTimer = fireDelay;
            Vector3 offset = transform.rotation * new Vector3(0, 0.8f, 0);
           // bullet.GetComponent<MoveForward>().dmg = GetComponent<MyPanzer>().CurrentDamage;
            GameObject BulletInstance = (GameObject)Instantiate(bullet, transform.position + offset, transform.rotation);
            BulletInstance.GetComponent<MoveForward>().dmg = GetComponentInParent<BasePanzer>().CurrentDamage;
            BulletInstance.layer = gameObject.layer;
        
            
        }
	}
}

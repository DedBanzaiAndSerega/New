using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {
   
    
    public GameObject    bullet;
    public float fireDelay = 0.25f;
    float coolDawnTimer = 0;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        coolDawnTimer -= Time.deltaTime;
        if (coolDawnTimer <= 0)
        {
           // Debug.Log("pew!");
            coolDawnTimer = fireDelay +Random.Range(0.25f, 0.99f);
            Vector3 offset = transform.rotation * new Vector3(0, 0.8f, 0);
            //bullet.GetComponent<MoveForward>().dmg = GetComponent<EnemyPanzer>().CurrentDamage;
            GameObject BulletInstance = (GameObject)Instantiate(bullet, transform.position + offset, transform.rotation);
            BulletInstance.GetComponent<MoveForward>().dmg = GetComponent<BasePanzer>().CurrentDamage;
            BulletInstance.layer = gameObject.layer;

        }
    }
}

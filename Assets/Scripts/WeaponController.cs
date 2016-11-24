using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

    public float rotSpeed;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	/// <summary>
    /// 
    /// </summary>
    void Update () {

        Vector3 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        dir.Normalize();
        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);

    }


        //Vector3 dir = Input.mousePosition - transform.position;
        //dir.Normalize();
        //float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        //Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
    }


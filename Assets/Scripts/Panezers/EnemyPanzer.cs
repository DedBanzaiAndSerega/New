using UnityEngine;
using System.Collections;

public class EnemyPanzer : BasePanzer {
    public GameObject expl;
	// Use this for initialization
	public EnemyPanzer() : base (2,5,5)
    {

    }
    private void Awake()
    {
        SetBaseHP(2);

    }
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            KillSelf();
        }
    }
    void OnTriggerEnter2D(Collider2D item)
    {
        GameObject temp = item.gameObject;
        if (temp.tag == "Weapon")
        {

            ChangeHP(temp.GetComponent<MoveForward>().dmg);
            Instantiate(temp.GetComponent<MoveForward>().expl, temp.transform.position, temp.transform.rotation);
            Destroy(temp);
        }
        if (temp.tag == "bonus")
        {

        }
      //  Debug.Log("Trigger!");
    }
    void KillSelf()
    {
        Destroy(gameObject);
        Instantiate(expl, transform.position, transform.rotation);
    }

}

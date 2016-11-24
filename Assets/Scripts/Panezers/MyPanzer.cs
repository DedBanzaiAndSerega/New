using UnityEngine;
using System.Collections;

public class MyPanzer : BasePanzer 
{
    public GameObject expl;
   public MyPanzer() : base (1,5,5)
    {

    }
    private void Awake()
    {
        SetBaseHP(500);

    }
    void Update()
    {
        if(CurrentHealth <= 0)
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
            temp.GetComponent<BaseBonus>().GetBonus(gameObject);
            Destroy(temp);
        }
      //  Debug.Log("Trigger!");
    }
    void KillSelf()
    {
        Destroy(gameObject);
        Instantiate(expl, transform.position , transform.rotation);
    }
}

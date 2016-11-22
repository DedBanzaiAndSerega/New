using UnityEngine;
using System.Collections;

public class BasePanzer : MonoBehaviour {


	public BasePanzer(float damage, float attackSpeed, float attackRadius)
    {
        CurrentDamage = baseDamage = damage;
        CurrentAttackSpeed = baseAttackSpeed = attackSpeed;
        CurrentAttackRadius = baseAttackRadius = attackRadius;
    }
   


    protected GameController gameControl;

    protected float baseHealth;
    protected float baseDamage;
    protected float baseAttackSpeed;
    protected float baseAttackRadius;

    public float CurrentHealth { get; set; }
    public float CurrentDamage { get; set; }
    public float CurrentAttackSpeed { get; set; }
    public float CurrentAttackRadius { get; set; }
    public virtual void ChangeHP(float damage)
    {
        CurrentHealth -= damage;
    }
    public void SetBaseHP(float hp)
    {
        CurrentHealth = baseHealth = hp;
    }
    public void ChangeAttackRadius(float newAttackRadius)
    {
        CurrentAttackRadius = baseAttackRadius = newAttackRadius;
    }
    public void ChangeAttackSpeed(float newAttackSpeed)
    {
        CurrentAttackSpeed = baseAttackSpeed = newAttackSpeed;
    }
    public void ChangeDamage(float newDamage)
    {
        CurrentDamage = baseDamage = newDamage;
    }

    public void ModifyDamage(float modDamage)
    {
        CurrentDamage += CurrentDamage * modDamage;
    }
    public void ModifyAttackSpeed(float modSpeed)
    {
        CurrentAttackSpeed += CurrentAttackSpeed * modSpeed;
    }
    public void ModifyAttackRadius(float modRadius)
    {
        CurrentAttackRadius += CurrentAttackRadius * modRadius;
    }
    public void SetBaseHeath()
    {
        CurrentHealth = baseHealth;
    }
    public void SetBaseDamage()
    {
        CurrentDamage = baseDamage;
    }
    public void SetBaseAttackSpeed()
    {
        CurrentAttackSpeed = baseAttackSpeed;
    }
    public void SetBaseAttackRadius()
    {
        CurrentAttackRadius = baseAttackRadius;
    }

}

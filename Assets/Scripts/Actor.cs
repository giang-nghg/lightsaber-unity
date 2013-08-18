using UnityEngine;
using System.Collections;

public class Actor : MonoBehaviour {
	
	public float maxHP = 1;
	protected float HP;	
	
	// Use this for initialization
	virtual protected void Start () {
	
		HP = maxHP;
	}
	
	// Update is called once per frame
	virtual protected void Update () {
	
		if (HP <= 0)
		{
			Destroy();
		}
	}
	
	virtual protected void OnCollisionEnter(Collision collision)
	{
		Bullet bullet;
		if (bullet = collision.gameObject.GetComponent<Bullet>())
		{
			OnDamage(bullet.damage);
		}
	}
	
	virtual protected void OnDamage(float amount)
	{
		HP -= amount;
	}
	
	virtual protected void Destroy()
	{
		Destroy(gameObject);
	}
	
	public float GetHP()
	{
		return HP;
	}
}

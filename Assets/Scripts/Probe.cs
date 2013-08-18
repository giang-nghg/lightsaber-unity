using UnityEngine;
using System.Collections;

public class Probe : Enemy {
	
	public float shotInterval = 3;
	float timeSinceLastShot = 0;
	
	public ParticleSystem explosion;
	
	// Use this for initialization
	override protected void Start () {
	
		base.Start();
	}
	
	// Update is called once per frame
	override protected void Update () {
		
		base.Update();
		
		timeSinceLastShot += Time.deltaTime;
		if (timeSinceLastShot >= shotInterval)
		{
			BroadcastMessage("Fire");
			
			timeSinceLastShot = 0;
		}
	}
	
	override protected void Destroy()
	{
		Instantiate(explosion, transform.position, transform.rotation);
		
		base.Destroy();
	}
}

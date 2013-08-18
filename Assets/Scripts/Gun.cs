using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	
	public Bullet bullet;
	public float power = 10;
	
	public float numberOfBullets = 4;
	public float bulletDeviation = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Fire()
	{
		audio.Play();
		
		for (int i = 1; i <= numberOfBullets/2; ++i)
		{
			GameObject b = (GameObject)Instantiate(bullet.gameObject, transform.position, transform.rotation);
			b.transform.RotateAround(Vector3.forward, -i * bulletDeviation);
			b.rigidbody.AddForce(b.transform.forward * power, ForceMode.Impulse);
			
			b = (GameObject)Instantiate(bullet.gameObject, transform.position, transform.rotation);
			b.transform.RotateAround(Vector3.forward, i * bulletDeviation);
			b.rigidbody.AddForce(b.transform.forward * power, ForceMode.Impulse);
		}		
	}
}

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public float damage = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision)
	{
		audio.Play();
		
		if (collision.gameObject.layer == LayerMask.NameToLayer("Blade"))
		{
			gameObject.layer = LayerMask.NameToLayer("Reflected");
		}		
		
		if (collision.gameObject.GetComponent<Actor>() != null ||
			collision.gameObject.layer == LayerMask.NameToLayer("Boundary"))
		{
			Destroy(gameObject);
		}
	}
}

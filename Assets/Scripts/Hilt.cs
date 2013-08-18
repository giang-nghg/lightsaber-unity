using UnityEngine;
using System.Collections;

public class Hilt : Player {
	
	public AudioClip igniteSFX;	
			
	// Use this for initialization
	override protected void Start () {
	
		audio.PlayOneShot(igniteSFX);
		
		base.Start();		
	}
	
	// Update is called once per frame
	override protected void Update () {
		
		base.Update();			
	}
	
	override protected void Destroy()
	{
		Destroy(GetComponent<FixedJoint>().connectedBody.gameObject);
		
		base.Destroy();
	}
}

using UnityEngine;
using System.Collections;

public class Enemy : Actor {
	
	public int pointWorth = 1;

	// Use this for initialization
	override protected void Start () {
	
		base.Start();
	}
	
	// Update is called once per frame
	override protected void Update () {
	
		base.Update();
	}
	
	override protected void Destroy()
	{
		GameObject player;
		if (player = GameObject.FindGameObjectWithTag("Player"))
		{
			player.SendMessage("Score", pointWorth);
		}
		
		base.Destroy();
	}
}

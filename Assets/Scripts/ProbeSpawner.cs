using UnityEngine;
using System.Collections;

public class ProbeSpawner : MonoBehaviour {
	
	public Probe probe;
	public int numberOfProbes;

	public float spawnInterval = 3;
	float timeSinceLastSpawn = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		timeSinceLastSpawn += Time.deltaTime;
		if (timeSinceLastSpawn >= spawnInterval &&
			GameObject.FindGameObjectsWithTag("Probe").Length < numberOfProbes)
		{
			GameObject p = (GameObject)Instantiate(probe.gameObject, transform.position, transform.rotation);
			
			GameObject player;
			if (player = GameObject.FindGameObjectWithTag("Player"))
			{
				p.SendMessage("SetTarget", player.transform);
			}
			
			timeSinceLastSpawn = 0;
		}
	}
}

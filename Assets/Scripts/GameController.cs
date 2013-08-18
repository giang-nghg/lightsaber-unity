using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	bool bPaused = false;

	// Use this for initialization
	void Start () {
	
		Unpause();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Pause()
	{
		Time.timeScale = 0;
		bPaused = true;
	}
	
	public void Unpause()
	{
		Time.timeScale = 1;
		bPaused = false;
	}
	
	public bool IsPaused()
	{
		return bPaused;
	}
}

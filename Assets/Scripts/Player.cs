using UnityEngine;
using System.Collections;

public class Player : Actor {
	
	public int victoryScore = 10;
	protected int score = 0;
	
	bool bVictory = false;	
	
	public AudioClip gruntSFX;
	
	public AudioSource dangerSFX;	
	GameObject dangerSFXObj = null;		
	
	// Use this for initialization
	override protected void Start () {
	
		base.Start();
	}
	
	// Update is called once per frame
	override protected void Update () {
	
		base.Update();		
		
		if (HP / maxHP < 0.25)
		{
			if (dangerSFXObj == null)
			{
				dangerSFXObj = (GameObject)Instantiate(dangerSFX.gameObject);
				dangerSFXObj.transform.parent = transform;
			}
		}
		
		if (score >= victoryScore)
		{
			Victory();
		}
	}
	
	virtual protected void Victory()
	{
		bVictory = true;		
		
		MusicPlayer musicPlayer = GameObject.FindGameObjectWithTag("MainCamera").GetComponentInChildren<MusicPlayer>();
		musicPlayer.audio.clip = musicPlayer.victorySFX;
		musicPlayer.audio.Play();
		
		GameObject.Find("Game Controller").GetComponent<GameController>().Pause();
	}
	
	override protected void Destroy()
	{
		MusicPlayer musicPlayer = GameObject.FindGameObjectWithTag("MainCamera").GetComponentInChildren<MusicPlayer>();
		musicPlayer.audio.clip = musicPlayer.capturedSFX;
		musicPlayer.audio.Play();
		
		GameObject.Find("Game Controller").GetComponent<GameController>().Pause();
		
		base.Destroy();
	}
	
	public void Score(int point)
	{
		score += point;		
	}
	
	public int GetScore()
	{
		return score;
	}
	
	public bool IsVictory()
	{
		return bVictory;
	}
	
	override protected void OnDamage(float amount)
	{
		audio.PlayOneShot(gruntSFX);
		
		base.OnDamage(amount);
	}
}

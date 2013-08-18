using UnityEngine;
using System.Collections;

public class HUD : BaseGUI {
	
	public Player player;
	float HP = 0;
	int score = 0;
	
	bool bDead = false;
	
	public Material gameoverBG;
		
	// Use this for initialization
	override protected void Start () {	
		
		base.Start();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (player != null)
		{
			HP = player.GetHP();
			score = player.GetScore();
		}
		else
		{
			bDead = true;
			
			GetComponent<Skybox>().material = gameoverBG;
		}
	}
	
	void OnGUI()
	{
		GUILayout.BeginHorizontal(GUILayout.Width(Screen.width));	
		
		GUILayout.Label("Hit points: "+HP);
		GUILayout.Label("Score: "+score);
		
		GUILayout.FlexibleSpace();
		
		if (!gameController.IsPaused())
		{
			if (GUILayout.Button("Menu"))
			{
				gameController.Pause();
			}
		}
		else
		{
			GUILayout.BeginVertical();
			
			if (player.IsVictory())
			{
				if (GUILayout.Button("Next Level"))
				{
				}
			}
			
			if (GUILayout.Button("Restart"))
			{
				Application.LoadLevel(Application.loadedLevelName);
			}
			
			if (GUILayout.Button("Quit to Main Menu"))
			{
				Application.LoadLevel("Main Menu");
			}
			
			if (!bDead && !player.IsVictory())
			{
				if (GUILayout.Button("Resume"))
				{
					gameController.Unpause();
				}
			}
			
			GUILayout.EndVertical();
		}
		
		GUILayout.EndHorizontal();
	}	
}

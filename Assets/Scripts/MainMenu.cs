using UnityEngine;
using System.Collections;

public class MainMenu : BaseGUI {

	// Use this for initialization
	override protected void Start () {
	
		base.Start();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		GUILayout.BeginHorizontal(GUILayout.Width(Screen.width));
		
		//GUILayout.Label("Music from KOTOR. I only use it here in the demo version.");
		
		GUILayout.FlexibleSpace();
		GUILayout.BeginVertical(GUILayout.Height(Screen.height));
		GUILayout.FlexibleSpace();
		
		if (GUILayout.Button("Play"))
		{
			Application.LoadLevel("Level 1");
		}
		
		if (GUILayout.Button("Quit"))
		{
			Application.Quit();
		}
		
		GUILayout.FlexibleSpace();
		GUILayout.EndVertical();
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
	}
}

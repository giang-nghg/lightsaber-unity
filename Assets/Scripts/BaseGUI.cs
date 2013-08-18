using UnityEngine;
using System.Collections;

public class BaseGUI : MonoBehaviour {
	
	protected GameController gameController;
	
	// Use this for initialization
	virtual protected void Start () {
	
		gameController = GameObject.Find("Game Controller").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

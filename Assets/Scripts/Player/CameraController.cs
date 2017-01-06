using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	public Controller player;

	private Vector3 offset = new Vector3 (-5, 10, -5);

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Camera.main.transform.position = offset + player.transform.position;
		
	}
}

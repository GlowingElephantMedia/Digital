using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
	public GameObject goTerrain;

	Vector3 TargetPos ()
	{
		Vector3 tPos = Vector3.zero;
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (goTerrain.GetComponent<Collider> ().Raycast (ray, out hit, Mathf.Infinity)) {
			tPos = hit.point;
		}
		return tPos;
	}

	NavMeshAgent agent;

	void Update ()
	{
		if (agent == null) {
			agent = GetComponent<NavMeshAgent> ();
		}

		if (Input.GetMouseButton (0)) {
			Move (TargetPos ());
		}
	}

	void Move (Vector3 target)
	{
		agent.SetDestination (target);
	}
}

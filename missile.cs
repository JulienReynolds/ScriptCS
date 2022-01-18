using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour {

	public float speed;
	public float turn;
	void Update () {
		GameObject[] targets = GameObject.FindGameObjectsWithTag("Ennemi");
		GameObject closest = targets[0];
		float closestDist = Mathf.Infinity;

		foreach (GameObject Target in targets){
			float dist = (transform.position - Target.transform.position).sqrMagnitude;

			if (dist < closestDist){
				closestDist = dist;
				closest = Target;
			}
		}
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (closest.transform.position - transform.position), turn * Time.deltaTime);
		transform.position += transform.forward * speed * Time.deltaTime;
	}
}

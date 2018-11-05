using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Members
	public float health = 1.0f;
	
	private GameObject triggerEnemy;
	
	// Update is called once per frame
	void Update () {
		
		if(health <=0)
		{
			Die();
		}
	}
	void Die()
	{
		Destroy(this.gameObject);
	}
}

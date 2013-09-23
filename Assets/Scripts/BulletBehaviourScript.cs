using UnityEngine;
using System.Collections;

public class BulletBehaviourScript : MonoBehaviour {
	public float Timer;
	
	// Use this for initialization
	void Start () {
		Timer = 3;
	}
	
	// Update is called once per frame
	void Update () {
		Timer -= 1 * Time.deltaTime;
		transform.Translate(0, 0, 1);
		if(Timer<= 0)
		{
			Destroy(gameObject);
		}
	}
	/*void OnTriggerEnter(Collider col)
	{	
		// destroy the enemy
		if(col.name == "Astriod" || col.name == "Astriod(Clone)")
		{
			Destroy(col.collider.gameObject);
			Destroy(gameObject);
			
		}
	}*/
	void OnCollisionEnter(Collision col)
	{
		if(collider.name == "Astriod" || collider.name == "Astriod(Clone)")
		{
			Destroy(collider.gameObject);
			Destroy(gameObject);
			
		}
		
	}
}

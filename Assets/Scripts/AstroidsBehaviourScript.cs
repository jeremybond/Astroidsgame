using UnityEngine;
using System.Collections;

public class AstroidsBehaviourScript : MonoBehaviour {
	private int randomNumb;
	private bool number1 = false;
	private bool number2 = false;
	private bool number3 = false;
	private bool number4 = false;
	
	void Start () {
		randomNumb = Random.Range(0, 4);
		
	}
	// Update is called once per frame
	void FixedUpdate () {
		if(randomNumb == 0)
		{
			transform.Translate(0.2f, 0, 0);
			if(transform.position.x > 35)
			{
				Destroy(gameObject);
			}
		}
		if(randomNumb == 1)
		{
			transform.Translate(-0.2f, 0, 0);
			if(transform.position.x < -35)
			{
				Destroy(gameObject);
			}
		}
		if(randomNumb == 2)
		{
			transform.Translate(0, 0, 0.2f);
			if(transform.position.z > 35)
			{
				Destroy(gameObject);
			}
		}
		if(randomNumb == 3)
		{
			transform.Translate(0, 0, -0.2f);
			if(transform.position.z < -35)
			{
				Destroy(gameObject);
			}
		}
			
	}
	void OnCollisionEnter(Collision col)
	{
		if(collider.name == "Bullet" || collider.name == "Bullet(Clone)")
		{
			Destroy(collider.gameObject);
			Destroy(gameObject);
			
		}
		
	}
}

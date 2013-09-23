using UnityEngine;
using System.Collections;

public class PlayerBehaviourScript : MonoBehaviour {
	
	public float speed;
	public float rotationSpeed;
	public float shootTime;
	public GameObject bullet;
	public GameObject astroid;
	public float spawn;
	private int randomNumb1;
	private int randomNumb2;
	void Start(){
		shootTime = 0;
		spawn = 1;
		
	}
	
	void FixedUpdate () {
		//////////////////Spawn//////////////
		spawn = spawn - Time.deltaTime;
		if(spawn <= 0)
		{
			randomNumb1 = Random.Range(0, 4);
			randomNumb2 = Random.Range(0, 100);
			GameObject newAstroid = Instantiate(astroid, transform.position, Quaternion.identity) as GameObject;
			if(randomNumb1 == 0)
			{
				newAstroid.transform.Translate(-25, 0.5f, (randomNumb2-50) * 0.15f);
			}
			if(randomNumb1 == 1)
			{
				newAstroid.transform.Translate(25, 0.5f, (randomNumb2-50) * 0.15f);
			}
			if(randomNumb1 == 2)
			{
				newAstroid.transform.Translate((randomNumb2-50) * 0.2f, 0.5f, -20);
			}
			if(randomNumb1 == 3)
			{
				newAstroid.transform.Translate((randomNumb2-50) * 0.2f, 0.5f, 20);
			}
			newAstroid.transform.Translate(20, 0, 0);
			spawn = 1;
		}
		
		
		
		
		///////////////////Walk//////////////
		float z = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(0.0f, 0.0f, z);
		
		rigidbody.AddRelativeForce(movement * speed * Time.deltaTime);
		
		float x = Input.GetAxis("Horizontal");
		transform.Rotate(0, x * rotationSpeed * Time.deltaTime, 0);
		
		
		/////////////////Fire////////////////
		float shoot = Input.GetAxis("Fire1");
		
		if(shootTime > 0)
		{
			shootTime -= Time.deltaTime;
		}
		if(shoot > 0 && shootTime<=0)
		{
			GameObject newBull = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
			newBull.transform.Translate(0, 0, 0);
			shootTime = 0.2f;
		}
		
		//////////////Redirect////////////////
		if(gameObject.transform.position.x > 20)
		{
			Vector3 nieuwPos = transform.position;
			nieuwPos.x = -20;
			transform.position = nieuwPos;
		}
		if(gameObject.transform.position.x < -20)
		{
			Vector3 nieuwPos = transform.position;
			nieuwPos.x = 20;
			transform.position = nieuwPos;
		}
		if(gameObject.transform.position.z > 15)
		{
			Vector3 nieuwPos = transform.position;
			nieuwPos.z = -15;
			transform.position = nieuwPos;
		}
		if(gameObject.transform.position.z < -15)
		{
			Vector3 nieuwPos = transform.position;
			nieuwPos.z = 15;
			transform.position = nieuwPos;
		}
	}
}

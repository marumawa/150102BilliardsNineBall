using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	Vector3 moveDir; //移動方向
	public float moveSpeed; //移動スピード
	Rigidbody rigidBody;

	// Use this for initialization
	void Start () 
	{
		rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		moveDir = Vector3.zero;
		moveDir.x = Input.GetAxis("Horizontal") * moveSpeed;
		moveDir.z = Input.GetAxis ("Vertical") * moveSpeed;


		rigidBody.AddForce (moveDir);
		
	
	}
}

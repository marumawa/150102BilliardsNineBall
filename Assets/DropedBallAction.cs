using UnityEngine;
using System.Collections;

public class DropedBallAction : MonoBehaviour {

	Vector3 startPos;
	public string whiteBallTag;
	public string otherBallTag;

	Rigidbody rbWhiteBall;

	void Start()
	{
		startPos.x = 0;
		startPos.y = 1;
		startPos.z = -5.6f;
	}


	void OnTriggerEnter(Collider aTarget)
	{
		if (aTarget.gameObject.tag == whiteBallTag)
		{
			Debug.Log ("White Ball Droped");
		
			rbWhiteBall = aTarget.GetComponent<Rigidbody> ();


			rbWhiteBall.velocity = Vector3.zero;
			rbWhiteBall.angularVelocity = Vector3.zero;
			aTarget.gameObject.transform.position = startPos;
		}

		if (aTarget.gameObject.tag == otherBallTag)
		{
			Destroy (aTarget.gameObject, 1.0f);
		}
	}
}

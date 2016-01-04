using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OtherNineBallSetting : MonoBehaviour {

	public GameObject ballPrefab;
	List<GameObject> OtherNineBall = new List<GameObject>();

	//-----------------------------------------------------------
	// Use this for initialization
	void Start () 
	{
		NineBallSetting ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	//-----------------------------------------------------------

	void NineBallSetting()
	{
		for (int i = 0; i < 3; i++)
		{
			OtherNineBall.Add (Instantiate (ballPrefab));
			OtherNineBall [i].transform.position = new Vector3(0, 1, 3);
		}



		/*for (int i = 1; i < 3; i++)
		{
			float offset = (float)(Mod(i) * 0.75 * .9 * 1.0);
			OtherNineBall [i].transform.position += new Vector3 (offset, 0, Mod(i) * offset);
		}*/

	}

	//偶奇判定
	int Mod(int aVal)
	{
		if (aVal % 2 == 0)
		{
			return 1;
		}
		else
		{
			return -1;
		}
	}


}

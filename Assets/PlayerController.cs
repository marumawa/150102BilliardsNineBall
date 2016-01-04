using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

	public GameObject whiteBall;
	public float power;

	Rigidbody rbWhiteBall;
	Vector3 ballVec;

	Vector3 clickPosDown, clickPosUp;

	// Use this for initialization
	void Start () 
	{
		rbWhiteBall = whiteBall.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			clickPosDown = Input.mousePosition;
			Debug.Log ("ClickDown(" + clickPosDown);
		}
		if (Input.GetMouseButtonUp (0))
		{

			clickPosUp = Input.mousePosition;
			//Debug.Log ("ClickUp(" + clickPosUp);
		
			if (clickPosUp == clickPosDown)
			{
				return;
			}

			//ボールを飛ばす方向を計算
			//マウスポジションは(x, y, z)が画面上の位置でありzは奥行きである
			//しかし空間軸の縦方向がzになるため、計算時に入れ替える
			ballVec = (clickPosDown - clickPosUp);
			ballVec.z = ballVec.y;
			ballVec.y = 0;
			ballVec.Normalize ();

			rbWhiteBall.AddForce (ballVec * power);
		}
	}

	public void Reload()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

}

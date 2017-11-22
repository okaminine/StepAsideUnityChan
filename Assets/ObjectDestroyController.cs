using UnityEngine;
using System.Collections;

public class ObjectDestroyController : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void OnTriggerEnter(Collider other)
	{
		//画面外のオブジェクトを消す
		//ユニティちゃんのようにRigidbodyがあるからOnTriggerEnter関数が使える。
			Destroy (other.gameObject);
	}
}


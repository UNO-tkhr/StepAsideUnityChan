using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	private GameObject mainCamera;

	// Use this for initialization
	void Start () {
		this.mainCamera = GameObject.Find("Main Camera");
		//回転を開始する角度を設定
		this.transform.Rotate(0, Random.Range(0,360), 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.z < mainCamera.transform.position.z){
			Destroy(this.gameObject);
		}
		//回転
		this.transform.Rotate(0,3,0);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour {
    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "Water")
        {
            //相手のタグがWaterならば、距離を確定させる
        }
        else
        {
            //相手のタグがWaterでなければ、ゲームオーバーを出力する
            GameObject.FindWithTag("MainCamera").SendMessage("GameOver");
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

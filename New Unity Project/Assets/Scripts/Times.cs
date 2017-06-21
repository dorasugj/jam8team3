using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Times : MonoBehaviour {
    public float RainTime = 10;
    private float elpased;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        elpased += Time.deltaTime;
        if(elpased>= RainTime)
        {
            BroadcastMessage("Timeup");
            enabled = false;
        }
	}
}

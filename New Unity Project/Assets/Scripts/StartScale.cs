using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScale : MonoBehaviour {

    private bool _bigScaleFlag = true;
    
    private float _currentTime = 0;

    [SerializeField]
    private float _waitTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        _currentTime += Time.deltaTime;
        if(_currentTime>_waitTime)
        {
            _bigScaleFlag = !_bigScaleFlag;
            _currentTime = 0;
        }
        //フラグがあれば大きくする
        if(_bigScaleFlag)
        {
            transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime/2;
        }
        else
        {
            transform.localScale += new Vector3(-1, -1, -1) * Time.deltaTime/2;
        }


	}
}

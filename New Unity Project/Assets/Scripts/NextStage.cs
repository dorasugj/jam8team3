using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextStage : MonoBehaviour {

    [SerializeField]
    private string _nextSceneName;

    [SerializeField]
    private float _waitTime;

    private float _currentTime = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //連続でシーン移動しないための処理
        _currentTime += Time.deltaTime;
        if (_currentTime > _waitTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(_nextSceneName);
                _currentTime = 0;
            }
        }
	}
}

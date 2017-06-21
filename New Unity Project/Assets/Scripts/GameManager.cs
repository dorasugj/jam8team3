using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private static int[] _scoredate= {300,200,100};

    public static int[] Instance { get { return _scoredate; } }

    private void Awake()
    {
        //シーン移動しても問題なくする
        DontDestroyOnLoad(gameObject);
    }
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        	
	}
}

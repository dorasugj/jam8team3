using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainGenerator : MonoBehaviour {
    public float interval;
    public GameObject Rain;
    private bool nextIsRed;
    private float timer;
	// Use this for initialization
	void Start () {
        nextIsRed = true;
        timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer < 0.0f)
        {
            Vector3 position = transform.position+new Vector3(Random.Range(-8.0f,8.0f), Random.Range(-8.0f, 8.0f), Random.Range(-8.0f, 8.0f));
            GameObject boxPrefab = nextIsRed ? Rain : Rain;
            Instantiate(boxPrefab, transform.position, transform.rotation);
            timer = interval;
            nextIsRed = !nextIsRed;
                }
	}
    void Timeup()
    {
        enabled = false;
    }
}

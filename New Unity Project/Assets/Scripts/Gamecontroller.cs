using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{

    public GameObject StartObj;
    public GameObject PlayerObj;
    public GameObject DistanceTextObj;
    private Text DistanceText;

    void Start()
    {
        DistanceText = DistanceTextObj.GetComponent<Text>();
    }

    void Update()
    {
        Vector2 Apos = StartObj.transform.position;
        Vector2 Bpos = PlayerObj.transform.position;
        float dis = Vector2.Distance(Apos, Bpos);
        DistanceText.text = "進んだ距離:" + dis.ToString();
    }
}
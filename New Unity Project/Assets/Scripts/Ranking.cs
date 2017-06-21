using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
public class Ranking : MonoBehaviour {


    [SerializeField]
    private Text[] _score;

    // Use this for initialization
    void Start ()
    {
        int[] score = GameManager.Instance;
        for(int i=0;i<_score.Length;i++)
        {
            _score[i].text = score[i].ToString();
        }
        
    }
}

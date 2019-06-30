﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerAlertPanelMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string team = null;
        if (pos._teamFlag)
        {
            team = "紅";
        }
        else
        {
            team = "黑";
        }

        this.gameObject.GetComponent<Text>().text = team + "方勝利\n是否再來一局?";
    }
}

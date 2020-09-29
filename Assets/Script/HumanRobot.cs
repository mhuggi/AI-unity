﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanRobot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(0, 0, 0.08f);
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(0, 0, -0.08f);
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0, -1.0f, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(0, 1.0f, 0);
        }



    }
}

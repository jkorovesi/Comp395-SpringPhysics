﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMassText : MonoBehaviour {

    public Text sliderValue;
    public Slider slider;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sliderValue.text = "Mass = " + slider.value.ToString();
    }
}

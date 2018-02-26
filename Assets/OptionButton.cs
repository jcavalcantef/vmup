using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using VMUP.Buttons;
using VMUP.Panels;

public class OptionButton : ButtonInteraction
{
    public int value;

    public Text valueText;
    public Text answerValue;

    new void OnEnable()
    {
        base.OnEnable();

        interactiveObject.OnClicked += Choose;
    }

    // Use this for initialization
    void Choose()
    {
        VentiladorMecanico.instance.O2Text.text = valueText.text;

        VentiladorMecanico.instance.Show();

        this.transform.parent.GetComponent<Canvas>().enabled = false;
    }
}

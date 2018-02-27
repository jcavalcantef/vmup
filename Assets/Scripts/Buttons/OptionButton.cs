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
    private Panel parent
    {
        get
        {
            return transform.parent.GetComponent<Panel>();
        }
    }

    public Text valueText;
    public Text targetText;

    public AudioSource audioSource;

    new void OnEnable()
    {
        base.OnEnable();

        interactiveObject.OnClicked += Choose;
    }

    // Use this for initialization
    void Choose()
    {
        parent.Close();

        targetText.text = valueText.text;

        VentiladorMecanico.instance.Show();

        if (!audioSource.isPlaying)
            audioSource.Play();
    }
}

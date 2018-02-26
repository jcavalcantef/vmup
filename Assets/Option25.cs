using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Option25: InteractiveObject
{
    public int value;

    public Canvas thisCanvas;
    public Canvas vmCanvas;

    public Image thisPanel;

    public Text valueText;
    public Text answerValue;

    public InteractiveObject interactiveObject
    {
        get
        {
            return transform.GetComponent<InteractiveObject>();
        }
    }

    public Rigidbody rb
    {
        get
        {
            return transform.GetComponent<Rigidbody>();
        }
    }

    public BoxCollider bc
    {
        get
        {
            return transform.GetComponent<BoxCollider>();
        }
    }

    void OnEnable()
    {
        interactiveObject.OnClicked += Choose;
        interactiveObject.OnHovered += Focus;
        interactiveObject.OnExit += Close;
    }

    // Use this for initialization
    void Choose()
    {
        thisCanvas.enabled = false;
        vmCanvas.enabled = true;

        answerValue.text = valueText.text;
    }

    void Focus()
    {
        thisPanel.DOColor(Color.cyan, 1f);
    }

    void Close()
    {
        thisPanel.DOColor(Color.white, 1f);
    }
}

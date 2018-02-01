using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2VMButton : InteractiveObject
{
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
        interactiveObject.OnClicked += OpenO2Percentages;
        interactiveObject.OnHovered += FocusArea;
        interactiveObject.OnExit += HidePercentages;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OpenO2Percentages()
    {

    }

    void HidePercentages()
    {

    }

    void FocusArea()
    {

    }
}

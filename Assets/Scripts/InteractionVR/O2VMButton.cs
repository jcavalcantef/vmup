using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2VMButton : InteractiveObject
{
    public static O2VMButton instance;

    public InteractiveObject interactiveObject
    {
        get
        {
            return transform.GetComponent<InteractiveObject>();
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

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start ()
    {
		
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

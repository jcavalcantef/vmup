using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2VMButton : InteractiveObject
{
    public static O2VMButton instance;

    public Canvas thisCanvas;
    public Canvas optionsCanvas;

    public BoxCollider[] optionColliders;

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
        optionsCanvas.enabled = true;
        thisCanvas.enabled = false;

        EnableColliders();
    }

    void HidePercentages()
    {

    }

    void FocusArea()
    {

    }

    public void DisableColliders()
    {
        foreach (BoxCollider col in optionColliders)
            col.enabled = false;
    }

    void EnableColliders()
    {
        foreach (BoxCollider col in optionColliders)
            col.enabled = true;
    }
}

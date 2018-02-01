using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class VMInterativo : InteractiveObject
{
    public Image textPanel;
    public Text name;

    public Color offPanel = new Color(1f, 1f, 1f, 0f);
    public Color onPanel = new Color(1f, 1f, 1f, 1f);
    public Color offText = new Color(0f, 0f, 0f, 0f);
    public Color onText = new Color(0f, 0f, 0f, 1f);

    public Canvas thisCanvas;
    public Canvas VMCAnvas;

    public Material mainSkybox;
    public Material vmSkybox;

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
        interactiveObject.OnClicked += OpenVMPanel;
        interactiveObject.OnHovered += FocusInteraction;
        interactiveObject.OnExit += UnFocusInteraction;
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OpenVMPanel()
    {
        VMCAnvas.enabled = true;
        thisCanvas.enabled = false;

        Destroy(rb);
        Destroy(bc);

        RenderSettings.skybox = vmSkybox;

        UnFocusInteraction();

        interactiveObject.OnClicked -= OpenVMPanel;
    }

    void FocusInteraction()
    {
        name.DOColor(onText, 1f);
        textPanel.DOColor(onPanel, 1f);
    }

    void UnFocusInteraction()
    {
        name.DOColor(offText, 1f);
        textPanel.DOColor(offPanel, 1f);
    }
}

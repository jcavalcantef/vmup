using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionMarkBtn : InteractiveObject
{
    public Canvas tutorCanvas;
    public Canvas vmCanvas;

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
        interactiveObject.OnClicked += Teach;
        interactiveObject.OnHovered += GiveHint;
        interactiveObject.OnExit += Close;
    }

    // Use this for initialization
    void Teach ()
    {
        tutorCanvas.enabled = true;
        vmCanvas.enabled = false;

        Invoke("CloseExplanation", 10.0f);
	}

    void GiveHint()
    {

    }

    void Close()
    {

    }
	
	void CloseExplanation()
    {
        tutorCanvas.enabled = false;
        vmCanvas.enabled = true;
    }
}

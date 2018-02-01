using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public event Action OnClicked;
    public event Action OnHovered;
    public event Action OnExit;

	void Start ()
    {
		
	}
	
    public void OnClick()
    {
        if (OnClicked != null)
            OnClicked();
    }

    public void OnHover()
    {
        if (OnHovered != null)
            OnHovered();
    }

    public void Exit()
    {
        if (OnExit != null)
            OnExit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VMUP.Buttons;
using VMUP.Panels;

public class O2Options : ButtonInteraction
{
    public Canvas options;

    public BoxCollider[] colliders;

    public Panel parent;

    public Transform panelTransform;

    new void OnEnable()
    {
        base.OnEnable();

        interactiveObject.OnClicked += Open;

        options = GameObject.Find("OptionButtons").GetComponent<Canvas>();
        options.transform.position = GameObject.Find("PanelShowPos").transform.position;
    }

    void Open()
    {
        options.enabled = true;

        parent.Close();
    }
}

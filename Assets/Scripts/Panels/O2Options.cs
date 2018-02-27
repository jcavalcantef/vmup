using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VMUP.Buttons;
using VMUP.Panels;

public class O2Options : Panel
{
    public Canvas options;

    public Panel parent;

    public Transform panelTransform;

    void OnEnable()
    {
    }

    void Open()
    {
        options.enabled = true;

        parent.Close();
    }
}

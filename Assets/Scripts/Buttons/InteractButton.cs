using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using VMUP.Scenes;

namespace VMUP.Buttons
{
    public class InteractButton : ButtonInteraction
    {
        public Transform panelTransform;
        public GameObject vmPanel;

        new void OnEnable()
        {
            base.OnEnable();

            interactiveObject.OnClicked += Interact;
        }

        public void Interact()
        {
            vmPanel = Instantiate(vmPanel, panelTransform.position, Quaternion.identity) as GameObject;
        }
    }
}

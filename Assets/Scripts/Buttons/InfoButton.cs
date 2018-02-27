using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using VMUP.Scenes;
using VMUP.Panels;

namespace VMUP.Buttons
{
    public class InfoButton : ButtonInteraction
    {
        public Panel infoPanel;
        public Panel parent;

        public Transform panelTransform;

        new void OnEnable()
        {
            base.OnEnable();

            panelTransform = GameObject.Find("PanelShowPos").transform;

            interactiveObject.OnClicked += Interact;
        }

        public void Interact()
        {
            infoPanel.Show();

            parent.Close();
        }
    }
}

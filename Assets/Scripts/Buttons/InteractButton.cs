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
    public class InteractButton : ButtonInteraction
    {
        public Transform panelTransform;
        public Panel vmPanel;
        public Panel monitorParam;

        public GameObject cleanGO;

        new void OnEnable()
        {
            base.OnEnable();

            interactiveObject.OnClicked += Interact;
        }

        public void Interact()
        {
            vmPanel = Instantiate(vmPanel, vmPanel.transform.position, Quaternion.identity) as Panel;
            vmPanel.transform.position = panelTransform.position;
            vmPanel.Show();

            monitorParam = Instantiate(monitorParam, monitorParam.transform.position, monitorParam.transform.rotation) as Panel;
            monitorParam.Show();

            Destroy(cleanGO);
        }
    }
}

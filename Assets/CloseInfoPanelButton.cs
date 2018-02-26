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
    public class CloseInfoPanelButton : ButtonInteraction
    {
        public Canvas canvas;

        new void OnEnable()
        {
            base.OnEnable();

            interactiveObject.OnClicked += Close;
        }

        public void Close()
        {
            canvas.enabled = false;

            VentiladorMecanico.instance.Show();
        }
    }
}

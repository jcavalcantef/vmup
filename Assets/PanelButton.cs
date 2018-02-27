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
    public class PanelButton : ButtonInteraction
    {
        public Panel panel;

        new void OnEnable()
        {
            base.OnEnable();

            interactiveObject.OnClicked += ShowPanel;
        }

        public void ShowPanel()
        {
            VentiladorMecanico.instance.Close();

            panel.Show();
        }
    }
}

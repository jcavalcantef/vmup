using UnityEngine;
using VMUP.Panels;
using System;
using VMUP.Data;
using VMUP.Scenes;
using UnityEngine.SceneManagement;

namespace VMUP.Buttons
{
    public class SubmitButton : ButtonInteraction
    {
        new void OnEnable()
        {
            base.OnEnable();

            interactiveObject.OnClicked += Submit;
        }

        public void Submit()
        {
            DataTransfer.instance.resultFromCase = Sala.instance.result;

            SceneManager.LoadScene(Sala.instance.nextScene);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using VMUP.Scenes;

namespace VMUP.Buttons
{
    public class SceneButton : ButtonInteraction
    {
        private void Awake()
        {
        }

        void OnEnable()
        {
            base.OnEnable();
            interactiveObject.OnClicked += LoadScene;
        }

        public void LoadScene()
        {
            SceneManager.LoadScene(Instructions.instance.nextScene);

            //CameraFade.instance.CameraFadesOutFollowFadeInExternal(LoadScene);
        }
    }
}

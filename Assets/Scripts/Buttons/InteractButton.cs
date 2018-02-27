using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using VMUP.Scenes;
using VMUP.Panels;
using System;

namespace VMUP.Buttons
{
    public class InteractButton : ButtonInteraction
    {
        public Transform panelTransform;
        public Panel vmPanel;
        public Panel monitorParam;

        public GameObject cleanGO;

        public AudioSource audioSource;

        public event Action OnPlaySoundFinishes;

        new void OnEnable()
        {
            base.OnEnable();

            OnPlaySoundFinishes += DeleteButton;

            interactiveObject.OnClicked += Interact;
        }

        public void Interact()
        {
            vmPanel.Show();
            monitorParam.Show();

            audioSource.Play();

            Invoke("DeleteButton", audioSource.clip.length);
        }

        void DeleteButton()
        {
            Destroy(cleanGO);
        }
    }
}

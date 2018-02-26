using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace VMUP.Buttons
{
    public class ButtonInteraction : InteractiveObject
    {
        public InteractiveObject interactiveObject
        {
            get
            {
                return transform.GetComponent<InteractiveObject>();
            }
        }

        public Image image
        {
            get
            {
                return GetComponent<Image>();
            }
        }

        public BoxCollider bc
        {
            get
            {
                return transform.GetComponent<BoxCollider>();
            }
        }

        protected void OnEnable()
        {
            interactiveObject.OnClicked += Click;
            interactiveObject.OnHovered += Focus;
            interactiveObject.OnExit += UnFocus;
        }

        void Click()
        {
            Debug.Log("Clicked");

            Destroy(this.gameObject);
        }

        void Focus()
        {
            image.DOColor(Color.cyan, 1f);
        }

        void UnFocus()
        {
            image.DOColor(Color.white, 1f);
        }
    }
}



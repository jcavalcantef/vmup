using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VMUP.Panels
{
    public class Panel : MonoBehaviour
    {
        private Canvas panelCanvas
        {
            get
            {
                return GetComponent<Canvas>();
            }
        }

        public BoxCollider[] colliders;

        private void OnEnable()
        {
            Close();
        }

        public void Show()
        {
            panelCanvas.enabled = true;

            if (colliders.Length > 0)
                EnableColliders();
        }

        public void Close()
        {
            panelCanvas.enabled = false;

            if (colliders.Length > 0)
                DisableColliders();
        }

        public void EnableColliders()
        {
            foreach (Collider col in colliders)
                col.enabled = true;
        }

        public void DisableColliders()
        {
            foreach (Collider col in colliders)
                col.enabled = false;
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VMUP.Panel
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

        public void Show()
        {
            panelCanvas.enabled = true;
        }

        public void Close()
        {
            panelCanvas.enabled = false;
        }
    }
}



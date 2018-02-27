using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VMUP.Panels
{
    public class VentiladorMecanico : Panel
    {
        public static VentiladorMecanico instance;

        public Text O2Text;
        public Text PeepText;
        public Text RespRateText;
        public Text PCAbovePeepText;

        void Awake()
        {
            instance = this;
        }

        void Update()
        {
        }

        public void TurnOn()
        {
            Invoke("ShowParameters", 1.5f);
        }

        void ShowParameters()
        {
            O2Text.enabled = true;
            PeepText.enabled = true;
            RespRateText.enabled = true;
            PCAbovePeepText.enabled = true;

            MonitorMultiParametrico.instance.UpdateOxygenSaturation();
        }
    }
}
   

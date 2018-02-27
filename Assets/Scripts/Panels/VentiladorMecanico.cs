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

        void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            
        }

        void Update()
        {

        }
    }
}
   

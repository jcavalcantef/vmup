using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VMUP.Data;
using VMUP.Scenes;

namespace VMUP.Panels
{
    public class MonitorMultiParametrico : Panel
    {
        public static MonitorMultiParametrico instance;

        private OxygenSaturation oxygenSaturation;

        public Text OxygenSaturationText;

        public AudioSource audioSource;

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

        public void UpdateOxygenSaturation()
        {
            oxygenSaturation = new OxygenSaturation(Int32.Parse(VentiladorMecanico.instance.O2Text.text), Int32.Parse(VentiladorMecanico.instance.PeepText.text));

            OxygenSaturationText.text = oxygenSaturation.getSaturation(Int32.Parse(VentiladorMecanico.instance.O2Text.text), Int32.Parse(VentiladorMecanico.instance.PeepText.text));

            if (!audioSource.isPlaying)
                audioSource.Play();

            Sala.instance.result = oxygenSaturation.isWithinNormalCondition;
        }
    }
}


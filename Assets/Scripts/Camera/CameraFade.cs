using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace VMUP.CameraFade
{
	public class CameraFade : MonoBehaviour
	 {
        public static CameraFade instance;

        public Transform camPanel;

        public Color startColor;
        public Color endColor;

        public Color cameraColor
        {
            get { return camPanel.GetComponent<Image>().color; }

            set { camPanel.GetComponent<Image>().color = value; }
        }

        public event Action OnFadeComplete;

        void Awake()
        {
            instance = this;
        }

        //------------------------------------
        //  Call on initialization
        //------------------------------------

        void Start () 
		{
            // Every scene starts the camera fading in
            //CameraFadeIn();

            //CameraFadeOut();

            //CameraFadesOutFollowFadeIn();
		}

        //------------------------
        //  Run every frame
        //------------------------

        void Update () 
		{
			
		}

        //------------------------------------
        //  Fades in the camera color
        //------------------------------------

        public void CameraFadeIn()
        {
            StartCoroutine(FadeIn(startColor, endColor, 1.5f));
        }

        //------------------------------------
        //  Fades out the camera color
        //------------------------------------

        public void CameraFadeOut()
        {
            StartCoroutine(FadeOut(startColor, endColor, 1.5f));
        }

        //-----------------------------------------------------
        //  Fades in the camera color and after fades out
        //-----------------------------------------------------

        public void CameraFadesInFollowFadeOut()
        {
            StartCoroutine(FadeInFollowOut(startColor, endColor, 1.5f, CameraFadeOut));
        }

        //-----------------------------------------------------
        //  Fades out the camera color and after fades in
        //-----------------------------------------------------

        public void CameraFadesOutFollowFadeIn()
        {
            StartCoroutine(FadesOutFollowIn(startColor, endColor, 1.5f, CameraFadeIn));
        }

        public void CameraFadesOutFollowFadeInExternal(Action action)
        {
            StartCoroutine(FadesOutFollowIn(startColor, endColor, 1.5f, action));
        }

        //------------------------------------------
        //  Fades in the camera color routine
        //------------------------------------------

        private IEnumerator FadeIn(Color startCol, Color endCol, float duration)
        {
            // Execute this loop once per frame until the timer exceeds the duration.
            float timer = 0f;

            //set the initial color for the camera
            cameraColor = startCol;

            while (timer <= duration)
            {
                // Set the colour based on the normalised time.
                cameraColor = Color.Lerp(startCol, endCol, timer / duration);

                // Increment the timer by the time between frames and return next frame.
                timer += Time.deltaTime;
                yield return null;
            }

            // If anything is subscribed to OnFadeComplete call it.
            if (OnFadeComplete != null)
                OnFadeComplete();
        }

        //------------------------------------------
        //  Fades in the camera color routine
        //------------------------------------------

        private IEnumerator FadeOut(Color startCol, Color endCol, float duration)
        {
            // Execute this loop once per frame until the timer exceeds the duration.
            float timer = 0f;

            //set the initial color for the camera
            cameraColor = endCol;

            while (timer <= duration)
            {
                // Set the colour based on the normalised time.
                cameraColor = Color.Lerp(endCol, startCol, timer / duration);

                // Increment the timer by the time between frames and return next frame.
                timer += Time.deltaTime;
                yield return null;
            }

            // If anything is subscribed to OnFadeComplete call it.
            if (OnFadeComplete != null)
                OnFadeComplete();
        }

        private IEnumerator FadeInFollowOut(Color startCol, Color endCol, float duration, Action fade)
        {
            // Subscribe the function to be called after Fade
            OnFadeComplete += fade;

            // Execute this loop once per frame until the timer exceeds the duration.
            float timer = 0f;

            // set the initial color for the camera
            cameraColor = startCol;

            while (timer <= duration)
            {
                // Set the colour based on the normalised time.
                cameraColor = Color.Lerp(startCol, endCol, timer / duration);

                // Increment the timer by the time between frames and return next frame.
                timer += Time.deltaTime;
                yield return null;
            }

            // If anything is subscribed to OnFadeComplete call it.
            if (OnFadeComplete != null)
                OnFadeComplete();

            // Unsubscribe the function to be called after Fade
            OnFadeComplete -= fade;
        }

        private IEnumerator FadesOutFollowIn(Color startCol, Color endCol, float duration, Action fade)
        {
            // Subscribe the function to be called after Fade
            OnFadeComplete += fade;

            // Execute this loop once per frame until the timer exceeds the duration.
            float timer = 0f;

            // set the initial color for the camera
            cameraColor = endCol;

            while (timer <= duration)
            {
                // Set the colour based on the normalised time.
                cameraColor = Color.Lerp(endCol, startCol, timer / duration);

                // Increment the timer by the time between frames and return next frame.
                timer += Time.deltaTime;
                yield return null;
            }

            // If anything is subscribed to OnFadeComplete call it.
            if (OnFadeComplete != null)
                OnFadeComplete();

            // Unsubscribe the function to be called after Fade
            OnFadeComplete -= fade;
        }
    }
}



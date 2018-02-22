using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VMUP.Scenes
{
    public class Instructions : MonoBehaviour
    {
        public static Instructions instance;

        public string nextScene;


        void Awake()
        {
            instance = this;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void LoadNextScene()
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}


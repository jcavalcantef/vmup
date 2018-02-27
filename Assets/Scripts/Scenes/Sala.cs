using UnityEngine;
using UnityEngine.SceneManagement;

namespace VMUP.Scenes
{
    public class Sala : MonoBehaviour
    {
        public static Sala instance;

        public bool result;

        public string nextScene;


        void Awake()
        {
            instance = this;
        }

        public void CheckResult()
        {
           
        }

        public void LoadNextScene()
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}


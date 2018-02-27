using UnityEngine;
using UnityEngine.SceneManagement;
using VMUP.Data;

namespace VMUP.Scenes
{
    public class Feedback : MonoBehaviour
    {
        public static Feedback instance;

        public GameObject[] feedbacks;

        public string nextScene;


        void Awake()
        {
            instance = this;
        }

        void Start()
        {
            GiveFeedback(DataTransfer.instance.resultFromCase);
        }

        void Update()
        {

        }

        public void GiveFeedback(bool ok)
        {
            if (ok)
                Instantiate(feedbacks[0], feedbacks[0].transform.position, feedbacks[0].transform.rotation);
            else
                Instantiate(feedbacks[1], feedbacks[1].transform.position, feedbacks[1].transform.rotation);
        }

        public void LoadNextScene()
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}


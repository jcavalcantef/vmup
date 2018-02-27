
using UnityEngine;
using UnityEngine.SceneManagement;


namespace VMUP.Buttons
{
    public class RestartButton : ButtonInteraction
    {
        new void OnEnable()
        {
            base.OnEnable();

            interactiveObject.OnClicked += Restart;
        }

        public void Restart()
        {
            Destroy(GameObject.Find("Intensive Care Unit Ambient").gameObject);
            Destroy(GameObject.Find("DataTransfer").gameObject);

            SceneManager.LoadScene("MainMenu");
        }
    }
}

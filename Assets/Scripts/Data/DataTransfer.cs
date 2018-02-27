using UnityEngine;
using UnityEngine.SceneManagement;

namespace VMUP.Data
{
    public class DataTransfer : MonoBehaviour
    {
        public static DataTransfer instance;

        public bool resultFromCase;

        void Awake()
        {
            instance = this;

            DontDestroyOnLoad(this);
        }
    }
}


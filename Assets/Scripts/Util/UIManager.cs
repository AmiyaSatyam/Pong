using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PONG.Util
{
    public class UIManager : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}

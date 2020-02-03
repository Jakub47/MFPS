using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MFPS.UI
{
    public class CloseCurrentSceneAsync : MonoBehaviour
    {
       public void CloseScene(string scene)
        {
            SceneManager.UnloadSceneAsync(scene);
        }
    }
}
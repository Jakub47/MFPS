using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MFPS.UI
{
    public class Alerts : MonoBehaviour
    {
        public  IEnumerator CreateNewAlert(string msg)
        {
            yield return SceneManager.LoadSceneAsync("Alerts", LoadSceneMode.Additive);
            GameObject.FindObjectOfType<AlertObjects>().AlertText.text = msg;
        }
    }

}
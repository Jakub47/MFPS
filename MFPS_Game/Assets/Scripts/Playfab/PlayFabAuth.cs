using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using MFPS.UI;
using UnityEngine.SceneManagement;

namespace MFPS.Playfab
{
    public class PlayFabAuth : MonoBehaviour
    {
        public InputField UserName;
        public InputField Password;
        public string LevelToLoad;

        public void Login()
        {
            LoginWithPlayFabRequest request = new LoginWithPlayFabRequest();
            request.Username = UserName.text;
            request.Password = UserName.text;

            PlayFabClientAPI.LoginWithPlayFab(request, result => {
                Alerts a = new Alerts();
                StartCoroutine(a.CreateNewAlert(UserName.text + " You have logged in"));
                SceneManager.LoadScene(LevelToLoad);

            }, error =>
            {
                Alerts a = new Alerts();
                StartCoroutine(a.CreateNewAlert(error.ErrorMessage));
            });
        }
    }
}
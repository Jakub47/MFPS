using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab.ClientModels;
using UnityEngine.UI;
using PlayFab;
using MFPS.UI;

namespace MFPS.Playfab
{
    public class Register : MonoBehaviour
    {
        public InputField UserName;
        public InputField Password;
        public InputField ConfPassword;
        public InputField Email;

        public void CreateAccount()
        {
            if (Password.text == ConfPassword.text)
            {
                RegisterPlayFabUserRequest request = new RegisterPlayFabUserRequest();
                request.Username = UserName.text;
                request.Password = ConfPassword.text;
                request.Email = Email.text;
                request.DisplayName = UserName.text;

                PlayFabClientAPI.RegisterPlayFabUser(request, result =>
                {
                    Alerts a = new Alerts();
                    StartCoroutine(a.CreateNewAlert(result.Username + " Has been created"));
                },
                error =>
                {
                    Alerts a = new Alerts();
                    StartCoroutine(a.CreateNewAlert(error.ErrorMessage));
                });
            }
        }
    }
}

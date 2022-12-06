using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using PlayFab;
using PlayFab.ClientModels;

public class AccountsManager : MonoBehaviour
{
    public static AccountsManager instance;


    //Eventos
    public static UnityEvent OnLoginSuccess = new UnityEvent();
    public static UnityEvent<string> OnLoginFailed = new UnityEvent<string>();
    public static UnityEvent OnCreateSuccess = new UnityEvent();
    public static UnityEvent<string> OnCreateFailed = new UnityEvent<string>();


    private void Awake()
    {
        instance = this;
    }
    public void CreateAccount (string email, string password)
    {
        PlayFabClientAPI.RegisterPlayFabUser(
            new RegisterPlayFabUserRequest()
            {
                RequireBothUsernameAndEmail = false,
                Email = email,
                Password = password,
               

            },
            response =>
            {
                OnCreateSuccess.Invoke();
            },
            error =>
            {
                Debug.Log(error);
                OnCreateFailed.Invoke(error.ErrorMessage);
            }
        ); ;
    }

    public void LogIn (string email_, string password_)
    {
        PlayFabClientAPI.LoginWithEmailAddress (
             new LoginWithEmailAddressRequest()
             {
                 Email = email_ ,
                 Password = password_,
             },
             response =>
             {
                 OnLoginSuccess.Invoke();
             },
            error =>
            {
                Debug.Log(error.ErrorMessage);
                OnLoginFailed.Invoke(error.ErrorMessage);
            }
        );   
    }

}

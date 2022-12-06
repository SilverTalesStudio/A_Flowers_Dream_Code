using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;

public class AccountsManager : MonoBehaviour
{
    public static AccountsManager instance;


    //Eventos
    public static UnityEvent OnLoginSuccess = new UnityEvent();
    public static UnityEvent<string> OnLoginFailed = new UnityEvent<string>();
    public static UnityEvent OnCreateSuccess = new UnityEvent();
    public static UnityEvent<string> OnCreateFailed = new UnityEvent<string>();
    public static UnityEvent OnRecoverySuccess = new UnityEvent();
    //public static UnityEvent<string> OnCreateFailed = new UnityEvent<string>();

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        if (string.IsNullOrEmpty(PlayFabSettings.TitleId))
        {
            PlayFabSettings.TitleId = "7C020";
        }
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

    public void RecoverPassword(string email_)
    {
        transform.GetChild(1).gameObject.transform.GetChild(7).gameObject.GetComponent<Button>().interactable = false;

        PlayFabClientAPI.SendAccountRecoveryEmail(
            new SendAccountRecoveryEmailRequest()
            {
                Email= email_,
                TitleId = "7C020"
            },
            resultCallback =>
            {
                transform.GetChild(1).gameObject.transform.GetChild(7).gameObject.GetComponent<Button>().interactable = true;
                OnRecoverySuccess.Invoke();

            }, 
            error =>
            {
                transform.GetChild(1).gameObject.transform.GetChild(7).gameObject.GetComponent<Button>().interactable = true;
                OnLoginFailed.Invoke(error.ErrorMessage);
            }
            
            );
    }

}

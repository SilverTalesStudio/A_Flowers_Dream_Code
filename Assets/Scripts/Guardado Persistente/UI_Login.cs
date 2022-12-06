using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UI_Login : MonoBehaviour
{
    [SerializeField] TMP_Text whenTryLogInText;
    [SerializeField] GameObject canvasHide;
    [SerializeField] GameObject canvasShow;
    string email;
    string password;

    private void OnEnable()
    {
        AccountsManager.OnLoginFailed.AddListener(LoginFailed);
        AccountsManager.OnLoginSuccess.AddListener(LoginSuccess);
    }
    private void OnDisable()
    {
        AccountsManager.OnLoginFailed.RemoveListener(LoginFailed);
        AccountsManager.OnLoginSuccess.RemoveListener(LoginSuccess);

    }
    void LoginFailed(string error)
    {
        whenTryLogInText.gameObject.SetActive(true);
        whenTryLogInText.text = error;
    }
    void LoginSuccess()
    {
        canvasHide.SetActive(false);
        canvasShow.SetActive(true);
    }

    public void UpdateEmail_FromInputField(string email_)
    {
        email = email_;
    }
    public void UpdatePassword_FromInputField(string password_)
    {
        password = password_;
    }

    public void SignIn()
    {
        AccountsManager.instance.LogIn(email, password);
    }
}

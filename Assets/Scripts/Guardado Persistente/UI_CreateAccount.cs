using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_CreateAccount : MonoBehaviour
{
    [SerializeField] TMP_Text whenTryCreateText;

    string email;
    string password;

    private void OnEnable()
    {
        AccountsManager.OnCreateFailed.AddListener(CreateAccountFailed);
        AccountsManager.OnCreateSuccess.AddListener(CreateAccountSuccess);

    }
    private void OnDisable()
    {
        AccountsManager.OnCreateFailed.RemoveListener(CreateAccountFailed);
        AccountsManager.OnCreateSuccess.RemoveListener(CreateAccountSuccess);
    }
    void CreateAccountFailed(string error)
    {
        whenTryCreateText.gameObject.SetActive(true);
        whenTryCreateText.text = error;
    }
    void CreateAccountSuccess()
    {
        whenTryCreateText.text = "Cuenta creada con éxito, ya puedes iniciar sesión";
    }
    public void UpdateEmail_FromInputField(string email_)
    {
        email = email_;
    }
    public void UpdatePassword_FromInputField(string password_)
    {
        password = password_;
    }

    public void CreateAccount()
    {
        AccountsManager.instance.CreateAccount(email, password);
    }
}

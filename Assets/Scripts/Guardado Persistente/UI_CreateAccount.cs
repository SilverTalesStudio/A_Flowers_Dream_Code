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
        if(password.Length < 6)
        {
            whenTryCreateText.text = "La contrase�a debe tener m�s de 6 caracteres";
        }
        else if (error == "User not found")
        {
            whenTryCreateText.text = "Usuario no encontrado";
        }
        else if (error == "Invalid input parameters")
        {
            whenTryCreateText.text = "Par�metros introducidos no v�lidos";
        }
        else if (error == "Invalid email address or password")
        {
            whenTryCreateText.text = "Email o contrase�a inv�lidos";
        }
        else
        {
            whenTryCreateText.text = error;
        }
    }
    void CreateAccountSuccess()
    {
        whenTryCreateText.text = "Cuenta creada con �xito, ya puedes iniciar sesi�n";
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

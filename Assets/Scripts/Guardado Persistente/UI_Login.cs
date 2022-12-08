using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_Login : MonoBehaviour
{
    [SerializeField] TMP_Text whenTryLogInText;
    [SerializeField] GameObject canvasHide;
    [SerializeField] GameObject canvasShow;
    [SerializeField] Button CargaBTN;
    string email;
    string password;

    private void OnEnable()
    {
        AccountsManager.OnLoginFailed.AddListener(LoginFailed);
        AccountsManager.OnLoginSuccess.AddListener(LoginSuccess);
        AccountsManager.OnRecoverySuccess.AddListener(ResetSuccess);
        AccountsManager.OnUserDataGetted.AddListener(SetGameSaveState);
    }
    private void OnDisable()
    {
        AccountsManager.OnLoginFailed.RemoveListener(LoginFailed);
        AccountsManager.OnLoginSuccess.RemoveListener(LoginSuccess);
        AccountsManager.OnRecoverySuccess.RemoveListener(ResetSuccess);
        AccountsManager.OnUserDataGetted.RemoveListener(SetGameSaveState);


    }
    void LoginFailed(string error)
    {
        whenTryLogInText.gameObject.SetActive(true);
        whenTryLogInText.text = error;
    }
    void LoginSuccess()
    {
        whenTryLogInText.text = "Sesi�n iniciada con �xito";
        PlayerPrefs.SetInt("Guest", 1); //1 -> true
        AccountsManager.instance.GetUserData("UserData");
    }
    void ResetSuccess()
    {
        whenTryLogInText.text = "�Correo de recuperaci�n de contrase�a enviado!";
    }

    void SetGameSaveState(string value)
    {
        canvasHide.SetActive(false);
        canvasShow.SetActive(true);
        // Debug.Log("GameState"+value);
        SaveState userSave = JsonUtility.FromJson<SaveState>(value);
        userSave.setPlayerPrefs();

        if (userSave.nodeSaved!=null)
        {

            CargaBTN.interactable = true;
        }
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
    public void ResetPassword()
    {
        AccountsManager.instance.RecoverPassword(email);
    }

    public void setJugarInvitado()
    {
        PlayerPrefs.SetInt("Guest", 0); //0 -> false
    }
}

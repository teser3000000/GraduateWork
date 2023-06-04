using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Autorization : MonoBehaviour
{
    [SerializeField] public Text textLogin;
    [SerializeField] public Text textPassword;

    [SerializeField] public GameObject error;

    public string adminLogin = "Anime";
    public string adminPassword = "123";
    public bool isCheck = false;
    public bool errorActive = false;

    public float invoke_delay = 3f;
  
    public void checkUser()
    {
        if (textLogin.text == adminLogin && textPassword.text == adminPassword) isCheck = true;
        else error.SetActive(!errorActive);
    }
    public void Delay()
    {
        Invoke("checkUser", invoke_delay);
    }
    public void Error()
    {
        error.SetActive(!errorActive);
    }


}

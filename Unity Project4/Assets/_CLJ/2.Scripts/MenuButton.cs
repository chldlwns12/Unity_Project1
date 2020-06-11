using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject MenuMain;

    public void OnMenuButton()
    {
        MenuMain.SetActive(true);
    }

    public void OnContinueButton()
    {
        MenuMain.SetActive(false);
    }

    public void OnOptionButton()
    {

    }

    public void OnMainButton()
    {
        SceneMgr.Instance.LoadScene("StartScene");
    }
}

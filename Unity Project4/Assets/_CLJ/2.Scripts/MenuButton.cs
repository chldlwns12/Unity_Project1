using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject MenuMain;

    public void OnMenuButton()
    {
        MenuMain.SetActive(true);
        Time.timeScale = 0;
    }

    public void OnContinueButton()
    {
        MenuMain.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnOptionButton()
    {

    }

    public void OnMainButton()
    {
        SceneMgr.Instance.LoadScene("StartScene");
    }
}

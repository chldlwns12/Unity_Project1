using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventButton : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        SceneMgr.Instance.LoadScene("GameScene");
    }

    public void OnMenuButtonClick()
    {

    }

    public void OnOptionButtonClick()
    {
        
    }
}

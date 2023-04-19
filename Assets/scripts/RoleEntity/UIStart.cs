using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UIStart : MonoBehaviour
{
    [SerializeField] Button btnGameStart;
    [SerializeField] Canvas UIMain;
    public void Ctor(Action onGameStartHandle)
    {
        btnGameStart.onClick.AddListener(() =>
        {
            onGameStartHandle.Invoke();
        });
    }
    public void startGame(){
        UIMain.gameObject.SetActive(false);
        Instantiate(Resources.Load("role"));
        Instantiate(Resources.Load("panel"));
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sale : MonoBehaviour
{
    [Header("Manager:")]
    [SerializeField] private GameManager gameManager;
    [SerializeField] private UIManager uiManager;
    [Header("Shop:")]
    [SerializeField] private GameObject shop;

    private void Update()
    {
        if(gameManager._costMilletShop >= 30)
        {
            shop.SetActive(true);
            gameManager.DecreaseMilletShop();
            uiManager.WinGame();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [Header("GameObject:")]
    [SerializeField] private GameObject _gameScreen;
    [SerializeField] private GameObject _winScreen;
    [Header("Managers:")]
    [SerializeField] private GameManager _gameManager;

    private void Start()
    {
        _gameScreen.SetActive(true);
        _winScreen.SetActive(false);
    }

    public void WinGame()
    {
        _gameScreen.SetActive(false);
        _winScreen.SetActive(true);
    }
}

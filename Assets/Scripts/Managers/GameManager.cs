using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Controllers:")]
    [SerializeField] private PlayerController _playerController;
    [Header("TextMeshPro:")]
    [SerializeField] private TextMeshProUGUI _scoreMillet;
    [SerializeField] private TextMeshProUGUI _maxMillet;

    public int _costMilletShop = 0;

    public void IncreaseMilletPlayer()
    {
        _playerController._costMillet++;
        _scoreMillet.text = _playerController._costMillet.ToString() + "/12";
        
    }

    public void IncreaseMilletShop()
    {
        _costMilletShop += _playerController._costMillet;
        _playerController._costMillet = 0;
        _scoreMillet.text = _playerController._costMillet.ToString() + "/12";
        _maxMillet.text = _costMilletShop.ToString() + "/30";
    }

    public void DecreaseMilletShop()
    {
        _costMilletShop = 0;
        _maxMillet.text = _costMilletShop.ToString() + "/30";
    }
}

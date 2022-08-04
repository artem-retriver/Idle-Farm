using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Controllers:")]
    [SerializeField] private AnimationController controller;
    //[SerializeField] private MoveController moveController;
    //[SerializeField] private Sale sale;
    [Header("Managers:")]
    [SerializeField] private GameManager gameManager;
    //[SerializeField] private UIManager uIManager;
    [Header("GameObjects:")]
    [SerializeField] private GameObject packageMillet1;
    [SerializeField] private GameObject packageMillet2;
    [SerializeField] private GameObject packageMillet3;
    [SerializeField] private GameObject packageMillet4;
    [SerializeField] private GameObject packageMillet5;
    [SerializeField] private GameObject packageMillet6;
    [SerializeField] private GameObject packageMillet7;
    [SerializeField] private GameObject packageMillet8;
    [SerializeField] private GameObject packageMillet9;
    [SerializeField] private GameObject packageMillet10;
    [SerializeField] private GameObject packageMillet11;
    [SerializeField] private GameObject packageMillet12;

    //public bool _enabled = true;
    public int _costMillet = 0;

    public void OnCollisionEnter(Collision collision)
    {
        if(_costMillet < 12)
        {
            if (collision.gameObject.TryGetComponent(out Millet millet))
            {
                //uIManager.UnVisibleJoystick();
                controller.SetWheatTrigger();
                StartCoroutine(OffMillet(millet));
                StartCoroutine(OnMillet(millet));
                gameManager.IncreaseMilletPlayer();
            }
        }
        else
        {
            Debug.Log("Максимальный рюкзак");
        }

        if(gameManager._costMilletShop < 30)
        {
            if (collision.gameObject.TryGetComponent(out Sale sal))
            {
                gameManager.IncreaseMilletShop();
            }
        }
        else
        {
            Debug.Log("Максимальный запас");
        }
    }

    private IEnumerator OffMillet(Millet millet)
    {
        yield return new WaitForSeconds(1f);
        millet.gameObject.SetActive(false); 
    }

    private IEnumerator OnMillet(Millet millet)
    {
        //uIManager.VisibleJoystick();
        yield return new WaitForSeconds(10f);
        millet.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (_costMillet == 0)
        {
            packageMillet1.SetActive(false);
            packageMillet2.SetActive(false);
            packageMillet3.SetActive(false);
            packageMillet4.SetActive(false);
            packageMillet5.SetActive(false);
            packageMillet6.SetActive(false);
            packageMillet7.SetActive(false);
            packageMillet8.SetActive(false);
            packageMillet9.SetActive(false);
            packageMillet10.SetActive(false);
            packageMillet11.SetActive(false);
            packageMillet12.SetActive(false);
        }

        if (_costMillet == 1)
        {
            packageMillet1.SetActive(true);
        }

        if (_costMillet == 2)
        {
            packageMillet2.SetActive(true);
        }

        if (_costMillet == 3)
        {
            packageMillet3.SetActive(true);
        }

        if (_costMillet == 4)
        {
            packageMillet4.SetActive(true);
        }

        if (_costMillet == 5)
        {
            packageMillet5.SetActive(true);
        }

        if (_costMillet == 6)
        {
            packageMillet6.SetActive(true);
        }

        if (_costMillet == 7)
        {
            packageMillet7.SetActive(true);
        }

        if (_costMillet == 8)
        {
            packageMillet8.SetActive(true);
        }

        if (_costMillet == 9)
        {
            packageMillet9.SetActive(true);
        }

        if (_costMillet == 10)
        {
            packageMillet10.SetActive(true);
        }

        if (_costMillet == 11)
        {
            packageMillet11.SetActive(true);
        }

        if (_costMillet == 12)
        {
            packageMillet12.SetActive(true);
        }
    }
}

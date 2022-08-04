using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceMillet : MonoBehaviour
{
    [Header("GameObject:")]
    [SerializeField] private GameObject millet;

    private void Start()
    {
        millet.SetActive(true);
    }
}

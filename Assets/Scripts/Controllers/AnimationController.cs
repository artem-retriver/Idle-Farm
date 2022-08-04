using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [Header("Animators:")]
    [SerializeField] private Animator animator;

    private int _runID;
    private int _idleID;
    private int _wheatID;

    private void Awake()
    {
        _idleID = Animator.StringToHash("Idle");
        _runID = Animator.StringToHash("Run");
        _wheatID = Animator.StringToHash("Wheat");
    }

    public void SetIdletrigger()
    {
        SetTrigger(_idleID);
    }

    public void SetRunTrigger()
    {
        SetTrigger(_runID);
    }

    public void SetWheatTrigger()
    {
        SetTrigger(_wheatID);
    }

    public void SetTrigger(int id) => animator.SetTrigger(id);
}

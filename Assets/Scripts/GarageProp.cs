using UnityEngine;

public class GarageProp : MonoBehaviour
{
    //=================
    //===Vars
    //=================

    [SerializeField] private Animator garageAnimator;

    //=================
    //===MonoBehaviour
    //=================

    private void Awake()
    {
        garageAnimator.Play("Open");
    }
}

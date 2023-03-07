using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 


public class HandController : MonoBehaviour
{

    [SerializeField]
    private InputActionReference gripInput;

    [SerializeField]
    private InputActionReference triggerInput;

    //Private Variables
    private Animator _animator;
    private float grip;
    private float trigger;

    private void Awake()
    {
        //Obtenemos el componente animator
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        grip = gripInput.action.ReadValue<float>();
        trigger = triggerInput.action.ReadValue<float>();

        _animator.SetFloat("Grip", grip);
        _animator.SetFloat("trigger", trigger);
    }
}

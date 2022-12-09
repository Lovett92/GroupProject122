using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_CharacterController : MonoBehaviour
{

    private DefaultInput defaultInput;
    public Vector2 input_Movement;
    public Vector2 input_View;

    private Vector3 newCameraRotation;

    private void Awake()
    {
        defaultInput = new DefaultInput();

        defaultInput.Character.Movement.preformed += e => input_Movement = e.ReadValue<Vector2>();
        defaultInput.Character.View.preformed += e => input_View = e.ReadValue<Vector2>();

        defaultInput.Enable();

    }

    private void Update()
    {

        CalculateView();
        CalculateMovement();

    }

    private void CalculateView()
    {



    }

    private void CalculateMovement()
    {



    }
}

using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //=================
    //===Vars
    //=================
    
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float     playerMovementSpeed = 25f;
    [SerializeField] private float     playerRotationSpeed = 50f;

    //=================
    //===MonoBehaviour
    //=================

    private void Update()
    {
        //Move Forward
        if (Input.GetKey(KeyCode.W))
        {
            playerRigidbody.velocity = transform.forward * playerMovementSpeed;
        }

        //Move Back
        if (Input.GetKey(KeyCode.S))
        {
            playerRigidbody.velocity = -transform.forward * playerMovementSpeed;
        }

        //Rotate Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * playerRotationSpeed, Space.World);
        }

        //Rotate Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * playerRotationSpeed, Space.World);
        }
    }
}

using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    private CharacterController characterController;

    public int Health { get; internal set; }

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        characterController.Move(new Vector3(horizontal, 0, vertical));
    }
}

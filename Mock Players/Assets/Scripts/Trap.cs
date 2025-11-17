using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var characterMover = other.GetComponent<CharacterMover>();
       characterMover.Health--;
    }
}

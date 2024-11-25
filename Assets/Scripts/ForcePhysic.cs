using UnityEngine;

public class ForcePhysic : MonoBehaviour
{
    private Rigidbody rbPlayer;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // rbPlayer.velocity = 
    }
}

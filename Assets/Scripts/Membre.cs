using UnityEngine;
using DG.Tweening;

public class Membre : MonoBehaviour
{
    [SerializeField] private Vector3 finalPosition;
    public Vector3 FinalPosition => finalPosition;
    [SerializeField] private float speed = 1;
    public float Speed => speed;
}

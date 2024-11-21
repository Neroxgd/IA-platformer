using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class Player : MonoBehaviour
{
    private Membre[] membres;

    private void Start()
    {
        membres = GetComponentsInChildren<Membre>();
    }

    public void ButtonAction(InputAction.CallbackContext context)
    {
        if (context.started)
            for (int i = 0; i < membres.Length; i++)
            {
                DOTween.Kill(membres[i].transform);
                membres[i].transform.DOLocalRotate(membres[i].FinalPosition, membres[i].Speed).SetSpeedBased(true);
            }
        else if (context.canceled)
            for (int i = 0; i < membres.Length; i++)
            {
                DOTween.Kill(membres[i].transform);
                membres[i].transform.DOLocalRotate(Vector3.zero, membres[i].Speed).SetSpeedBased(true);
            }
    }
}

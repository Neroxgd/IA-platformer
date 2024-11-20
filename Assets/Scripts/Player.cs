using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class Player : MonoBehaviour
{
    private Membre[] membres;
    private Tween[] membretween;

    private void Start()
    {
        membres = GetComponentsInChildren<Membre>();
        membretween = new Tween[membres.Length];
    }

    public void ButtonAction(InputAction.CallbackContext context)
    {
        if (context.started)
            for (int i = 0; i < membres.Length; i++)
                membretween[i] = membres[i].transform.DOBlendableLocalRotateBy(membres[i].FinalPosition, membres[i].Speed).SetAutoKill(false);
        else if (context.canceled)
            for (int i = 0; i < membres.Length; i++)
                membretween[i].PlayBackwards();
    }
}

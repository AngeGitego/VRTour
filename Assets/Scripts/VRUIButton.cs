using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class VRUIButton : MonoBehaviour
{
    public UnityEvent onPress;

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        onPress.Invoke();
    }
}

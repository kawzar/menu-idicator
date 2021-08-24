using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    [SerializeField]
    private Image selectionPointer;

    public void OnClick()
    {
        // TODO 
    }

    public void OnDeselect(BaseEventData eventData)
    {
        selectionPointer.color = Color.clear;
    }

    public void OnSelect(BaseEventData eventData)
    {
        selectionPointer.color = Color.white;
    }
}

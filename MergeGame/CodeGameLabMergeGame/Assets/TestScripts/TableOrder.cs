using UnityEngine;
using UnityEngine.EventSystems;

public class TableOrder : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        var otherItemTransform = eventData.pointerDrag.transform;
        var item = transform.GetChild(0).gameObject;

        if (otherItemTransform.gameObject.CompareTag("4") && item.CompareTag("4"))
            item.SetActive(true);

        else if (otherItemTransform.gameObject.CompareTag("8") && item.CompareTag("8"))
            item.SetActive(true);

    }
}

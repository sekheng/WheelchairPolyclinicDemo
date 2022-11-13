using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MainMenuIconEnlarger : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] private Vector2 _newScale;

    private Vector2 _oldScale = new Vector2(1,1);


    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(_newScale, .5f);
        transform.GetChild(0).gameObject.SetActive(true);
        transform.SetAsLastSibling();
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(_oldScale, .5f);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.SetAsFirstSibling();
    }

}

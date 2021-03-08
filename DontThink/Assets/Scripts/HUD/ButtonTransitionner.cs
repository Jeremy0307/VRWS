using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonTransitionner : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    [SerializeField] private Color32 _normalColor = Color.white;
    [SerializeField] private Color32 _hoverColor = Color.grey;
    [SerializeField] private Color32 _downColor = Color.white;

    private Image _image = null;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        print("Enter");

        _image.color = _downColor;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        print("Exit");
        _image.color = _normalColor;
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        print("Down");
        _image.color = _downColor;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        print("Up");
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        print("Click");
    }
}

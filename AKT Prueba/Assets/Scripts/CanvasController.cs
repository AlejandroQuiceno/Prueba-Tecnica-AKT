using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class CanvasController : MonoBehaviour
{
    [SerializeField] private RectTransform[] vistas;
    [SerializeField] private RectTransform posicionFuera;
    [SerializeField] private RectTransform posicionAdentro;
    [SerializeField] Ease easing;
    public void CambiarVista1()
    {
        Debug.Log(posicionFuera.position);
        vistas[0].DOAnchorPos(posicionFuera.anchoredPosition, 1f).SetEase(easing);
        vistas[1].DOAnchorPos(posicionAdentro.anchoredPosition, 1f).SetEase(easing);
    }
}

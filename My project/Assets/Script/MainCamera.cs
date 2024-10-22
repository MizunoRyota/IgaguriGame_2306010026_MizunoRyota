using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Camera mainCamera; // ƒJƒƒ‰‚ª’Ç]‚·‚é‘ÎÛ
    public Camera EffectCamera ;
    public float  transitionDirection = 0.125f; // ƒJƒƒ‰‚ÌˆÚ“®‚ÌŠŠ‚ç‚©‚³
    public Vector3 strPosition = new Vector3(0,0,0);
    public Vector3 endPotation = new Vector3(-53,26,-100);

    void Start()
    {
        StartCoroutine(CameraTransition());
    }
    private IEnumerator CameraTransition()
    {
        mainCamera.enabled = false;
        EffectCamera.enabled = true;
        EffectCamera.transform.position = strPosition;
        float elapsedTime = 0f;
        while (elapsedTime < transitionDirection)
        {
            EffectCamera.transform.position = Vector3.Lerp(strPosition, endPotation, elapsedTime / transitionDirection);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        mainCamera.enabled = true;
        EffectCamera.enabled=false;
    }
}

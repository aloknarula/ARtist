using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawMarker : MonoBehaviour
{
    // Public //
    public Slider m_slider;
    public Image m_image;
    public Canvas m_3dCanvas;
    // Protected //
    // Private //
    // Access //

    void Start()
    {
        
        m_3dCanvas.worldCamera = CameraRenderTexture.Instance.m_mainCamera;
    }

    public void OnValueChange(float value)
    {
        m_image.color = new Color(1f, 1f, 1f, value);
    }
}

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

        Vector3 camVec = transform.position - CameraRenderTexture.Instance.m_camera.transform.position;
        camVec.y = 0f;

        transform.LookAt(transform.position - camVec.normalized);
    }

    public void OnValueChange(float value)
    {
        m_image.color = new Color(1f, 1f, 1f, value);
    }
}

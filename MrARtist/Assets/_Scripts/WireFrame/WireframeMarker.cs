using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WireframeMarker : MonoBehaviour
{
    // Public //
    public GameObject m_glass;
    public GameObject m_glassWireframe;
    public GameObject m_paper;
    public Canvas m_3dCanvas;
    // Protected //
    // Private //
    // Access //

    void Start()
    {
        m_3dCanvas.worldCamera = CameraRenderTexture.Instance.m_mainCamera;
    }

    public void OnSetButton()
    {
        CameraRenderTexture.Instance.m_camera.enabled = false;
        m_paper.SetActive(true);
        m_glass.SetActive(false);
        m_glassWireframe.SetActive(false);

        Vector3 camVec = m_paper.transform.position - CameraRenderTexture.Instance.m_camera.transform.position;
        camVec.y = 0f;

        m_paper.transform.LookAt(m_paper.transform.position - camVec.normalized);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRenderTexture : MonoBehaviour
{
    // Public //
    public Camera m_mainCamera;
    public Camera m_camera;
    // Protected //
    // Private //
    // Access //
    public static CameraRenderTexture Instance { get; private set; }

    void Awake()
    {
        Instance = this;
    }

    private void OnDestroy()
    {
        Instance = null;
    }
}

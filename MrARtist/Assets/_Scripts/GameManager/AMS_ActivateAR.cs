using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class AMS_ActivateAR : AppManagerState
{
    // Public //
    public ARPlaneManager m_planeManager;
    // Protected //
    // Private //
    // Access //

    public override void OnEnter()
    {
        base.OnEnter();
        m_planeManager.planesChanged += PlanesChanged;
    }

    void PlanesChanged(ARPlanesChangedEventArgs args)
    {
        m_stateMachine.RequestState(ExitState);
    }

    public override void OnExit()
    {
        base.OnExit();
        m_planeManager.planesChanged -= PlanesChanged;
    }
}

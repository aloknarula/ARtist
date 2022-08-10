using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SketchSelection : MonoBehaviour
{
    // Public //
    // Protected //
    // Private //
    // Access //
    public static SketchType SketchTypeKyaHai;

    public enum SketchType
    {
        WireFrame,
        Sketch
    }

    void Start()
    {
        
    }

    public void Load(int type)
    {
        SketchTypeKyaHai = (SketchType)type;
        SceneManager.LoadScene(1);
    }


    void Update()
    {
        
    }
}

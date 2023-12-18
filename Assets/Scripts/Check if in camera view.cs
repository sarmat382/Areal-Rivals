using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkifincameraview : MonoBehaviour
{
     Camera camera;
    MeshRenderer renderer;
    Plane[] cameraFrustum;
    Collider collider; 

    
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        renderer = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        var bounds = collider.bounds;
        cameraFrustum = GeometryUtility.CalculateFrustumPlanes(camera);
        if (GeometryUtility.TestPlanesAABB(cameraFrustum,bounds))
        {
            Debug.Log("Les goooo!!!!");
        }
    }
}

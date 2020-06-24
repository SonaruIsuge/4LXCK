using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWarScript : MonoBehaviour
{
    public GameObject FogOfWarPlane;
    public Transform playerTrans;
    public LayerMask fogLayer;
    public float radius = 5.0f;
    private float radsqr;

    private Mesh f_mesh;
    private Vector3[] vertices;
    private Color[] f_color;

    // Start is called before the first frame update
    void Start()
    {
        radsqr = radius * radius;
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        Ray r = new Ray(transform.position, playerTrans.position - transform.position);
        
        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 playerv = playerTrans.position;
            playerv.y = 20f;
            Vector3 v = FogOfWarPlane.transform.TransformPoint(vertices[i]);
            float dist = Vector3.SqrMagnitude(v - playerv);
            if (dist < radsqr)
            {
                float alpha = Mathf.Min(f_color[i].a, dist / radsqr);
                f_color[i].a = alpha;
            }
        }
        updateColor();
        
    }
    //void Update()
    //{
    //    Vector3 playerv = playerTrans.position;
    //    for (int i = 0; i < vertices.Length; i++)
    //    {
    //        playerv.y = 20f;
    //        Vector3 v = FogOfWarPlane.transform.TransformPoint(vertices[i]);
    //        float dist = Vector3.SqrMagnitude(v - playerv);
    //        if (dist < radius)
    //        {
    //            //float alpha = Mathf.Min(f_color[i].a, dist / radsqr);
    //            f_color[i].a = 0f;
    //            Debug.Log("ASADASd");
    //        }
    //    }
    //    updateColor();
    //}

    void Initialize()
    {
        f_mesh = FogOfWarPlane.GetComponent<MeshFilter>().mesh;
        vertices = f_mesh.vertices;
        f_color = new Color[vertices.Length];
        for (int i = 0; i < vertices.Length; i++)
        {
            f_color[i] = Color.black;
        }
    }

    void updateColor()
    {
        f_mesh.colors = f_color;
    }
}

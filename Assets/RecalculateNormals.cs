using UnityEngine;

public class RecalculateNormals : MonoBehaviour
{
    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter != null)
        {
            Mesh originalMesh = meshFilter.sharedMesh;
            Mesh newMesh = new Mesh();
            newMesh.vertices = originalMesh.vertices;
            newMesh.triangles = originalMesh.triangles;
            newMesh.uv = originalMesh.uv;
            newMesh.colors = originalMesh.colors;
            newMesh.RecalculateNormals();
            meshFilter.mesh = newMesh;
        }
    }
}
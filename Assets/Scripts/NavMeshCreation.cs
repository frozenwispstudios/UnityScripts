using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshCreation : MonoBehaviour
{
    [Header("NavMesh Surface")]
    public NavMeshSurface surface;

    // Start is called before the first frame update
    void Start()
    {
        surface = FindObjectOfType<NavMeshSurface>();
        /// <summary>
        /// Call this to create a navmesh after the world has finished being created.
        /// This is useful for Procedural Generated Worlds.
        /// </summary>
        surface.BuildNavMesh();
    }
}

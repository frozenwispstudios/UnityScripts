using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFollowCamera : Health
{
    [SerializeField] private GameObject _canvasBar;
    private Camera _camera;

    private void Start()
    {
        base.Start();
        _camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        UILookAtScreen();
    }

    private void UILookAtScreen()
    {
        _canvasBar.gameObject.transform.LookAt(_camera.transform);
    }
}

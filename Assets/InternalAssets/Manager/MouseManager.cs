using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public static MouseManager Instance;

    [SerializeField] private TextMesh _textMesh;
    [SerializeField] private Vector2 _textShiftCenter;
    [SerializeField] private Camera _camera;


    private void Start()
    {
        Instance = this;
        _camera = Camera.main;
    }

    public void TextInfo(string text)
    {
        _textMesh.text = text;
    }
    private void Update()
    {
        Vector2 position = _camera.ScreenToWorldPoint(Input.mousePosition);
        _textMesh.transform.position = position + _textShiftCenter;
    }
}

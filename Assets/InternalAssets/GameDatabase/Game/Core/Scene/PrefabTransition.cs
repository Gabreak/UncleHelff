using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;

public class PrefabTransition : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;


    private void OnMouseDown()
    {
        LoadManager.OpenPrefab(gameObject, _prefab);
    }
}

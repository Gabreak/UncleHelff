using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    public static void OpenPrefab(GameObject current, GameObject open)
    {
        Instantiate(open);
        Destroy(current);
    }
}

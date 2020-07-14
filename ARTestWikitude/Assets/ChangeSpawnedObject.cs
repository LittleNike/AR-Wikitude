using System.Collections.Generic;
using UnityEngine;
using Wikitude;

public class ChangeSpawnedObject : MonoBehaviour
{
    [SerializeField] private List<GameObject> _objects = new List<GameObject>();

    public void OnObjectRecognized(ObjectTarget recognizedObject)
    {
        foreach (GameObject o in _objects)
            if (o.name == recognizedObject.Name)
            {
                GameObject g = Instantiate(o, transform);
                g.transform.parent = recognizedObject.Drawable.transform;
            }
    }

    public void TrackTest(ImageTarget recognizedObject)
    {
        Debug.LogError($"[Unity] {recognizedObject.Name}");
    }
}

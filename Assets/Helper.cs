using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour {

    public static IMoveable TestIfMoveable(GameObject obj)
    {
        var scripts = obj.GetComponents<MonoBehaviour>();
        foreach (var script in scripts)
        {
            if (script is IMoveable)
                return (IMoveable)script;
        }
        return null;
    }
}

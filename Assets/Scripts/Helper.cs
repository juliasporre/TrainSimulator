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

    public static IParkBreaks TestIfParkBreaks(GameObject obj) {
        var scripts = obj.GetComponents<MonoBehaviour>();
        foreach (var script in scripts) {
            if (script is IParkBreaks)
                return (IParkBreaks)script;
        }
        return null;
    }

	public static IBackForward TestIfBackForward(GameObject obj) {
		var scripts = obj.GetComponents<MonoBehaviour>();
		foreach (var script in scripts) {
			if (script is IBackForward)
				return (IBackForward)script;
		}
		return null;
	}
}

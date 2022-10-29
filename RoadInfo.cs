using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu( menuName = "White Wolf/2D Level Generator/Road Info")]
public class RoadInfo : ScriptableObject {

    [SerializeField] private RoadParts[] values;

    public Dictionary<string, GameObject> Get(){

        var toReturn = new Dictionary<string, GameObject>();

        foreach ( var entry in values )
            toReturn.TryAdd( entry.key, entry.@object );

        return toReturn;

    }

}

[System.Serializable]
public struct RoadParts {

    public string key;
    public GameObject @object;

}
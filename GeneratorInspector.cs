using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Generator))]
public class GeneratorInspector : Editor {

    public override void OnInspectorGUI(){
        
        base.OnInspectorGUI();

        Generator generator = (Generator)target;

        GUILayout.BeginHorizontal();

        if ( GUILayout.Button( "Generate Map" ) ) 
            generator.Generate();

        GUILayout.EndHorizontal();
        
    }

}
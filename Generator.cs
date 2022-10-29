using UnityEngine;

[System.Serializable]
public class Elements {

    public string name;
    [Space]
    public Color color;
    public GameObject element;

}

public class Generator : MonoBehaviour {
    
    [Space]
    [SerializeField] private Texture2D map;
    [SerializeField] private  Transform level;
    [Space]
    [SerializeField] private  Elements[] elements;
    [Space]
    [SerializeField] private Color roadColor;
    [SerializeField] private DictionaryGameObjects roads;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    private int _posX, _posY;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void Start() => Generate();

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public void Generate(){
        
        _posX = -( map.width / 2 );
        _posY = -( map.height / 2 );

        for ( var x=0; x<map.width; x++ ) 
            for ( var y=0; y<map.height; y++ ) 
                GenerateTile( x, y );

    }

    private void GenerateTile( int x, int y ){

        var pixelColor = map.GetPixel( x, y );

        if ( pixelColor.a == 0 ){ return; }

        if ( pixelColor == roadColor )
            Road( x, y );
        
        else {
            
            foreach ( var element in elements ){

                if ( element.color.Equals( pixelColor ) ){

                    var pos = new Vector2( _posX + x, _posY + y );
                    var obj = Instantiate( element.element, pos, Quaternion.identity, level );
                    obj.name = element.name;

                }

            }
            
        }

    }
    
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    private void Road( int x, int y ){
        
        var key = ""; // string

        if ( ( x >= 0 && y >= 0 ) && map.GetPixel( x, y ) == roadColor ){
            
            if ( map.GetPixel( x, y+1 ) == roadColor )
                key += "1";

            if ( map.GetPixel( x+1, y ) == roadColor )
                key += "2";

            if ( map.GetPixel( x, y-1 ) == roadColor )
                key += "3";

            if ( map.GetPixel( x-1, y ) == roadColor )
                key += "4";

            var blockObj = Instantiate( roads.Get()[ key ], new Vector3( _posX + x, _posY + y, 0 ), Quaternion.identity, level );
            blockObj.name = $"Road_{key}";

        }

    }

}
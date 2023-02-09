using UnityEngine;

namespace AdOns
{
    public static class Extensions
    {
        
        public static bool InfiniteCameraCanSeePoint(Vector3 point)
        {
            var viewportPoint = UIManager.MainCamera.WorldToViewportPoint(point);
            return (viewportPoint.z > 0 && (new Rect(0, 0, 1, 1)).Contains(viewportPoint));
        }

        public static float RandomInVector2(Vector2 vector2) => Random.Range(vector2.x, vector2.y);

        public static Color ConvertHexToColor( this string hex )
        {
            hex = hex.Replace ("0x", ""); // ★彡[ in case the string is formatted 0xFFFFFF ]彡★
            hex = hex.Replace ("#", ""); // ★彡[ in case the string is formatted #FFFFFF ]彡★
        
            var red = byte.Parse( hex.Substring( 0, 2 ), System.Globalization.NumberStyles.HexNumber );
            var green = byte.Parse( hex.Substring( 2, 2 ), System.Globalization.NumberStyles.HexNumber );
            var blue = byte.Parse( hex.Substring( 4, 2 ), System.Globalization.NumberStyles.HexNumber );
            var alpha = (byte)255;
        
            // ★彡[ Only use alpha if the string has enough characters ]彡★
            if( hex.Length == 8 )
                alpha = byte.Parse( hex.Substring( 6, 2 ), System.Globalization.NumberStyles.HexNumber ); 

            return new Color32(red,green,blue,alpha);
        }
       
        internal static bool UnityEditor
        {
            get
            {
#if UNITY_EDITOR
                return true;
#endif
                return false;
            }
        }
    }
}

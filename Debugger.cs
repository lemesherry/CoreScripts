using System;
using UnityEngine;
namespace AdOns
{
    public static class Debugger
    {
        public static void LogWarning( string warning )
        {
            PrintInEditor( $"WARNING: {warning}","E9A755" );
        }

        public static void LogInfo( string info )
        {
            PrintInEditor( info,"669CFF" );
        }

        public static void LogStatus( string status )
        {
            PrintInEditor( status,"669CFF" );
        }

        public static void LogProminently( string prominentMsg )
        {
            PrintInEditor( prominentMsg,"FF62DA" );
        }

        public static void LogError( string error )
        {
            PrintInEditor( error,"CC423B" );
        }

        public static void Log( string msg )
        {
#if UNITY_EDITOR
            Debug.Log( msg );
#endif
        }


        static void PrintInEditor( string msg, string colorCode )
        {
#if UNITY_EDITOR
            Debug.Log( $"<color=#{colorCode}>{msg}</color>" );
#endif
        }
    }

}


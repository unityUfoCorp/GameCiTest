using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

public class BuildScript : MonoBehaviour
{


static Dictionary<string, string> arguments = new Dictionary<string, string>();

    public static void PerformBuild()
    {

        string message = "";
                  arguments = GetCommandlineArgs();
          if (arguments.TryGetValue("-mode", out string mode))
        message = "i like to ride ";
        Debug.Log(message + mode);
        //Debug.LogError(message + mode);

//          string file = Path.Combine(GetCurrentDirectory(), "myfile.txt");
//             using (File.Create(file));
//         Debug.Log("myfile is " + file);


    //     EditorUserBuildSettings.exportAsGoogleAndroidProject = true;
    //     string[] defaultScene ={ "Assets/Scenes/MainScene.unity" };
    //   //  BuildPipeline.BuildPlayer(defaultScene,"./builds/windows",BuildTarget.StandaloneWindows,BuildOptions.None);
    //     BuildPipeline.BuildPlayer(defaultScene,"./builds/Android",BuildTarget.Android,BuildOptions.AcceptExternalModificationsToPlayer);
      //AssetDatabase.Refresh();
    }


     private static Dictionary<string, string> GetCommandlineArgs()
   {
       Dictionary<string, string> argDictionary = new Dictionary<string, string>();

       var args = System.Environment.GetCommandLineArgs();

       for (int i = 0; i < args.Length; ++i)
       {
           var arg = args[i].ToLower();
           if (arg.StartsWith("-"))
           {
               var value = i < args.Length - 1 ? args[i + 1].ToLower() : null;
               value = (value?.StartsWith("-") ?? false) ? null : value;

               argDictionary.Add(arg, value);
           }
       }
       return argDictionary;
   }
}




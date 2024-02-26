using System.Diagnostics;
using UnityEditor;
using UnityEngine;

namespace Gamebok.GeneralUtilities.Editor
{
    public static class OpenTerminal
    {
        private static readonly string ProjectPath = Application.dataPath + "/..";
    
#if UNITY_EDITOR_WIN
        private const string WindowsTerminalPath = "wt";
    
        [MenuItem("Superplay/Utility/Open Terminal/Windows Terminal", priority = 0)]
        private static void OpenWindowsTerminal()
        {
            Process.Start(WindowsTerminalPath, $@"-d ""{ProjectPath}""");
        }

        [MenuItem("Superplay/Utility/Open Terminal/Command Prompt", priority = 1)]
        private static void OpenCmd()
        {
            Process.Start("cmd.exe", $@"/K cd /d ""{ProjectPath}""");
        }
#endif
    }
}



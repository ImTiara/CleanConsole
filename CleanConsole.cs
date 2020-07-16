using MelonLoader;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CleanConsole
{
    public static class BuildInfo
    {
        public const string Name = "CleanConsole";
        public const string Author = "ImTiara";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class CleanConsole : MelonMod
    {
        public unsafe override void OnApplicationStart()
        {
            string[] methods = {
                "NativeMethodInfoPtr_WriteLine_Public_Static_Void_Object_0",
                "NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_0",
                "NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_Object_Object_0"
            };

            foreach(string name in methods)
                Hook((IntPtr)(&*(IntPtr*)(IntPtr)typeof(Il2CppSystem.Console).GetField(name,
                    BindingFlags.NonPublic | BindingFlags.Static).GetValue(null)),
                    Marshal.GetFunctionPointerForDelegate(new Action(() => { })));

        }

        public static void Hook(IntPtr _old, IntPtr _new) => typeof(Imports).GetMethod("Hook", Harmony.AccessTools.all).Invoke(null, new object[] { _old, _new });
    }
}
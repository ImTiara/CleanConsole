using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(CleanConsole.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(CleanConsole.BuildInfo.Company)]
[assembly: AssemblyProduct(CleanConsole.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + CleanConsole.BuildInfo.Author)]
[assembly: AssemblyTrademark(CleanConsole.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(CleanConsole.BuildInfo.Version)]
[assembly: AssemblyFileVersion(CleanConsole.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonModInfo(typeof(CleanConsole.CleanConsole), CleanConsole.BuildInfo.Name, CleanConsole.BuildInfo.Version, CleanConsole.BuildInfo.Author, CleanConsole.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonModGame("VRChat", "VRChat")]
using System;
using System.Linq;
using UnityEditor;
using UnityEditor.Build.Player;

namespace CompileTester
{
    public class Tester
    {
        public static void Test(BuildTarget buildTarget, ScriptCompilationOptions scriptCompilationOptions = ScriptCompilationOptions.None, string[] extraScriptingDefines = null)
        {
            var options = new ScriptCompilationSettings
            {
                target = buildTarget,
                group = BuildPipeline.GetBuildTargetGroup(buildTarget),
                options = scriptCompilationOptions,
                extraScriptingDefines = extraScriptingDefines,
            };

            var result = PlayerBuildInterface.CompilePlayerScripts(options, "Temp/CompileTester");

            if (!result.assemblies.Any() && result.typeDB == null)
            {
                throw new Exception();
            }
        }
    }
}

using UnityEditor;

namespace CompileTester
{
    public class DefaultTests
    {
        public static void CurrentPlatform()
        {
            Tester.Test(EditorUserBuildSettings.activeBuildTarget);
        }
        
        public static void StandaloneWindows()
        {
            Tester.Test(BuildTarget.StandaloneWindows);
        }

        public static void StandaloneWindows64()
        {
            Tester.Test(BuildTarget.StandaloneWindows64);
        }

        public static void StandaloneOSX()
        {
            Tester.Test(BuildTarget.StandaloneOSX);
        }
        
        public static void iOS()
        {
            Tester.Test(BuildTarget.iOS);
        }
        
        public static void Android()
        {
            Tester.Test(BuildTarget.Android);
        }
    }
}

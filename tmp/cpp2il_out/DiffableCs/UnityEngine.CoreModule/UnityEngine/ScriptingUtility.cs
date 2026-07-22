namespace UnityEngine;

internal class ScriptingUtility
{
	private struct TestClass
	{
		public int value; //Field offset: 0x0

	}


	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	private static bool IsManagedCodeWorking() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	private static void SetupCallbacks(IntPtr p) { }

}


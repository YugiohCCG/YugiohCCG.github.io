namespace System.Threading.Tasks;

[Extension]
internal static class TaskAwaiters
{

	[CallerCount(Count = 778)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static ForceAsyncAwaiter ForceAsync(Task task) { }

}


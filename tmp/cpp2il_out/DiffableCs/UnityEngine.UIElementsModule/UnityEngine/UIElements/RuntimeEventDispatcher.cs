namespace UnityEngine.UIElements;

internal static class RuntimeEventDispatcher
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatcher), Member = "CreateDefault", ReturnType = typeof(EventDispatcher))]
	public static EventDispatcher Create() { }

}


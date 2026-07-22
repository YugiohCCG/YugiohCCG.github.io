namespace UnityEngine;

public sealed class ExitGUIException : Exception
{

	[CalledBy(Type = typeof(GUIUtility), Member = "ExitGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	public ExitGUIException() { }

}


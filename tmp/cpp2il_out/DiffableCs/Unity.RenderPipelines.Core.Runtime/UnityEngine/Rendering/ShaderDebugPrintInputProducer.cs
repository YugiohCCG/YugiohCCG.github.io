namespace UnityEngine.Rendering;

public static class ShaderDebugPrintInputProducer
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "ReadValue", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static ShaderDebugPrintInput Get() { }

}


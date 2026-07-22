namespace UnityEngine.Rendering;

public class MousePositionDebug
{
	private static MousePositionDebug s_Instance; //Field offset: 0x0

	public static MousePositionDebug instance
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MousePositionDebug() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Build() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Cleanup() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static MousePositionDebug get_instance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "ReadValue", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	private Vector2 GetInputMousePosition() { }

	[CallerCount(Count = 43)]
	public Vector2 GetMouseClickPosition(float ScreenHeight) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "ReadValue", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	public Vector2 GetMousePosition(float ScreenHeight, bool sceneView) { }

}


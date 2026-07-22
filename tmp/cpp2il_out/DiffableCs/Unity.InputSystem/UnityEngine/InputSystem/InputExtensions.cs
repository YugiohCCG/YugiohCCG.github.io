namespace UnityEngine.InputSystem;

[Extension]
public static class InputExtensions
{

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsActive(TouchPhase phase) { }

	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "UpdateTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TouchPhase), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsEndedOrCanceled(TouchPhase phase) { }

	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static bool IsInProgress(InputActionPhase phase) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsModifierKey(Key key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsTextInputKey(Key key) { }

}


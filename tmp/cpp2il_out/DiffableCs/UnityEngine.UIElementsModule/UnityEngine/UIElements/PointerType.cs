namespace UnityEngine.UIElements;

public static class PointerType
{
	public static readonly string mouse; //Field offset: 0x0
	public static readonly string touch; //Field offset: 0x8
	public static readonly string pen; //Field offset: 0x10
	public static readonly string unknown; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private static PointerType() { }

	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(Vector2), typeof(int)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	internal static string GetPointerType(int pointerId) { }

	[CalledBy(Type = typeof(PointerUpEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCancelEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool IsDirectManipulationDevice(string pointerType) { }

}


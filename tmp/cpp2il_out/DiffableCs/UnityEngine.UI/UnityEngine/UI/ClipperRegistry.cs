namespace UnityEngine.UI;

public class ClipperRegistry
{
	private static ClipperRegistry s_Instance; //Field offset: 0x0
	private readonly IndexedSet<IClipper> m_Clippers; //Field offset: 0x10

	public static ClipperRegistry instance
	{
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClipperRegistry), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClipperRegistry), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClipperRegistry), Member = "Disable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(IndexedSet`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 241
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IndexedSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected ClipperRegistry() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IndexedSet`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Cull() { }

	[CalledBy(Type = typeof(RectMask2D), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "DisableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void Disable(IClipper c) { }

	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "Disable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(IndexedSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static ClipperRegistry get_instance() { }

	[CalledBy(Type = typeof(RectMask2D), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "AddUnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void Register(IClipper c) { }

	[CalledBy(Type = typeof(RectMask2D), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void Unregister(IClipper c) { }

}


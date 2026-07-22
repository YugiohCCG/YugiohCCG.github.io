namespace TMPro;

internal static class TMP_ListPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <.cctor>b__3_0(List<T> l) { }

	}

	private static readonly TMP_ObjectPool<List`1<T>> s_ListPool; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	[DeduplicatedMethod]
	private static TMP_ListPool`1() { }

	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "GetMaterialForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskableGraphic), typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetCanvas", ReturnType = typeof(Canvas))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static List<T> Get() { }

	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "GetMaterialForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskableGraphic), typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetCanvas", ReturnType = typeof(Canvas))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static void Release(List<T> toRelease) { }

}


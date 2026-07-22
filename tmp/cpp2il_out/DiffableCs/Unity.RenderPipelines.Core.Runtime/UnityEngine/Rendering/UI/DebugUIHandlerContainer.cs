namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerContainer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public DebugUIHandlerWidget widget; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass3_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <IsDirectChild>b__0(DebugUIHandlerWidget x) { }

	}

	[SerializeField]
	public RectTransform contentHolder; //Field offset: 0x20

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerContainer() { }

	[CalledBy(Type = typeof(DebugUIHandlerContainer), Member = "GetFirstItem", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerContainer), Member = "GetLastItem", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerContainer), Member = "IsDirectChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private List<DebugUIHandlerWidget> GetActiveChildren() { }

	[CalledBy(Type = typeof(DebugUIHandlerBitField), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerVector3), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerVector2), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerRenderingLayerField), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerPanel), Member = "GetFirstItem", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerVBox), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerGroup), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerFoldout), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "ActivatePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerHBox), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DebugUIHandlerContainer), Member = "GetActiveChildren", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.UI.DebugUIHandlerWidget>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DebugUIHandlerWidget GetFirstItem() { }

	[CalledBy(Type = typeof(DebugUIHandlerBitField), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerFoldout), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerGroup), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerHBox), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerRenderingLayerField), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVBox), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVector2), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVector3), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DebugUIHandlerContainer), Member = "GetActiveChildren", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.UI.DebugUIHandlerWidget>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DebugUIHandlerWidget GetLastItem() { }

	[CalledBy(Type = typeof(DebugUIHandlerVector2), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerBitField), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerFoldout), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerGroup), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerHBox), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerRenderingLayerField), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVBox), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVector3), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DebugUIHandlerContainer), Member = "GetActiveChildren", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.UI.DebugUIHandlerWidget>))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsDirectChild(DebugUIHandlerWidget widget) { }

}


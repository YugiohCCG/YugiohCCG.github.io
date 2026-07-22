namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerVBox : DebugUIHandlerWidget
{
	private DebugUIHandlerContainer m_Container; //Field offset: 0x60

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerVBox() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugUIHandlerContainer), Member = "GetFirstItem", ReturnType = typeof(DebugUIHandlerWidget))]
	[Calls(Type = typeof(DebugUIHandlerWidget), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CallsUnknownMethods(Count = 1)]
	public virtual DebugUIHandlerWidget Next() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerContainer), Member = "IsDirectChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugUIHandlerContainer), Member = "GetLastItem", ReturnType = typeof(DebugUIHandlerWidget))]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "ChangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerWidget), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void SetWidget(Widget widget) { }

}


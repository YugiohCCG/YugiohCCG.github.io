namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerObjectPopupField : DebugUIHandlerField<ObjectPopupField>
{
	private int m_Index; //Field offset: 0x88

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerField`1), Member = ".ctor", ReturnType = typeof(void))]
	public DebugUIHandlerObjectPopupField() { }

	[CalledBy(Type = typeof(DebugUIHandlerObjectPopupField), Member = "OnIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerObjectPopupField), Member = "OnDecrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void ChangeSelectedObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerObjectPopupField), Member = "ChangeSelectedObject", ReturnType = typeof(void))]
	public virtual void OnDecrement(bool fast) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerObjectPopupField), Member = "ChangeSelectedObject", ReturnType = typeof(void))]
	public virtual void OnIncrement(bool fast) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerField`1), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
	internal virtual void SetWidget(Widget widget) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(DebugUIHandlerField`1), Member = "SetLabelText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void UpdateValueLabel() { }

}


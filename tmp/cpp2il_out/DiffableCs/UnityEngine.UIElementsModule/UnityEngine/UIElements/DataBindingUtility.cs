namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class DataBindingUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal TypePathVisitor <.cctor>b__23_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TypePathVisitor), Member = "Reset", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <.cctor>b__23_1(TypePathVisitor v) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AutoCompletePathVisitor), Member = ".ctor", ReturnType = typeof(void))]
		internal AutoCompletePathVisitor <.cctor>b__23_2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AutoCompletePathVisitor), Member = "Reset", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <.cctor>b__23_3(AutoCompletePathVisitor v) { }

	}

	private static readonly ObjectPool<TypePathVisitor> k_TypeVisitors; //Field offset: 0x0
	private static readonly ObjectPool<AutoCompletePathVisitor> k_AutoCompleteVisitors; //Field offset: 0x8
	private static readonly Regex s_ReplaceIndices; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private static DataBindingUtility() { }

	[CalledBy(Type = typeof(VisualElement), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Binding&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingRequest>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.UIElements.DataBindingManager+BindingRequest")]
	[Calls(Type = typeof(BindingId), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.DataBindingManager+BindingDataCollection", Member = "TryGetBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(BindingId))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	public static bool TryGetBinding(VisualElement element, in BindingId bindingId, out BindingInfo bindingInfo) { }

}


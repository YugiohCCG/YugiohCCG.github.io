namespace UnityEngine.UIElements;

internal class BindingUpdater
{
	private sealed class CastDataSourceVisitor : ConcreteTypeVisitor
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private DataBinding <Binding>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private BindingContext <bindingContext>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private BindingResult <result>k__BackingField; //Field offset: 0x150

		public DataBinding Binding
		{
			[CallerCount(Count = 106)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public BindingContext bindingContext
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 get { } //Length: 144
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			 set { } //Length: 140
		}

		public BindingResult result
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 14
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			 set { } //Length: 24
		}

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CastDataSourceVisitor() { }

		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public DataBinding get_Binding() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public BindingContext get_bindingContext() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public BindingResult get_result() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public void Reset() { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_Binding(DataBinding value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		public void set_bindingContext(BindingContext value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		public void set_result(BindingResult value) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		protected virtual void VisitContainer(ref TContainer container) { }

	}

	private sealed class UIPathVisitor : PathVisitor
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private DataBinding <binding>k__BackingField; //Field offset: 0xB8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private BindingUpdateStage <direction>k__BackingField; //Field offset: 0xC0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private BindingContext <bindingContext>k__BackingField; //Field offset: 0xC8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private BindingResult <result>k__BackingField; //Field offset: 0x200

		public DataBinding binding
		{
			[CallerCount(Count = 17)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 19
		}

		public BindingContext bindingContext
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 get { } //Length: 146
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			 set { } //Length: 143
		}

		public BindingUpdateStage direction
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 7
		}

		public BindingResult result
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 14
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			 set { } //Length: 24
		}

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public UIPathVisitor() { }

		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public DataBinding get_binding() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public BindingContext get_bindingContext() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public BindingUpdateStage get_direction() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public BindingResult get_result() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PathVisitor), Member = "Reset", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public virtual void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_binding(DataBinding value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		public void set_bindingContext(BindingContext value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_direction(BindingUpdateStage value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		public void set_result(BindingResult value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		protected virtual void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

	}

	private static readonly CastDataSourceVisitor s_VisitDataSourceAsRootVisitor; //Field offset: 0x0
	private static readonly UIPathVisitor s_VisitDataSourceAtPathVisitor; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static BindingUpdater() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BindingUpdater() { }

	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	internal static string GetExtractValueErrorString(VisitReturnCode returnCode, object target, in PropertyPath path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static string GetRootDataSourceError(object target) { }

	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	internal static string GetVisitationErrorString(VisitReturnCode returnCode, in BindingContext context) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	public bool ShouldProcessBindingAtStage(Binding bindingObject, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private bool ShouldProcessBindingAtStage(CustomBinding customBinding, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static bool ShouldProcessBindingAtStage(DataBinding dataBinding, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(DataBinding), Member = "get_updateUIMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 44)]
	private static BindingResult TryUpdateUIWithNonContainer(in BindingContext context, DataBinding binding, object value) { }

	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(Binding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingUpdater), Member = "VisitAtPath", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBinding), typeof(BindingUpdateStage), "TContainer&", typeof(PropertyPath&), typeof(BindingContext&)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, Unity.Properties.VisitReturnCode, Unity.Properties.VisitReturnCode, UnityEngine.UIElements.BindingResult>))]
	[Calls(Type = typeof(BindingUpdater), Member = "GetExtractValueErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BindingUpdater), Member = "GetVisitationErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(BindingContext&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private BindingResult UpdateDataSource(in BindingContext context, DataBinding dataBinding) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private BindingResult UpdateDataSource(in BindingContext context, CustomBinding customBinding) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BindingUpdater), Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public BindingResult UpdateSource(in BindingContext context, Binding bindingObject) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private BindingResult UpdateUI(in BindingContext context, CustomBinding customBinding) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public BindingResult UpdateUI(in BindingContext context, Binding bindingObject) { }

	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(Binding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingUpdater), Member = "VisitAtPath", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBinding), typeof(BindingUpdateStage), "TContainer&", typeof(PropertyPath&), typeof(BindingContext&)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, Unity.Properties.VisitReturnCode, Unity.Properties.VisitReturnCode, UnityEngine.UIElements.BindingResult>))]
	[Calls(Type = typeof(BindingUpdater), Member = "GetExtractValueErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BindingUpdater), Member = "GetVisitationErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(BindingContext&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeTraits), Member = "IsContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingUpdater), Member = "VisitRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBinding), typeof(Object&), typeof(BindingContext&)}, ReturnType = typeof(System.ValueTuple`3<System.Boolean, Unity.Properties.VisitReturnCode, UnityEngine.UIElements.BindingResult>))]
	[Calls(Type = typeof(BindingUpdater), Member = "TryUpdateUIWithNonContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding), typeof(object)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private BindingResult UpdateUI(in BindingContext context, DataBinding dataBinding) { }

	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Object&), typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ValueTuple`4<System.Boolean, System.Int32Enum, System.Int32Enum, UnityEngine.UIElements.BindingResult>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Int32Enum", "System.Int32Enum", typeof(BindingResult)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static ValueTuple<Boolean, VisitReturnCode, VisitReturnCode, BindingResult> VisitAtPath(DataBinding dataBinding, BindingUpdateStage direction, ref TContainer container, in PropertyPath path, in BindingContext context) { }

	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Object&), typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ValueTuple`3<System.Boolean, System.Int32Enum, UnityEngine.UIElements.BindingResult>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Int32Enum", typeof(BindingResult)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static ValueTuple<Boolean, VisitReturnCode, BindingResult> VisitRoot(DataBinding dataBinding, ref object container, in BindingContext context) { }

}


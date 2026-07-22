namespace UnityEngine.UIElements;

public struct EasingFunction : IEquatable<EasingFunction>
{
	public class PropertyBag : ContainerPropertyBag<EasingFunction>
	{
		private class ModeProperty : Property<EasingFunction, EasingMode>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			public virtual bool IsReadOnly
			{
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 get { } //Length: 5
			}

			public virtual string Name
			{
				[CallerCount(Count = 31)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 get { } //Length: 5
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public ModeProperty() { }

			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual bool get_IsReadOnly() { }

			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual string get_Name() { }

			[CallerCount(Count = 6)]
			[DeduplicatedMethod]
			public virtual EasingMode GetValue(ref EasingFunction container) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual void SetValue(ref EasingFunction container, EasingMode value) { }

		}


		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public PropertyBag() { }

	}

	private EasingMode m_Mode; //Field offset: 0x0

	public EasingMode mode
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public EasingFunction(EasingMode mode) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(EasingFunction other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public EasingMode get_mode() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(EasingFunction lhs, EasingFunction rhs) { }

	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	public static EasingFunction op_Implicit(EasingMode easingMode) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_mode(EasingMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}


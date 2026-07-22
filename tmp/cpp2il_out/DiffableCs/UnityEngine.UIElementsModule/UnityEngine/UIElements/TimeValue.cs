namespace UnityEngine.UIElements;

public struct TimeValue : IEquatable<TimeValue>
{
	public class PropertyBag : ContainerPropertyBag<TimeValue>
	{
		private class UnitProperty : Property<TimeValue, TimeUnit>
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
			public UnitProperty() { }

			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual bool get_IsReadOnly() { }

			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual string get_Name() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual TimeUnit GetValue(ref TimeValue container) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual void SetValue(ref TimeValue container, TimeUnit value) { }

		}

		private class ValueProperty : Property<TimeValue, Single>
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
			public ValueProperty() { }

			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual bool get_IsReadOnly() { }

			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual string get_Name() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual float GetValue(ref TimeValue container) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual void SetValue(ref TimeValue container, float value) { }

		}


		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public PropertyBag() { }

	}

	private float m_Value; //Field offset: 0x0
	private TimeUnit m_Unit; //Field offset: 0x4

	public TimeUnit unit
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public TimeValue(float value) { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public TimeValue(float value, TimeUnit unit) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(TimeValue other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public TimeUnit get_unit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_value() { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 36)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(TimeValue lhs, TimeValue rhs) { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	public static TimeValue op_Implicit(float value) { }

	[CallerCount(Count = 57)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(TimeValue lhs, TimeValue rhs) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_unit(TimeUnit value) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public void set_value(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}


namespace UnityEngine.UIElements;

public struct Scale : IEquatable<Scale>
{
	public class PropertyBag : ContainerPropertyBag<Scale>
	{
		private class ValueProperty : Property<Scale, Vector3>
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
			public virtual Vector3 GetValue(ref Scale container) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual void SetValue(ref Scale container, Vector3 value) { }

		}


		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public PropertyBag() { }

	}

	private Vector3 m_Scale; //Field offset: 0x0
	private bool m_IsNone; //Field offset: 0xC

	public Vector3 value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 18
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 15
	}

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public Scale(Vector3 scale) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Scale other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector3 get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static Scale Initial() { }

	[CalledBy(Type = typeof(UIDocument), Member = "SetNoTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Scale))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static Scale None() { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(Scale lhs, Scale rhs) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Scale lhs, Scale rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_value(Vector3 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}


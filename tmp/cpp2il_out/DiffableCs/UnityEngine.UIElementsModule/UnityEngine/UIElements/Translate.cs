namespace UnityEngine.UIElements;

public struct Translate : IEquatable<Translate>
{
	public class PropertyBag : ContainerPropertyBag<Translate>
	{
		private class XProperty : Property<Translate, Length>
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
			public XProperty() { }

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
			public virtual Length GetValue(ref Translate container) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual void SetValue(ref Translate container, Length value) { }

		}

		private class YProperty : Property<Translate, Length>
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
			public YProperty() { }

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
			public virtual Length GetValue(ref Translate container) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual void SetValue(ref Translate container, Length value) { }

		}

		private class ZProperty : Property<Translate, Single>
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
			public ZProperty() { }

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
			public virtual float GetValue(ref Translate container) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual void SetValue(ref Translate container, float value) { }

		}


		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		public PropertyBag() { }

	}

	private Length m_X; //Field offset: 0x0
	private Length m_Y; //Field offset: 0x8
	private float m_Z; //Field offset: 0x10
	private bool m_isNone; //Field offset: 0x14

	public Length x
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Length y
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float z
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.ITransform.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate), typeof(float)}, ReturnType = typeof(Translate))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "UpdateValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Translate))]
	[CallerCount(Count = 4)]
	public Translate(Length x, Length y, float z) { }

	[CalledBy(Type = typeof(UIDocument), Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal Translate(Vector3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Translate other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public Length get_x() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Length get_y() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_z() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(UIDocument), Member = "SetNoTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Translate))]
	[CallerCount(Count = 2)]
	public static Translate None() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "IsSame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Translate lhs, Translate rhs) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Translate lhs, Translate rhs) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public void set_x(Length value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_y(Length value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_z(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Length), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual string ToString() { }

}


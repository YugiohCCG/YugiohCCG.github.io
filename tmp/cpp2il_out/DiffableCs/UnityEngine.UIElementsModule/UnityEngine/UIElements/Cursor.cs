namespace UnityEngine.UIElements;

public struct Cursor : IEquatable<Cursor>
{
	public class PropertyBag : ContainerPropertyBag<Cursor>
	{
		private class DefaultCursorIdProperty : Property<Cursor, Int32>
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
			public DefaultCursorIdProperty() { }

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
			public virtual int GetValue(ref Cursor container) { }

			[CallerCount(Count = 0)]
			public virtual void SetValue(ref Cursor container, int value) { }

		}

		private class HotspotProperty : Property<Cursor, Vector2>
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
			public HotspotProperty() { }

			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual bool get_IsReadOnly() { }

			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual string get_Name() { }

			[CallerCount(Count = 0)]
			public virtual Vector2 GetValue(ref Cursor container) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual void SetValue(ref Cursor container, Vector2 value) { }

		}

		private class TextureProperty : Property<Cursor, Texture2D>
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
			public TextureProperty() { }

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
			public virtual Texture2D GetValue(ref Cursor container) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public virtual void SetValue(ref Cursor container, Texture2D value) { }

		}


		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		public PropertyBag() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Texture2D <texture>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <hotspot>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <defaultCursorId>k__BackingField; //Field offset: 0x10

	internal int defaultCursorId
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public Vector2 hotspot
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public Texture2D texture
	{
		[CallerCount(Count = 138)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Cursor other) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal int get_defaultCursorId() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public Vector2 get_hotspot() { }

	[CallerCount(Count = 138)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public Texture2D get_texture() { }

	[CalledBy(Type = typeof(RareData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleCursor), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.Vector2>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.Vector2>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_cursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RareData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RareData), typeof(RareData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RareData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RareData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleCursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor), typeof(StyleCursor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleCursor), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleCursor), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Cursor style1, Cursor style2) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_defaultCursorId(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_hotspot(Vector2 value) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_texture(Texture2D value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}


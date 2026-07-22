namespace UnityEngine.UIElements;

public abstract class TypedUxmlAttributeDescription : UxmlAttributeDescription
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private T <defaultValue>k__BackingField; //Field offset: 0x0

	public T defaultValue
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = typeof(UxmlAssetAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlDoubleAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlUnsignedIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlUnsignedLongAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlLongAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTypeAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlHash128AttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected TypedUxmlAttributeDescription`1() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public T get_defaultValue() { }

	public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_defaultValue(T value) { }

}


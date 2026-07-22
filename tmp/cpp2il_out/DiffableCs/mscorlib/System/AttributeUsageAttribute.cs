namespace System;

[AttributeUsage(AttributeTargets::Class (4), Inherited = True)]
public sealed class AttributeUsageAttribute : Attribute
{
	internal static AttributeUsageAttribute Default; //Field offset: 0x0
	private AttributeTargets _attributeTarget; //Field offset: 0x10
	private bool _allowMultiple; //Field offset: 0x14
	private bool _inherited; //Field offset: 0x15

	public bool AllowMultiple
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool Inherited
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static AttributeUsageAttribute() { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "RetrieveAttributeUsageNoCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeUsageAttribute))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AttributeUsageAttribute(AttributeTargets validOn) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_AllowMultiple() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Inherited() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AllowMultiple(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Inherited(bool value) { }

}


namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class RefreshPropertiesAttribute : Attribute
{
	public static readonly RefreshPropertiesAttribute All; //Field offset: 0x0
	public static readonly RefreshPropertiesAttribute Repaint; //Field offset: 0x8
	public static readonly RefreshPropertiesAttribute Default; //Field offset: 0x10
	private RefreshProperties refresh; //Field offset: 0x10

	public RefreshProperties RefreshProperties
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static RefreshPropertiesAttribute() { }

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RefreshPropertiesAttribute(RefreshProperties refresh) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public RefreshProperties get_RefreshProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool IsDefaultAttribute() { }

}


namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Property (128))]
public sealed class SettingsBindableAttribute : Attribute
{
	public static readonly SettingsBindableAttribute Yes; //Field offset: 0x0
	public static readonly SettingsBindableAttribute No; //Field offset: 0x8
	[CompilerGenerated]
	private readonly bool <Bindable>k__BackingField; //Field offset: 0x10

	public bool Bindable
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static SettingsBindableAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SettingsBindableAttribute(bool bindable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Bindable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}


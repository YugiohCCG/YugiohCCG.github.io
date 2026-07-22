namespace Unity.Properties;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
public class GeneratePropertyBagsForTypesQualifiedWithAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly TypeGenerationOptions <Options>k__BackingField; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public GeneratePropertyBagsForTypesQualifiedWithAttribute(Type type, TypeGenerationOptions options = 6) { }

}


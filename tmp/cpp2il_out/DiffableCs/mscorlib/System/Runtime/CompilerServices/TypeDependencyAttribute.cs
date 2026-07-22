namespace System.Runtime.CompilerServices;

[AttributeUsage(1036, AllowMultiple = True, Inherited = False)]
internal sealed class TypeDependencyAttribute : Attribute
{
	private string typeName; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public TypeDependencyAttribute(string typeName) { }

}


namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = True)]
[RequiredByNativeCode]
public sealed class RequireComponent : Attribute
{
	public Type m_Type0; //Field offset: 0x10
	public Type m_Type1; //Field offset: 0x18
	public Type m_Type2; //Field offset: 0x20

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public RequireComponent(Type requiredComponent) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public RequireComponent(Type requiredComponent, Type requiredComponent2) { }

}


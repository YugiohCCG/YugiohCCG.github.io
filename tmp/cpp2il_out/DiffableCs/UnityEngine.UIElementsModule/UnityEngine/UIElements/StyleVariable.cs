namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleVariable
{
	public readonly string name; //Field offset: 0x0
	public readonly StyleSheet sheet; //Field offset: 0x8
	public readonly StyleValueHandle[] handles; //Field offset: 0x10

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public StyleVariable(string name, StyleSheet sheet, StyleValueHandle[] handles) { }

	[CalledBy(Type = typeof(StyleVariableContext), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleVariable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

}


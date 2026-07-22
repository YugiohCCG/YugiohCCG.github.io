namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False, Inherited = False)]
[VisibleToOtherModules]
internal class PreventReadOnlyInstanceModificationAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PreventReadOnlyInstanceModificationAttribute() { }

}


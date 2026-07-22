namespace UnityEngine;

[AttributeUsage(AttributeTargets::Enum (16))]
public sealed class InspectorOrderAttribute : PropertyAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private InspectorSort <m_inspectorSort>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private InspectorSortDirection <m_sortDirection>k__BackingField; //Field offset: 0x1C

	internal InspectorSort m_inspectorSort
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal InspectorSortDirection m_sortDirection
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal InspectorSort get_m_inspectorSort() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal InspectorSortDirection get_m_sortDirection() { }

}


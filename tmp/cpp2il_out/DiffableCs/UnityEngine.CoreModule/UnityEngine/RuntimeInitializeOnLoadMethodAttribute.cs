namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = False)]
[RequiredByNativeCode]
public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
{
	private RuntimeInitializeLoadType m_LoadType; //Field offset: 0x10

	private RuntimeInitializeLoadType loadType
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RuntimeInitializeOnLoadMethodAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	private void set_loadType(RuntimeInitializeLoadType value) { }

}


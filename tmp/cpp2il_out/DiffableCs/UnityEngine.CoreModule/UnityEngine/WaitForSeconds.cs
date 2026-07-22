namespace UnityEngine;

[RequiredByNativeCode]
public sealed class WaitForSeconds : YieldInstruction
{
	internal float m_Seconds; //Field offset: 0x10

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public WaitForSeconds(float seconds) { }

}


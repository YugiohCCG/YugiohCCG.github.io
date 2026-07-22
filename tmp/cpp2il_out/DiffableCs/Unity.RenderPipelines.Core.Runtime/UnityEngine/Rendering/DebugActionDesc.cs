namespace UnityEngine.Rendering;

internal class DebugActionDesc
{
	public InputAction buttonAction; //Field offset: 0x10
	public DebugActionRepeatMode repeatMode; //Field offset: 0x18
	public float repeatDelay; //Field offset: 0x1C

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugActionDesc() { }

}


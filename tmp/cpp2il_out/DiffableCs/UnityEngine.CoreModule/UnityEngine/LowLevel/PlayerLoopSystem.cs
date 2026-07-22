namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
public struct PlayerLoopSystem
{
	internal sealed class UpdateFunction : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public UpdateFunction(object object, IntPtr method) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	public Type type; //Field offset: 0x0
	public PlayerLoopSystem[] subSystemList; //Field offset: 0x8
	public UpdateFunction updateDelegate; //Field offset: 0x10
	public IntPtr updateFunction; //Field offset: 0x18
	public IntPtr loopConditionFunction; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}


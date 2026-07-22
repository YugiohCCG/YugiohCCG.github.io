namespace System;

public sealed class Func : MulticastDelegate
{

	[CalledBy(Type = "DuelBot.Game.GameBehavior", Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.GameBehavior", Member = "OnSelectUnselectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.GameBehavior", Member = "OnSelectTribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public Func`6(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

}


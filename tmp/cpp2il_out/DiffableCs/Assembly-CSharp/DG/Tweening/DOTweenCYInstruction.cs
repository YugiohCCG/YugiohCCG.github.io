namespace DG.Tweening;

public static class DOTweenCYInstruction
{
	internal class WaitForCompletion : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x10

		public virtual bool keepWaiting
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TweenExtensions), Member = "IsComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 51
		}

		[CallerCount(Count = 27)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public WaitForCompletion(Tween tween) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenExtensions), Member = "IsComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public virtual bool get_keepWaiting() { }

	}

	internal class WaitForElapsedLoops : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x10
		private readonly int elapsedLoops; //Field offset: 0x18

		public virtual bool keepWaiting
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TweenExtensions), Member = "CompletedLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 62
		}

		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenExtensions), Member = "CompletedLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual bool get_keepWaiting() { }

	}

	internal class WaitForKill : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x10

		public virtual bool keepWaiting
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 30
		}

		[CallerCount(Count = 27)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public WaitForKill(Tween tween) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public virtual bool get_keepWaiting() { }

	}

	internal class WaitForPosition : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x10
		private readonly float position; //Field offset: 0x18

		public virtual bool keepWaiting
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TweenExtensions), Member = "CompletedLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 98
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public WaitForPosition(Tween tween, float position) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenExtensions), Member = "CompletedLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual bool get_keepWaiting() { }

	}

	internal class WaitForRewind : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x10

		public virtual bool keepWaiting
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TweenExtensions), Member = "CompletedLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 105
		}

		[CallerCount(Count = 27)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public WaitForRewind(Tween tween) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenExtensions), Member = "CompletedLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual bool get_keepWaiting() { }

	}

	internal class WaitForStart : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x10

		public virtual bool keepWaiting
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
			[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
			[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 8)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 336
		}

		[CallerCount(Count = 27)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public WaitForStart(Tween tween) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		public virtual bool get_keepWaiting() { }

	}


}


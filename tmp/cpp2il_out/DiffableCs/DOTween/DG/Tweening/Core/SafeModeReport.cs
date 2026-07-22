namespace DG.Tweening.Core;

internal struct SafeModeReport
{
	public enum SafeModeReportType
	{
		Unset = 0,
		TargetOrFieldMissing = 1,
		Callback = 2,
		StartupFailure = 3,
	}

	[CompilerGenerated]
	private int <totMissingTargetOrFieldErrors>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <totCallbackErrors>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private int <totStartupErrors>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <totUnsetErrors>k__BackingField; //Field offset: 0xC

	public private int totCallbackErrors
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int totMissingTargetOrFieldErrors
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 3
	}

	public private int totStartupErrors
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int totUnsetErrors
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tween), Member = "OnTweenCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.TweenCallback`1<T>", typeof(Tween), "T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tweener), Member = "DoStartup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tweener), Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ApplyTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(bool), typeof(UpdateMode), typeof(UpdateNotice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	public void Add(SafeModeReportType type) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_totCallbackErrors() { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_totMissingTargetOrFieldErrors() { }

	[CallerCount(Count = 28)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_totStartupErrors() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_totUnsetErrors() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetTotErrors() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_totCallbackErrors(int value) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_totMissingTargetOrFieldErrors(int value) { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_totStartupErrors(int value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_totUnsetErrors(int value) { }

}


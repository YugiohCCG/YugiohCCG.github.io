namespace Spine;

public class AnimationStateData
{
	internal struct AnimationPair
	{
		public readonly Animation a1; //Field offset: 0x0
		public readonly Animation a2; //Field offset: 0x8

		[CallerCount(Count = 68)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public AnimationPair(Animation a1, Animation a2) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		public virtual string ToString() { }

	}

	internal class AnimationPairComparer : IEqualityComparer<AnimationPair>
	{
		public static readonly AnimationPairComparer Instance; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static AnimationPairComparer() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AnimationPairComparer() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private override bool System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.Equals(AnimationPair x, AnimationPair y) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private override int System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.GetHashCode(AnimationPair obj) { }

	}

	internal SkeletonData skeletonData; //Field offset: 0x10
	private readonly Dictionary<AnimationPair, Single> animationToMixTime; //Field offset: 0x18
	internal float defaultMix; //Field offset: 0x20

	public float DefaultMix
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public SkeletonData SkeletonData
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "InitializeWithData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.AnimationStateData+AnimationPair, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<Spine.AnimationStateData+AnimationPair>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AnimationStateData(SkeletonData skeletonData) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_DefaultMix() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public SkeletonData get_SkeletonData() { }

	[CalledBy(Type = typeof(AnimationState), Member = "NewTrackEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool), typeof(TrackEntry)}, ReturnType = typeof(TrackEntry))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.AnimationStateData+AnimationPair, System.Single>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationPair), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public float GetMix(Animation from, Animation to) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_DefaultMix(float value) { }

	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "InitializeWithData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "FillStateData", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SkeletonData), Member = "FindAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Animation))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.AnimationStateData+AnimationPair, System.Single>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationPair)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.AnimationStateData+AnimationPair, System.Single>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationPair), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public void SetMix(string fromName, string toName, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.AnimationStateData+AnimationPair, System.Single>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationPair)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.AnimationStateData+AnimationPair, System.Single>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationPair), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public void SetMix(Animation from, Animation to, float duration) { }

}


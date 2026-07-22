namespace Spine.Unity;

[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonMecanim-Component")]
[RequireComponent(typeof(Animator))]
public class SkeletonMecanim : SkeletonRenderer, ISkeletonAnimation, ISpineComponent
{
	internal class MecanimTranslator
	{
		private class AnimationClipEqualityComparer : IEqualityComparer<AnimationClip>
		{
			internal static readonly IEqualityComparer<AnimationClip> Instance; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static AnimationClipEqualityComparer() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public AnimationClipEqualityComparer() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			public override bool Equals(AnimationClip x, AnimationClip y) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override int GetHashCode(AnimationClip o) { }

		}

		internal class ClipInfos
		{
			public bool isInterruptionActive; //Field offset: 0x10
			public bool isLastFrameOfInterruption; //Field offset: 0x11
			public int clipInfoCount; //Field offset: 0x14
			public int nextClipInfoCount; //Field offset: 0x18
			public int interruptingClipInfoCount; //Field offset: 0x1C
			public readonly List<AnimatorClipInfo> clipInfos; //Field offset: 0x20
			public readonly List<AnimatorClipInfo> nextClipInfos; //Field offset: 0x28
			public readonly List<AnimatorClipInfo> interruptingClipInfos; //Field offset: 0x30
			public AnimatorStateInfo stateInfo; //Field offset: 0x38
			public AnimatorStateInfo nextStateInfo; //Field offset: 0x5C
			public AnimatorStateInfo interruptingStateInfo; //Field offset: 0x80
			public float interruptingClipTimeAddition; //Field offset: 0xA4

			[CalledBy(Type = typeof(MecanimTranslator), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(MecanimTranslator), Member = "InitClipInfosForLayers", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(MecanimTranslator), Member = "ClearClipInfosForLayers", ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 4)]
			[CallsUnknownMethods(Count = 3)]
			public ClipInfos() { }

		}

		private class IntEqualityComparer : IEqualityComparer<Int32>
		{
			internal static readonly IEqualityComparer<Int32> Instance; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static IntEqualityComparer() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public IntEqualityComparer() { }

			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			public override bool Equals(int x, int y) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public override int GetHashCode(int o) { }

		}

		internal enum MixMode
		{
			AlwaysMix = 0,
			MixNext = 1,
			Hard = 2,
		}

		internal sealed class OnClipAppliedDelegate : MulticastDelegate
		{

			[CalledBy(Type = typeof(SkeletonMecanimRootMotion), Member = "Start", ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 7)]
			public OnClipAppliedDelegate(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(Animation clip, int layerIndex, float weight, float time, float lastTime, bool playsBackward, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public override void Invoke(Animation clip, int layerIndex, float weight, float time, float lastTime, bool playsBackward) { }

		}

		private const float WeightEpsilon = 0.0001; //Field offset: 0x0
		public bool autoReset; //Field offset: 0x10
		public bool useCustomMixMode; //Field offset: 0x11
		public MixMode[] layerMixModes; //Field offset: 0x18
		public MixBlend[] layerBlendModes; //Field offset: 0x20
		[CompilerGenerated]
		private OnClipAppliedDelegate _OnClipApplied; //Field offset: 0x28
		private readonly Dictionary<Int32, Animation> animationTable; //Field offset: 0x30
		private readonly Dictionary<AnimationClip, Int32> clipNameHashCodeTable; //Field offset: 0x38
		private readonly List<Animation> previousAnimations; //Field offset: 0x40
		protected ClipInfos[] layerClipInfos; //Field offset: 0x48
		private Animator animator; //Field offset: 0x50

		protected event OnClipAppliedDelegate _OnClipApplied
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 add { } //Length: 146
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 remove { } //Length: 146
		}

		public event OnClipAppliedDelegate OnClipApplied
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 add { } //Length: 146
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 remove { } //Length: 146
		}

		public Animator Animator
		{
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public int MecanimLayerCount
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(Animator), Member = "get_layerCount", ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 124
		}

		public String[] MecanimLayerNames
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(Animator), Member = "get_layerCount", ReturnType = typeof(int))]
			[Calls(Type = typeof(Animator), Member = "GetLayerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
			[CallsUnknownMethods(Count = 3)]
			 get { } //Length: 304
		}

		[CalledBy(Type = typeof(SkeletonMecanim), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		public MecanimTranslator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		protected void add__OnClipApplied(OnClipAppliedDelegate value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public void add_OnClipApplied(OnClipAppliedDelegate value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private static float AnimationTime(float normalizedTime, float clipLength, bool reversed) { }

		[CalledBy(Type = typeof(MecanimTranslator), Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), typeof(MixBlend), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MecanimTranslator), Member = "GetActiveAnimationAndTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<Spine.Animation, System.Single>))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed) { }

		[CalledBy(Type = typeof(SkeletonMecanim), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonMecanim), Member = "ApplyAnimation", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MecanimTranslator), Member = "GetMixMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MixBlend)}, ReturnType = typeof(MixMode))]
		[Calls(Type = typeof(MecanimTranslator), Member = "GetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip)}, ReturnType = typeof(Animation))]
		[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip", ReturnType = typeof(AnimationClip))]
		[Calls(Type = typeof(Animator), Member = "GetNextAnimatorStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(AnimatorStateInfo))]
		[Calls(Type = typeof(Animator), Member = "GetLayerWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Animation), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(bool), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MecanimTranslator), Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), typeof(MixBlend), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MecanimTranslator), Member = "GetStateUpdatesFromAnimator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClipInfos), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Animator), Member = "get_layerCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(MecanimTranslator), Member = "ApplyInterruptionAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), typeof(MixBlend), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 27)]
		[ContainsUnimplementedInstructions]
		public void Apply(Skeleton skeleton) { }

		[CalledBy(Type = typeof(MecanimTranslator), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip", ReturnType = typeof(AnimationClip))]
		[Calls(Type = typeof(MecanimTranslator), Member = "GetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip)}, ReturnType = typeof(Animation))]
		[Calls(Type = typeof(AnimationClip), Member = "get_length", ReturnType = typeof(float))]
		[Calls(Type = typeof(Motion), Member = "get_isLooping", ReturnType = typeof(bool))]
		[Calls(Type = typeof(MecanimTranslator), Member = "AnimationTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Animation), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(bool), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MecanimTranslator), Member = "OnClipAppliedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimatorStateInfo), typeof(int), typeof(float), typeof(bool), typeof(float)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private bool ApplyAnimation(Skeleton skeleton, AnimatorClipInfo info, AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, MixBlend layerBlendMode, bool useClipWeight1 = false) { }

		[CalledBy(Type = typeof(MecanimTranslator), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip", ReturnType = typeof(AnimationClip))]
		[Calls(Type = typeof(MecanimTranslator), Member = "GetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip)}, ReturnType = typeof(Animation))]
		[Calls(Type = typeof(AnimationClip), Member = "get_length", ReturnType = typeof(float))]
		[Calls(Type = typeof(Motion), Member = "get_isLooping", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Animation), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(bool), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MecanimTranslator), Member = "OnClipAppliedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimatorStateInfo), typeof(int), typeof(float), typeof(bool), typeof(float)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private bool ApplyInterruptionAnimation(Skeleton skeleton, bool interpolateWeightTo1, AnimatorClipInfo info, AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, MixBlend layerBlendMode, float interruptingClipTimeAddition, bool useClipWeight1 = false) { }

		[CalledBy(Type = typeof(MecanimTranslator), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animator), typeof(SkeletonDataAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ClipInfos), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		private void ClearClipInfosForLayers() { }

		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		public Animator get_Animator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Animator), Member = "get_layerCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		public int get_MecanimLayerCount() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Animator), Member = "get_layerCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Animator), Member = "GetLayerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		public String[] get_MecanimLayerNames() { }

		[CalledBy(Type = typeof(SkeletonMecanimRootMotion), Member = "GetRemainingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(SkeletonMecanimRootMotion), Member = "GetRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RootMotionInfo))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip", ReturnType = typeof(AnimationClip))]
		[Calls(Type = typeof(MecanimTranslator), Member = "GetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip)}, ReturnType = typeof(Animation))]
		[Calls(Type = typeof(AnimationClip), Member = "get_length", ReturnType = typeof(float))]
		[Calls(Type = typeof(Motion), Member = "get_isLooping", ReturnType = typeof(bool))]
		[Calls(Type = typeof(MecanimTranslator), Member = "AnimationTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public KeyValuePair<Animation, Single> GetActiveAnimationAndTime(int layer) { }

		[CalledBy(Type = typeof(MecanimTranslator), Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), typeof(MixBlend), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MecanimTranslator), Member = "ApplyInterruptionAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), typeof(MixBlend), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MecanimTranslator), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MecanimTranslator), Member = "GetActiveAnimationAndTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<Spine.Animation, System.Single>))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private Animation GetAnimation(AnimationClip clip) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		private void GetAnimatorClipInfos(int layer, out bool isInterruptionActive, out int clipInfoCount, out int nextClipInfoCount, out int interruptingClipInfoCount, out IList<AnimatorClipInfo>& clipInfo, out IList<AnimatorClipInfo>& nextClipInfo, out IList<AnimatorClipInfo>& interruptingClipInfo, out bool shallInterpolateWeightTo1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private void GetAnimatorStateInfos(int layer, out bool isInterruptionActive, out AnimatorStateInfo stateInfo, out AnimatorStateInfo nextStateInfo, out AnimatorStateInfo interruptingStateInfo, out float interruptingClipTimeAddition) { }

		[CalledBy(Type = typeof(MecanimTranslator), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private MixMode GetMixMode(int layer, MixBlend layerBlendMode) { }

		[CalledBy(Type = typeof(MecanimTranslator), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorClipInfoCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Animator), Member = "GetNextAnimatorClipInfoCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Animator), Member = "GetNextAnimatorClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(AnimatorStateInfo))]
		[Calls(Type = typeof(Animator), Member = "GetNextAnimatorStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(AnimatorStateInfo))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private void GetStateUpdatesFromAnimator(int layer) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Animator), Member = "get_layerCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClipInfos), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		private void InitClipInfosForLayers() { }

		[CalledBy(Type = typeof(SkeletonMecanim), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
		[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MecanimTranslator), Member = "ClearClipInfosForLayers", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		public void Initialize(Animator animator, SkeletonDataAsset skeletonDataAsset) { }

		[CalledBy(Type = typeof(MecanimTranslator), Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), typeof(MixBlend), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MecanimTranslator), Member = "ApplyInterruptionAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), typeof(MixBlend), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private void OnClipAppliedCallback(Animation clip, AnimatorStateInfo stateInfo, int layerIndex, float time, bool isLooping, float weight) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		protected void remove__OnClipApplied(OnClipAppliedDelegate value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public void remove_OnClipApplied(OnClipAppliedDelegate value) { }

	}

	[SerializeField]
	protected MecanimTranslator translator; //Field offset: 0xE8
	private bool wasUpdatedAfterInit; //Field offset: 0xF0
	[CompilerGenerated]
	private UpdateBonesDelegate _BeforeApply; //Field offset: 0xF8
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateLocal; //Field offset: 0x100
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateWorld; //Field offset: 0x108
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateComplete; //Field offset: 0x110

	protected event UpdateBonesDelegate _BeforeApply
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	protected event UpdateBonesDelegate _UpdateComplete
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	protected event UpdateBonesDelegate _UpdateLocal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	protected event UpdateBonesDelegate _UpdateWorld
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	public event UpdateBonesDelegate BeforeApply
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	public override event UpdateBonesDelegate UpdateComplete
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	public override event UpdateBonesDelegate UpdateLocal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	public override event UpdateBonesDelegate UpdateWorld
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	public MecanimTranslator Translator
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRenderer), Member = ".ctor", ReturnType = typeof(void))]
	public SkeletonMecanim() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void add__BeforeApply(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void add__UpdateComplete(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void add__UpdateLocal(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void add__UpdateWorld(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void add_BeforeApply(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void add_UpdateComplete(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void add_UpdateLocal(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void add_UpdateWorld(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MecanimTranslator), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected void ApplyAnimation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MecanimTranslator get_Translator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRenderer), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MecanimTranslator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(MecanimTranslator), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animator), typeof(SkeletonDataAsset)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Initialize(bool overwrite, bool quiet = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonMecanim), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "LateUpdate", ReturnType = typeof(void))]
	public virtual void LateUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonMecanim), Member = "Update", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void OnBecameVisible() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void remove__BeforeApply(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void remove__UpdateComplete(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void remove__UpdateLocal(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void remove__UpdateWorld(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void remove_BeforeApply(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void remove_UpdateComplete(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void remove_UpdateLocal(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void remove_UpdateWorld(UpdateBonesDelegate value) { }

	[CalledBy(Type = typeof(SkeletonMecanim), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonMecanim), Member = "OnBecameVisible", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MecanimTranslator), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void Update() { }

}


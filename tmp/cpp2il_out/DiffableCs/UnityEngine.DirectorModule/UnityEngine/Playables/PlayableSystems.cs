namespace UnityEngine.Playables;

[NativeHeader("Modules/Director/ScriptBindings/PlayableSystems.bindings.h")]
[StaticAccessor("PlayableSystemsBindings", StaticAccessorType::DoubleColon (2))]
internal static class PlayableSystems
{
	[DefaultMember("Item")]
	private class DataPlayableOutputList : IReadOnlyList<DataPlayableOutput>, IEnumerable<DataPlayableOutput>, IEnumerable, IReadOnlyCollection<DataPlayableOutput>
	{
		private class DataPlayableOutputEnumerator : IEnumerator<DataPlayableOutput>, IEnumerator, IDisposable
		{
			private DataPlayableOutputList m_List; //Field offset: 0x10
			private int m_Index; //Field offset: 0x18

			public override DataPlayableOutput Current
			{
				[CalledBy(Type = typeof(DataPlayableOutputEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
				[CallerCount(Count = 1)]
				[Calls(Type = typeof(DataPlayableOutput), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
				[CallsUnknownMethods(Count = 14)]
				 get { } //Length: 437
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(DataPlayableOutputEnumerator), Member = "get_Current", ReturnType = typeof(DataPlayableOutput))]
				private get { } //Length: 84
			}

			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public DataPlayableOutputEnumerator(DataPlayableOutputList list) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Dispose() { }

			[CalledBy(Type = typeof(DataPlayableOutputEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(DataPlayableOutput), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
			[CallsUnknownMethods(Count = 14)]
			public override DataPlayableOutput get_Current() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			public override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public override void Reset() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DataPlayableOutputEnumerator), Member = "get_Current", ReturnType = typeof(DataPlayableOutput))]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		private PlayableOutputHandle* m_Outputs; //Field offset: 0x10
		private int m_Count; //Field offset: 0x18

		public override int Count
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public override DataPlayableOutput Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DataPlayableOutput), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 8)]
			 get { } //Length: 329
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DataPlayableOutputList(PlayableOutputHandle* outputs, int count) { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public override int get_Count() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataPlayableOutput), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		public override DataPlayableOutput get_Item(int index) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IEnumerator<DataPlayableOutput> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	internal sealed class PlayableSystemDelegate : MulticastDelegate
	{

		[CallerCount(Count = 389)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public PlayableSystemDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(IReadOnlyList<DataPlayableOutput> outputs) { }

	}

	internal enum PlayableSystemStage
	{
		FixedUpdate = 0,
		FixedUpdatePostPhysics = 1,
		Update = 2,
		AnimationBegin = 3,
		AnimationEnd = 4,
		LateUpdate = 5,
		Render = 6,
	}

	private static Dictionary<Int32, Type> s_SystemTypes; //Field offset: 0x0
	private static Dictionary<Int32, PlayableSystemDelegate> s_Delegates; //Field offset: 0x8
	private static ReaderWriterLockSlim s_RWLock; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsInvalidInstructions]
	private static PlayableSystems() { }

	[CallerCount(Count = 0)]
	private static int CombineTypeAndIndex(int typeIndex, PlayableSystemStage stage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterReadLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitReadLock", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	private static bool Internal_CallSystemDelegate(int systemIndex, PlayableSystemStage stage, IntPtr outputsPtr, int numOutputs) { }

}


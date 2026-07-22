namespace UnityEngine.InputSystem.EnhancedTouch;

[DefaultMember("Item")]
public struct TouchHistory : IReadOnlyList<Touch>, IEnumerable<Touch>, IEnumerable, IReadOnlyCollection<Touch>
{
	private class Enumerator : IEnumerator<Touch>, IEnumerator, IDisposable
	{
		private readonly TouchHistory m_Owner; //Field offset: 0x10
		private int m_Index; //Field offset: 0x30

		public override Touch Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TouchHistory), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
			 get { } //Length: 74
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TouchHistory), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
			private get { } //Length: 119
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Enumerator(TouchHistory owner) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TouchHistory), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
		public override Touch get_Current() { }

		[CallerCount(Count = 0)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TouchHistory), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private readonly InputStateHistory<TouchState> m_History; //Field offset: 0x0
	private readonly Finger m_Finger; //Field offset: 0x8
	private readonly int m_Count; //Field offset: 0x10
	private readonly int m_StartIndex; //Field offset: 0x14
	private readonly uint m_Version; //Field offset: 0x18

	public override int Count
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override Touch Item
	{
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(Touch))]
		[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TouchHistory), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputStateHistory`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 350
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal TouchHistory(Finger finger, InputStateHistory<TouchState> history, int startIndex = -1, int count = -1) { }

	[CalledBy(Type = typeof(TouchHistory), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	internal void CheckValid() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(Touch))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TouchHistory), Member = "CheckValid", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateHistory`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override Touch get_Item(int index) { }

	[CalledBy(Type = typeof(TouchHistory), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerator<Touch> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchHistory), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<UnityEngine.InputSystem.EnhancedTouch.Touch>))]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}


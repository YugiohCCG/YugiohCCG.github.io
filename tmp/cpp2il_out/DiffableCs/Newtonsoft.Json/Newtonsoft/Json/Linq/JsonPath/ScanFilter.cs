namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(2)]
internal class ScanFilter : PathFilter
{
	[CompilerGenerated]
	private sealed class <ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		[Nullable(1)]
		private JToken <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerable<JToken> current; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public IEnumerable<JToken> <>3__current; //Field offset: 0x30
		[Nullable(0)]
		public ScanFilter <>4__this; //Field offset: 0x38
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x40
		[Nullable(0)]
		private JToken <c>5__3; //Field offset: 0x48
		[Nullable(0)]
		private JToken <value>5__4; //Field offset: 0x50

		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <ExecuteFilter>d__2(int <>1__state) { }

		[CalledBy(Type = typeof(<ExecuteFilter>d__2), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PathFilter), Member = "GetNextScanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JToken), typeof(JToken)}, ReturnType = typeof(JToken))]
		[Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
		[Calls(Type = typeof(<ExecuteFilter>d__2), Member = "<>m__Finally1", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 21)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CalledBy(Type = "Newtonsoft.Json.Linq.JProperty+<WriteToAsync>d__1", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal string Name; //Field offset: 0x10

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ScanFilter(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	[NullableContext(1)]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}


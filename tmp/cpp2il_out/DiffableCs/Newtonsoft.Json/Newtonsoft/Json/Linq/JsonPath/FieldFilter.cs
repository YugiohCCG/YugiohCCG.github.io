namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(2)]
internal class FieldFilter : PathFilter
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
		public FieldFilter <>4__this; //Field offset: 0x38
		[Nullable(0)]
		private JsonSelectSettings settings; //Field offset: 0x40
		[Nullable(0)]
		public JsonSelectSettings <>3__settings; //Field offset: 0x48
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x50
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1, 2})]
		private IEnumerator<KeyValuePair`2<String, JToken>> <>7__wrap2; //Field offset: 0x58

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

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void <>m__Finally2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JObject), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>))]
		[Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JToken))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 39)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
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
		[CallsUnknownMethods(Count = 7)]
		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal string Name; //Field offset: 0x10

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public FieldFilter(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[IteratorStateMachine(typeof(<ExecuteFilter>d__2))]
	[NullableContext(1)]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}


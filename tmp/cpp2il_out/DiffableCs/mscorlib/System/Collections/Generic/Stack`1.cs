namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(StackDebugView`1))]
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
public class Stack : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly Stack<T> _stack; //Field offset: 0x0
		private readonly int _version; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private T _currentElement; //Field offset: 0x0

		public override T Current
		{
			[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "Cleanup", ReturnType = typeof(void))]
			[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<JsonSchemaModel>"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 68
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			private get { } //Length: 153
		}

		[CalledBy(Type = typeof(Stack`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Stack`1<T>+Enumerator<T>")]
		[CalledBy(Type = typeof(Stack`1), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CalledBy(Type = typeof(Stack`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal Enumerator(Stack<T> stack) { }

		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<JsonSchemaModel>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override T get_Current() { }

		[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "Cleanup", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private void ThrowEnumerationNotStartedOrEnded() { }

	}

	private T[] _array; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public override int Count
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 104
	}

	[CallerCount(Count = 66)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Stack`1() { }

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public Stack`1(int capacity) { }

	[CalledBy(Type = "UnityEngine.UIElements.TreeDataController`1", Member = "ConvertTreeViewItemDataToHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TreeViewItemData`1<T>>", "System.Func`2<HierarchyNode, HierarchyNode>", "System.Action`2<Int32, HierarchyNode>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.DrawParams", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.Entry", "UnityEngine.UIElements.UIR.RenderChain", "UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher", Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.Expression", "System.Collections.Generic.List`1<StylePropertyValue>"}, ReturnType = "UnityEngine.UIElements.StyleSheets.MatchResult")]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickPool", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickBlendingPool", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "CullUnusedPasses", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>", typeof(bool), typeof(string), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "LastIndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Contains(T item) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<JsonSchemaModel>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Stack`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Enumerator<T> GetEnumerator() { }

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T Peek() { }

	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.Expression"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+TestBuilder", Member = "ToExpression", ReturnType = "System.Linq.Expressions.Expression")]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+TestBuilder", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Dynamic.BindingRestrictions"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "CullUnusedRenderPasses", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "CullUnusedPasses", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "RequestScratchBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<Byte>")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ProcessCombinatorStack", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"}, ReturnType = "UnityEngine.UIElements.StyleSheets.Syntax.Expression")]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+TestBuilder", Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "MatchCombinator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.Expression"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "RestoreContext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutManager", Member = "TryFreeNodes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextureRegistry", Member = "AllocAndAcquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Texture", typeof(bool)}, ReturnType = "UnityEngine.UIElements.TextureId")]
	[CalledBy(Type = "UnityEngine.UIElements.AncestorFilter", Member = "PopElement", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeDataController`1", Member = "ConvertTreeViewItemDataToHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TreeViewItemData`1<T>>", "System.Func`2<HierarchyNode, HierarchyNode>", "System.Action`2<Int32, HierarchyNode>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "DropContext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+MergedRestriction", Member = "GetExpression", ReturnType = "System.Linq.Expressions.Expression")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T Pop() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Stack`1), Member = "PushWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Push(T item) { }

	[CalledBy(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void PushWithResize(T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Stack`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Stack`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void ThrowForEmptyStack() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T[] ToArray() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPreProcessor", Member = "PreProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.Entry"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPreProcessor", Member = "DoEvaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.Entry"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool TryPop(out T result) { }

}


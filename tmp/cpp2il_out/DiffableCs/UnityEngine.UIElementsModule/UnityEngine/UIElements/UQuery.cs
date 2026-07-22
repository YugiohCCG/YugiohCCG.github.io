namespace UnityEngine.UIElements;

public static class UQuery
{
	public class FirstQueryMatcher : SingleQueryMatcher
	{
		public static readonly FirstQueryMatcher Instance; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static FirstQueryMatcher() { }

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public FirstQueryMatcher() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public virtual SingleQueryMatcher CreateNew() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	}

	public class IsOfType : IVisualPredicateWrapper
	{
		public static IsOfType<T> s_Instance; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static IsOfType`1() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public IsOfType`1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool Predicate(object e) { }

	}

	public interface IVisualPredicateWrapper
	{

		public bool Predicate(object e) { }

	}

	public abstract class SingleQueryMatcher : UQueryMatcher
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private VisualElement <match>k__BackingField; //Field offset: 0x18

		public VisualElement match
		{
			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		protected SingleQueryMatcher() { }

		public abstract SingleQueryMatcher CreateNew() { }

		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public VisualElement get_match() { }

		[CalledBy(Type = typeof(UQueryState`1), Member = "Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SingleQueryMatcher)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool IsInUse() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public virtual void Run(VisualElement root, List<RuleMatcher> matchers) { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_match(VisualElement value) { }

	}

	public abstract class UQueryMatcher : HierarchyTraversal
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action<VisualElement, MatchResultInfo> <>9__5_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			internal void <TraverseRecursive>b__5_0(VisualElement e, MatchResultInfo i) { }

		}

		internal List<RuleMatcher> m_Matchers; //Field offset: 0x10

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		protected UQueryMatcher() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		private static void NoProcessResult(VisualElement e, MatchResultInfo i) { }

		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override void Run(VisualElement root, List<RuleMatcher> matchers) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyTraversal), Member = "Traverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		public virtual void Traverse(VisualElement element) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StyleSelectorHelper), Member = "MatchRightToLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleComplexSelector), typeof(System.Action`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HierarchyTraversal), Member = "Recurse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void TraverseRecursive(VisualElement element, int depth) { }

	}


}


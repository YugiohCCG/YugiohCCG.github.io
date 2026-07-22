namespace System.Linq.Expressions.Interpreter;

internal sealed class TryCatchFinallyHandler
{
	internal readonly int TryStartIndex; //Field offset: 0x10
	internal readonly int TryEndIndex; //Field offset: 0x14
	internal readonly int FinallyStartIndex; //Field offset: 0x18
	internal readonly int FinallyEndIndex; //Field offset: 0x1C
	internal readonly int GotoEndTargetIndex; //Field offset: 0x20
	private readonly ExceptionHandler[] _handlers; //Field offset: 0x28

	internal ExceptionHandler[] Handlers
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool IsCatchBlockExist
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 9
	}

	internal bool IsFinallyBlockExist
	{
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[CalledBy(Type = "System.Linq.Enumerable+<RangeIterator>d__115", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "Analyze", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) { }

	[CalledBy(Type = typeof(TryCatchFinallyHandler), Member = "HasHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(Exception), typeof(ExceptionHandler&), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal ExceptionHandler[] get_Handlers() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_IsCatchBlockExist() { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Enumerable+<RangeIterator>d__115", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "Analyze", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsFinallyBlockExist() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "SaveTraceToException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TryCatchFinallyHandler), Member = "FilterPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(Object&), typeof(ExceptionFilter)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) { }

}


namespace System;

[StackTraceHidden]
internal static class ThrowHelper
{

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_DestinationTooShort", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static Exception CreateArgumentException_DestinationTooShort() { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	private static Exception CreateArgumentOutOfRangeException() { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArrayTypeMismatchException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayTypeMismatchException), Member = ".ctor", ReturnType = typeof(void))]
	private static Exception CreateArrayTypeMismatchException() { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	private static Exception CreateIndexOutOfRangeException() { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException_ArrayMemoryPoolBuffer", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Exception CreateObjectDisposedException_ArrayMemoryPoolBuffer() { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	private static Exception CreateThrowNotSupportedException() { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowAddingDuplicateWithKeyArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static ArgumentException GetAddingDuplicateWithKeyArgumentException(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static ArgumentException GetArgumentException(ExceptionResource resource) { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "GetArraySegmentCtorValidationFailedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "GetArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(ArgumentNullException))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallerCount(Count = 7)]
	[ContainsInvalidInstructions]
	internal static string GetArgumentName(ExceptionArgument argument) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, string resource) { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "GetArraySegmentCtorValidationFailedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArraySegmentCtorValidationFailedExceptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static Exception GetArraySegmentCtorValidationFailedException(Array array, int offset, int count) { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_ConcurrentOperationsNotSupported", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static InvalidOperationException GetInvalidOperationException(string str) { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowKeyNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static KeyNotFoundException GetKeyNotFoundException(object key) { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowSerializationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsInvalidInstructions]
	internal static string GetResourceName(ExceptionResource resource) { }

	[CalledBy(Type = typeof(Collection`1), Member = "System.Collections.IList.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Collection`1), Member = "System.Collections.IList.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Collection`1), Member = "System.Collections.IList.Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "System.Collections.IList.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "System.Collections.IList.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(List`1), Member = "System.Collections.IList.Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal static void IfNullAndNullsAreIllegalThenThrow(object value, ExceptionArgument argName) { }

	[CalledBy(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetAddingDuplicateWithKeyArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ArgumentException))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowAddingDuplicateWithKeyArgumentException(object key) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowArgumentException(ExceptionResource resource) { }

	[CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BitConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BitConverter), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(BitConverter), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(BitConverter), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(BitConverter), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(BitConverter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(BitConverter), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(BitConverter), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(string), Member = "CheckStringComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringComparison)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BitConverter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument) { }

	[CalledBy(Type = typeof(Collection`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadOnlyCollection`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void ThrowArgumentException_Argument_InvalidArrayType() { }

	[CalledBy(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "CreateArgumentException_DestinationTooShort", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowArgumentException_DestinationTooShort() { }

	[CallerCount(Count = 129)]
	[Calls(Type = typeof(ThrowHelper), Member = "CreateArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.IList<T>.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "System.Collections.IList.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(List`1), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(List`1), Member = "System.Collections.IList.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "System.Collections.IList.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Collection`1), Member = "System.Collections.IList.Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Collection`1), Member = "System.Collections.IList.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Collection`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Collection`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Collection`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.IReadOnlyList<T>.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.IList<T>.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowArgumentOutOfRange_IndexException() { }

	[CallerCount(Count = 346)]
	[Calls(Type = typeof(ThrowHelper), Member = "CreateArgumentOutOfRangeException", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowArgumentOutOfRangeException() { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ThrowHelper), Member = "GetResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(ThrowHelper), Member = "CreateArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	[CalledBy(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArraySegmentCtorValidationFailedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowArraySegmentCtorValidationFailedExceptions(Array array, int offset, int count) { }

	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackList", Member = "get_Span", ReturnType = "System.Span`1<EventCallbackFunctorBase>")]
	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackRegistry+DynamicCallbackList", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "CreateArrayTypeMismatchException", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowArrayTypeMismatchException() { }

	[CalledBy(Type = typeof(List`1), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count() { }

	[CalledBy(Type = typeof(Collection`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadOnlyCollection`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(List`1), Member = "GetRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CalledBy(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException() { }

	[CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Span`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CalledBy(Type = typeof(ReadOnlySpan`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CalledBy(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(string), Member = "TrimHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), "System.String+TrimType"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String+TrimType"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ValueListBuilder`1<Int32>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(ValueListBuilder`1<Int32>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ThrowHelper), Member = "CreateIndexOutOfRangeException", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowIndexOutOfRangeException() { }

	[CalledBy(Type = typeof(ArraySegment`1), Member = "GetEnumerator", ReturnType = "System.ArraySegment`1<T>+Enumerator<T>")]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.IList<T>.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.IList<T>.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.IList<T>.IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.IReadOnlyList<T>.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.ICollection<T>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "ThrowInvalidOperationIfDefault", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowInvalidOperationException(ExceptionResource resource) { }

	[CalledBy(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported() { }

	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumEnded() { }

	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNextRare", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion() { }

	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted() { }

	[CalledBy(Type = "System.Runtime.CompilerServices.ConditionalWeakTable`2+Enumerator", Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
	[CalledBy(Type = "System.Runtime.CompilerServices.ConditionalWeakTable`2+Enumerator", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IDictionaryEnumerator.get_Entry", ReturnType = typeof(DictionaryEntry))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IDictionaryEnumerator.get_Key", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IDictionaryEnumerator.get_Value", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen() { }

	[CalledBy(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void ThrowInvalidOperationException_InvalidOperation_NoValue() { }

	[CalledBy(Type = typeof(ReadOnlySpan`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Span`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void ThrowInvalidTypeWithPointersNotSupported(Type targetType) { }

	[CalledBy(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetKeyNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(KeyNotFoundException))]
	internal static void ThrowKeyNotFoundException(object key) { }

	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.IList<T>.Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.IList<T>.RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.ICollection<T>.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.ICollection<T>.Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySegment`1), Member = "System.Collections.Generic.ICollection<T>.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "CreateThrowNotSupportedException", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowNotSupportedException() { }

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowNotSupportedException(ExceptionResource resource) { }

	[CalledBy(Type = "System.Buffers.ArrayMemoryPool`1+ArrayMemoryPoolBuffer", Member = "get_Memory", ReturnType = "System.Memory`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "CreateObjectDisposedException_ArrayMemoryPoolBuffer", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowObjectDisposedException_ArrayMemoryPoolBuffer() { }

	[CalledBy(Type = typeof(Dictionary`2), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowSerializationException(ExceptionResource resource) { }

	[CalledBy(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index() { }

	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	internal static void ThrowWrongKeyTypeArgumentException(object key, Type targetType) { }

	[CalledBy(Type = typeof(Collection`1), Member = "System.Collections.IList.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Collection`1), Member = "System.Collections.IList.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Collection`1), Member = "System.Collections.IList.Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "System.Collections.IList.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "System.Collections.IList.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(List`1), Member = "System.Collections.IList.Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) { }

}


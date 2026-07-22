namespace System.Reflection;

internal abstract class RtFieldInfo : FieldInfo
{

	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected RtFieldInfo() { }

	internal abstract void CheckConsistency(object target) { }

	internal abstract object UnsafeGetValue(object obj) { }

	internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}


namespace System.Reflection;

public class InvalidFilterCriteriaException : ApplicationException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public InvalidFilterCriteriaException() { }

	[CalledBy(Type = typeof(Type), Member = "FilterAttributeImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "FilterNameImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "FilterNameIgnoreCaseImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Module), Member = "FilterTypeNameImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Module), Member = "FilterTypeNameIgnoreCaseImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public InvalidFilterCriteriaException(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public InvalidFilterCriteriaException(string message, Exception inner) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected InvalidFilterCriteriaException(SerializationInfo info, StreamingContext context) { }

}


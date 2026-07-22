namespace System.Net;

internal class HttpRequestCreator : IWebRequestCreate
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal HttpRequestCreator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	public override WebRequest Create(Uri uri) { }

}


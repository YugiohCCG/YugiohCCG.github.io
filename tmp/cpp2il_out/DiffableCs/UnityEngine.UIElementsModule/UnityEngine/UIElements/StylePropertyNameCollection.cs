namespace UnityEngine.UIElements;

public struct StylePropertyNameCollection : IEnumerable<StylePropertyName>, IEnumerable
{
	internal struct Enumerator : IEnumerator<StylePropertyName>, IEnumerator, IDisposable
	{
		private Enumerator<StylePropertyName> m_Enumerator; //Field offset: 0x0

		public override StylePropertyName Current
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 65
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			private get { } //Length: 97
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal Enumerator(Enumerator<StylePropertyName> enumerator) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		public override StylePropertyName get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		public override bool MoveNext() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal List<StylePropertyName> propertiesList; //Field offset: 0x0

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal StylePropertyNameCollection(List<StylePropertyName> list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsUnknownMethods(Count = 2)]
	public Enumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsUnknownMethods(Count = 2)]
	private override IEnumerator<StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsUnknownMethods(Count = 2)]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}


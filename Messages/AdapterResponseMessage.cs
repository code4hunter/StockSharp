namespace StockSharp.Messages
{
	using System;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	using Ecng.Collections;

	/// <summary>
	/// Adapter response message.
	/// </summary>
	[Serializable]
	[DataContract]
	public class AdapterResponseMessage : BaseResultMessage<AdapterResponseMessage>
	{
		/// <summary>
		/// Initialize <see cref="AdapterResponseMessage"/>.
		/// </summary>
		public AdapterResponseMessage()
			: base(MessageTypes.AdapterResponse)
		{
		}

		/// <summary>
		/// Parameters.
		/// </summary>
		[DataMember]
		public IDictionary<string, Tuple<string, string>> Parameters { get; private set; } = new Dictionary<string, Tuple<string, string>>();

		/// <inheritdoc />
		protected override void CopyTo(AdapterResponseMessage destination)
		{
			base.CopyTo(destination);

			destination.Parameters = Parameters.ToDictionary();
		}
	}
}
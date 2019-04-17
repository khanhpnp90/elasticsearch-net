﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	[JsonFormatter(typeof(ResolvableDictionaryResponseFormatter<GetRollupIndexCapabilitiesResponse, IndexName, RollupIndexCapabilities>))]
	public class GetRollupIndexCapabilitiesResponse : DictionaryResponseBase<IndexName, RollupIndexCapabilities>
	{
		public IReadOnlyDictionary<IndexName, RollupIndexCapabilities> Indices => Self.BackingDictionary;
	}

	public class RollupIndexCapabilities
	{
		[DataMember(Name = "rollup_jobs")]
		public IReadOnlyCollection<RollupIndexCapabilitiesJob> RollupJobs { get; internal set; }
	}

	public class RollupIndexCapabilitiesJob
	{
		[DataMember(Name = "fields")]
		public RollupFieldsIndexCapabilitiesDictionary Fields { get; internal set; }

		[DataMember(Name = "index_pattern")]
		public string IndexPattern { get; internal set; }

		[DataMember(Name = "job_id")]
		public string JobId { get; internal set; }

		[DataMember(Name = "rollup_index")]
		public string RollupIndex { get; internal set; }
	}

	public class RollupFieldsIndexCapabilities : IsADictionaryBase<string, string> { }

	[JsonFormatter(typeof(Converter))]
	public class RollupFieldsIndexCapabilitiesDictionary : ResolvableDictionaryProxy<Field, IReadOnlyCollection<RollupFieldsIndexCapabilities>>
	{
		internal RollupFieldsIndexCapabilitiesDictionary(IConnectionConfigurationValues c,
			IReadOnlyDictionary<Field, IReadOnlyCollection<RollupFieldsIndexCapabilities>> b
		) : base(c, b) { }

		public IReadOnlyCollection<RollupFieldsIndexCapabilities> Field<T>(Expression<Func<T, object>> selector) => this[selector];

		internal class Converter : ResolvableDictionaryFormatterBase
				<RollupFieldsIndexCapabilitiesDictionary, Field, IReadOnlyCollection<RollupFieldsIndexCapabilities>>
		{
			protected override RollupFieldsIndexCapabilitiesDictionary Create(
				IConnectionSettingsValues s, Dictionary<Field, IReadOnlyCollection<RollupFieldsIndexCapabilities>> d
			) => new RollupFieldsIndexCapabilitiesDictionary(s, d);
		}
	}
}

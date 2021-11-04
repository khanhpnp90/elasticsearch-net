// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Clients.Elasticsearch.Experimental;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexDiskUsageRequestParameters : RequestParameters<IndexDiskUsageRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Flush { get => Q<bool?>("flush"); set => Q("flush", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.TimeUnit? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.TimeUnit?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.TimeUnit? Timeout { get => Q<Elastic.Clients.Elasticsearch.TimeUnit?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? RunExpensiveTasks { get => Q<bool?>("run_expensive_tasks"); set => Q("run_expensive_tasks", value); }

		[JsonIgnore]
		public string? WaitForActiveShards { get => Q<string?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	}

	public partial class IndexDiskUsageRequest : PlainRequestBase<IndexDiskUsageRequestParameters>
	{
		public IndexDiskUsageRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDiskUsage;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Flush { get => Q<bool?>("flush"); set => Q("flush", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.TimeUnit? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.TimeUnit?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.TimeUnit? Timeout { get => Q<Elastic.Clients.Elasticsearch.TimeUnit?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? RunExpensiveTasks { get => Q<bool?>("run_expensive_tasks"); set => Q("run_expensive_tasks", value); }

		[JsonIgnore]
		public string? WaitForActiveShards { get => Q<string?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	}

	[JsonConverter(typeof(IndexDiskUsageRequestDescriptorConverter))]
	public sealed partial class IndexDiskUsageRequestDescriptor : RequestDescriptorBase<IndexDiskUsageRequestDescriptor, IndexDiskUsageRequestParameters>
	{
		public IndexDiskUsageRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDiskUsage;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public IndexDiskUsageRequestDescriptor AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public IndexDiskUsageRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public IndexDiskUsageRequestDescriptor Flush(bool? flush) => Qs("flush", flush);
		public IndexDiskUsageRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public IndexDiskUsageRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.TimeUnit? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IndexDiskUsageRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.TimeUnit? timeout) => Qs("timeout", timeout);
		public IndexDiskUsageRequestDescriptor RunExpensiveTasks(bool? runExpensiveTasks) => Qs("run_expensive_tasks", runExpensiveTasks);
		public IndexDiskUsageRequestDescriptor WaitForActiveShards(string? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	}

	internal sealed class IndexDiskUsageRequestDescriptorConverter : JsonConverter<IndexDiskUsageRequestDescriptor>
	{
		public override IndexDiskUsageRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IndexDiskUsageRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}
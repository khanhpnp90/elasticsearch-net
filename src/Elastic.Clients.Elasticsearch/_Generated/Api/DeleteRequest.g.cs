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
namespace Elastic.Clients.Elasticsearch
{
	public class DeleteRequestParameters : RequestParameters<DeleteRequestParameters>
	{
		[JsonIgnore]
		public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

		[JsonIgnore]
		public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public string? Routing { get => Q<string?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public long? Version { get => Q<long?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	}

	public partial class DeleteRequest : PlainRequestBase<DeleteRequestParameters>
	{
		public DeleteRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

		[JsonIgnore]
		public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public string? Routing { get => Q<string?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public long? Version { get => Q<long?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	}

	[JsonConverter(typeof(DeleteRequestDescriptorConverter))]
	public sealed partial class DeleteRequestDescriptor : RequestDescriptorBase<DeleteRequestDescriptor, DeleteRequestParameters>
	{
		public DeleteRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public DeleteRequestDescriptor IfPrimaryTerm(long? ifPrimaryTerm) => Qs("if_primary_term", ifPrimaryTerm);
		public DeleteRequestDescriptor IfSeqNo(long? ifSeqNo) => Qs("if_seq_no", ifSeqNo);
		public DeleteRequestDescriptor Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);
		public DeleteRequestDescriptor Routing(string? routing) => Qs("routing", routing);
		public DeleteRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public DeleteRequestDescriptor Version(long? version) => Qs("version", version);
		public DeleteRequestDescriptor VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);
		public DeleteRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	}

	internal sealed class DeleteRequestDescriptorConverter : JsonConverter<DeleteRequestDescriptor>
	{
		public override DeleteRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, DeleteRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}
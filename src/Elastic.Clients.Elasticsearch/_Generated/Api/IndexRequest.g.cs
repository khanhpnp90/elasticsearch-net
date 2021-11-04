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
	public class IndexRequestParameters : RequestParameters<IndexRequestParameters>
	{
		[JsonIgnore]
		public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

		[JsonIgnore]
		public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.OpType? OpType { get => Q<Elastic.Clients.Elasticsearch.OpType?>("op_type"); set => Q("op_type", value); }

		[JsonIgnore]
		public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

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

		[JsonIgnore]
		public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }
	}

	public partial class IndexRequest<TDocument> : PlainRequestBase<IndexRequestParameters>
	{
		public IndexRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Required("index", index).Optional("id", id))
		{
		}

		public IndexRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceIndex;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public TDocument Document { get; set; }

		[JsonIgnore]
		public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

		[JsonIgnore]
		public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.OpType? OpType { get => Q<Elastic.Clients.Elasticsearch.OpType?>("op_type"); set => Q("op_type", value); }

		[JsonIgnore]
		public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

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

		[JsonIgnore]
		public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }
	}

	public sealed partial class IndexRequestDescriptor<TDocument> : RequestDescriptorBase<IndexRequestDescriptor<TDocument>, IndexRequestParameters>
	{
		public IndexRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Required("index", index).Optional("id", id))
		{
		}

		public IndexRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		internal TDocument _document;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceIndex;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public IndexRequestDescriptor<TDocument> IfPrimaryTerm(long? ifPrimaryTerm) => Qs("if_primary_term", ifPrimaryTerm);
		public IndexRequestDescriptor<TDocument> IfSeqNo(long? ifSeqNo) => Qs("if_seq_no", ifSeqNo);
		public IndexRequestDescriptor<TDocument> OpType(Elastic.Clients.Elasticsearch.OpType? opType) => Qs("op_type", opType);
		public IndexRequestDescriptor<TDocument> Pipeline(string? pipeline) => Qs("pipeline", pipeline);
		public IndexRequestDescriptor<TDocument> Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);
		public IndexRequestDescriptor<TDocument> Routing(string? routing) => Qs("routing", routing);
		public IndexRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public IndexRequestDescriptor<TDocument> Version(long? version) => Qs("version", version);
		public IndexRequestDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);
		public IndexRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
		public IndexRequestDescriptor<TDocument> RequireAlias(bool? requireAlias) => Qs("require_alias", requireAlias);
		public IndexRequestDescriptor<TDocument> Document(TDocument document) => Assign(document, (a, v) => a._document = v);
	}
}
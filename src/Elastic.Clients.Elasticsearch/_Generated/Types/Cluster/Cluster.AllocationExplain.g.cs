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

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster.AllocationExplain
{
	public partial class AllocationDecision
	{
		[JsonInclude]
		[JsonPropertyName("decider")]
		public string Decider { get; init; }

		[JsonInclude]
		[JsonPropertyName("decision")]
		public Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.AllocationExplainDecision Decision { get; init; }

		[JsonInclude]
		[JsonPropertyName("explanation")]
		public string Explanation { get; init; }
	}

	public partial class AllocationStore
	{
		[JsonInclude]
		[JsonPropertyName("allocation_id")]
		public string AllocationId { get; init; }

		[JsonInclude]
		[JsonPropertyName("found")]
		public bool Found { get; init; }

		[JsonInclude]
		[JsonPropertyName("in_sync")]
		public bool InSync { get; init; }

		[JsonInclude]
		[JsonPropertyName("matching_size_in_bytes")]
		public long MatchingSizeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("matching_sync_id")]
		public bool MatchingSyncId { get; init; }

		[JsonInclude]
		[JsonPropertyName("store_exception")]
		public string StoreException { get; init; }
	}

	public partial class ClusterInfo
	{
		[JsonInclude]
		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.NodeDiskUsage> Nodes { get; init; }

		[JsonInclude]
		[JsonPropertyName("shard_sizes")]
		public Dictionary<string, long> ShardSizes { get; init; }

		[JsonInclude]
		[JsonPropertyName("shard_data_set_sizes")]
		public Dictionary<string, string>? ShardDataSetSizes { get; init; }

		[JsonInclude]
		[JsonPropertyName("shard_paths")]
		public Dictionary<string, string> ShardPaths { get; init; }

		[JsonInclude]
		[JsonPropertyName("reserved_sizes")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.ReservedSize> ReservedSizes { get; init; }
	}

	public partial class CurrentNode
	{
		[JsonInclude]
		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id Id { get; init; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name { get; init; }

		[JsonInclude]
		[JsonPropertyName("attributes")]
		public Dictionary<string, string> Attributes { get; init; }

		[JsonInclude]
		[JsonPropertyName("transport_address")]
		public string TransportAddress { get; init; }

		[JsonInclude]
		[JsonPropertyName("weight_ranking")]
		public int WeightRanking { get; init; }
	}

	public partial class DiskUsage
	{
		[JsonInclude]
		[JsonPropertyName("path")]
		public string Path { get; init; }

		[JsonInclude]
		[JsonPropertyName("total_bytes")]
		public long TotalBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("used_bytes")]
		public long UsedBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("free_bytes")]
		public long FreeBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("free_disk_percent")]
		public double FreeDiskPercent { get; init; }

		[JsonInclude]
		[JsonPropertyName("used_disk_percent")]
		public double UsedDiskPercent { get; init; }
	}

	public partial class NodeAllocationExplanation
	{
		[JsonInclude]
		[JsonPropertyName("deciders")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.AllocationDecision> Deciders { get; init; }

		[JsonInclude]
		[JsonPropertyName("node_attributes")]
		public Dictionary<string, string> NodeAttributes { get; init; }

		[JsonInclude]
		[JsonPropertyName("node_decision")]
		public Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.Decision NodeDecision { get; init; }

		[JsonInclude]
		[JsonPropertyName("node_id")]
		public Elastic.Clients.Elasticsearch.Id NodeId { get; init; }

		[JsonInclude]
		[JsonPropertyName("node_name")]
		public Elastic.Clients.Elasticsearch.Name NodeName { get; init; }

		[JsonInclude]
		[JsonPropertyName("store")]
		public Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.AllocationStore? Store { get; init; }

		[JsonInclude]
		[JsonPropertyName("transport_address")]
		public string TransportAddress { get; init; }

		[JsonInclude]
		[JsonPropertyName("weight_ranking")]
		public int WeightRanking { get; init; }
	}

	public partial class NodeDiskUsage
	{
		[JsonInclude]
		[JsonPropertyName("node_name")]
		public Elastic.Clients.Elasticsearch.Name NodeName { get; init; }

		[JsonInclude]
		[JsonPropertyName("least_available")]
		public Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.DiskUsage LeastAvailable { get; init; }

		[JsonInclude]
		[JsonPropertyName("most_available")]
		public Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.DiskUsage MostAvailable { get; init; }
	}

	public partial class ReservedSize
	{
		[JsonInclude]
		[JsonPropertyName("node_id")]
		public Elastic.Clients.Elasticsearch.Id NodeId { get; init; }

		[JsonInclude]
		[JsonPropertyName("path")]
		public string Path { get; init; }

		[JsonInclude]
		[JsonPropertyName("total")]
		public long Total { get; init; }

		[JsonInclude]
		[JsonPropertyName("shards")]
		public IReadOnlyCollection<string> Shards { get; init; }
	}

	public partial class UnassignedInformation
	{
		[JsonInclude]
		[JsonPropertyName("at")]
		public string At { get; init; }

		[JsonInclude]
		[JsonPropertyName("last_allocation_status")]
		public string? LastAllocationStatus { get; init; }

		[JsonInclude]
		[JsonPropertyName("reason")]
		public Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.UnassignedInformationReason Reason { get; init; }

		[JsonInclude]
		[JsonPropertyName("details")]
		public string? Details { get; init; }

		[JsonInclude]
		[JsonPropertyName("failed_allocation_attempts")]
		public int? FailedAllocationAttempts { get; init; }

		[JsonInclude]
		[JsonPropertyName("delayed")]
		public bool? Delayed { get; init; }

		[JsonInclude]
		[JsonPropertyName("allocation_status")]
		public string? AllocationStatus { get; init; }
	}
}
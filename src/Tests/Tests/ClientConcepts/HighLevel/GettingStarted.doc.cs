﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Nest;

namespace Tests.ClientConcepts.HighLevel
{
	//TODO update documentation here to reflect type removal

	/**[[nest-getting-started]]
	 * == Getting started
	 *
	 * NEST is a high level Elasticsearch .NET client that still maps very closely to the original Elasticsearch API.
	 * All requests and responses are exposed through types, making it ideal for getting up and running quickly.
	 *
	 * Under the covers, NEST uses the <<elasticsearch-net,Elasticsearch.Net low level client>> to dispatch requests and
	 * responses, using and extending many of the types within Elasticsearch.Net. The low level client itself is still
	 * exposed on the high level client through the `.LowLevel` property.
	 */
	public class GettingStarted
	{
		private IElasticClient client = new ElasticClient(new ConnectionSettings(new SingleNodeConnectionPool(new Uri("http://localhost:9200")), new InMemoryConnection()));

		/**[float]
		 * === Connecting
		 *
		 * To connect to Elasticsearch running locally at `http://localhost:9200` is as simple as instantiating a new instance of the client
		 */
		public void SimpleInstantiation()
		{
			var client = new ElasticClient();
		}

		/**
		 * Often you may need to pass additional configuration options to the client such as the address of Elasticsearch if it's running on
		 * a remote machine. This is where `ConnectionSettings` come in; an instance can be instantiated to provide the client with different
		 * configurations.
		 */
		public void UsingConnectionSettings()
		{
			var settings = new ConnectionSettings(new Uri("http://example.com:9200"))
				.DefaultIndex("people");

			var client = new ElasticClient(settings);
		}

		/**
		 * In this example, a default index was also specified to use if no other index is supplied for the request or can be inferred for the
		 * POCO generic type parameter in the request. There are many other <<configuration-options,Configuration options>> on `ConnectionSettings`, which it inherits
		 * from `ConnectionConfiguration`, the type used to pass additional configuration options to the low level client in <<elasticsearch-net,Elasticsearch.Net>>.
		 *
		 * TIP: Specifying a default index is _optional_ but NEST may throw an exception if no index can be inferred for a given request. To understand more around how
		 * an index can be specified for a request, see <<index-name-inference,Index name inference>>.
		 *
		 * `ConnectionSettings` is not restricted to being passed a single address for Elasticsearch. There are several different
		 * types of <<connection-pooling,Connection pool>> available in NEST, each with different characteristics, that can be used to
		 * configure the client. The following example uses a <<sniffing-connection-pool,SniffingConnectionPool>> seeded with the addresses
		 * of three Elasticsearch nodes in the cluster, and the client will use this type of pool to maintain a list of available nodes within the
		 * cluster to which it can send requests in a round-robin fashion.
		 */
		public void UsingConnectionPool()
		{
			var uris = new[]
			{
				new Uri("http://localhost:9200"),
				new Uri("http://localhost:9201"),
				new Uri("http://localhost:9202"),
			};

			var connectionPool = new SniffingConnectionPool(uris);
			var settings = new ConnectionSettings(connectionPool)
				.DefaultIndex("people");

			var client = new ElasticClient(settings);
		}

		/**[float]
		 * === Indexing
		 *
		 * Once a client had been configured to connect to Elasticsearch, we need to get some data into the cluster
		 * to work with.
		 *
		 * Imagine we have the following http://en.wikipedia.org/wiki/Plain_Old_CLR_Object[Plain Old CLR Object (POCO)]
		 */
		public class Person
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }
		}

		/**
		 * Indexing a single instance of the POCO either synchronously or asynchronously, is as simple as
		 */
		public async Task Indexing()
		{
			var person = new Person
			{
				Id = 1,
				FirstName = "Martijn",
				LastName = "Laarman"
			};

			var ndexResponse = client.IndexDocument(person); //<1> synchronous method that returns an `IndexResponse`

			var asyncIndexResponse = await client.IndexDocumentAsync(person); //<2> asynchronous method that returns a `Task<IndexResponse>` that can be awaited
		}

		/**
		 * NOTE: All methods available within NEST are exposed as both synchronous and asynchronous versions,
		 * with the latter using the idiomatic *Async suffix on the method name.
		 *
		 * This will index the document to the endpoint `/people/person/1`. NEST is smart enough to infer the
		 * type from the Person CLR type as well as infer the id for the document by looking for an `Id` property on the POCO. Take a look
		 * at <<ids-inference,Ids inference>> to see other ways in which NEST can be configured to infer an id for a document. The default index configured
		 * on `ConnectionSettings` has been used as the index name for the request.
		 *
		 * CAUTION: By default, NEST camel cases the property names on the POCO when serializing the POCO into a JSON document to send to Elasticsearch.
		 * You can <<camel-casing,change this behaviour>> by using the `.DefaultFieldNameInferrer(Func<string,string>)` method on `ConnectionSettings`.
		 *
		 * [float]
		 * === Searching
		 *
		 * Now that we have indexed some documents we can begin to search for them.
		 */
		public void Searching()
		{
			var searchResponse = client.Search<Person>(s => s
				.From(0)
				.Size(10)
				.Query(q => q
					 .Match(m => m
						.Field(f => f.FirstName)
						.Query("Martijn")
					 )
				)
			);

			var people = searchResponse.Documents;
		}

		/**
		 * `people` now holds the first ten people whose first name is Martijn. The search endpoint for this query is
		 * `/people/_search` and the index (`"people"`) has been determined from
		 *
		 * . the default index on `ConnectionSettings`
		 * . the `Person` generic type parameter on the search.
		 *
		 *
		 * which generates a request to the search endpoint `/people/_search`, using the default index specified on `ConnectionSettings` as the index
		 * in the search request.
		 *
		 * Similarly, a search can be performed for `person` types in all indices with `.AllIndices()`
		 */
		public void SearchingAllIndices()
		{
			var searchResponse = client.Search<Person>(s => s
				.AllIndices()
				.From(0)
				.Size(10)
				.Query(q => q
					 .Match(m => m
						.Field(f => f.FirstName)
						.Query("Martijn")
					 )
				)
			);
		}

		/**
		 * which generates a request to the search endpoint `/_search`, taking the `person` type from the generic type parameter on the search
		 * method.
		 *
		 * Both `.AllTypes()` and `.AllIndices()` can be provided to perform a search across _all_ types in _all_ indices, generating a request to `/_search`
		 */
		public async Task SearchingAllIndicesAndAllTypes()
		{
			var searchResponse = await client.SearchAsync<Person>(s => s
				.AllIndices()
				.From(0)
				.Size(10)
				.Query(q => q
					 .Match(m => m
						.Field(f => f.FirstName)
						.Query("Martijn")
					 )
				)
			);
		}

		/**
		 * Single or multiple index and type names can be provided in the request;
		 * see the documentation on <<indices-paths,Indices paths>> and <<document-paths,Document paths>>, respectively.
		 *
		 * All of the search examples so far have used NEST's Fluent API which uses lambda expressions to construct a query with a structure
		 * that mimics the structure of a query expressed in the Elasticsearch's JSON based {ref_current}/query-dsl.html[Query DSL].
		 *
		 * NEST also exposes an Object Initializer syntax that can also be used to construct queries,
		 * for those not keen on deeply nested lambda expressions (layout is __key__!).
		 *
		 * Here's the same query as the previous example, this time constructed using the Object Initializer syntax
		 */
		public async Task ObjectInitializerSyntax()
		{
			var searchRequest = new SearchRequest<Person>(Nest.Indices.All) //<1> All indices and types are specified in the constructor
			{
				From = 0,
				Size = 10,
				Query = new MatchQuery
				{
					Field = Infer.Field<Person>(f => f.FirstName),
					Query = "Martijn"
				}
			};

			var searchResponse = await client.SearchAsync<Person>(searchRequest);
		}

		/** [NOTE]
		 * --
		 * As indicated at the start of this section, the high level client still exposes the low level client from Elasticsearch.Net
		 * through the `.LowLevel` property on the client. The low level client can be useful in scenarios where you may already have
		 * the JSON that represents the request that you wish to send and don't wish to translate it over to the Fluent API or Object Initializer syntax
		 * at this point in time, or perhaps there is a bug in the client that can be worked around by sending a request as a string or anonymous type.
		 *
		 * Using the low level client via the `.LowLevel` property means you can get with the best of both worlds:
		 *
		 * . Use the high level client
		 * . Use the low level client where it makes sense, taking advantage of all the strong types within NEST and using the JSON.Net based
		 * serializer for deserialization.
		 *
		 * Here's an example
		 */

		public void SearchingWithTheLowLevelClient()
		{
			var searchResponse = client.LowLevel.Search<SearchResponse<Person>>("people", PostData.Serializable(new
			{
				from = 0,
				size = 10,
				query = new
				{
					match = new
					{
						field = "firstName",
						query = "Martijn"
					}
				}
			}));

			var responseJson = searchResponse;
		}
		/**
		 * Here, the query is represented as an anonymous type, but the body of the response is a concrete
		 * implementation of the same response type returned from NEST.
		 * --
		 */


		/**[float]
		 * === Aggregations
		 *
		 * In addition to structured and unstructured search, Elasticsearch is also able to aggregate data based on a search query
		 */
		public async Task Aggregations()
		{
			var searchResponse = await client.SearchAsync<Person>(s => s
				.Size(0)
				.Query(q => q
					 .Match(m => m
						.Field(f => f.FirstName)
						.Query("Martijn")
					 )
				)
				.Aggregations(a => a
					.Terms("last_names", ta => ta
						.Field(f => f.LastName)
					)
				)
			);

			var termsAggregation = searchResponse.Aggregations.Terms("last_names");
		}

		/**
		 * In this example, a `match` query to search for people with the first name of "Martijn" is issued as before;
		 * this time however,
		 *
		 * . a size of `0` is set because we don't want the first 10 documents that match this query to be returned,
		 * we're only interested in the aggregation results
		 * . a `terms` aggregation is specified to group matching documents into buckets based on last name.
		 *
		 * `termsAggregation` can be used to get the count of documents for each bucket, where each bucket will be
		 * keyed by last name.
		 *
		 * See <<writing-aggregations, Writing aggregations>> for more details.
		 */
	}
}

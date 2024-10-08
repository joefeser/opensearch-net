/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*   http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//
// This file is automatically generated
// Please do not edit these files manually
// Run the following in the root of the repos:
//
//      *NIX        :   ./build.sh codegen
//      Windows     :   build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using OpenSearch.Net;
using OpenSearch.Net.Specification.IndicesApi;
using OpenSearch.Net.Utf8Json;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
    [InterfaceDataContract]
    public partial interface IDeleteComposableIndexTemplateRequest
        : IRequest<DeleteComposableIndexTemplateRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for DeleteComposableTemplate <para>https://opensearch.org/docs/latest/im-plugin/index-templates/#delete-a-template</para></summary>
    public partial class DeleteComposableIndexTemplateRequest
        : PlainRequestBase<DeleteComposableIndexTemplateRequestParameters>,
            IDeleteComposableIndexTemplateRequest
    {
        protected IDeleteComposableIndexTemplateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesDeleteComposableTemplate;

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public DeleteComposableIndexTemplateRequest(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected DeleteComposableIndexTemplateRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IDeleteComposableIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>
        /// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns
        /// an error.
        /// </summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }

        /// <summary>Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.</summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IComposableIndexTemplateExistsRequest
        : IRequest<ComposableIndexTemplateExistsRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for ComposableTemplateExists <para>https://opensearch.org/docs/latest/im-plugin/index-templates/</para></summary>
    public partial class ComposableIndexTemplateExistsRequest
        : PlainRequestBase<ComposableIndexTemplateExistsRequestParameters>,
            IComposableIndexTemplateExistsRequest
    {
        protected IComposableIndexTemplateExistsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesComposableTemplateExists;

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public ComposableIndexTemplateExistsRequest(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected ComposableIndexTemplateExistsRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IComposableIndexTemplateExistsRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Return settings in flat format.</summary>
        public bool? FlatSettings
        {
            get => Q<bool?>("flat_settings");
            set => Q("flat_settings", value);
        }

        /// <summary>Return local information, do not retrieve the state from cluster-manager node.</summary>
        public bool? Local
        {
            get => Q<bool?>("local");
            set => Q("local", value);
        }

        /// <summary>
        /// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns
        /// an error.
        /// </summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IGetComposableIndexTemplateRequest
        : IRequest<GetComposableIndexTemplateRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for GetComposableTemplate <para>https://opensearch.org/docs/latest/im-plugin/index-templates/</para></summary>
    public partial class GetComposableIndexTemplateRequest
        : PlainRequestBase<GetComposableIndexTemplateRequestParameters>,
            IGetComposableIndexTemplateRequest
    {
        protected IGetComposableIndexTemplateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesGetComposableTemplate;

        /// <summary>/_index_template</summary>
        public GetComposableIndexTemplateRequest()
            : base() { }

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">Optional, accepts null</param>
        public GetComposableIndexTemplateRequest(Name name)
            : base(r => r.Optional("name", name)) { }

        // values part of the url path
        [IgnoreDataMember]
        Name IGetComposableIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>If true, returns settings in flat format.</summary>
        public bool? FlatSettings
        {
            get => Q<bool?>("flat_settings");
            set => Q("flat_settings", value);
        }

        /// <summary>
        /// If true, the request retrieves information from the local node only. Defaults to false, which means information is retrieved from the
        /// master node.
        /// </summary>
        public bool? Local
        {
            get => Q<bool?>("local");
            set => Q("local", value);
        }

        /// <summary>
        /// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns
        /// an error.
        /// </summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IPutComposableIndexTemplateRequest
        : IRequest<PutComposableIndexTemplateRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for PutComposableTemplate <para>https://opensearch.org/docs/latest/im-plugin/index-templates/</para></summary>
    public partial class PutComposableIndexTemplateRequest
        : PlainRequestBase<PutComposableIndexTemplateRequestParameters>,
            IPutComposableIndexTemplateRequest
    {
        protected IPutComposableIndexTemplateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesPutComposableTemplate;

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public PutComposableIndexTemplateRequest(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected PutComposableIndexTemplateRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IPutComposableIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>User defined reason for creating/updating the index template.</summary>
        public string Cause
        {
            get => Q<string>("cause");
            set => Q("cause", value);
        }

        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>If `true`, this request cannot replace or update existing index templates.</summary>
        public bool? Create
        {
            get => Q<bool?>("create");
            set => Q("create", value);
        }

        /// <summary>Operation timeout for connection to master node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IIndicesStatsRequest : IRequest<IndicesStatsRequestParameters>
    {
        [IgnoreDataMember]
        Indices Index { get; }

        [IgnoreDataMember]
        Metrics Metric { get; }
    }

    /// <summary>Request for Stats <para>https://opensearch.org/docs/latest</para></summary>
    public partial class IndicesStatsRequest
        : PlainRequestBase<IndicesStatsRequestParameters>,
            IIndicesStatsRequest
    {
        protected IIndicesStatsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesStats;

        /// <summary>/_stats</summary>
        public IndicesStatsRequest()
            : base() { }

        /// <summary>/{index}/_stats</summary>
        /// <param name="index">Optional, accepts null</param>
        public IndicesStatsRequest(Indices index)
            : base(r => r.Optional("index", index)) { }

        /// <summary>/{index}/_stats/{metric}</summary>
        /// <param name="index">Optional, accepts null</param>
        /// <param name="metric">Optional, accepts null</param>
        public IndicesStatsRequest(Indices index, Metrics metric)
            : base(r => r.Optional("index", index).Optional("metric", metric)) { }

        /// <summary>/_stats/{metric}</summary>
        /// <param name="metric">Optional, accepts null</param>
        public IndicesStatsRequest(Metrics metric)
            : base(r => r.Optional("metric", metric)) { }

        // values part of the url path
        [IgnoreDataMember]
        Indices IIndicesStatsRequest.Index => Self.RouteValues.Get<Indices>("index");

        [IgnoreDataMember]
        Metrics IIndicesStatsRequest.Metric => Self.RouteValues.Get<Metrics>("metric");

        // Request parameters
        /// <summary>Comma-separated list or wildcard expressions of fields to include in fielddata and suggest statistics.</summary>
        public Fields CompletionFields
        {
            get => Q<Fields>("completion_fields");
            set => Q("completion_fields", value);
        }

        /// <summary>
        /// Type of index that wildcard patterns can match. If the request can target data streams, this argument determines whether wildcard
        /// expressions match hidden data streams. Supports comma-separated values, such as `open,hidden`.
        /// </summary>
        public ExpandWildcards? ExpandWildcards
        {
            get => Q<ExpandWildcards?>("expand_wildcards");
            set => Q("expand_wildcards", value);
        }

        /// <summary>Comma-separated list or wildcard expressions of fields to include in fielddata statistics.</summary>
        public Fields FielddataFields
        {
            get => Q<Fields>("fielddata_fields");
            set => Q("fielddata_fields", value);
        }

        /// <summary>Comma-separated list or wildcard expressions of fields to include in the statistics.</summary>
        public Fields Fields
        {
            get => Q<Fields>("fields");
            set => Q("fields", value);
        }

        /// <summary>If true, statistics are not collected from closed indices.</summary>
        public bool? ForbidClosedIndices
        {
            get => Q<bool?>("forbid_closed_indices");
            set => Q("forbid_closed_indices", value);
        }

        /// <summary>Comma-separated list of search groups to include in the search statistics.</summary>
        public string[] Groups
        {
            get => Q<string[]>("groups");
            set => Q("groups", value);
        }

        /// <summary>If true, the call reports the aggregated disk usage of each one of the Lucene index files (only applies if segment stats are requested).</summary>
        public bool? IncludeSegmentFileSizes
        {
            get => Q<bool?>("include_segment_file_sizes");
            set => Q("include_segment_file_sizes", value);
        }

        /// <summary>If true, the response includes information from segments that are not loaded into memory.</summary>
        public bool? IncludeUnloadedSegments
        {
            get => Q<bool?>("include_unloaded_segments");
            set => Q("include_unloaded_segments", value);
        }

        /// <summary>Indicates whether statistics are aggregated at the cluster, index, or shard level.</summary>
        public Level? Level
        {
            get => Q<Level?>("level");
            set => Q("level", value);
        }
    }
}

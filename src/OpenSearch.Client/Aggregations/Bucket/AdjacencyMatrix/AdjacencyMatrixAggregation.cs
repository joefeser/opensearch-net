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
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/

using System;
using System.Runtime.Serialization;
using OpenSearch.Net.Utf8Json;

namespace OpenSearch.Client;

[InterfaceDataContract]
[ReadAs(typeof(AdjacencyMatrixAggregation))]
public interface IAdjacencyMatrixAggregation : IBucketAggregation
{
    [DataMember(Name = "filters")]
    INamedFiltersContainer Filters { get; set; }
}

public class AdjacencyMatrixAggregation : BucketAggregationBase, IAdjacencyMatrixAggregation
{
    internal AdjacencyMatrixAggregation() { }

    public AdjacencyMatrixAggregation(string name) : base(name) { }

    public INamedFiltersContainer Filters { get; set; }

    internal override void WrapInContainer(AggregationContainer c) => c.AdjacencyMatrix = this;
}

public class AdjacencyMatrixAggregationDescriptor<T>
    : BucketAggregationDescriptorBase<AdjacencyMatrixAggregationDescriptor<T>, IAdjacencyMatrixAggregation, T>
        , IAdjacencyMatrixAggregation
    where T : class
{
    INamedFiltersContainer IAdjacencyMatrixAggregation.Filters { get; set; }

    public AdjacencyMatrixAggregationDescriptor<T> Filters(Func<NamedFiltersContainerDescriptor<T>, IPromise<INamedFiltersContainer>> selector) =>
        Assign(selector, (a, v) => a.Filters = v?.Invoke(new NamedFiltersContainerDescriptor<T>())?.Value);
}

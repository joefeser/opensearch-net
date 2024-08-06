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

using FluentAssertions;
using OpenSearch.Client;
using OpenSearch.OpenSearch.Xunit.XunitPlumbing;
using Tests.Core.Extensions;

namespace Tests.ClientConcepts.HighLevel.Inference.Equality
{
    public class NodeIdsEqualityTests
    {
        [U]
        public void Eq()
        {
            NodeIds types = "foo,bar";
            NodeIds[] equal = { "foo,bar", "bar,foo", "foo,  bar", "bar,  foo   " };
            foreach (var t in equal)
            {
                (t == types).ShouldBeTrue(t);
                t.Should().Be(types);
            }
        }

        [U]
        public void NotEq()
        {
            NodeIds types = "foo,bar";
            NodeIds[] notEqual = { "foo,bar,x", "foo" };
            foreach (var t in notEqual)
            {
                (t != types).ShouldBeTrue(t);
                t.Should().NotBe(types);
            }
        }

        [U]
        public void Null()
        {
            NodeIds value = "foo";
            (value == null).Should().BeFalse();
            (null == value).Should().BeFalse();
        }
    }
}

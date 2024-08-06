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

using System.Runtime.Serialization;

namespace OpenSearch.Client
{
    [DataContract]
    public class MergesStats
    {
        [DataMember(Name = "current")]
        public long Current { get; set; }

        [DataMember(Name = "current_docs")]
        public long CurrentDocuments { get; set; }

        [DataMember(Name = "current_size")]
        public string CurrentSize { get; set; }

        [DataMember(Name = "current_size_in_bytes")]
        public long CurrentSizeInBytes { get; set; }

        [DataMember(Name = "total")]
        public long Total { get; set; }

        [DataMember(Name = "total_auto_throttle")]
        public string TotalAutoThrottle { get; set; }

        [DataMember(Name = "total_auto_throttle_in_bytes")]
        public long TotalAutoThrottleInBytes { get; set; }

        [DataMember(Name = "total_docs")]
        public long TotalDocuments { get; set; }

        [DataMember(Name = "total_size")]
        public string TotalSize { get; set; }

        [DataMember(Name = "total_size_in_bytes")]
        public long TotalSizeInBytes { get; set; }

        [DataMember(Name = "total_stopped_time")]
        public string TotalStoppedTime { get; set; }

        [DataMember(Name = "total__stopped_time_in_millis")]
        public long TotalStoppedTimeInMilliseconds { get; set; }

        [DataMember(Name = "total_throttled_time")]
        public string TotalThrottledTime { get; set; }

        [DataMember(Name = "total_throttled_time_in_millis")]
        public long TotalThrottledTimeInMilliseconds { get; set; }

        [DataMember(Name = "total_time")]
        public string TotalTime { get; set; }

        [DataMember(Name = "total_time_in_millis")]
        public long TotalTimeInMilliseconds { get; set; }
    }
}

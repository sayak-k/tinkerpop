#region License

/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

#endregion

using System.Collections.Generic;

namespace Gremlin.Net.Driver.Messages
{
    /// <summary>
    ///     Represents the result as a response to a <see cref="RequestMessage"/> sent as part of a
    ///     <see cref="ResponseMessage{T}"/> by the server.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="Data"/>.</typeparam>
    public class ResponseResult<T>
    {
        /// <summary>
        ///     Gets or sets the data of this result.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        ///     Gets or sets meta data of this result.
        /// </summary>
        public Dictionary<string, object> Meta { get; set; }
    }
}
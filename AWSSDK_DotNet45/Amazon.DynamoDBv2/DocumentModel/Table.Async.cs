﻿/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Util;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.DocumentModel
{
    public partial class Table
    {
        #region PutItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the PutItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.PutItem"/>
        /// </summary>
        /// <param name="doc">Document to save.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task<Document> PutItemAsync(Document doc, PutItemOperationConfig config = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AsyncRunner.Run(() => PutItemHelper(doc, config, true), cancellationToken);
        }

        #endregion

        #region GetItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.GetItem"/>
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task<Document> GetItemAsync(Primitive hashKey, Primitive rangeKey = null, GetItemOperationConfig config = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AsyncRunner.Run(() => GetItemHelper(MakeKey(hashKey, rangeKey), config, true), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.GetItem"/>
        /// </summary>
        /// <param name="key">Ley of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task<Document> GetItemAsync(IDictionary<string, DynamoDBEntry> key, GetItemOperationConfig config = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AsyncRunner.Run(() => GetItemHelper(MakeKey(key), config, true), cancellationToken);
        }

        #endregion

        #region UpdateItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task<Document> UpdateItemAsync(Document doc, Primitive hashKey = null, Primitive rangeKey = null, UpdateItemOperationConfig config = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AsyncRunner.Run(() => UpdateHelper(doc, hashKey, rangeKey, config, true), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task<Document> UpdateItemAsync(Document doc, IDictionary<string, DynamoDBEntry> key, UpdateItemOperationConfig config = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AsyncRunner.Run(() => UpdateHelper(doc, MakeKey(key), config, true), cancellationToken);
        }

        #endregion

        #region DeleteItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="document">Document to delete.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task<Document> DeleteItemAsync(Document document, DeleteItemOperationConfig config = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AsyncRunner.Run(() => DeleteHelper(MakeKey(document), config, true), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task<Document> DeleteItemAsync(Primitive hashKey, Primitive rangeKey = null, DeleteItemOperationConfig config = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AsyncRunner.Run(() => DeleteHelper(MakeKey(hashKey, rangeKey), config, true), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task<Document> DeleteItemAsync(IDictionary<string, DynamoDBEntry> key, DeleteItemOperationConfig config = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AsyncRunner.Run(() => DeleteHelper(MakeKey(key), config, true), cancellationToken);
        }
        
        #endregion

    }
}
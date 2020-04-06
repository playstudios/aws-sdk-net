/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.QLDBSession.Model;
using Amazon.QLDBSession.Model.Internal.MarshallTransformations;
using Amazon.QLDBSession.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.QLDBSession
{
    /// <summary>
    /// Implementation for accessing QLDBSession
    ///
    /// The transactional data APIs for Amazon QLDB
    /// </summary>
    public partial class AmazonQLDBSessionClient : AmazonServiceClient, IAmazonQLDBSession
    {
        private static IServiceMetadata serviceMetadata = new AmazonQLDBSessionMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonQLDBSessionClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQLDBSessionConfig()) { }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonQLDBSessionClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQLDBSessionConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonQLDBSessionClient Configuration Object</param>
        public AmazonQLDBSessionClient(AmazonQLDBSessionConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQLDBSessionClient(AWSCredentials credentials)
            : this(credentials, new AmazonQLDBSessionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQLDBSessionClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQLDBSessionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Credentials and an
        /// AmazonQLDBSessionClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQLDBSessionClient Configuration Object</param>
        public AmazonQLDBSessionClient(AWSCredentials credentials, AmazonQLDBSessionConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQLDBSessionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQLDBSessionConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQLDBSessionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQLDBSessionClient Configuration Object</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQLDBSessionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQLDBSessionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQLDBSessionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBSessionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQLDBSessionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQLDBSessionClient Configuration Object</param>
        public AmazonQLDBSessionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQLDBSessionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  SendCommand

        /// <summary>
        /// Sends a command to an Amazon QLDB ledger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by QLDBSession.</returns>
        /// <exception cref="Amazon.QLDBSession.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.InvalidSessionException">
        /// Returned if the session doesn't exist anymore because it timed-out or expired.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.LimitExceededException">
        /// Returned if a resource limit such as number of active sessions is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.OccConflictException">
        /// Returned when a transaction cannot be written to the journal due to a failure in the
        /// verification phase of Optimistic Concurrency Control.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.RateExceededException">
        /// Returned when the rate of requests exceeds the allowed throughput.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-session-2019-07-11/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual SendCommandResponse SendCommand(SendCommandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCommandResponseUnmarshaller.Instance;

            return Invoke<SendCommandResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendCommand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCommand operation on AmazonQLDBSessionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendCommand
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-session-2019-07-11/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual IAsyncResult BeginSendCommand(SendCommandRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCommandResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendCommand.</param>
        /// 
        /// <returns>Returns a  SendCommandResult from QLDBSession.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-session-2019-07-11/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual SendCommandResponse EndSendCommand(IAsyncResult asyncResult)
        {
            return EndInvoke<SendCommandResponse>(asyncResult);
        }

        #endregion
        
    }
}
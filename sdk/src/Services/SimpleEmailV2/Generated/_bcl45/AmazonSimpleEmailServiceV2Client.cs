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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SimpleEmailV2.Model;
using Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations;
using Amazon.SimpleEmailV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleEmailV2
{
    /// <summary>
    /// Implementation for accessing SimpleEmailServiceV2
    ///
    /// Amazon SES API v2 
    /// <para>
    /// Welcome to the Amazon SES API v2 Reference. This guide provides information about
    /// the Amazon SES API v2, including supported operations, data types, parameters, and
    /// schemas.
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://aws.amazon.com/pinpoint">Amazon SES</a> is an AWS service that you
    /// can use to send email messages to your customers.
    /// </para>
    ///  
    /// <para>
    /// If you're new to Amazon SES API v2, you might find it helpful to also review the <a
    /// href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/">Amazon Simple Email
    /// Service Developer Guide</a>. The <i>Amazon SES Developer Guide</i> provides information
    /// and code samples that demonstrate how to use Amazon SES API v2 features programmatically.
    /// </para>
    ///  
    /// <para>
    /// The Amazon SES API v2 is available in several AWS Regions and it provides an endpoint
    /// for each of these Regions. For a list of all the Regions and endpoints where the API
    /// is currently available, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#ses_region">AWS
    /// Service Endpoints</a> in the <i>Amazon Web Services General Reference</i>. To learn
    /// more about AWS Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
    /// AWS Regions</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// In each Region, AWS maintains multiple Availability Zones. These Availability Zones
    /// are physically isolated from each other, but are united by private, low-latency, high-throughput,
    /// and highly redundant network connections. These Availability Zones enable us to provide
    /// very high levels of availability and redundancy, while also minimizing latency. To
    /// learn more about the number of Availability Zones that are available in each Region,
    /// see <a href="http://aws.amazon.com/about-aws/global-infrastructure/">AWS Global Infrastructure</a>.
    /// </para>
    /// </summary>
    public partial class AmazonSimpleEmailServiceV2Client : AmazonServiceClient, IAmazonSimpleEmailServiceV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimpleEmailServiceV2Metadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleEmailServiceV2Config()) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleEmailServiceV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleEmailServiceV2Client Configuration Object</param>
        public AmazonSimpleEmailServiceV2Client(AmazonSimpleEmailServiceV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleEmailServiceV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleEmailServiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleEmailServiceV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Credentials and an
        /// AmazonSimpleEmailServiceV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceV2Client Configuration Object</param>
        public AmazonSimpleEmailServiceV2Client(AWSCredentials credentials, AmazonSimpleEmailServiceV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceV2Client Configuration Object</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleEmailServiceV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceV2Client Configuration Object</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleEmailServiceV2Config clientConfig)
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


        #region  CreateConfigurationSet


        /// <summary>
        /// Create a configuration set. <i>Configuration sets</i> are groups of rules that you
        /// can apply to the emails that you send. You apply a configuration set to an email by
        /// specifying the name of the configuration set when you call the Amazon SES API v2.
        /// When you apply a configuration set to an email, all of the rules in that configuration
        /// set are applied to the email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetResponse>(request, options);
        }


        /// <summary>
        /// Create a configuration set. <i>Configuration sets</i> are groups of rules that you
        /// can apply to the emails that you send. You apply a configuration set to an email by
        /// specifying the name of the configuration set when you call the Amazon SES API v2.
        /// When you apply a configuration set to an email, all of the rules in that configuration
        /// set are applied to the email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConfigurationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationSetEventDestination


        /// <summary>
        /// Create an event destination. <i>Events</i> include message sends, deliveries, opens,
        /// clicks, bounces, and complaints. <i>Event destinations</i> are places that you can
        /// send information about these events to. For example, you can send event data to Amazon
        /// SNS to receive notifications when you receive bounces or complaints, or you can use
        /// Amazon Kinesis Data Firehose to stream data to Amazon S3 for long-term storage.
        /// 
        ///  
        /// <para>
        /// A single configuration set can include more than one event destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        public virtual CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetEventDestinationResponse>(request, options);
        }


        /// <summary>
        /// Create an event destination. <i>Events</i> include message sends, deliveries, opens,
        /// clicks, bounces, and complaints. <i>Event destinations</i> are places that you can
        /// send information about these events to. For example, you can send event data to Amazon
        /// SNS to receive notifications when you receive bounces or complaints, or you can use
        /// Amazon Kinesis Data Firehose to stream data to Amazon S3 for long-term storage.
        /// 
        ///  
        /// <para>
        /// A single configuration set can include more than one event destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        public virtual Task<CreateConfigurationSetEventDestinationResponse> CreateConfigurationSetEventDestinationAsync(CreateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDedicatedIpPool


        /// <summary>
        /// Create a new pool of dedicated IP addresses. A pool can include one or more dedicated
        /// IP addresses that are associated with your AWS account. You can associate a pool with
        /// a configuration set. When you send an email that uses that configuration set, the
        /// message is sent from one of the addresses in the associated pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool service method.</param>
        /// 
        /// <returns>The response from the CreateDedicatedIpPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDedicatedIpPool">REST API Reference for CreateDedicatedIpPool Operation</seealso>
        public virtual CreateDedicatedIpPoolResponse CreateDedicatedIpPool(CreateDedicatedIpPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDedicatedIpPoolResponseUnmarshaller.Instance;

            return Invoke<CreateDedicatedIpPoolResponse>(request, options);
        }


        /// <summary>
        /// Create a new pool of dedicated IP addresses. A pool can include one or more dedicated
        /// IP addresses that are associated with your AWS account. You can associate a pool with
        /// a configuration set. When you send an email that uses that configuration set, the
        /// message is sent from one of the addresses in the associated pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDedicatedIpPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDedicatedIpPool">REST API Reference for CreateDedicatedIpPool Operation</seealso>
        public virtual Task<CreateDedicatedIpPoolResponse> CreateDedicatedIpPoolAsync(CreateDedicatedIpPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDedicatedIpPoolResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDedicatedIpPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeliverabilityTestReport


        /// <summary>
        /// Create a new predictive inbox placement test. Predictive inbox placement tests can
        /// help you predict how your messages will be handled by various email providers around
        /// the world. When you perform a predictive inbox placement test, you provide a sample
        /// message that contains the content that you plan to send to your customers. Amazon
        /// SES then sends that message to special email addresses spread across several major
        /// email providers. After about 24 hours, the test is complete, and you can use the <code>GetDeliverabilityTestReport</code>
        /// operation to view the results of the test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport service method.</param>
        /// 
        /// <returns>The response from the CreateDeliverabilityTestReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDeliverabilityTestReport">REST API Reference for CreateDeliverabilityTestReport Operation</seealso>
        public virtual CreateDeliverabilityTestReportResponse CreateDeliverabilityTestReport(CreateDeliverabilityTestReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeliverabilityTestReportResponseUnmarshaller.Instance;

            return Invoke<CreateDeliverabilityTestReportResponse>(request, options);
        }


        /// <summary>
        /// Create a new predictive inbox placement test. Predictive inbox placement tests can
        /// help you predict how your messages will be handled by various email providers around
        /// the world. When you perform a predictive inbox placement test, you provide a sample
        /// message that contains the content that you plan to send to your customers. Amazon
        /// SES then sends that message to special email addresses spread across several major
        /// email providers. After about 24 hours, the test is complete, and you can use the <code>GetDeliverabilityTestReport</code>
        /// operation to view the results of the test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeliverabilityTestReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDeliverabilityTestReport">REST API Reference for CreateDeliverabilityTestReport Operation</seealso>
        public virtual Task<CreateDeliverabilityTestReportResponse> CreateDeliverabilityTestReportAsync(CreateDeliverabilityTestReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeliverabilityTestReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDeliverabilityTestReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEmailIdentity


        /// <summary>
        /// Starts the process of verifying an email identity. An <i>identity</i> is an email
        /// address or domain that you use when you send email. Before you can use an identity
        /// to send email, you first have to verify it. By verifying an identity, you demonstrate
        /// that you're the owner of the identity, and that you've given Amazon SES API v2 permission
        /// to send email from the identity.
        /// 
        ///  
        /// <para>
        /// When you verify an email address, Amazon SES sends an email to the address. Your email
        /// address is verified as soon as you follow the link in the verification email. 
        /// </para>
        ///  
        /// <para>
        /// When you verify a domain without specifying the <code>DkimSigningAttributes</code>
        /// object, this operation provides a set of DKIM tokens. You can convert these tokens
        /// into CNAME records, which you then add to the DNS configuration for your domain. Your
        /// domain is verified when Amazon SES detects these records in the DNS configuration
        /// for your domain. This verification method is known as <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can perform the verification process by providing your own public-private
        /// key pair. This verification method is known as Bring Your Own DKIM (BYODKIM). To use
        /// BYODKIM, your call to the <code>CreateEmailIdentity</code> operation has to include
        /// the <code>DkimSigningAttributes</code> object. When you specify this object, you provide
        /// a selector (a component of the DNS record name that identifies the public key that
        /// you want to use for DKIM authentication) and a private key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentity">REST API Reference for CreateEmailIdentity Operation</seealso>
        public virtual CreateEmailIdentityResponse CreateEmailIdentity(CreateEmailIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<CreateEmailIdentityResponse>(request, options);
        }


        /// <summary>
        /// Starts the process of verifying an email identity. An <i>identity</i> is an email
        /// address or domain that you use when you send email. Before you can use an identity
        /// to send email, you first have to verify it. By verifying an identity, you demonstrate
        /// that you're the owner of the identity, and that you've given Amazon SES API v2 permission
        /// to send email from the identity.
        /// 
        ///  
        /// <para>
        /// When you verify an email address, Amazon SES sends an email to the address. Your email
        /// address is verified as soon as you follow the link in the verification email. 
        /// </para>
        ///  
        /// <para>
        /// When you verify a domain without specifying the <code>DkimSigningAttributes</code>
        /// object, this operation provides a set of DKIM tokens. You can convert these tokens
        /// into CNAME records, which you then add to the DNS configuration for your domain. Your
        /// domain is verified when Amazon SES detects these records in the DNS configuration
        /// for your domain. This verification method is known as <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can perform the verification process by providing your own public-private
        /// key pair. This verification method is known as Bring Your Own DKIM (BYODKIM). To use
        /// BYODKIM, your call to the <code>CreateEmailIdentity</code> operation has to include
        /// the <code>DkimSigningAttributes</code> object. When you specify this object, you provide
        /// a selector (a component of the DNS record name that identifies the public key that
        /// you want to use for DKIM authentication) and a private key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentity">REST API Reference for CreateEmailIdentity Operation</seealso>
        public virtual Task<CreateEmailIdentityResponse> CreateEmailIdentityAsync(CreateEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEmailIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSet


        /// <summary>
        /// Delete an existing configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetResponse>(request, options);
        }


        /// <summary>
        /// Delete an existing configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConfigurationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSetEventDestination


        /// <summary>
        /// Delete an event destination.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon SNS to receive notifications when
        /// you receive bounces or complaints, or you can use Amazon Kinesis Data Firehose to
        /// stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        public virtual DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetEventDestinationResponse>(request, options);
        }


        /// <summary>
        /// Delete an event destination.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon SNS to receive notifications when
        /// you receive bounces or complaints, or you can use Amazon Kinesis Data Firehose to
        /// stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        public virtual Task<DeleteConfigurationSetEventDestinationResponse> DeleteConfigurationSetEventDestinationAsync(DeleteConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDedicatedIpPool


        /// <summary>
        /// Delete a dedicated IP pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool service method.</param>
        /// 
        /// <returns>The response from the DeleteDedicatedIpPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteDedicatedIpPool">REST API Reference for DeleteDedicatedIpPool Operation</seealso>
        public virtual DeleteDedicatedIpPoolResponse DeleteDedicatedIpPool(DeleteDedicatedIpPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDedicatedIpPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteDedicatedIpPoolResponse>(request, options);
        }


        /// <summary>
        /// Delete a dedicated IP pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDedicatedIpPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteDedicatedIpPool">REST API Reference for DeleteDedicatedIpPool Operation</seealso>
        public virtual Task<DeleteDedicatedIpPoolResponse> DeleteDedicatedIpPoolAsync(DeleteDedicatedIpPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDedicatedIpPoolResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDedicatedIpPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEmailIdentity


        /// <summary>
        /// Deletes an email identity. An identity can be either an email address or a domain
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailIdentity">REST API Reference for DeleteEmailIdentity Operation</seealso>
        public virtual DeleteEmailIdentityResponse DeleteEmailIdentity(DeleteEmailIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailIdentityResponse>(request, options);
        }


        /// <summary>
        /// Deletes an email identity. An identity can be either an email address or a domain
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailIdentity">REST API Reference for DeleteEmailIdentity Operation</seealso>
        public virtual Task<DeleteEmailIdentityResponse> DeleteEmailIdentityAsync(DeleteEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEmailIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSuppressedDestination


        /// <summary>
        /// Removes an email address from the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuppressedDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteSuppressedDestination">REST API Reference for DeleteSuppressedDestination Operation</seealso>
        public virtual DeleteSuppressedDestinationResponse DeleteSuppressedDestination(DeleteSuppressedDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuppressedDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteSuppressedDestinationResponse>(request, options);
        }


        /// <summary>
        /// Removes an email address from the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuppressedDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteSuppressedDestination">REST API Reference for DeleteSuppressedDestination Operation</seealso>
        public virtual Task<DeleteSuppressedDestinationResponse> DeleteSuppressedDestinationAsync(DeleteSuppressedDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuppressedDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSuppressedDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccount


        /// <summary>
        /// Obtain information about the email-sending status and capabilities of your Amazon
        /// SES account in the current AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetAccount">REST API Reference for GetAccount Operation</seealso>
        public virtual GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountResponseUnmarshaller.Instance;

            return Invoke<GetAccountResponse>(request, options);
        }


        /// <summary>
        /// Obtain information about the email-sending status and capabilities of your Amazon
        /// SES account in the current AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetAccount">REST API Reference for GetAccount Operation</seealso>
        public virtual Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBlacklistReports


        /// <summary>
        /// Retrieve a list of the blacklists that your dedicated IP addresses appear on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports service method.</param>
        /// 
        /// <returns>The response from the GetBlacklistReports service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetBlacklistReports">REST API Reference for GetBlacklistReports Operation</seealso>
        public virtual GetBlacklistReportsResponse GetBlacklistReports(GetBlacklistReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlacklistReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlacklistReportsResponseUnmarshaller.Instance;

            return Invoke<GetBlacklistReportsResponse>(request, options);
        }


        /// <summary>
        /// Retrieve a list of the blacklists that your dedicated IP addresses appear on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBlacklistReports service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetBlacklistReports">REST API Reference for GetBlacklistReports Operation</seealso>
        public virtual Task<GetBlacklistReportsResponse> GetBlacklistReportsAsync(GetBlacklistReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlacklistReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlacklistReportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBlacklistReportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConfigurationSet


        /// <summary>
        /// Get information about an existing configuration set, including the dedicated IP pool
        /// that it's associated with, whether or not it's enabled for sending email, and more.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSet">REST API Reference for GetConfigurationSet Operation</seealso>
        public virtual GetConfigurationSetResponse GetConfigurationSet(GetConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationSetResponse>(request, options);
        }


        /// <summary>
        /// Get information about an existing configuration set, including the dedicated IP pool
        /// that it's associated with, whether or not it's enabled for sending email, and more.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSet">REST API Reference for GetConfigurationSet Operation</seealso>
        public virtual Task<GetConfigurationSetResponse> GetConfigurationSetAsync(GetConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConfigurationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConfigurationSetEventDestinations


        /// <summary>
        /// Retrieve a list of event destinations that are associated with a configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon SNS to receive notifications when
        /// you receive bounces or complaints, or you can use Amazon Kinesis Data Firehose to
        /// stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationSetEventDestinations service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSetEventDestinations">REST API Reference for GetConfigurationSetEventDestinations Operation</seealso>
        public virtual GetConfigurationSetEventDestinationsResponse GetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetEventDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationSetEventDestinationsResponse>(request, options);
        }


        /// <summary>
        /// Retrieve a list of event destinations that are associated with a configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon SNS to receive notifications when
        /// you receive bounces or complaints, or you can use Amazon Kinesis Data Firehose to
        /// stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationSetEventDestinations service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSetEventDestinations">REST API Reference for GetConfigurationSetEventDestinations Operation</seealso>
        public virtual Task<GetConfigurationSetEventDestinationsResponse> GetConfigurationSetEventDestinationsAsync(GetConfigurationSetEventDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetEventDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConfigurationSetEventDestinationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDedicatedIp


        /// <summary>
        /// Get information about a dedicated IP address, including the name of the dedicated
        /// IP pool that it's associated with, as well information about the automatic warm-up
        /// process for the address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp service method.</param>
        /// 
        /// <returns>The response from the GetDedicatedIp service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIp">REST API Reference for GetDedicatedIp Operation</seealso>
        public virtual GetDedicatedIpResponse GetDedicatedIp(GetDedicatedIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpResponseUnmarshaller.Instance;

            return Invoke<GetDedicatedIpResponse>(request, options);
        }


        /// <summary>
        /// Get information about a dedicated IP address, including the name of the dedicated
        /// IP pool that it's associated with, as well information about the automatic warm-up
        /// process for the address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDedicatedIp service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIp">REST API Reference for GetDedicatedIp Operation</seealso>
        public virtual Task<GetDedicatedIpResponse> GetDedicatedIpAsync(GetDedicatedIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDedicatedIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDedicatedIps


        /// <summary>
        /// List the dedicated IP addresses that are associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps service method.</param>
        /// 
        /// <returns>The response from the GetDedicatedIps service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIps">REST API Reference for GetDedicatedIps Operation</seealso>
        public virtual GetDedicatedIpsResponse GetDedicatedIps(GetDedicatedIpsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpsResponseUnmarshaller.Instance;

            return Invoke<GetDedicatedIpsResponse>(request, options);
        }


        /// <summary>
        /// List the dedicated IP addresses that are associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDedicatedIps service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIps">REST API Reference for GetDedicatedIps Operation</seealso>
        public virtual Task<GetDedicatedIpsResponse> GetDedicatedIpsAsync(GetDedicatedIpsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDedicatedIpsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeliverabilityDashboardOptions


        /// <summary>
        /// Retrieve information about the status of the Deliverability dashboard for your account.
        /// When the Deliverability dashboard is enabled, you gain access to reputation, deliverability,
        /// and other metrics for the domains that you use to send email. You also gain the ability
        /// to perform predictive inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
        /// in addition to any other fees that you accrue by using Amazon SES and other AWS services.
        /// For more information about the features and cost of a Deliverability dashboard subscription,
        /// see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions service method.</param>
        /// 
        /// <returns>The response from the GetDeliverabilityDashboardOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityDashboardOptions">REST API Reference for GetDeliverabilityDashboardOptions Operation</seealso>
        public virtual GetDeliverabilityDashboardOptionsResponse GetDeliverabilityDashboardOptions(GetDeliverabilityDashboardOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityDashboardOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityDashboardOptionsResponseUnmarshaller.Instance;

            return Invoke<GetDeliverabilityDashboardOptionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieve information about the status of the Deliverability dashboard for your account.
        /// When the Deliverability dashboard is enabled, you gain access to reputation, deliverability,
        /// and other metrics for the domains that you use to send email. You also gain the ability
        /// to perform predictive inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
        /// in addition to any other fees that you accrue by using Amazon SES and other AWS services.
        /// For more information about the features and cost of a Deliverability dashboard subscription,
        /// see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeliverabilityDashboardOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityDashboardOptions">REST API Reference for GetDeliverabilityDashboardOptions Operation</seealso>
        public virtual Task<GetDeliverabilityDashboardOptionsResponse> GetDeliverabilityDashboardOptionsAsync(GetDeliverabilityDashboardOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityDashboardOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityDashboardOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeliverabilityDashboardOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeliverabilityTestReport


        /// <summary>
        /// Retrieve the results of a predictive inbox placement test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport service method.</param>
        /// 
        /// <returns>The response from the GetDeliverabilityTestReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityTestReport">REST API Reference for GetDeliverabilityTestReport Operation</seealso>
        public virtual GetDeliverabilityTestReportResponse GetDeliverabilityTestReport(GetDeliverabilityTestReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityTestReportResponseUnmarshaller.Instance;

            return Invoke<GetDeliverabilityTestReportResponse>(request, options);
        }


        /// <summary>
        /// Retrieve the results of a predictive inbox placement test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeliverabilityTestReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityTestReport">REST API Reference for GetDeliverabilityTestReport Operation</seealso>
        public virtual Task<GetDeliverabilityTestReportResponse> GetDeliverabilityTestReportAsync(GetDeliverabilityTestReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityTestReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeliverabilityTestReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainDeliverabilityCampaign


        /// <summary>
        /// Retrieve all the deliverability data for a specific campaign. This data is available
        /// for a campaign only if the campaign sent email by using a domain that the Deliverability
        /// dashboard is enabled for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDeliverabilityCampaign service method.</param>
        /// 
        /// <returns>The response from the GetDomainDeliverabilityCampaign service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainDeliverabilityCampaign">REST API Reference for GetDomainDeliverabilityCampaign Operation</seealso>
        public virtual GetDomainDeliverabilityCampaignResponse GetDomainDeliverabilityCampaign(GetDomainDeliverabilityCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainDeliverabilityCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainDeliverabilityCampaignResponseUnmarshaller.Instance;

            return Invoke<GetDomainDeliverabilityCampaignResponse>(request, options);
        }


        /// <summary>
        /// Retrieve all the deliverability data for a specific campaign. This data is available
        /// for a campaign only if the campaign sent email by using a domain that the Deliverability
        /// dashboard is enabled for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDeliverabilityCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainDeliverabilityCampaign service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainDeliverabilityCampaign">REST API Reference for GetDomainDeliverabilityCampaign Operation</seealso>
        public virtual Task<GetDomainDeliverabilityCampaignResponse> GetDomainDeliverabilityCampaignAsync(GetDomainDeliverabilityCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainDeliverabilityCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainDeliverabilityCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainDeliverabilityCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainStatisticsReport


        /// <summary>
        /// Retrieve inbox placement and engagement rates for the domains that you use to send
        /// email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport service method.</param>
        /// 
        /// <returns>The response from the GetDomainStatisticsReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainStatisticsReport">REST API Reference for GetDomainStatisticsReport Operation</seealso>
        public virtual GetDomainStatisticsReportResponse GetDomainStatisticsReport(GetDomainStatisticsReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainStatisticsReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainStatisticsReportResponseUnmarshaller.Instance;

            return Invoke<GetDomainStatisticsReportResponse>(request, options);
        }


        /// <summary>
        /// Retrieve inbox placement and engagement rates for the domains that you use to send
        /// email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainStatisticsReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainStatisticsReport">REST API Reference for GetDomainStatisticsReport Operation</seealso>
        public virtual Task<GetDomainStatisticsReportResponse> GetDomainStatisticsReportAsync(GetDomainStatisticsReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainStatisticsReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainStatisticsReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainStatisticsReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEmailIdentity


        /// <summary>
        /// Provides information about a specific identity, including the identity's verification
        /// status, its DKIM authentication status, and its custom Mail-From settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the GetEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailIdentity">REST API Reference for GetEmailIdentity Operation</seealso>
        public virtual GetEmailIdentityResponse GetEmailIdentity(GetEmailIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<GetEmailIdentityResponse>(request, options);
        }


        /// <summary>
        /// Provides information about a specific identity, including the identity's verification
        /// status, its DKIM authentication status, and its custom Mail-From settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailIdentity">REST API Reference for GetEmailIdentity Operation</seealso>
        public virtual Task<GetEmailIdentityResponse> GetEmailIdentityAsync(GetEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEmailIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSuppressedDestination


        /// <summary>
        /// Retrieves information about a specific email address that's on the suppression list
        /// for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuppressedDestination service method.</param>
        /// 
        /// <returns>The response from the GetSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetSuppressedDestination">REST API Reference for GetSuppressedDestination Operation</seealso>
        public virtual GetSuppressedDestinationResponse GetSuppressedDestination(GetSuppressedDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuppressedDestinationResponseUnmarshaller.Instance;

            return Invoke<GetSuppressedDestinationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a specific email address that's on the suppression list
        /// for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuppressedDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetSuppressedDestination">REST API Reference for GetSuppressedDestination Operation</seealso>
        public virtual Task<GetSuppressedDestinationResponse> GetSuppressedDestinationAsync(GetSuppressedDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuppressedDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSuppressedDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurationSets


        /// <summary>
        /// List all of the configuration sets associated with your account in the current region.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        public virtual ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationSetsResponse>(request, options);
        }


        /// <summary>
        /// List all of the configuration sets associated with your account in the current region.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        public virtual Task<ListConfigurationSetsResponse> ListConfigurationSetsAsync(ListConfigurationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConfigurationSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDedicatedIpPools


        /// <summary>
        /// List all of the dedicated IP pools that exist in your AWS account in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools service method.</param>
        /// 
        /// <returns>The response from the ListDedicatedIpPools service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDedicatedIpPools">REST API Reference for ListDedicatedIpPools Operation</seealso>
        public virtual ListDedicatedIpPoolsResponse ListDedicatedIpPools(ListDedicatedIpPoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDedicatedIpPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDedicatedIpPoolsResponseUnmarshaller.Instance;

            return Invoke<ListDedicatedIpPoolsResponse>(request, options);
        }


        /// <summary>
        /// List all of the dedicated IP pools that exist in your AWS account in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDedicatedIpPools service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDedicatedIpPools">REST API Reference for ListDedicatedIpPools Operation</seealso>
        public virtual Task<ListDedicatedIpPoolsResponse> ListDedicatedIpPoolsAsync(ListDedicatedIpPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDedicatedIpPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDedicatedIpPoolsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDedicatedIpPoolsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeliverabilityTestReports


        /// <summary>
        /// Show a list of the predictive inbox placement tests that you've performed, regardless
        /// of their statuses. For predictive inbox placement tests that are complete, you can
        /// use the <code>GetDeliverabilityTestReport</code> operation to view the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports service method.</param>
        /// 
        /// <returns>The response from the ListDeliverabilityTestReports service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDeliverabilityTestReports">REST API Reference for ListDeliverabilityTestReports Operation</seealso>
        public virtual ListDeliverabilityTestReportsResponse ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeliverabilityTestReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeliverabilityTestReportsResponseUnmarshaller.Instance;

            return Invoke<ListDeliverabilityTestReportsResponse>(request, options);
        }


        /// <summary>
        /// Show a list of the predictive inbox placement tests that you've performed, regardless
        /// of their statuses. For predictive inbox placement tests that are complete, you can
        /// use the <code>GetDeliverabilityTestReport</code> operation to view the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeliverabilityTestReports service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDeliverabilityTestReports">REST API Reference for ListDeliverabilityTestReports Operation</seealso>
        public virtual Task<ListDeliverabilityTestReportsResponse> ListDeliverabilityTestReportsAsync(ListDeliverabilityTestReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeliverabilityTestReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeliverabilityTestReportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDeliverabilityTestReportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomainDeliverabilityCampaigns


        /// <summary>
        /// Retrieve deliverability data for all the campaigns that used a specific domain to
        /// send email during a specified time range. This data is available for a domain only
        /// if you enabled the Deliverability dashboard for the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainDeliverabilityCampaigns service method.</param>
        /// 
        /// <returns>The response from the ListDomainDeliverabilityCampaigns service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDomainDeliverabilityCampaigns">REST API Reference for ListDomainDeliverabilityCampaigns Operation</seealso>
        public virtual ListDomainDeliverabilityCampaignsResponse ListDomainDeliverabilityCampaigns(ListDomainDeliverabilityCampaignsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainDeliverabilityCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainDeliverabilityCampaignsResponseUnmarshaller.Instance;

            return Invoke<ListDomainDeliverabilityCampaignsResponse>(request, options);
        }


        /// <summary>
        /// Retrieve deliverability data for all the campaigns that used a specific domain to
        /// send email during a specified time range. This data is available for a domain only
        /// if you enabled the Deliverability dashboard for the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainDeliverabilityCampaigns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainDeliverabilityCampaigns service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDomainDeliverabilityCampaigns">REST API Reference for ListDomainDeliverabilityCampaigns Operation</seealso>
        public virtual Task<ListDomainDeliverabilityCampaignsResponse> ListDomainDeliverabilityCampaignsAsync(ListDomainDeliverabilityCampaignsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainDeliverabilityCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainDeliverabilityCampaignsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDomainDeliverabilityCampaignsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEmailIdentities


        /// <summary>
        /// Returns a list of all of the email identities that are associated with your AWS account.
        /// An identity can be either an email address or a domain. This operation returns identities
        /// that are verified as well as those that aren't. This operation returns identities
        /// that are associated with Amazon SES and Amazon Pinpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities service method.</param>
        /// 
        /// <returns>The response from the ListEmailIdentities service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailIdentities">REST API Reference for ListEmailIdentities Operation</seealso>
        public virtual ListEmailIdentitiesResponse ListEmailIdentities(ListEmailIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEmailIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEmailIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListEmailIdentitiesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all of the email identities that are associated with your AWS account.
        /// An identity can be either an email address or a domain. This operation returns identities
        /// that are verified as well as those that aren't. This operation returns identities
        /// that are associated with Amazon SES and Amazon Pinpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEmailIdentities service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailIdentities">REST API Reference for ListEmailIdentities Operation</seealso>
        public virtual Task<ListEmailIdentitiesResponse> ListEmailIdentitiesAsync(ListEmailIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEmailIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEmailIdentitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEmailIdentitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSuppressedDestinations


        /// <summary>
        /// Retrieves a list of email addresses that are on the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuppressedDestinations service method.</param>
        /// 
        /// <returns>The response from the ListSuppressedDestinations service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.InvalidNextTokenException">
        /// The specified request includes an invalid or expired token.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListSuppressedDestinations">REST API Reference for ListSuppressedDestinations Operation</seealso>
        public virtual ListSuppressedDestinationsResponse ListSuppressedDestinations(ListSuppressedDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuppressedDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuppressedDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListSuppressedDestinationsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of email addresses that are on the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuppressedDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSuppressedDestinations service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.InvalidNextTokenException">
        /// The specified request includes an invalid or expired token.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListSuppressedDestinations">REST API Reference for ListSuppressedDestinations Operation</seealso>
        public virtual Task<ListSuppressedDestinationsResponse> ListSuppressedDestinationsAsync(ListSuppressedDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuppressedDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuppressedDestinationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSuppressedDestinationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieve a list of the tags (keys and values) that are associated with a specified
        /// resource. A <i>tag</i> is a label that you optionally define and associate with a
        /// resource. Each tag consists of a required <i>tag key</i> and an optional associated <i>tag
        /// value</i>. A tag key is a general label that acts as a category for more specific
        /// tag values. A tag value acts as a descriptor within a tag key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Retrieve a list of the tags (keys and values) that are associated with a specified
        /// resource. A <i>tag</i> is a label that you optionally define and associate with a
        /// resource. Each tag consists of a required <i>tag key</i> and an optional associated <i>tag
        /// value</i>. A tag key is a general label that acts as a category for more specific
        /// tag values. A tag value acts as a descriptor within a tag key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccountDedicatedIpWarmupAttributes


        /// <summary>
        /// Enable or disable the automatic warm-up feature for dedicated IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountDedicatedIpWarmupAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDedicatedIpWarmupAttributes">REST API Reference for PutAccountDedicatedIpWarmupAttributes Operation</seealso>
        public virtual PutAccountDedicatedIpWarmupAttributesResponse PutAccountDedicatedIpWarmupAttributes(PutAccountDedicatedIpWarmupAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountDedicatedIpWarmupAttributesResponse>(request, options);
        }


        /// <summary>
        /// Enable or disable the automatic warm-up feature for dedicated IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountDedicatedIpWarmupAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDedicatedIpWarmupAttributes">REST API Reference for PutAccountDedicatedIpWarmupAttributes Operation</seealso>
        public virtual Task<PutAccountDedicatedIpWarmupAttributesResponse> PutAccountDedicatedIpWarmupAttributesAsync(PutAccountDedicatedIpWarmupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAccountDedicatedIpWarmupAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccountSendingAttributes


        /// <summary>
        /// Enable or disable the ability of your account to send email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountSendingAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSendingAttributes">REST API Reference for PutAccountSendingAttributes Operation</seealso>
        public virtual PutAccountSendingAttributesResponse PutAccountSendingAttributes(PutAccountSendingAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountSendingAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSendingAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountSendingAttributesResponse>(request, options);
        }


        /// <summary>
        /// Enable or disable the ability of your account to send email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSendingAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSendingAttributes">REST API Reference for PutAccountSendingAttributes Operation</seealso>
        public virtual Task<PutAccountSendingAttributesResponse> PutAccountSendingAttributesAsync(PutAccountSendingAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountSendingAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSendingAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAccountSendingAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccountSuppressionAttributes


        /// <summary>
        /// Change the settings for the account-level suppression list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSuppressionAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountSuppressionAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSuppressionAttributes">REST API Reference for PutAccountSuppressionAttributes Operation</seealso>
        public virtual PutAccountSuppressionAttributesResponse PutAccountSuppressionAttributes(PutAccountSuppressionAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountSuppressionAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSuppressionAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountSuppressionAttributesResponse>(request, options);
        }


        /// <summary>
        /// Change the settings for the account-level suppression list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSuppressionAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSuppressionAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSuppressionAttributes">REST API Reference for PutAccountSuppressionAttributes Operation</seealso>
        public virtual Task<PutAccountSuppressionAttributesResponse> PutAccountSuppressionAttributesAsync(PutAccountSuppressionAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountSuppressionAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSuppressionAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAccountSuppressionAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetDeliveryOptions


        /// <summary>
        /// Associate a configuration set with a dedicated IP pool. You can use dedicated IP pools
        /// to create groups of dedicated IP addresses for sending specific types of email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetDeliveryOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        public virtual PutConfigurationSetDeliveryOptionsResponse PutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetDeliveryOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetDeliveryOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetDeliveryOptionsResponse>(request, options);
        }


        /// <summary>
        /// Associate a configuration set with a dedicated IP pool. You can use dedicated IP pools
        /// to create groups of dedicated IP addresses for sending specific types of email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetDeliveryOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        public virtual Task<PutConfigurationSetDeliveryOptionsResponse> PutConfigurationSetDeliveryOptionsAsync(PutConfigurationSetDeliveryOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetDeliveryOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetDeliveryOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutConfigurationSetDeliveryOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetReputationOptions


        /// <summary>
        /// Enable or disable collection of reputation metrics for emails that you send using
        /// a particular configuration set in a specific AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetReputationOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetReputationOptions">REST API Reference for PutConfigurationSetReputationOptions Operation</seealso>
        public virtual PutConfigurationSetReputationOptionsResponse PutConfigurationSetReputationOptions(PutConfigurationSetReputationOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetReputationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetReputationOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetReputationOptionsResponse>(request, options);
        }


        /// <summary>
        /// Enable or disable collection of reputation metrics for emails that you send using
        /// a particular configuration set in a specific AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetReputationOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetReputationOptions">REST API Reference for PutConfigurationSetReputationOptions Operation</seealso>
        public virtual Task<PutConfigurationSetReputationOptionsResponse> PutConfigurationSetReputationOptionsAsync(PutConfigurationSetReputationOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetReputationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetReputationOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutConfigurationSetReputationOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetSendingOptions


        /// <summary>
        /// Enable or disable email sending for messages that use a particular configuration set
        /// in a specific AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetSendingOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSendingOptions">REST API Reference for PutConfigurationSetSendingOptions Operation</seealso>
        public virtual PutConfigurationSetSendingOptionsResponse PutConfigurationSetSendingOptions(PutConfigurationSetSendingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetSendingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetSendingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetSendingOptionsResponse>(request, options);
        }


        /// <summary>
        /// Enable or disable email sending for messages that use a particular configuration set
        /// in a specific AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetSendingOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSendingOptions">REST API Reference for PutConfigurationSetSendingOptions Operation</seealso>
        public virtual Task<PutConfigurationSetSendingOptionsResponse> PutConfigurationSetSendingOptionsAsync(PutConfigurationSetSendingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetSendingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetSendingOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutConfigurationSetSendingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetSuppressionOptions


        /// <summary>
        /// Specify the account suppression list preferences for a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSuppressionOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetSuppressionOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSuppressionOptions">REST API Reference for PutConfigurationSetSuppressionOptions Operation</seealso>
        public virtual PutConfigurationSetSuppressionOptionsResponse PutConfigurationSetSuppressionOptions(PutConfigurationSetSuppressionOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetSuppressionOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetSuppressionOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetSuppressionOptionsResponse>(request, options);
        }


        /// <summary>
        /// Specify the account suppression list preferences for a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSuppressionOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetSuppressionOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSuppressionOptions">REST API Reference for PutConfigurationSetSuppressionOptions Operation</seealso>
        public virtual Task<PutConfigurationSetSuppressionOptionsResponse> PutConfigurationSetSuppressionOptionsAsync(PutConfigurationSetSuppressionOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetSuppressionOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetSuppressionOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutConfigurationSetSuppressionOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetTrackingOptions


        /// <summary>
        /// Specify a custom domain to use for open and click tracking elements in email that
        /// you send.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetTrackingOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetTrackingOptions">REST API Reference for PutConfigurationSetTrackingOptions Operation</seealso>
        public virtual PutConfigurationSetTrackingOptionsResponse PutConfigurationSetTrackingOptions(PutConfigurationSetTrackingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetTrackingOptionsResponse>(request, options);
        }


        /// <summary>
        /// Specify a custom domain to use for open and click tracking elements in email that
        /// you send.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetTrackingOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetTrackingOptions">REST API Reference for PutConfigurationSetTrackingOptions Operation</seealso>
        public virtual Task<PutConfigurationSetTrackingOptionsResponse> PutConfigurationSetTrackingOptionsAsync(PutConfigurationSetTrackingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutConfigurationSetTrackingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDedicatedIpInPool


        /// <summary>
        /// Move a dedicated IP address to an existing dedicated IP pool.
        /// 
        ///  <note> 
        /// <para>
        /// The dedicated IP address that you specify must already exist, and must be associated
        /// with your AWS account. 
        /// </para>
        ///  
        /// <para>
        /// The dedicated IP pool you specify must already exist. You can create a new pool by
        /// using the <code>CreateDedicatedIpPool</code> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool service method.</param>
        /// 
        /// <returns>The response from the PutDedicatedIpInPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpInPool">REST API Reference for PutDedicatedIpInPool Operation</seealso>
        public virtual PutDedicatedIpInPoolResponse PutDedicatedIpInPool(PutDedicatedIpInPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpInPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpInPoolResponseUnmarshaller.Instance;

            return Invoke<PutDedicatedIpInPoolResponse>(request, options);
        }


        /// <summary>
        /// Move a dedicated IP address to an existing dedicated IP pool.
        /// 
        ///  <note> 
        /// <para>
        /// The dedicated IP address that you specify must already exist, and must be associated
        /// with your AWS account. 
        /// </para>
        ///  
        /// <para>
        /// The dedicated IP pool you specify must already exist. You can create a new pool by
        /// using the <code>CreateDedicatedIpPool</code> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDedicatedIpInPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpInPool">REST API Reference for PutDedicatedIpInPool Operation</seealso>
        public virtual Task<PutDedicatedIpInPoolResponse> PutDedicatedIpInPoolAsync(PutDedicatedIpInPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpInPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpInPoolResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutDedicatedIpInPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDedicatedIpWarmupAttributes


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes service method.</param>
        /// 
        /// <returns>The response from the PutDedicatedIpWarmupAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpWarmupAttributes">REST API Reference for PutDedicatedIpWarmupAttributes Operation</seealso>
        public virtual PutDedicatedIpWarmupAttributesResponse PutDedicatedIpWarmupAttributes(PutDedicatedIpWarmupAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return Invoke<PutDedicatedIpWarmupAttributesResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDedicatedIpWarmupAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpWarmupAttributes">REST API Reference for PutDedicatedIpWarmupAttributes Operation</seealso>
        public virtual Task<PutDedicatedIpWarmupAttributesResponse> PutDedicatedIpWarmupAttributesAsync(PutDedicatedIpWarmupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutDedicatedIpWarmupAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDeliverabilityDashboardOption


        /// <summary>
        /// Enable or disable the Deliverability dashboard. When you enable the Deliverability
        /// dashboard, you gain access to reputation, deliverability, and other metrics for the
        /// domains that you use to send email. You also gain the ability to perform predictive
        /// inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
        /// in addition to any other fees that you accrue by using Amazon SES and other AWS services.
        /// For more information about the features and cost of a Deliverability dashboard subscription,
        /// see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption service method.</param>
        /// 
        /// <returns>The response from the PutDeliverabilityDashboardOption service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDeliverabilityDashboardOption">REST API Reference for PutDeliverabilityDashboardOption Operation</seealso>
        public virtual PutDeliverabilityDashboardOptionResponse PutDeliverabilityDashboardOption(PutDeliverabilityDashboardOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliverabilityDashboardOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliverabilityDashboardOptionResponseUnmarshaller.Instance;

            return Invoke<PutDeliverabilityDashboardOptionResponse>(request, options);
        }


        /// <summary>
        /// Enable or disable the Deliverability dashboard. When you enable the Deliverability
        /// dashboard, you gain access to reputation, deliverability, and other metrics for the
        /// domains that you use to send email. You also gain the ability to perform predictive
        /// inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
        /// in addition to any other fees that you accrue by using Amazon SES and other AWS services.
        /// For more information about the features and cost of a Deliverability dashboard subscription,
        /// see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDeliverabilityDashboardOption service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDeliverabilityDashboardOption">REST API Reference for PutDeliverabilityDashboardOption Operation</seealso>
        public virtual Task<PutDeliverabilityDashboardOptionResponse> PutDeliverabilityDashboardOptionAsync(PutDeliverabilityDashboardOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliverabilityDashboardOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliverabilityDashboardOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutDeliverabilityDashboardOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEmailIdentityDkimAttributes


        /// <summary>
        /// Used to enable or disable DKIM authentication for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityDkimAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimAttributes">REST API Reference for PutEmailIdentityDkimAttributes Operation</seealso>
        public virtual PutEmailIdentityDkimAttributesResponse PutEmailIdentityDkimAttributes(PutEmailIdentityDkimAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityDkimAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityDkimAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityDkimAttributesResponse>(request, options);
        }


        /// <summary>
        /// Used to enable or disable DKIM authentication for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEmailIdentityDkimAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimAttributes">REST API Reference for PutEmailIdentityDkimAttributes Operation</seealso>
        public virtual Task<PutEmailIdentityDkimAttributesResponse> PutEmailIdentityDkimAttributesAsync(PutEmailIdentityDkimAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityDkimAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityDkimAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutEmailIdentityDkimAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEmailIdentityDkimSigningAttributes


        /// <summary>
        /// Used to configure or change the DKIM authentication settings for an email domain identity.
        /// You can use this operation to do any of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Update the signing attributes for an identity that uses Bring Your Own DKIM (BYODKIM).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using no DKIM authentication to using Easy DKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using no DKIM authentication to using BYODKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using Easy DKIM to using BYODKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using BYODKIM to using Easy DKIM.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimSigningAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityDkimSigningAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimSigningAttributes">REST API Reference for PutEmailIdentityDkimSigningAttributes Operation</seealso>
        public virtual PutEmailIdentityDkimSigningAttributesResponse PutEmailIdentityDkimSigningAttributes(PutEmailIdentityDkimSigningAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityDkimSigningAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityDkimSigningAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityDkimSigningAttributesResponse>(request, options);
        }


        /// <summary>
        /// Used to configure or change the DKIM authentication settings for an email domain identity.
        /// You can use this operation to do any of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Update the signing attributes for an identity that uses Bring Your Own DKIM (BYODKIM).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using no DKIM authentication to using Easy DKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using no DKIM authentication to using BYODKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using Easy DKIM to using BYODKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using BYODKIM to using Easy DKIM.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimSigningAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEmailIdentityDkimSigningAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimSigningAttributes">REST API Reference for PutEmailIdentityDkimSigningAttributes Operation</seealso>
        public virtual Task<PutEmailIdentityDkimSigningAttributesResponse> PutEmailIdentityDkimSigningAttributesAsync(PutEmailIdentityDkimSigningAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityDkimSigningAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityDkimSigningAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutEmailIdentityDkimSigningAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEmailIdentityFeedbackAttributes


        /// <summary>
        /// Used to enable or disable feedback forwarding for an identity. This setting determines
        /// what happens when an identity is used to send an email that results in a bounce or
        /// complaint event.
        /// 
        ///  
        /// <para>
        /// If the value is <code>true</code>, you receive email notifications when bounce or
        /// complaint events occur. These notifications are sent to the address that you specified
        /// in the <code>Return-Path</code> header of the original email.
        /// </para>
        ///  
        /// <para>
        /// You're required to have a method of tracking bounces and complaints. If you haven't
        /// set up another mechanism for receiving bounce or complaint notifications (for example,
        /// by setting up an event destination), you receive an email notification when these
        /// events occur (even if this setting is disabled).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityFeedbackAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityFeedbackAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityFeedbackAttributes">REST API Reference for PutEmailIdentityFeedbackAttributes Operation</seealso>
        public virtual PutEmailIdentityFeedbackAttributesResponse PutEmailIdentityFeedbackAttributes(PutEmailIdentityFeedbackAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityFeedbackAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityFeedbackAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityFeedbackAttributesResponse>(request, options);
        }


        /// <summary>
        /// Used to enable or disable feedback forwarding for an identity. This setting determines
        /// what happens when an identity is used to send an email that results in a bounce or
        /// complaint event.
        /// 
        ///  
        /// <para>
        /// If the value is <code>true</code>, you receive email notifications when bounce or
        /// complaint events occur. These notifications are sent to the address that you specified
        /// in the <code>Return-Path</code> header of the original email.
        /// </para>
        ///  
        /// <para>
        /// You're required to have a method of tracking bounces and complaints. If you haven't
        /// set up another mechanism for receiving bounce or complaint notifications (for example,
        /// by setting up an event destination), you receive an email notification when these
        /// events occur (even if this setting is disabled).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityFeedbackAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEmailIdentityFeedbackAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityFeedbackAttributes">REST API Reference for PutEmailIdentityFeedbackAttributes Operation</seealso>
        public virtual Task<PutEmailIdentityFeedbackAttributesResponse> PutEmailIdentityFeedbackAttributesAsync(PutEmailIdentityFeedbackAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityFeedbackAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityFeedbackAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutEmailIdentityFeedbackAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEmailIdentityMailFromAttributes


        /// <summary>
        /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityMailFromAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityMailFromAttributes">REST API Reference for PutEmailIdentityMailFromAttributes Operation</seealso>
        public virtual PutEmailIdentityMailFromAttributesResponse PutEmailIdentityMailFromAttributes(PutEmailIdentityMailFromAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityMailFromAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityMailFromAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityMailFromAttributesResponse>(request, options);
        }


        /// <summary>
        /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEmailIdentityMailFromAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityMailFromAttributes">REST API Reference for PutEmailIdentityMailFromAttributes Operation</seealso>
        public virtual Task<PutEmailIdentityMailFromAttributesResponse> PutEmailIdentityMailFromAttributesAsync(PutEmailIdentityMailFromAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityMailFromAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityMailFromAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutEmailIdentityMailFromAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSuppressedDestination


        /// <summary>
        /// Adds an email address to the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSuppressedDestination service method.</param>
        /// 
        /// <returns>The response from the PutSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutSuppressedDestination">REST API Reference for PutSuppressedDestination Operation</seealso>
        public virtual PutSuppressedDestinationResponse PutSuppressedDestination(PutSuppressedDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSuppressedDestinationResponseUnmarshaller.Instance;

            return Invoke<PutSuppressedDestinationResponse>(request, options);
        }


        /// <summary>
        /// Adds an email address to the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSuppressedDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutSuppressedDestination">REST API Reference for PutSuppressedDestination Operation</seealso>
        public virtual Task<PutSuppressedDestinationResponse> PutSuppressedDestinationAsync(PutSuppressedDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSuppressedDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutSuppressedDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendEmail


        /// <summary>
        /// Sends an email message. You can use the Amazon SES API v2 to send two types of messages:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Simple</b> – A standard email message. When you create this type of message, you
        /// specify the sender, the recipient, and the message body, and Amazon SES assembles
        /// the message for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Raw</b> – A raw, MIME-formatted email message. When you send this type of email,
        /// you have to specify all of the message headers, as well as the message body. You can
        /// use this message type to send messages that contain attachments. The message that
        /// you specify has to be a valid MIME message.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendEmail">REST API Reference for SendEmail Operation</seealso>
        public virtual SendEmailResponse SendEmail(SendEmailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailResponseUnmarshaller.Instance;

            return Invoke<SendEmailResponse>(request, options);
        }


        /// <summary>
        /// Sends an email message. You can use the Amazon SES API v2 to send two types of messages:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Simple</b> – A standard email message. When you create this type of message, you
        /// specify the sender, the recipient, and the message body, and Amazon SES assembles
        /// the message for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Raw</b> – A raw, MIME-formatted email message. When you send this type of email,
        /// you have to specify all of the message headers, as well as the message body. You can
        /// use this message type to send messages that contain attachments. The message that
        /// you specify has to be a valid MIME message.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendEmail">REST API Reference for SendEmail Operation</seealso>
        public virtual Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendEmailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add one or more tags (keys and values) to a specified resource. A <i>tag</i> is a
        /// label that you optionally define and associate with a resource. Tags can help you
        /// categorize and manage resources in different ways, such as by purpose, owner, environment,
        /// or other criteria. A resource can have as many as 50 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a required <i>tag key</i> and an associated <i>tag value</i>,
        /// both of which you define. A tag key is a general label that acts as a category for
        /// more specific tag values. A tag value acts as a descriptor within a tag key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Add one or more tags (keys and values) to a specified resource. A <i>tag</i> is a
        /// label that you optionally define and associate with a resource. Tags can help you
        /// categorize and manage resources in different ways, such as by purpose, owner, environment,
        /// or other criteria. A resource can have as many as 50 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a required <i>tag key</i> and an associated <i>tag value</i>,
        /// both of which you define. A tag key is a general label that acts as a category for
        /// more specific tag values. A tag value acts as a descriptor within a tag key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove one or more tags (keys and values) from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Remove one or more tags (keys and values) from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetEventDestination


        /// <summary>
        /// Update the configuration of an event destination for a configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon SNS to receive notifications when
        /// you receive bounces or complaints, or you can use Amazon Kinesis Data Firehose to
        /// stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        public virtual UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetEventDestinationResponse>(request, options);
        }


        /// <summary>
        /// Update the configuration of an event destination for a configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon SNS to receive notifications when
        /// you receive bounces or complaints, or you can use Amazon Kinesis Data Firehose to
        /// stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        public virtual Task<UpdateConfigurationSetEventDestinationResponse> UpdateConfigurationSetEventDestinationAsync(UpdateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
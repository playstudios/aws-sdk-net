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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateQualificationType operation.
    /// The <code>UpdateQualificationType</code> operation modifies the attributes of an
    /// existing Qualification type, which is represented by a QualificationType data structure.
    /// Only the owner of a Qualification type can modify its attributes. 
    /// 
    ///  
    /// <para>
    ///  Most attributes of a Qualification type can be changed after the type has been created.
    /// However, the Name and Keywords fields cannot be modified. The RetryDelayInSeconds
    /// parameter can be modified or added to change the delay or to enable retries, but RetryDelayInSeconds
    /// cannot be used to disable retries. 
    /// </para>
    ///  
    /// <para>
    ///  You can use this operation to update the test for a Qualification type. The test
    /// is updated based on the values specified for the Test, TestDurationInSeconds and AnswerKey
    /// parameters. All three parameters specify the updated test. If you are updating the
    /// test for a type, you must specify the Test and TestDurationInSeconds parameters. The
    /// AnswerKey parameter is optional; omitting it specifies that the updated test does
    /// not have an answer key. 
    /// </para>
    ///  
    /// <para>
    ///  If you omit the Test parameter, the test for the Qualification type is unchanged.
    /// There is no way to remove a test from a Qualification type that has one. If the type
    /// already has a test, you cannot update it to be AutoGranted. If the Qualification type
    /// does not have a test and one is provided by an update, the type will henceforth have
    /// a test. 
    /// </para>
    ///  
    /// <para>
    ///  If you want to update the test duration or answer key for an existing test without
    /// changing the questions, you must specify a Test parameter with the original questions,
    /// along with the updated values. 
    /// </para>
    ///  
    /// <para>
    ///  If you provide an updated Test but no AnswerKey, the new test will not have an answer
    /// key. Requests for such Qualifications must be granted manually. 
    /// </para>
    ///  
    /// <para>
    ///  You can also update the AutoGranted and AutoGrantedValue attributes of the Qualification
    /// type.
    /// </para>
    /// </summary>
    public partial class UpdateQualificationTypeRequest : AmazonMTurkRequest
    {
        private string _answerKey;
        private bool? _autoGranted;
        private int? _autoGrantedValue;
        private string _description;
        private string _qualificationTypeId;
        private QualificationTypeStatus _qualificationTypeStatus;
        private long? _retryDelayInSeconds;
        private string _test;
        private long? _testDurationInSeconds;

        /// <summary>
        /// Gets and sets the property AnswerKey. 
        /// <para>
        /// The answers to the Qualification test specified in the Test parameter, in the form
        /// of an AnswerKey data structure.
        /// </para>
        /// </summary>
        public string AnswerKey
        {
            get { return this._answerKey; }
            set { this._answerKey = value; }
        }

        // Check to see if AnswerKey property is set
        internal bool IsSetAnswerKey()
        {
            return this._answerKey != null;
        }

        /// <summary>
        /// Gets and sets the property AutoGranted. 
        /// <para>
        /// Specifies whether requests for the Qualification type are granted immediately, without
        /// prompting the Worker with a Qualification test.
        /// </para>
        ///  
        /// <para>
        /// Constraints: If the Test parameter is specified, this parameter cannot be true.
        /// </para>
        /// </summary>
        public bool AutoGranted
        {
            get { return this._autoGranted.GetValueOrDefault(); }
            set { this._autoGranted = value; }
        }

        // Check to see if AutoGranted property is set
        internal bool IsSetAutoGranted()
        {
            return this._autoGranted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoGrantedValue. 
        /// <para>
        /// The Qualification value to use for automatically granted Qualifications. This parameter
        /// is used only if the AutoGranted parameter is true.
        /// </para>
        /// </summary>
        public int AutoGrantedValue
        {
            get { return this._autoGrantedValue.GetValueOrDefault(); }
            set { this._autoGrantedValue = value; }
        }

        // Check to see if AutoGrantedValue property is set
        internal bool IsSetAutoGrantedValue()
        {
            return this._autoGrantedValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description of the Qualification type.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        /// The ID of the Qualification type to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string QualificationTypeId
        {
            get { return this._qualificationTypeId; }
            set { this._qualificationTypeId = value; }
        }

        // Check to see if QualificationTypeId property is set
        internal bool IsSetQualificationTypeId()
        {
            return this._qualificationTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property QualificationTypeStatus. 
        /// <para>
        /// The new status of the Qualification type - Active | Inactive
        /// </para>
        /// </summary>
        public QualificationTypeStatus QualificationTypeStatus
        {
            get { return this._qualificationTypeStatus; }
            set { this._qualificationTypeStatus = value; }
        }

        // Check to see if QualificationTypeStatus property is set
        internal bool IsSetQualificationTypeStatus()
        {
            return this._qualificationTypeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RetryDelayInSeconds. 
        /// <para>
        /// The amount of time, in seconds, that Workers must wait after requesting a Qualification
        /// of the specified Qualification type before they can retry the Qualification request.
        /// It is not possible to disable retries for a Qualification type after it has been created
        /// with retries enabled. If you want to disable retries, you must dispose of the existing
        /// retry-enabled Qualification type using DisposeQualificationType and then create a
        /// new Qualification type with retries disabled using CreateQualificationType.
        /// </para>
        /// </summary>
        public long RetryDelayInSeconds
        {
            get { return this._retryDelayInSeconds.GetValueOrDefault(); }
            set { this._retryDelayInSeconds = value; }
        }

        // Check to see if RetryDelayInSeconds property is set
        internal bool IsSetRetryDelayInSeconds()
        {
            return this._retryDelayInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Test. 
        /// <para>
        /// The questions for the Qualification test a Worker must answer correctly to obtain
        /// a Qualification of this type. If this parameter is specified, <code>TestDurationInSeconds</code>
        /// must also be specified.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must not be longer than 65535 bytes. Must be a QuestionForm data structure.
        /// This parameter cannot be specified if AutoGranted is true.
        /// </para>
        ///  
        /// <para>
        /// Constraints: None. If not specified, the Worker may request the Qualification without
        /// answering any questions.
        /// </para>
        /// </summary>
        public string Test
        {
            get { return this._test; }
            set { this._test = value; }
        }

        // Check to see if Test property is set
        internal bool IsSetTest()
        {
            return this._test != null;
        }

        /// <summary>
        /// Gets and sets the property TestDurationInSeconds. 
        /// <para>
        /// The number of seconds the Worker has to complete the Qualification test, starting
        /// from the time the Worker requests the Qualification.
        /// </para>
        /// </summary>
        public long TestDurationInSeconds
        {
            get { return this._testDurationInSeconds.GetValueOrDefault(); }
            set { this._testDurationInSeconds = value; }
        }

        // Check to see if TestDurationInSeconds property is set
        internal bool IsSetTestDurationInSeconds()
        {
            return this._testDurationInSeconds.HasValue; 
        }

    }
}
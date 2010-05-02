﻿using Microsoft.Build.Framework;

namespace Snowcode.S3BuildPublisher.SNS
{
    /// <summary>
    /// MSBuild task to create a AWS Simple Notification Service Topic.
    /// </summary>
    public class CreateSNSTopicTask : AwsTaskBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Topic Name to create
        /// </summary>
        [Required]
        public string TopicName { get; set; }

        /// <summary>
        /// Gets or sets the TopicArn
        /// </summary>
        [Output]
        public string TopicArn { get; set; }

        #endregion

        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.Normal, "Creating SNS Topic {0}", TopicName);

            AwsClientDetails clientDetails = GetClientDetails();

            CreateTopic(clientDetails);

            return true;
        }

        private void CreateTopic(AwsClientDetails clientDetails)
        {
            var helper = new SNSHelper(clientDetails);
            TopicArn = helper.CreateTopic(TopicName);
            Log.LogMessage(MessageImportance.Normal, "Created Sns TopicAssociated {0}, Topic Arn {1}", TopicName, TopicArn);
        }
    }
}

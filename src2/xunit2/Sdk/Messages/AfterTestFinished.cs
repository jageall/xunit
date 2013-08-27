﻿using Xunit.Abstractions;

namespace Xunit.Sdk
{
    /// <summary>
    /// Default implementation of <see cref="IAfterTestFinished"/>.
    /// </summary>
    public class AfterTestFinished : TestMessage, IAfterTestFinished
    {
        public AfterTestFinished(ITestCase testCase, string testDisplayName, string attributeName)
            : base(testCase, testDisplayName)
        {
            AttributeName = attributeName;
        }

        /// <inheritdoc/>
        public string AttributeName { get; private set; }
    }
}
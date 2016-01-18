﻿using NUnit.Framework;
using Phaxio.Tests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phaxio.Tests.IntegrationTests
{
    [TestFixture, Explicit]
    class GetHostedDocumentTests
    {
        [Test]
        public void IntegrationTest_GetHostedDocumentTest()
        {
            var config = new KeyManager();

            var phaxio = new Phaxio(config["api_key"], config["api_secret"]);

            var filename = "hostedoc.pdf";

            Assert.Throws(typeof(ApplicationException), () => phaxio.GetHostedDocument(filename));
        }
    }
}
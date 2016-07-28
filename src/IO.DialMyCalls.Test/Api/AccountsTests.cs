/* 
 * DialMyCalls API
 *
 * The DialMyCalls API
 *
 * OpenAPI spec version: 2.0.1
 * Contact: support@dialmycalls.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.DialMyCalls.Client;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Model;

namespace IO.DialMyCalls.Test
{
    /// <summary>
    ///  Class for testing Accounts
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountsTests
    {
        private Accounts instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Accounts();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Accounts
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Accounts
            //Assert.IsInstanceOfType(typeof(Accounts), instance, "instance is a Accounts");
        }

        
        /// <summary>
        /// Test CreateAccessAccount
        /// </summary>
        [Test]
        public void CreateAccessAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateAccessAccountParameters createAccessAccountParameters = null;
            //var response = instance.CreateAccessAccount(createAccessAccountParameters);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteAccessAccountById
        /// </summary>
        [Test]
        public void DeleteAccessAccountByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessAccountId = null;
            //var response = instance.DeleteAccessAccountById(accessAccountId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetAccessAccountById
        /// </summary>
        [Test]
        public void GetAccessAccountByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessAccountId = null;
            //var response = instance.GetAccessAccountById(accessAccountId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetAccessAccounts
        /// </summary>
        [Test]
        public void GetAccessAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string range = null;
            //var response = instance.GetAccessAccounts(range);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetAccount
        /// </summary>
        [Test]
        public void GetAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAccount();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test UpdateAccessAccountById
        /// </summary>
        [Test]
        public void UpdateAccessAccountByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateAccessAccountByIdParameters updateAccessAccountByIdParameters = null;
            //string accessAccountId = null;
            //var response = instance.UpdateAccessAccountById(updateAccessAccountByIdParameters, accessAccountId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}

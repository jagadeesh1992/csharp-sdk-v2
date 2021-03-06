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
    ///  Class for testing Contacts
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContactsTests
    {
        private Contacts instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Contacts();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Contacts
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Contacts
            //Assert.IsInstanceOfType(typeof(Contacts), instance, "instance is a Contacts");
        }

        
        /// <summary>
        /// Test CreateContact
        /// </summary>
        [Test]
        public void CreateContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateContactParameters createContactParameters = null;
            //var response = instance.CreateContact(createContactParameters);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteContactById
        /// </summary>
        [Test]
        public void DeleteContactByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //var response = instance.DeleteContactById(contactId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetContactById
        /// </summary>
        [Test]
        public void GetContactByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //var response = instance.GetContactById(contactId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetContacts
        /// </summary>
        [Test]
        public void GetContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string range = null;
            //var response = instance.GetContacts(range);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetContactsByGroupId
        /// </summary>
        [Test]
        public void GetContactsByGroupIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //var response = instance.GetContactsByGroupId(groupId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test UpdateContactById
        /// </summary>
        [Test]
        public void UpdateContactByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateContactByIdParameters updateContactByIdParameters = null;
            //string contactId = null;
            //var response = instance.UpdateContactById(updateContactByIdParameters, contactId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}

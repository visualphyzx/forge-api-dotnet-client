/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
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

using Autodesk.Forge.Client;
using Autodesk.Forge;
using Autodesk.Forge.Model;

namespace Autodesk.Forge.Test
{
    /// <summary>
    ///  Class for testing ItemsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ItemsApiTests
    {
        private ItemsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ItemsApi
            //Assert.IsInstanceOfType(typeof(ItemsApi), instance, "instance is a ItemsApi");
        }

        
        /// <summary>
        /// Test GetItem
        /// </summary>
        [Test]
        public void GetItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string itemId = null;
            //var response = instance.GetItem(projectId, itemId);
            //Assert.IsInstanceOf<Item> (response, "response is Item");
        }
        
        /// <summary>
        /// Test GetItemParentFolder
        /// </summary>
        [Test]
        public void GetItemParentFolderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string itemId = null;
            //var response = instance.GetItemParentFolder(projectId, itemId);
            //Assert.IsInstanceOf<Folder> (response, "response is Folder");
        }
        
        /// <summary>
        /// Test GetItemRefs
        /// </summary>
        [Test]
        public void GetItemRefsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string itemId = null;
            //List<string> filterType = null;
            //List<string> filterId = null;
            //List<string> filterExtensionType = null;
            //var response = instance.GetItemRefs(projectId, itemId, filterType, filterId, filterExtensionType);
            //Assert.IsInstanceOf<JsonApiCollection> (response, "response is JsonApiCollection");
        }
        
        /// <summary>
        /// Test GetItemRelationshipsRefs
        /// </summary>
        [Test]
        public void GetItemRelationshipsRefsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string itemId = null;
            //List<string> filterType = null;
            //List<string> filterId = null;
            //List<string> filterRefType = null;
            //string filterDirection = null;
            //List<string> filterExtensionType = null;
            //var response = instance.GetItemRelationshipsRefs(projectId, itemId, filterType, filterId, filterRefType, filterDirection, filterExtensionType);
            //Assert.IsInstanceOf<Refs> (response, "response is Refs");
        }
        
        /// <summary>
        /// Test GetItemTip
        /// </summary>
        [Test]
        public void GetItemTipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string itemId = null;
            //var response = instance.GetItemTip(projectId, itemId);
            //Assert.IsInstanceOf<Version> (response, "response is Version");
        }
        
        /// <summary>
        /// Test GetItemVersions
        /// </summary>
        [Test]
        public void GetItemVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string itemId = null;
            //List<string> filterType = null;
            //List<string> filterId = null;
            //List<string> filterExtensionType = null;
            //List<int?> filterVersionNumber = null;
            //int? pageNumber = null;
            //int? pageLimit = null;
            //var response = instance.GetItemVersions(projectId, itemId, filterType, filterId, filterExtensionType, filterVersionNumber, pageNumber, pageLimit);
            //Assert.IsInstanceOf<Versions> (response, "response is Versions");
        }
        
        /// <summary>
        /// Test PostItem
        /// </summary>
        [Test]
        public void PostItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //CreateItem body = null;
            //var response = instance.PostItem(projectId, body);
            //Assert.IsInstanceOf<ItemCreated> (response, "response is ItemCreated");
        }
        
        /// <summary>
        /// Test PostItemRelationshipsRef
        /// </summary>
        [Test]
        public void PostItemRelationshipsRefTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string itemId = null;
            //CreateRef body = null;
            //instance.PostItemRelationshipsRef(projectId, itemId, body);
            
        }
        
    }

}

using EnterpriseObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MBookTestProject
{
    
    
    /// <summary>
    ///这是 SerializeHelperTest 的测试类，旨在
    ///包含所有 SerializeHelperTest 单元测试
    ///</summary>
    [TestClass()]
    public class SerializeHelperTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///BinarySerialize 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("EnterpriseObjects.dll")]
        public void BinarySerializeTest()
        {
            object obj = new Person { Id = 1, Name = "MonoBook" }; // TODO: 初始化为适当的值
            string path = @"D:\xyz.mono"; // TODO: 初始化为适当的值
            bool expected = true; // TODO: 初始化为适当的值
            bool actual;
            actual = SerializeHelper_Accessor.BinarySerialize(obj, path);
            Assert.AreEqual(expected, actual, "序列化失败");
        }
    }

    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}

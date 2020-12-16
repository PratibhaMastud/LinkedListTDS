using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructDemo;

namespace LinklistTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenValuePresentInList_PassTheTest()
        {
            LinkList linkList = new LinkList();
            linkList.Add(56);
            linkList.Add(30);
            linkList.Add(70);
            int output = linkList.findNodeWithValue(30);
            Assert.AreEqual(2,output);
        }
    }
}

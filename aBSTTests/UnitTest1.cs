using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures2;

namespace aBSTTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            //          5
            //        /  \
            //       3    7
            //      / \  / \
            //     2  4 6   8
            
            var tree = new aBST(2);
            
            Assert.AreEqual(tree.Tree.Length, 7);

            Assert.AreEqual(tree.AddKey(5), 0);
            Assert.AreEqual(tree.AddKey(3), 1);
            Assert.AreEqual(tree.AddKey(4), 4);
            Assert.AreEqual(tree.AddKey(7), 2);
            Assert.AreEqual(tree.AddKey(6), 5);
            Assert.AreEqual(tree.AddKey(2), 3);
            Assert.AreEqual(tree.AddKey(8), 6);
            Assert.AreEqual(tree.AddKey(10), -1);
            
            Assert.AreEqual(tree.FindKeyIndex(5), 0);
            Assert.AreEqual(tree.FindKeyIndex(5), 0);
            Assert.AreEqual(tree.FindKeyIndex(3), 1);
            Assert.AreEqual(tree.FindKeyIndex(4), 4);
            Assert.AreEqual(tree.FindKeyIndex(7), 2);
            Assert.AreEqual(tree.FindKeyIndex(6), 5);
            Assert.AreEqual(tree.FindKeyIndex(2), 3);
            Assert.AreEqual(tree.FindKeyIndex(8), 6);
            Assert.IsNull(tree.FindKeyIndex(10));
        }
    }
}
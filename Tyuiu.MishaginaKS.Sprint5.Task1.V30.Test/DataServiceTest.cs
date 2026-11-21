using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task1.V30.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task1.V30.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void CheckedExistsFile()

    {
        DataService ds = new DataService();
        string path = ds.SaveToFileTextData(-5, 5);

        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        bool wait = true;

        Assert.AreEqual(wait, fileExists);
    }
}


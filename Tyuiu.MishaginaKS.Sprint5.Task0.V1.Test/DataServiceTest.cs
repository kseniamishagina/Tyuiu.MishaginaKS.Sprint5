using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task0.V1.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task0.V1.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void CheckedExistsFile()

    {
        DataService ds = new DataService();
        string path = ds.SaveToFileTextData(3);

        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        bool wait = true;

        Assert.AreEqual(wait, fileExists);
    }
}

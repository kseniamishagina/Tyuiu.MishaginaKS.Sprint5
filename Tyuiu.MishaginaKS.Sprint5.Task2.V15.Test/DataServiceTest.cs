using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task2.V15.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task2.V15.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void CheckedExistsFile()

    {
        DataService ds = new DataService();

        int[,] matrix = new int[3, 3] {
            { 6, 1, 7 },
            { 1, 8, 5 },
            { 6, 6, 4 }
        };

        string path = ds.SaveToFileTextData(matrix);

        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        bool wait = true;

        Assert.AreEqual(wait, fileExists);
    }
}


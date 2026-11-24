using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task7.V9.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task7.V9.Test;


[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void CheckedExistsFile()

    {
        DataService ds = new DataService();

        string inputPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V9.txt");
        File.WriteAllText(inputPath, "Hello, Мир! Это Is My First Program.");

        string outputPath = ds.LoadDataAndSave(inputPath);

        FileInfo fileInfo = new FileInfo(outputPath);
        bool fileExists = fileInfo.Exists;
        bool wait = true;

        Assert.AreEqual(wait, fileExists);
    }
}

